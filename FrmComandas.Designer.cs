namespace SistemDeCaixa
{
    partial class FrmComandas
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
            this.DgvComanda = new System.Windows.Forms.DataGridView();
            this.numerocomandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcomandasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.CbxComandas = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.v_comandasTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.v_comandasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcomandasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvComanda
            // 
            this.DgvComanda.AllowUserToAddRows = false;
            this.DgvComanda.AllowUserToDeleteRows = false;
            this.DgvComanda.AutoGenerateColumns = false;
            this.DgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerocomandaDataGridViewTextBoxColumn,
            this.prodnomeDataGridViewTextBoxColumn,
            this.prodprecoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn});
            this.DgvComanda.DataSource = this.vcomandasBindingSource;
            this.DgvComanda.Location = new System.Drawing.Point(12, 79);
            this.DgvComanda.Name = "DgvComanda";
            this.DgvComanda.Size = new System.Drawing.Size(483, 222);
            this.DgvComanda.TabIndex = 0;
            // 
            // numerocomandaDataGridViewTextBoxColumn
            // 
            this.numerocomandaDataGridViewTextBoxColumn.DataPropertyName = "numero_comanda";
            this.numerocomandaDataGridViewTextBoxColumn.HeaderText = "Nº Comanda";
            this.numerocomandaDataGridViewTextBoxColumn.Name = "numerocomandaDataGridViewTextBoxColumn";
            // 
            // prodnomeDataGridViewTextBoxColumn
            // 
            this.prodnomeDataGridViewTextBoxColumn.DataPropertyName = "prod_nome";
            this.prodnomeDataGridViewTextBoxColumn.HeaderText = "Item";
            this.prodnomeDataGridViewTextBoxColumn.Name = "prodnomeDataGridViewTextBoxColumn";
            this.prodnomeDataGridViewTextBoxColumn.Width = 140;
            // 
            // prodprecoDataGridViewTextBoxColumn
            // 
            this.prodprecoDataGridViewTextBoxColumn.DataPropertyName = "prod_preco";
            this.prodprecoDataGridViewTextBoxColumn.HeaderText = "Preço UN";
            this.prodprecoDataGridViewTextBoxColumn.Name = "prodprecoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // vcomandasBindingSource
            // 
            this.vcomandasBindingSource.DataMember = "v_comandas";
            this.vcomandasBindingSource.DataSource = this.comandasDataSet;
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbxComandas
            // 
            this.CbxComandas.FormattingEnabled = true;
            this.CbxComandas.Location = new System.Drawing.Point(13, 35);
            this.CbxComandas.Name = "CbxComandas";
            this.CbxComandas.Size = new System.Drawing.Size(74, 21);
            this.CbxComandas.TabIndex = 5;
            this.CbxComandas.SelectedIndexChanged += new System.EventHandler(this.CbxComandas_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // v_comandasTableAdapter
            // 
            this.v_comandasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nº Comanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor Total:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(416, 325);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 20);
            this.txtValor.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = global::SistemDeCaixa.Properties.Resources.repeat;
            this.button1.Location = new System.Drawing.Point(12, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 38);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Relatorio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CbxComandas);
            this.Controls.Add(this.DgvComanda);
            this.Name = "FrmComandas";
            this.Text = "FrmComandas";
            this.Load += new System.EventHandler(this.FrmComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcomandasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvComanda;
        private System.Windows.Forms.ComboBox CbxComandas;
        private System.Windows.Forms.Button button3;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource vcomandasBindingSource;
        private comandasDataSetTableAdapters.v_comandasTableAdapter v_comandasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocomandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}