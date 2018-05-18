using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.db_05579_1_C_1_2017DataSetTableAdapters;

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
            btnCancelar_Click(sender e); // para limpar informações pré existentes no formulário
            CarregaGridItens();
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            vid_VendaAtual = (int)taPedido.UltimoPedido() + 1;
            lblN.Text = vld_VendaAtual.ToString();
            grbPedido.Enabled = true;
            grbItens.Enabled = true;
            btnGravar.Enabled = true;
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

            taItemTemp.Delete(vld_VendaAtual, vCodigoProduto, vUsuario);
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
            vld_VendaAtual = (int)taPedido.UltimoPedido();
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
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void CarregaGridItens()
        {
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
            // TODO: This line of code loads data into the 'dataSet_Dados_Do_Banco.Cliente' table.
            // You cna move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Cliente);
            vUsuario = Properties.Settings.Default.NomeUsuarioLogado.ToString();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            // Grava item na tabela temporária
            Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
            taItemTemp.Insert(vld_VendaAtual, int.Parse(txtCodigo.Text), lblDescricaoProduto.Text,
            int.Parse(txtQtdVenda.Text), decimal.Parse(txtValorUnit.Text), vUsuario);
            // -----------------------------------------------
            Limpa_Campos_Item();
            CarregaGridItems(); // Carrega o grid com os dados, atualizados
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

        private void txtValorUNit_



    }
}
