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
    public partial class frmAtualizarCadastroProduto : Form
    {
        public frmAtualizarCadastroProduto()
        {
            InitializeComponent();
        }

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        //Por enquanto, as interações com o banco estão incluídas nos botões do projeto.

        #region Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlCommand comando;


            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "UPDATE[MovimentoEstoque].[dbo].[Estoque.Produto1] SET Nome = @NOME, Descricao = @DESCRICAO, Quantidade = @QUANTIDADE, Preco = @PRECO WHERE Codigo = @CODIGO";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@PRECO", txtPreco.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com êxito!", "Atualização de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlCommand comando;


            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "DELETE FROM [MovimentoEstoque].[dbo].[Estoque.Produto1] WHERE Codigo = @CODIGO";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text);
                comando.Parameters.AddWithValue("@PRECO", txtPreco.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluído com êxito!", "Exclusão de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
