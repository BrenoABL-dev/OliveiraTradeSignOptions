using OliveiraTrade.Controle;
using OliveiraTrade.UserInputExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliveiraTrade.Janelas
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUpCtrl signup = new SignUpCtrl();


            try
            {
                signup.RegisterToSQL(   txtBx_RegUsuario.Text,
                                        txtBx_RegSenha.Text,
                                        txtBx_ConfirmSenha.Text,
                                        long.Parse(mtxtb_RegCpf.Text),
                                        txtBx_RegEmail.Text);
               
                
                if (signup.hasBeenRegistered)
                {
                    MessageBox.Show(signup.sqlText, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    this.Close();
                }
                else
                {
                    MessageBox.Show(signup.sqlText, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            catch (Exception ex)
            {
                if      (ex is UserIdLenghExceededExeption)
                {
                    MessageBox.Show("O nome do usuário deve ser menor que 20 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ex is PasswLenghExceededExeption)
                {
                    MessageBox.Show("A senha deve ser menor que 20 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ex is PassWNotConfirmedExeption)
                {
                    MessageBox.Show("A senha e a confirmação da senha não correspondem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ex is InvalidEmailExeption)
                {
                    MessageBox.Show("O email colocado é invàlido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ex is InvalidCPFExeption)
                {
                    MessageBox.Show("O CPF colocado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
