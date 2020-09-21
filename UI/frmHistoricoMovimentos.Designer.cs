namespace MovimentoEstoque.UI
{
    partial class frmHistoricoMovimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoricoMovimentos));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMovimentos = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.toolTipAtualizarHist = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimentos realizados:";
            // 
            // dtgMovimentos
            // 
            this.dtgMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovimentos.Location = new System.Drawing.Point(12, 145);
            this.dtgMovimentos.Name = "dtgMovimentos";
            this.dtgMovimentos.Size = new System.Drawing.Size(776, 314);
            this.dtgMovimentos.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(711, 84);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 55);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAtualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(647, 84);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(58, 55);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // frmHistoricoMovimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dtgMovimentos);
            this.Controls.Add(this.label1);
            this.Name = "frmHistoricoMovimentos";
            this.Text = "Histórico Movimentos";
            this.Load += new System.EventHandler(this.frmHistoricoMovimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMovimentos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ToolTip toolTipAtualizarHist;
    }
}