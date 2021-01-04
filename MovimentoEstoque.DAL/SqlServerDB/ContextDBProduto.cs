using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentoEstoque.DAL
{

    //Classe para contexto do banco de dados da tabela de produtos

    public class ContextDBProduto
    {

        #region Atributos
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public int Quantidade { get; private set; }

        public string Descricao { get; private set; }

        public double Preco { get; private set; }

        SqlConnection conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");

        #endregion

        #region Construtores

        public ContextDBProduto(string nome, string descricao, int quantidade, double preco)
        {
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        public ContextDBProduto(int cod, string nome, string descricao, double preco)
        {
            Codigo = cod;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;

        }

        public ContextDBProduto(int cod, string nome, string descricao, int quantidade, double preco)
        {
            Codigo = cod;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;

        }



        #endregion

        #region Métodos CRUD

        SqlCommand comando;
        string strSql;

        #region Create

        public void SalvarProduto()
        {

            strSql = "INSERT INTO [MovimentoEstoque].[dbo].[Estoque.Produto1] (NOME, DESCRICAO, QUANTIDADE , PRECO) VALUES ( @NOME, @DESCRICAO, @QUANTIDADE, @PRECO)";
            comando = new SqlCommand(strSql, conexao);
            comando.Parameters.AddWithValue("@NOME", Nome);
            comando.Parameters.AddWithValue("@DESCRICAO", Descricao);
            comando.Parameters.AddWithValue("@QUANTIDADE", Quantidade);
            comando.Parameters.AddWithValue("@PRECO", Preco);


            conexao.Open();
            comando.ExecuteNonQuery();


            conexao.Close();
            comando.Clone();
            conexao = null;
            comando = null;

        }

        #endregion

        #region Read

        public SqlDataAdapter ObterProdutos()

        {
            strSql = "SELECT * FROM [MovimentoEstoque].[dbo].[Estoque.Produto1]";

            SqlDataAdapter da = new SqlDataAdapter(strSql, conexao);
            DataSet ds = new DataSet();

            da.Fill(ds);

            conexao.Open();

            conexao.Close();



            return da;

        }



        #endregion

        #region Update

        public void AtualizaCadastroProduto()
        {
            
            strSql = "UPDATE[MovimentoEstoque].[dbo].[Estoque.Produto1] SET Nome = @NOME, Descricao = @DESCRICAO, Quantidade = @QUANTIDADE, Preco = @PRECO WHERE Codigo = @CODIGO";
            comando = new SqlCommand(strSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", Codigo);
            comando.Parameters.AddWithValue("@NOME", Nome);
            comando.Parameters.AddWithValue("@DESCRICAO", Descricao);
            comando.Parameters.AddWithValue("@QUANTIDADE", Quantidade);
            comando.Parameters.AddWithValue("@PRECO", Preco);


            conexao.Open();
            comando.ExecuteNonQuery();

            conexao.Close();
            comando.Clone();
            conexao = null;
            comando = null;

        }



        #endregion

        #region Delete

        public void DeletarCadastroProduto()
        {

            strSql = "DELETE FROM [MovimentoEstoque].[dbo].[Estoque.Produto1] WHERE Codigo = @CODIGO";
            comando = new SqlCommand(strSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", Codigo);
            comando.Parameters.AddWithValue("@NOME", Nome);
            comando.Parameters.AddWithValue("@DESCRICAO", Descricao);
            comando.Parameters.AddWithValue("@QUANTIDADE", Quantidade);
            comando.Parameters.AddWithValue("@PRECO", Preco);


            conexao.Open();
            comando.ExecuteNonQuery();

            conexao.Close();
            comando.Clone();
            conexao = null;
            comando = null;

        }

        #endregion


        #endregion

    }

}
