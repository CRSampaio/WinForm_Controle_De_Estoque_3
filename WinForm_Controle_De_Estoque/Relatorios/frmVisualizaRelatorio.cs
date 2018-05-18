using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Relatorios
{
    public partial class frmVisualizaRelatorio : Form
    {
        public frmVisualizaRelatorio()
        {
            InitializeComponent();
        }

        private void frmVisualizaRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_05579_1_C_1_2017DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.db_05579_1_C_1_2017DataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
