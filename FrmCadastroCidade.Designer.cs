namespace SistemDeCaixa
{
    partial class FrmCadastroCidade
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
            this.CbxCidade = new System.Windows.Forms.ComboBox();
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.BTRemover = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.CbxUF = new System.Windows.Forms.ComboBox();
            this.UF = new System.Windows.Forms.Label();
            this.cidadeTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.cidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxCidade
            // 
            this.CbxCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comandasDataSet, "cidade.id", true));
            this.CbxCidade.DataSource = this.cidadeBindingSource;
            this.CbxCidade.DisplayMember = "nome";
            this.CbxCidade.FormattingEnabled = true;
            this.CbxCidade.Location = new System.Drawing.Point(12, 107);
            this.CbxCidade.Name = "CbxCidade";
            this.CbxCidade.Size = new System.Drawing.Size(156, 21);
            this.CbxCidade.TabIndex = 9;
            this.CbxCidade.ValueMember = "id";
            this.CbxCidade.SelectedIndexChanged += new System.EventHandler(this.CbxCidade_SelectedIndexChanged);
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.comandasDataSet;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Cidade:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(12, 29);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(156, 20);
            this.TxtCidade.TabIndex = 7;
            // 
            // BTRemover
            // 
            this.BTRemover.Location = new System.Drawing.Point(11, 134);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(75, 23);
            this.BTRemover.TabIndex = 6;
            this.BTRemover.Text = "Remover";
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(11, 62);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTSalvar.TabIndex = 5;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // CbxUF
            // 
            this.CbxUF.DisplayMember = "descricao";
            this.CbxUF.FormattingEnabled = true;
            this.CbxUF.Location = new System.Drawing.Point(174, 28);
            this.CbxUF.Name = "CbxUF";
            this.CbxUF.Size = new System.Drawing.Size(60, 21);
            this.CbxUF.TabIndex = 10;
            this.CbxUF.ValueMember = "id";
            // 
            // UF
            // 
            this.UF.AutoSize = true;
            this.UF.Location = new System.Drawing.Point(174, 12);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(21, 13);
            this.UF.TabIndex = 11;
            this.UF.Text = "UF";
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 192);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.CbxUF);
            this.Controls.Add(this.CbxCidade);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.BTRemover);
            this.Controls.Add(this.BTSalvar);
            this.Name = "FrmCadastroCidade";
            this.Text = "FrmCadastroCidade";
            this.Load += new System.EventHandler(this.FrmCadastroCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxCidade;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.Button BTSalvar;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.ComboBox CbxUF;
        private System.Windows.Forms.Label UF;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private comandasDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
    }
}