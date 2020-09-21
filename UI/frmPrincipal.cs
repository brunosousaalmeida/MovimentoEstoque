﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimentoEstoque.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            toolTipPrincipal.SetToolTip(btnProdutos,"Cadastros de produtos");
            toolTipPrincipal.SetToolTip(btnMovimentoEstoque, "Realizar movimentos de estoque");
            toolTipPrincipal.SetToolTip(btnHistoricoMovimento, "Consultar histórico de movimentos realizados");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto produto = new frmCadastrarProduto();
            produto.Show();
        }

        private void btnMovimentoEstoque_Click(object sender, EventArgs e)
        {
            frmMovimentoEstoque movimento = new frmMovimentoEstoque();
            movimento.Show();
        }

        private void btnHistoricoMovimento_Click(object sender, EventArgs e)
        {
            frmHistoricoMovimentos historico = new frmHistoricoMovimentos();
            historico.Show();
        }
    }
}
