namespace MovimentoEstoque.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtAdmUsuarios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnMovimentoEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistoricoMovimento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtAdmUsuarios
            // 
            this.txtAdmUsuarios.Location = new System.Drawing.Point(686, 347);
            this.txtAdmUsuarios.Name = "txtAdmUsuarios";
            this.txtAdmUsuarios.Size = new System.Drawing.Size(102, 43);
            this.txtAdmUsuarios.TabIndex = 0;
            this.txtAdmUsuarios.Text = "Administrar Usuários:";
            this.txtAdmUsuarios.UseVisualStyleBackColor = true;
            this.txtAdmUsuarios.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(686, 396);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 42);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.Location = new System.Drawing.Point(12, 12);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(151, 146);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnMovimentoEstoque
            // 
            this.btnMovimentoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentoEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMovimentoEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentoEstoque.Image")));
            this.btnMovimentoEstoque.Location = new System.Drawing.Point(202, 12);
            this.btnMovimentoEstoque.Name = "btnMovimentoEstoque";
            this.btnMovimentoEstoque.Size = new System.Drawing.Size(151, 146);
            this.btnMovimentoEstoque.TabIndex = 3;
            this.btnMovimentoEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMovimentoEstoque.UseVisualStyleBackColor = true;
            this.btnMovimentoEstoque.Click += new System.EventHandler(this.btnMovimentoEstoque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movimentar Estoque";
            // 
            // btnHistoricoMovimento
            // 
            this.btnHistoricoMovimento.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoricoMovimento.Image")));
            this.btnHistoricoMovimento.Location = new System.Drawing.Point(395, 12);
            this.btnHistoricoMovimento.Name = "btnHistoricoMovimento";
            this.btnHistoricoMovimento.Size = new System.Drawing.Size(151, 146);
            this.btnHistoricoMovimento.TabIndex = 5;
            this.btnHistoricoMovimento.UseVisualStyleBackColor = true;
            this.btnHistoricoMovimento.Click += new System.EventHandler(this.btnHistoricoMovimento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OliveDrab;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(392, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Histórico Movimentos";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHistoricoMovimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMovimentoEstoque);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtAdmUsuarios);
            this.Name = "frmPrincipal";
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtAdmUsuarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnMovimentoEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistoricoMovimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipPrincipal;
    }
}