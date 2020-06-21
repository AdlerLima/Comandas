namespace SistemDeCaixa
{
    partial class FrmCadastroProduto
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
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.BTAlterar = new System.Windows.Forms.Button();
            this.BTRemover = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgData
            // 
            this.dvgData.AllowUserToAddRows = false;
            this.dvgData.AllowUserToDeleteRows = false;
            this.dvgData.AllowUserToOrderColumns = true;
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Location = new System.Drawing.Point(12, 172);
            this.dvgData.MultiSelect = false;
            this.dvgData.Name = "dvgData";
            this.dvgData.ReadOnly = true;
            this.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgData.Size = new System.Drawing.Size(321, 150);
            this.dvgData.TabIndex = 0;
            this.dvgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgData_CellClick);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(15, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(171, 20);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Location = new System.Drawing.Point(15, 112);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BTAdicionar.TabIndex = 3;
            this.BTAdicionar.Text = "Adicionar";
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTAdicionar_Click);
            // 
            // BTAlterar
            // 
            this.BTAlterar.Location = new System.Drawing.Point(96, 112);
            this.BTAlterar.Name = "BTAlterar";
            this.BTAlterar.Size = new System.Drawing.Size(75, 23);
            this.BTAlterar.TabIndex = 4;
            this.BTAlterar.Text = "Alterar";
            this.BTAlterar.UseVisualStyleBackColor = true;
            this.BTAlterar.Click += new System.EventHandler(this.BTAlterar_Click);
            // 
            // BTRemover
            // 
            this.BTRemover.Location = new System.Drawing.Point(258, 112);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(75, 23);
            this.BTRemover.TabIndex = 5;
            this.BTRemover.Text = "Remover";
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(177, 112);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTSalvar.TabIndex = 6;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor:";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(205, 43);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 9;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 334);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.BTRemover);
            this.Controls.Add(this.BTAlterar);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.dvgData);
            this.Name = "FrmCadastroProduto";
            this.Text = "FrmCadastroProduto";
            this.Load += new System.EventHandler(this.FrmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgData;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.Button BTAlterar;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValor;
    }
}