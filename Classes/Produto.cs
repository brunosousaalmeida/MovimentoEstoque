using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentoEstoque.Classes
{
    public class Produto
    {

        #region Atributos
        private string _nome;
        public int Codigo { get; private set; }
        public int Quantidade { get; private set; }

        public string Descricao { get; private set; }

        public double Preco { get; private set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor completo
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public Produto(int cod, string nome, string descricao, int quantidade, double preco)
        {
            Codigo = cod;
            _nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        /// <summary>
        /// Contrutor sem quantidade inicial.
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="preco"></param>
        public Produto(int cod, string nome, string descricao, double preco)
        {
            Codigo = cod;
            _nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        /// <summary>
        /// Construtor sem código
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        /// <param name="quantidade"></param>
        /// <param name="preco"></param>
        public Produto(string nome, string descricao, int quantidade, double preco)
        {
            _nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método para retirada de quantidade em estoque
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="quantidadeRetirar"></param>
        /// <returns>Saldo Atualizado</returns>
        public int RetiradaEstoque(int quantidadeRetirar)
        {
            Quantidade -= quantidadeRetirar;
            return Quantidade;
        }

        /// <summary>
        /// Método para entrada de quantidade em estoque
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="quantidadeEntrada"></param>
        /// <returns></returns>
        public int EntradaEstoque(int quantidadeEntrada)
        {
            Quantidade += quantidadeEntrada;
            return Quantidade;
        }

        /// <summary>
        /// Método para inserir um novo cadastro de produto no banco
        /// </summary>

        public void InserirProduto()
        {



            SqlConnection conexao;
            SqlCommand comando;


            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "INSERT INTO [MovimentoEstoque].[dbo].[Estoque.Produto1] (NOME, DESCRICAO, QUANTIDADE , PRECO) VALUES ( @NOME, @DESCRICAO, @QUANTIDADE, @PRECO)";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@NOME", _nome);
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
            catch (Exception ex)
            {

                string erro = ex.Message;
            }


        }


        #endregion

    }
}
