using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_BancoTableAdapters;
using static WinForm_Controle_De_Estoque.Dados.DataSet_Dados_do_Banco;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadVendas : Form
    {
        public frmCadVendas()
        {
            InitializeComponent();
        }

        int vld_VendaAtual, vQuantidadeDigitada, vSaldoAtual;
        double vValorTotalProduto, vTotalDoPedido, vValorUnitDigitado;   
        string vUsuario;

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(null, null); // para limpar informações pré existentes no formulário
            CarregaGridItens();
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            vld_VendaAtual = Convert.ToInt32(taPedido.UltimoPedido().Rows[0]["UltimoID"]) + 1;
            lblN.Text = vld_VendaAtual.ToString();
            grbPedido.Enabled = true;
            grbItens.Enabled = true;
            btnGravar.Enabled = true;
            cmbCliente.Enabled = true;
            txtObservacao.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            cmbCliente.Focus();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCodigo.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCodigo.Focus();
            txtQtdVenda.Focus();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
            int vCodigoProduto = (int)dgvItem.CurrentRow.Cells["Codigo"].Value;
            vValorTotalProduto = double.Parse(dgvItem.CurrentRow.Cells["TotalItem"].Value.ToString());

            taItemTemp.Delete(vld_VendaAtual, vUsuario, vCodigoProduto);
            CarregaGridItens();

            vTotalDoPedido = vTotalDoPedido - vValorTotalProduto;
            lblTotalPedido.Text = (vTotalDoPedido).ToString("###,##0.00");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                ErrErro.SetError(cmbCliente, "Selecione um Cliente");
                return;
            }
            else
            {
                ErrErro.SetError(cmbCliente, "");
            }
            // Grava Pedido
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            taPedido.Insert(int.Parse(cmbCliente.SelectedValue.ToString()),
                dtpDataVenda.Value, decimal.Parse(vTotalDoPedido.ToString()), "V",
                txtObservacao.Text);
            vld_VendaAtual = Convert.ToInt32(taPedido.UltimoPedido().Rows[0]["UltimoID"]);
            // —————————————————————————————————————————————————————————————————————

            // Gravando os itens
            ItemTableAdapter taItem = new ItemTableAdapter();
            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            int vCodigoProduto, vQtdVendida;
            decimal vValorUnit;

            for (int i = 0; i <= dgvItem.RowCount - 1; i++)
            {
                vCodigoProduto = (int)dgvItem.Rows[i].Cells["Codigo"].Value;
                vQtdVendida = (int)dgvItem.Rows[i].Cells["Quantidade"].Value;           
                vValorUnit = (decimal)dgvItem.Rows[i].Cells["Valor_Unit"].Value;

                taItem.Insert(vld_VendaAtual, vCodigoProduto, vQtdVendida, vValorUnit);

                taProduto.Acerta_Saldo_Saida(vCodigoProduto, vQtdVendida);
            }

            MessageBox.Show("Venda gravada com sucesso");
            Limpa_Campos_Pedido();
            // Limpa os itens da tabela temporária
            Item_TempTableAdapter taItem_Temp = new Item_TempTableAdapter();
            taItem_Temp.Limpa_Itens(vld_VendaAtual, vUsuario);
            CarregaGridItens();
            // Desabilita controles
            grbPedido.Enabled = false;
            grbItens.Enabled = false;
            btnGravar.Enabled = false;
            cmbCliente.Enabled = false;
            txtObservacao.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void CarregaGridItens()
        {
            //item_TempTableAdapter.Fill(this.dataSet_Dados_do_Banco.Item_Temp);
            Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
            dgvItem.DataSource = taItemTemp.GetData();
        }

        private void Limpa_Campos_Item()
        {
            txtCodigo.Text = ""; // ou String.Empty;
            lblDescricaoProduto.Text = string.Empty; // ou ""
            txtQtdVenda.Text = "";
            txtValorUnit.Text = "";
            lblTotalProduto.Text = "";
        }

        private void frmCadVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Dados_do_Banco.Item_Temp' table. You can move, or remove it, as needed.
            this.item_TempTableAdapter.Fill(this.dataSet_Dados_do_Banco.Item_Temp);
            // TODO: This line of code loads data into the 'dataSet_Dados_do_Banco.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet_Dados_do_Banco.Cliente);
            vUsuario = Properties.Settings.Default.NomeUsuarioLogado.ToString();
            btnCancelar_Click(null, null);
            btnPesquisar_Click(null, null);
        }

        private void txtQtdVenda_Leave(object sender, EventArgs e)
        {
            if (txtQtdVenda.Text == "") txtQtdVenda.Text = "1";
            vQuantidadeDigitada = Convert.ToInt16(txtQtdVenda.Text);
            if (vQuantidadeDigitada > vSaldoAtual)
            {
                MessageBox.Show("Saldo insuficiente, só existem " + vSaldoAtual.ToString() + "disponível.");
                txtQtdVenda.Focus();
                txtQtdVenda.SelectAll(); // seleciona todo o texto da textbox
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            
                if (txtCodigo.Text != "")
                {
                    ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                    DataSet_Dados_do_Banco.ProdutoDataTable dtProduto = new DataSet_Dados_do_Banco.ProdutoDataTable();

                    dtProduto = taProduto.Procura_Produto1(int.Parse(txtCodigo.Text));

                    if (dtProduto.Rows.Count == 0)
                    {
                        MessageBox.Show("Código não cadastrado");
                        txtCodigo.Focus();
                    }
                    else
                    {
                        lblDescricaoProduto.Text = dtProduto.Rows[0]["pro_Descricao"].ToString();
                        txtValorUnit.Text = dtProduto.Rows[0]["pro_Valor"].ToString();
                        vSaldoAtual = (int)dtProduto.Rows[0]["pro_QtdeEstoque"];
                        txtQtdVenda.Focus();
                    }
                }
            
        }

        private void frmCadVendas_KeyDown(object sender, KeyEventArgs e)
        {
            // Para que o foco seja mudado com a tecla <Enter>
            // Obs.: Alterar a propriedade KeyPreview do formulário para True
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (grbPesquisaPedido.Visible == true)
                grbPesquisaPedido.Visible = false;
            else
            {
                grbPesquisaPedido.Visible = true;
                txtNumPedidoPesq.Focus();
            }
            btnCancelar_Click(sender, e);
            CarregaGridItens();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpa_Campos_Pedido();
            grbPedido.Enabled = false;
            grbItens.Enabled = false;
            cmbCliente.Enabled = false;
            txtObservacao.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            // Limpa os itens da tabela temp
            Item_TempTableAdapter taItem_Temp = new Item_TempTableAdapter();
            taItem_Temp.Limpa_Itens(vld_VendaAtual, vUsuario);
        }

        private void btnLocalizaPedido_Click(object sender, EventArgs e)
        {
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            DataSet_Dados_do_Banco.PedidoDataTable dt = new DataSet_Dados_do_Banco.PedidoDataTable();
            dt = taPedido.PesquisaPedido(int.Parse(txtNumPedidoPesq.Text));
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Pedido inexistente");
                txtNumPedidoPesq.Focus();
                txtNumPedidoPesq.SelectAll();
            }
            else
            {
                lblNumeroPedido.Text = dt.Rows[0]["ped_id"].ToString();
                cmbCliente.SelectedValue = dt.Rows[0]["cli_id"];
                dtpDataVenda.Value = DateTime.Parse(dt.Rows[0]["ped_dtEncomenda"].ToString());
                lblTotalPedido.Text = String.Format(dt.Rows[0]["ped_valor"].ToString(), "###,##0.00");
                txtObservacao.Text = dt.Rows[0]["Ped_observacao"].ToString();
                //if (dt.Rows[0]["ped_id"].ToString() == "")
                //TODO lblStatus
                ItemTableAdapter taItem = new ItemTableAdapter();
                ItemDataTable dtItem = new ItemDataTable();
                dtItem = taItem.Pesquisa_Itens_Pedido(int.Parse(txtNumPedidoPesq.Text));
                dgvItem.DataSource = dtItem;
                dgvItem.Columns["Codigo"].DisplayIndex = 0;
                dgvItem.Columns["Descricao"].DisplayIndex = 1;
                dgvItem.Columns["Quantidade"].DisplayIndex = 2;
                dgvItem.Columns["Valor_Unit"].DisplayIndex = 3;
                dgvItem.Columns["TotalItem"].DisplayIndex = 4;
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        

        private void txtValorUnit_Leave(object sender, EventArgs e)
        {
            double a;
            vValorUnitDigitado =  double.TryParse(txtValorUnit.Text, out a) ? Convert.ToDouble(txtValorUnit.Text): 0;
            vValorTotalProduto = vQuantidadeDigitada * vValorUnitDigitado;
            lblTotalProduto.Text = (vValorTotalProduto).ToString("###,##0.00");
            btnAdicionarItem.Focus();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            // Grava item na tabela temporária
            Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
            taItemTemp.Insert(vld_VendaAtual, int.Parse(txtCodigo.Text), lblDescricaoProduto.Text,
            int.Parse(txtQtdVenda.Text), decimal.Parse(txtValorUnit.Text), vUsuario);
            // -----------------------------------------------
            Limpa_Campos_Item();
            CarregaGridItens(); // Carrega o grid com os dados, atualizados
            vTotalDoPedido = vTotalDoPedido + vValorTotalProduto;
            lblTotalPedido.Text = (vTotalDoPedido).ToString("###,##0.00");
        }

        private void Limpa_Campos_Pedido()
        {
            lblNumeroPedido.Text = "";
            cmbCliente.SelectedIndex = -1;
            txtObservacao.Text = "";
            lblTotalPedido.Text = "";
            txtNumPedidoPesq.Text = "";
            lblNumeroPedido.Text = "";
            Limpa_Campos_Item();
        }
        
        



    }
}
