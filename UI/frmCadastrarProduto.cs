using MovimentoEstoque.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimentoEstoque.UI
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();

        }

        //Por enquanto, as interações com o banco estão incluídas nos botões do projeto.

        #region Evento Load
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
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

                dtgProdutos.DataSource = ds.Tables[0];

                conexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Botão Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            int quantidade;
            string nome, descricao;
            double preco;


            nome = txtNome.Text;
            descricao = txtDescricao.Text;
            quantidade = int.Parse(txtQuantidadeInicial.Text);
            preco = double.Parse(txtPreco.Text);

            Produto produto = new Produto(nome, descricao, quantidade, preco);

            SqlConnection conexao;
            SqlCommand comando;


            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "INSERT INTO [MovimentoEstoque].[dbo].[Estoque.Produto1] (NOME, DESCRICAO, QUANTIDADE , PRECO) VALUES ( @NOME, @DESCRICAO, @QUANTIDADE, @PRECO)";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@NOME", produto.Nome);
                comando.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
                comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
                comando.Parameters.AddWithValue("@PRECO", produto.Preco);


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro inserido com êxito!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Botão Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao;
            SqlDataAdapter da;
            string strSql;

            toolTipAtualizar.SetToolTip(btnAtualizar, "Atualizar lista de produtos cadastrados");

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id= sa; Password = open123;");
                strSql = "SELECT * FROM [MovimentoEstoque].[dbo].[Estoque.Produto1]";

                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSql, conexao);

                conexao.Open();
                da.Fill(ds);

                dtgProdutos.DataSource = ds.Tables[0];

                conexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        //O codigo para excluir um cadastro ou realizar update do mesmo está no evento abaixo

        #region Evento Duplo Click Item Grid
        private void dtgProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAtualizarCadastroProduto atualizarProduto = new frmAtualizarCadastroProduto();

            atualizarProduto.txtCodigo.Text = this.dtgProdutos.CurrentRow.Cells[0].Value.ToString();
            atualizarProduto.txtNome.Text = this.dtgProdutos.CurrentRow.Cells[1].Value.ToString();
            atualizarProduto.txtDescricao.Text = this.dtgProdutos.CurrentRow.Cells[2].Value.ToString();
            atualizarProduto.txtQuantidade.Text = this.dtgProdutos.CurrentRow.Cells[3].Value.ToString();
            atualizarProduto.txtPreco.Text = this.dtgProdutos.CurrentRow.Cells[4].Value.ToString();
            atualizarProduto.Show();
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
