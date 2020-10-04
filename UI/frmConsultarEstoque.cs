using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimentoEstoque.UI
{
    public partial class frmConsultarEstoque : Form
    {
        public frmConsultarEstoque()
        {
            
            InitializeComponent();

            #region Evento para popular a gridview
            SqlConnection conexao;
            SqlDataAdapter da;
            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id= sa; Password = open123;");
                strSql = "SELECT * FROM [MovimentoEstoque].[dbo].[Estoque.Produto1]";

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSql, conexao);

                conexao.Open();
                da.Fill(ds);

                dtgConsultaEstoque.DataSource = ds.Tables[0];

                conexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            #endregion

        }

        //Evento duplo click no item da grid view, para escolha do item a ser movimentado.
        
        #region Evento Duplo Click Item Grid View
        private void dtgConsultaEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMovimentoEstoque movimento = new frmMovimentoEstoque();
            movimento.txtCodigo.Text = this.dtgConsultaEstoque.CurrentRow.Cells[0].Value.ToString();
            movimento.txtNome.Text = this.dtgConsultaEstoque.CurrentRow.Cells[1].Value.ToString();
            movimento.txtDescricao.Text = this.dtgConsultaEstoque.CurrentRow.Cells[2].Value.ToString();
            movimento.txtQtdeEstoque.Text = this.dtgConsultaEstoque.CurrentRow.Cells[3].Value.ToString();
            movimento.txtPreco.Text = this.dtgConsultaEstoque.CurrentRow.Cells[4].Value.ToString();
            
            Close();
            movimento.Show();
            movimento.txtPreco.Focus();

        }

        #endregion

    }
}
