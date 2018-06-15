using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios
{
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        private int _CodigoRetorno;

        public int CodigoRetorno
        {
            get { return _CodigoRetorno; }
            set { _CodigoRetorno = value; }
        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Dados_do_Banco.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dataSet_Dados_do_Banco.Produto);
            // código gerado automaticamente?
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Dados_do_Banco);

        }

        // tem mais dois private void que eu não sei gerar
    }
}
