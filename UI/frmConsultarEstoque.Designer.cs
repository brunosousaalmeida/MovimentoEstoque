namespace MovimentoEstoque.UI
{
    partial class frmConsultarEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgConsultaEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o item que deseja movimentar:";
            // 
            // dtgConsultaEstoque
            // 
            this.dtgConsultaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaEstoque.Location = new System.Drawing.Point(12, 89);
            this.dtgConsultaEstoque.Name = "dtgConsultaEstoque";
            this.dtgConsultaEstoque.Size = new System.Drawing.Size(776, 349);
            this.dtgConsultaEstoque.TabIndex = 1;
            this.dtgConsultaEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaEstoque_CellDoubleClick);
            // 
            // frmConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultaEstoque);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarEstoque";
            this.Text = "Consulta Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgConsultaEstoque;
    }
}