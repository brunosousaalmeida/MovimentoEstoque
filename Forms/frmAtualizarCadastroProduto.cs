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
    public partial class frmAtualizarCadastroProduto : Form
    {
        public frmAtualizarCadastroProduto()
        {
            InitializeComponent();
        }

        //Botão para salvar atualização do cadastro, utilizando métodos da BLL.Produto (método update)

        #region Botão Salvar (Atualizar cadastro)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(int.Parse(txtCodigo.Text), txtNome.Text, txtDescricao.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text));

            try
            {
                produto.AtualizarCadastro();

                MessageBox.Show("Cadastro atualizado com êxito!", "Cadastro Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o cadastro!{ex}", "Erro Atualização Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

        }

        #endregion

        //Botão para excluir cadastro selecionado (dados expostos no form)

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            Produto produto = new Produto(int.Parse(txtCodigo.Text), txtNome.Text, txtDescricao.Text, int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text));

            try
            {
                produto.DeletarCadastro();

                MessageBox.Show("Cadastro excluído com êxito!", "Cadastro Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao excluir o cadastro!{ex}", "Erro Exclusão Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Botão simples para cancelar operação

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
