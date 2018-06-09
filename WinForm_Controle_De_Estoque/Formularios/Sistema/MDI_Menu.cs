using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WinForm_Controle_De_Estoque.Formularios;
using WinForm_Controle_De_Estoque.Formularios.Sistema;
using WinForm_Controle_De_Estoque.Relatorios;
using WinForm_Controle_De_Estoque.Formularios.Cadastros;


namespace WinForm_Controle_De_Estoque
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {
            staUsuario.Text = DateTime.Now.ToShortDateString();
            staUsuario.Text = "Usuário atual: " + Properties.Settings.Default.NomeUsuarioLogado;
            Checa_Teclas();
        }

        private void MDI_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumLock)
                staNum.Text = staNum.Text == "NUM" ? "" : "NUM";
            if (e.KeyCode == Keys.CapsLock)
                staCaps.Text = staCaps.Text == "CAPS" ? "" : "CAPS";
        }

        private void Checa_Teclas()
        {
            // verifica Capslock
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                staCaps.Text = "CAPS";
                staCaps.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staCaps.Text = "";
                staCaps.BorderStyle = Border3DStyle.Sunken;
            }

            // verifica Numlock
            if (Control.IsKeyLocked(Keys.NumLock))
            {
                staNum.Text = "NUM";
                staNum.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staNum.Text = "";
                staNum.BorderStyle = Border3DStyle.Sunken;
            }
        }

        //private void timer1_Tick(object sender etccccccccc)
        //{
        //    staHora.Text = DateTime.Now.ToString();
        //}
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirma", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else
                Application.ExitThread();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           frmCadProdutos frmProduto = new frmCadProdutos();
           frmProduto.MdiParent = this;
           frmProduto.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            //    frmCadVendas frmVendas = new frmCadVendas();
            //    frmVendas.MdiParent = this;
            //    frmVendas.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frmVisualizaRelatorio"] == null)
            {
                frmVisualizaRelatorio frm = new frmVisualizaRelatorio
                {
                    MdiParent = this
                };
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmVisualizaRelatorio"].BringToFront();
            }
        }

        private void prToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadProdutos"] == null)
            {
                frmCadProdutos frm = new frmCadProdutos
                {
                    MdiParent = this
                };
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmCadProdutos"].BringToFront();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCategoria"] == null)
            {
                frmCategoria frm = new frmCategoria
                {
                    MdiParent = this
                };
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmCategoria"].BringToFront();
            }
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadVendas"] == null)
            {
                frmCadVendas frm = new frmCadVendas
                {
                    MdiParent = this
                };
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmCadVendas"].BringToFront();
            }
        }



        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        private void rascunhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            System.Diagnostics.Process.Start(startInfo);
        }
        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplorer.exe", "www.terra.com.br");
        }
        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void pesquisaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPesquisaProduto"] == null)
            {
                frmPesquisaProduto frm = new frmPesquisaProduto
                {
                    MdiParent = this
                };
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmPesquisaProduto"].BringToFront();
            }
        }
    }
}
