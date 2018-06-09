﻿using System;
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

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int vErros = 0;

        private bool CaixasOK()
        {
            if (txtUsuario.Text == "")
            {
                errErro.SetError(txtUsuario, "Informar o usuário");
                return false;
            }
            else
                errErro.SetError(txtUsuario, "");

            if (txtSenha.Text == "")
            {
                errErro.SetError(txtSenha, "Informar a senha");
                return false;
            }
            else
                errErro.SetError(txtSenha, "");

            return true;            
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                //// enquanto não temos banco de dados
                //if (txtUsuario.Text != "123" && txtSenha.Text != "123")
                //{
                //    MessageBox.Show("Usuário ou Senha inválidos");
                //    vErros++;
                //    if (vErros == 3)
                //    {
                //        MessageBox.Show("Número de tentativas esgotado...");
                //        this.Close();
                //    }
                //}
                //else
                //{
                //    Properties.Settings.Default.NivelUsuarioLogado = 1;
                //    Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                //    MDI_Menu frmMenuPrincipal = new MDI_Menu();
                //    frmMenuPrincipal.Show();
                //    this.Close();
                //}

                //Quando estivermos acessando o Banco de Dados
                if (CaixasOK())
                {
                    DataSet_Dados_do_Banco.UsuarioDataTable dtUsuario;
                    UsuarioTableAdapter taUsuario = new UsuarioTableAdapter();
                    dtUsuario = taUsuario.VerificaNivel(txtUsuario.Text, txtSenha.Text);
                    if (dtUsuario.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuário ou Senha inválidos");
                        vErros++;
                        if (vErros == 3)
                        {
                            MessageBox.Show("Número de tentativas estogado...");
                            taUsuario.Dispose();
                            this.Close();
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
                        Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                        MDI_Menu frmMenuPrincipal = new MDI_Menu();
                        frmMenuPrincipal.Show();
                        this.Hide();

                    }
                }
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
