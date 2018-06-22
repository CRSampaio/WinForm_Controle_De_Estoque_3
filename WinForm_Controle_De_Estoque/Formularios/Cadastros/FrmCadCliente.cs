using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Dados_do_Banco);

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Dados_do_Banco.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet_Dados_do_Banco.Cliente);

        }
    }
}
