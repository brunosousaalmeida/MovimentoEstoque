using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovimentoEstoque.BLL;

namespace MovimentoEstoque
{
    public partial class frmLogin : Form
    {
        string nomeUsuario = "", login = "", senha = "";
        MovimentoEstoque.BLL.Usuarios = new MovimentoEstoque.BLL.Usuarios{}


            
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
