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
            this.components = new System.ComponentModel.Container();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandasDataSet1 = new SistemDeCaixa.comandasDataSet();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.BTAlterar = new System.Windows.Forms.Button();
            this.BTRemover = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.produtoidcategoriafkeyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.categoriaTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.categoriaTableAdapter();
            this.produtoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.produtoTableAdapter();
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoidcategoriafkeyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoidcategoriafkeyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoidcategoriafkeyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.comandasDataSet1;
            // 
            // comandasDataSet1
            // 
            this.comandasDataSet1.DataSetName = "comandasDataSet";
            this.comandasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(15, 43);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(135, 20);
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
            this.BTAlterar.Location = new System.Drawing.Point(114, 112);
            this.BTAlterar.Name = "BTAlterar";
            this.BTAlterar.Size = new System.Drawing.Size(75, 23);
            this.BTAlterar.TabIndex = 4;
            this.BTAlterar.Text = "Alterar";
            this.BTAlterar.UseVisualStyleBackColor = true;
            this.BTAlterar.Click += new System.EventHandler(this.BTAlterar_Click);
            // 
            // BTRemover
            // 
            this.BTRemover.Location = new System.Drawing.Point(293, 112);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(75, 23);
            this.BTRemover.TabIndex = 5;
            this.BTRemover.Text = "Remover";
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(205, 112);
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
            this.label2.Location = new System.Drawing.Point(155, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor:";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(158, 43);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(63, 20);
            this.TxtValor.TabIndex = 9;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoria";
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoidcategoriafkeyBindingSource1, "id_categoria", true));
            this.CbxCategoria.DataSource = this.categoriaBindingSource;
            this.CbxCategoria.DisplayMember = "descricao";
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(231, 41);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(102, 21);
            this.CbxCategoria.TabIndex = 11;
            this.CbxCategoria.ValueMember = "id";
            // 
            // produtoidcategoriafkeyBindingSource
            // 
            this.produtoidcategoriafkeyBindingSource.DataMember = "produto_id_categoria_fkey";
            this.produtoidcategoriafkeyBindingSource.DataSource = this.categoriaBindingSource;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.comandasDataSet;
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(339, 39);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(29, 23);
            this.btnAddCategoria.TabIndex = 12;
            this.btnAddCategoria.Text = "+";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // dvgData
            // 
            this.dvgData.AllowUserToAddRows = false;
            this.dvgData.AllowUserToDeleteRows = false;
            this.dvgData.AllowUserToOrderColumns = true;
            this.dvgData.AutoGenerateColumns = false;
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.prodnomeDataGridViewTextBoxColumn,
            this.prodprecoDataGridViewTextBoxColumn,
            this.idcategoriaDataGridViewTextBoxColumn});
            this.dvgData.DataSource = this.produtoidcategoriafkeyBindingSource;
            this.dvgData.Location = new System.Drawing.Point(12, 172);
            this.dvgData.MultiSelect = false;
            this.dvgData.Name = "dvgData";
            this.dvgData.ReadOnly = true;
            this.dvgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgData.Size = new System.Drawing.Size(344, 150);
            this.dvgData.TabIndex = 0;
            this.dvgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgData_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodnomeDataGridViewTextBoxColumn
            // 
            this.prodnomeDataGridViewTextBoxColumn.DataPropertyName = "prod_nome";
            this.prodnomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.prodnomeDataGridViewTextBoxColumn.Name = "prodnomeDataGridViewTextBoxColumn";
            this.prodnomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodprecoDataGridViewTextBoxColumn
            // 
            this.prodprecoDataGridViewTextBoxColumn.DataPropertyName = "prod_preco";
            this.prodprecoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.prodprecoDataGridViewTextBoxColumn.Name = "prodprecoDataGridViewTextBoxColumn";
            this.prodprecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            this.idcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoidcategoriafkeyBindingSource1
            // 
            this.produtoidcategoriafkeyBindingSource1.DataMember = "produto_id_categoria_fkey";
            this.produtoidcategoriafkeyBindingSource1.DataSource = this.categoriaBindingSource;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "descricao";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoidcategoriafkeyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoidcategoriafkeyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.Button BTAlterar;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.Button btnAddCategoria;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private comandasDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private comandasDataSet comandasDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private comandasDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridView dvgData;
        private System.Windows.Forms.BindingSource produtoidcategoriafkeyBindingSource;
        private System.Windows.Forms.BindingSource produtoidcategoriafkeyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
    }
}