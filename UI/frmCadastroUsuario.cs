﻿using System;
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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        //Por enquanto, as interações com o banco estão incluídas nos botões do projeto.
        //Por ora é possível realizar cadastro de usuários, mas o mesmo ainda não é consumido
        //Também falta a criação da tela de gerenciamento de usuários, que ficará disponível apenas para usuário administrador

        #region Botão Salvar
        private void txtSalvar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao;
            SqlCommand comando;
           
            string strSql;

            try
            {
                conexao = new SqlConnection("Server=LAPTOP-DPAT0JHO\\SQLEXPRESS;Database=MovimentoEstoque;User Id=sa; Password = open123;");
                strSql = "INSERT INTO [MovimentoEstoque].[dbo].[Sistema.Usuario] (NOMEUSUARIO, LOGIN, SENHA) VALUES (@NOMEUSUARIO, @LOGIN, @SENHA)";
                comando = new SqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@NOMEUSUARIO", txtNomeUsuario.Text);
                comando.Parameters.AddWithValue("@LOGIN", txtLogin.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                                
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro inserido com êxito!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
                comando.Clone();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                conexao = null;
                comando = null;

            }

        }

        #endregion

        #region Botão Sair
        private void txtSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}

