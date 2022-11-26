using OliveiraTrade.Controle;
using OliveiraTrade.Janelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTrade
{
    public partial class FormEntrada : Form
    {
        public FormEntrada()
        {
            InitializeComponent();
        }




        private void btn_ToRegistro_Click(object sender, EventArgs e)
        {
            FormCadastro telaCadastro= new FormCadastro();
            telaCadastro.ShowDialog();
        }




        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            SignInCtrl signin = new SignInCtrl();


            signin.TryLogin(txtBx_LogUsuario.Text, txtBx_LogSenha.Text);

            if (signin.sqlErrorTxt.Equals(""))
            {
                if (signin.hasAccount)
                {
                    MessageBox.Show("Você entrou em sua conta!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormBemVindoScreen telaBemVindo= new FormBemVindoScreen();
                    telaBemVindo.ShowDialog();
                    
                }

                else
                {
                    MessageBox.Show("Esta conta não foi encontrada, Verifique o Usuário e a Senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show(signin.sqlErrorTxt);
            }
        }
    }
}
