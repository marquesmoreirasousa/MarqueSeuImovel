using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarqueSeuImovel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Testando autenticação do usuário
            if (txbUser.Text == "admin" && txbPass.Text == "123456")
            {
                txbUser.Text = String.Empty; //Limpa o campo de usuário
                txbPass.Text = String.Empty; //Limpa o campo de senha
                txbUser.Focus(); //Coloca o foco no campo de usuário
                FrmPrincipal principal = new FrmPrincipal();
                this.Visible = false; //Esconder a tela de login
                principal.ShowDialog(); //Abre a tela principal
                this.Visible = true;  //Volta a mostrar a tela de login
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
