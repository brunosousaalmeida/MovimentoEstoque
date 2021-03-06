﻿using System;
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

        #region Construtores
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

        #endregion

    }
}
