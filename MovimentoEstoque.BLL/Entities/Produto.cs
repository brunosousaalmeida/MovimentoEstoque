using MovimentoEstoque.DAL;
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

        public ContextDBProduto ContextProduto { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão (vazio)
        /// </summary>
        public Produto()
        {

        }

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

            ContextProduto = new ContextDBProduto(Codigo, _nome, Descricao, Quantidade, Preco);
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

            ContextProduto = new ContextDBProduto(Codigo, _nome, Descricao, Preco);
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

            ContextProduto = new ContextDBProduto(Codigo, _nome, Descricao, Preco);
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

        public void CadastrarProduto()
        {
            ContextProduto.SalvarProduto();
        }



        public SqlDataAdapter ObterTodosProdutos()

        {
            return ContextProduto.ObterProdutos();
        }

        public void AtualizarCadastro()
        {
            ContextProduto.AtualizaCadastroProduto();
        }

        public void DeletarCadastro()
        {
            ContextProduto.DeletarCadastroProduto();
        }

        #endregion

    }
}
