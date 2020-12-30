using System;
using System.Collections.Generic;
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



        #endregion

        #region Métodos CRUD


        #region Create


        SqlConnection conexao;
        SqlCommand comando;
        string strSql;

        public void SalvarProduto()
        {
            conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
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


        #endregion

        #region Update

        public void AtualizaCadastroProduto()
        {

            conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
            strSql = "UPDATE[MovimentoEstoque].[dbo].[Estoque.Produto1] SET Nome = @NOME, Descricao = @DESCRICAO, Quantidade = @QUANTIDADE, Preco = @PRECO WHERE Codigo = @CODIGO";
            comando = new SqlCommand(strSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", Codigo);
            comando.Parameters.AddWithValue("@NOME", Nome);
            comando.Parameters.AddWithValue("@DESCRICAO", Descricao);
            comando.Parameters.AddWithValue("@QUANTIDADE", Quantidade);
            comando.Parameters.AddWithValue("@PRECO", Preco);


            conexao.Open();
            comando.ExecuteNonQuery();
            //MessageBox.Show("Cadastro atualizado com êxito!", "Atualização de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexao.Close();
            comando.Clone();
            conexao = null;
            comando = null;




        }



        #endregion

        #region Delete


        #endregion


        #endregion

    }

}
