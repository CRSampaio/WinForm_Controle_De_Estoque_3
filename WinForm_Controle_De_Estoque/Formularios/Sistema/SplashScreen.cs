using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // para usar o SoundPlayer
using System.Threading;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class SplashScreen : Form
    {
        private void gerarNomes()
        {
            Dictionary<string, string> dicionario = new Dictionary<string, string>();
            dicionario.Add("etec", "@\"C:\\Users\\ManutencaoEtec\\Desktop\04-08 WinForm_Controle_De_Estoque\\WinForm_Controle_De_Estoque\\Dados\versao_brasileira_herbert_richers.wav");
            dicionario.Add("etec-desktop", "@\"C:/Users/ManutencaoEtec/Desktop/wav.wav\"");
            dicionario.Add("casa", "@\"C:\\Users\\Misha\\Desktop\04-08 WinForm_Controle_De_Estoque\\WinForm_Controle_De_Estoque\\Dados\versao_brasileira_herbert_richers.wav");
            dicionario.Add("casa-desktop", "@\"C:/Users/Misha/Desktop/wav.wav\"");
        } 

        SoundPlayer meuPlayer = new SoundPlayer("versao_brasileira_herbert_richers.wav");

        public SplashScreen()
        {
            InitializeComponent();
            //gerarNomes();
            meuPlayer.Play(); // começa a tocar a música
            EffectTime(); // chama o procedimento que ativa o timer
        }       

        private bool Effect = true;
        private bool Delay = true; // para que a função Thread.Sleep execute só uma vez no método abaixo

        private void EffectTime()
        {
            SplashTimer.Interval = 120; // tempo em milisegundos para a atuação do timer
            SplashTimer.Tick += new EventHandler(SplashTimer_Tick); // dispara o evento Tick       
            SplashTimer.Enabled = true; // ativa o Timer
            this.Opacity = 1; // define a opacidade do form como 100% 
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if (Delay)
                Thread.Sleep(60); Delay = false;

            if (Effect)               
                this.Opacity -= 0.5D; // diminui a opacidade do form na velocidade estipulada no SplashTimer.Interval

            if (this.Opacity == 0)
            {
                Effect = false;
                SplashTimer.Enabled = false; // desliga o timer
                frmLogin frmLogin = new frmLogin(); // instancia um form Login
                frmLogin.Show(); // mostra o login
                meuPlayer.Stop(); // interrompe a música
                this.Hide(); // oculta o form sem tirar ele da memória
            }
        }


    }
}
