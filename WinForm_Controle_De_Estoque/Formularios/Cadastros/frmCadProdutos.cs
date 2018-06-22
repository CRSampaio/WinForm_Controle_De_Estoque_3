using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadProdutos : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }
        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblTitulo.Text = "Produtos";
                //DataSet_Dados_do_Banco.ProdutoDataTable dt = new DataSet_Dados_do_Banco.ProdutoDataTable();
                ProdutoTableAdapter ta = new ProdutoTableAdapter();
                //dt = ta.GetData();
                DataSet_Dados_do_Banco ds = new DataSet_Dados_do_Banco();
                ta.Fill(ds.Produto);
                dataSetDadosDoBancoBindingSource.DataSource = ds.Produto;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;
                bindingNavigator.BindingSource = dataSetDadosDoBancoBindingSource;

                //Configuração das colunas do DataGridView
                dgvGrid.Columns[0].HeaderText = "ID";
                dgvGrid.Columns[0].Width = 50;

                //Trocando o tipo das Colunas para ComboBox e ChechBox
                DataGridViewComboBoxColumn dgvcolcombo = new DataGridViewComboBoxColumn();
                dgvcolcombo.HeaderText = "Categoria";
                dgvcolcombo.DataSource = categoriaBindingSource;
                dgvcolcombo.DataPropertyName = "cat_Id";
                dgvcolcombo.Name = "cat_Id";
                dgvcolcombo.DisplayMember = "cat_Descricao";
                dgvcolcombo.ValueMember = "cat_Id";

                dgvGrid.Columns.Remove(dgvGrid.Columns["cat_Id"]);//Remove a colun a cat_ID
                dgvGrid.Columns.Add(dgvcolcombo);//Adiciona a Coluna do tipo ComboBox para a categoria

                //Para criar uma coluna no DataGridView do tipo checkbox
                DataGridViewCheckBoxColumn dgvcolcheck = new DataGridViewCheckBoxColumn();
                dgvcolcheck.HeaderText = "Ativo";
                dgvcolcheck.DataPropertyName = "pro_Ativo";
                dgvcolcheck.Name = "pro_Ativo";

                dgvGrid.Columns.Remove(dgvGrid.Columns["pro_Ativo"]);//Remove a colunda pro_Ativo criada automaticamente
                dgvGrid.Columns.Add(dgvcolcheck);//Adiciona a Coluna tipo checkbox

                //dgvGrid.Columns["cat_Id"];

                dgvGrid.Columns[1].HeaderText = "Categoria";
                dgvGrid.Columns[1].Width = 200;

                dgvGrid.Columns["pro_Descricao"].HeaderText = "Descrição";
                dgvGrid.Columns["pro_Descricao"].Width = 300;
                dgvGrid.Columns["pro_Descricao"].DisplayIndex = 1;//para definir a posição da coluna

                dgvGrid.Columns["pro_QtdeEstoque"].HeaderText = "Qtd";
                dgvGrid.Columns["pro_QtdeEstoque"].Width = 50;
                dgvGrid.Columns["pro_Valor"].HeaderText = "Valor";
                dgvGrid.Columns["pro_Valor"].Width = 100;
                dgvGrid.Columns["pro_Valor"].DefaultCellStyle.Format = "R$ ###,##0.00";
                dgvGrid.Columns["pro_Ativo"].HeaderText = "Ativo";
                dgvGrid.Columns["pro_Ativo"].Width = 45;
                dgvGrid.Columns["pro_Data"].HeaderText = "Data";
                dgvGrid.Columns["pro_Data"].Width = 100;
                dgvGrid.Columns["cat_id"].Width = 200;

                dgvGrid.Width = tabControl1.Width - 20;

                //Carrega a Combo com as Colunas
                if(cmbColuna.Items.Count == 0)
                {
                   foreach(DataColumn coluna in ds.Produto.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }
                dtGenerico = ds.Produto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void CarregaValores()
        {
            try
            {
                txtID.Text = dgvGrid.CurrentRow.Cells["pro_ID"].Value.ToString();
                cmbCategoria.SelectedValue = dgvGrid.CurrentRow.Cells["cat_ID"].Value;
                txtDescricao.Text = dgvGrid.CurrentRow.Cells["pro_Descricao"].Value.ToString();
                txtQtdEstoque.Text = dgvGrid.CurrentRow.Cells["pro_QtdeEstoque"].Value.ToString();
                txtValor.Text = dgvGrid.CurrentRow.Cells["pro_Valor"].Value.ToString();
                chkAtivo.Checked = bool.Parse(dgvGrid.CurrentRow.Cells["pro_Ativo"].Value.ToString());
                dateTimePicker.Value = Convert.ToDateTime(dgvGrid.CurrentRow.Cells["pro_Data"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override bool Salvar()
        {
            bool bSalvar = false;
            ProdutoTableAdapter ta = new ProdutoTableAdapter();
            if (sStatus == StatusCadastro.scIncluindo)
            {
                bSalvar = (ta.Insert(int.Parse(cmbCategoria.SelectedValue.ToString()),
                txtDescricao.Text, int.Parse(txtQtdEstoque.Text),
                decimal.Parse(txtValor.Text),
                chkAtivo.Checked.ToString(),
                dateTimePicker.Value) > 0);
            }
            else if (sStatus == StatusCadastro.scAlterando)
            {
                try
                {
                    bSalvar = (ta.Update(int.Parse(cmbCategoria.SelectedValue.ToString()),
                    txtDescricao.Text, int.Parse(txtQtdEstoque.Text),
                    decimal.Parse(txtValor.Text),
                    chkAtivo.Checked.ToString(),
                    dateTimePicker.Value,
                    nCodGenerico) > 0);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message + ex.Source + ex.StackTrace);
                }
            }
            return bSalvar;
        }

        public override bool Excluir()
        {
            bool bExcluir = false;
            try
            {
                ProdutoTableAdapter ta = new ProdutoTableAdapter();
                bExcluir = (ta.Delete(nCodGenerico) > 0);
            }
            catch (Exception)
            {
                bExcluir = false;
            }
            return bExcluir;
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Dados_do_Banco1.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.dataSet_Dados_do_Banco1.Categoria);
            //this.categoriaTableAdapter.Fill(this.dataSet_Dados_Do_Banco)
        }
    }
}
