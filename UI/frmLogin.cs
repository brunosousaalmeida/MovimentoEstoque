using MovimentoEstoque.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimentoEstoque
{
    public partial class frmLogin : Form
    {
        
        //Abertura de tela para cadastro de novo usuário
        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastro = new frmCadastroUsuario();
            cadastro.Show();
        }

        public frmLogin()
        {
            InitializeComponent();
        }

               

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (login == "Adm" && senha == "open123")

            {
                frmPrincipal princ = new frmPrincipal();
                princ.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!","Usuário não encontrado",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();

            }
            
        }
    }
}
