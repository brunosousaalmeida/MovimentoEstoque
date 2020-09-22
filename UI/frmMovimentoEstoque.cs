using MovimentoEstoque.Classes;
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
    public partial class frmMovimentoEstoque : Form
    {
        public frmMovimentoEstoque()
        {
            InitializeComponent();
            toolTipMovimentoEstoque.SetToolTip(lblTipoMov,"Tipo de movimento a ser executado (Entrada ou saída)");
            
        }

        //Por enquanto, as interações com o banco estão incluídas nos botões do projeto.

        #region Evento Duplo Click Campo Código
        private void txtCodigo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
            frmConsultarEstoque consulta = new frmConsultarEstoque();
            consulta.Show();
        }

        #endregion

        #region Botão Movimentar Estoque
        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            int qtde = int.Parse(txtQtdeEstoque.Text);
            int qtdeMov = int.Parse(txtQtdeMov.Text);
            double valor = double.Parse(txtPreco.Text);
            DateTime data = DateTime.Now;

            string tipoMov = cboTipoMovimento.SelectedItem.ToString();
            int estoqueAtualizado = 0;


            Produto produto = new Produto(cod,nome,descricao,qtde,valor);

            if (tipoMov == "Entrada")
            {
                estoqueAtualizado = produto.EntradaEstoque(qtdeMov);

            }
            else if (tipoMov == "Saída")
            {
                estoqueAtualizado = produto.RetiradaEstoque(qtdeMov);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um tipo de entrada!");
            }

            SqlConnection conexao;
            SqlCommand comando;


            string strSql;

            //Atualização do saldo na tabela de produto

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "UPDATE[MovimentoEstoque].[dbo].[Estoque.Produto1] SET Quantidade = @QUANTIDADE, Preco = @PRECO WHERE Codigo = @CODIGO";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);
                comando.Parameters.AddWithValue("@QUANTIDADE", estoqueAtualizado.ToString());
                comando.Parameters.AddWithValue("@PRECO", txtPreco.Text);


                conexao.Open();
                comando.ExecuteNonQuery();                

                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //Inserindo o movimento realizado na tabela de histórico.

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "INSERT INTO [MovimentoEstoque].[dbo].[Estoque.Movimento] (TIPOMOVIMENTO, DATAMOVIMENTO, CODIGO, NOME, DESCRICAO, QUANTIDADEMOVIMENTO , SALDOESTOQUE) VALUES (@TIPOMOVIMENTO, @DATAMOVIMENTO, @CODIGO, @NOME, @DESCRICAO, @QUANTIDADEMOVIMENTO, @SALDOESTOQUE)";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@TIPOMOVIMENTO", tipoMov);
                comando.Parameters.AddWithValue("@DATAMOVIMENTO", data);
                comando.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text);
                comando.Parameters.AddWithValue("@QUANTIDADEMOVIMENTO", txtQtdeMov.Text);
                comando.Parameters.AddWithValue("@SALDOESTOQUE", estoqueAtualizado.ToString());


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Movimento de estoque realizado com sucesso!", "Movimento de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQtdeEstoque.Clear();
            txtQtdeMov.Clear();
            txtPreco.Clear();

        }

        #endregion

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
