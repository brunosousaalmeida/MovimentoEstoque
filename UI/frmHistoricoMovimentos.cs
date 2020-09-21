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
    public partial class frmHistoricoMovimentos : Form
    {
        public frmHistoricoMovimentos()
        {
            InitializeComponent();
            toolTipAtualizarHist.SetToolTip(btnAtualizar, "Atualizar histórico de movimentos");
        }

        private void frmHistoricoMovimentos_Load(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlDataAdapter da;


            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id= sa; Password = open123;");
                strSql = "SELECT * FROM [MovimentoEstoque].[dbo].[Estoque.Movimento]";

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSql, conexao);

                conexao.Open();
                da.Fill(ds);

                dtgMovimentos.DataSource = ds.Tables[0];

                conexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlDataAdapter da;


            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id= sa; Password = open123;");
                strSql = "SELECT * FROM [MovimentoEstoque].[dbo].[Estoque.Movimento]";

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSql, conexao);

                conexao.Open();
                da.Fill(ds);

                dtgMovimentos.DataSource = ds.Tables[0];

                conexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
