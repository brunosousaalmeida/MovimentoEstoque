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
        public int Codigo;
        public string Nome;
        public string Descricao;
        public int Quantidade;
        public double Preco;

        public Produto(int cod, string nome, string descricao, int quantidade, double preco)
        {
            Codigo = cod;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Produto(int cod, string nome, string descricao, double preco)
        {
            Codigo = cod;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public Produto(string nome, string descricao, int quantidade, double preco)
        {
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        /// <summary>
        /// Método para retirada de quantidade em estoque
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="quantidadeRetirar"></param>
        /// <returns>Saldo Atualizado</returns>
        public int RetiradaEstoque(int quantidade, int quantidadeRetirar)
        {
            Quantidade = quantidade;
            int saldoAtualizado = quantidade - quantidadeRetirar;
            return saldoAtualizado;
        }

        /// <summary>
        /// Método para entrada de quantidade em estoque
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="quantidadeEntrada"></param>
        /// <returns></returns>
        public int EntradaEstoque(int quantidade, int quantidadeEntrada)
        {
            Quantidade = quantidade;
            int saldoAtualizado = quantidade + quantidadeEntrada;
            return saldoAtualizado;
        }

    }
}
