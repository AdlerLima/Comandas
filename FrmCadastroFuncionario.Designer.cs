namespace SistemDeCaixa
{
    partial class FrmCadastroFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.CbxCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.BTRemover = new System.Windows.Forms.Button();
            this.BTAlterar = new System.Windows.Forms.Button();
            this.DgvFuncionario = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.funcionarioTableAdapter();
            this.cargoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.cargoTableAdapter();
            this.fun_cargoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.fun_cargoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(15, 37);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(181, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(177, 92);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTSalvar.TabIndex = 9;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // CbxCargo
            // 
            this.CbxCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cargoBindingSource1, "id", true));
            this.CbxCargo.DataSource = this.cargoBindingSource;
            this.CbxCargo.DisplayMember = "descricao";
            this.CbxCargo.FormattingEnabled = true;
            this.CbxCargo.Location = new System.Drawing.Point(202, 37);
            this.CbxCargo.Name = "CbxCargo";
            this.CbxCargo.Size = new System.Drawing.Size(97, 21);
            this.CbxCargo.TabIndex = 10;
            this.CbxCargo.ValueMember = "id";
            // 
            // cargoBindingSource1
            // 
            this.cargoBindingSource1.DataMember = "cargo";
            this.cargoBindingSource1.DataSource = this.comandasDataSet;
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "cargo";
            this.cargoBindingSource.DataSource = this.comandasDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cargo";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(305, 36);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(28, 21);
            this.BtnNovo.TabIndex = 12;
            this.BtnNovo.Text = "+";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Location = new System.Drawing.Point(15, 92);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BTAdicionar.TabIndex = 13;
            this.BTAdicionar.Text = "Adicionar";
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTAdicionar_Click);
            // 
            // BTRemover
            // 
            this.BTRemover.Location = new System.Drawing.Point(258, 92);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(75, 23);
            this.BTRemover.TabIndex = 14;
            this.BTRemover.Text = "Remover";
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // BTAlterar
            // 
            this.BTAlterar.Location = new System.Drawing.Point(96, 92);
            this.BTAlterar.Name = "BTAlterar";
            this.BTAlterar.Size = new System.Drawing.Size(75, 23);
            this.BTAlterar.TabIndex = 15;
            this.BTAlterar.Text = "Alterar";
            this.BTAlterar.UseVisualStyleBackColor = true;
            this.BTAlterar.Click += new System.EventHandler(this.BTAlterar_Click);
            // 
            // DgvFuncionario
            // 
            this.DgvFuncionario.AllowUserToAddRows = false;
            this.DgvFuncionario.AllowUserToDeleteRows = false;
            this.DgvFuncionario.AllowUserToOrderColumns = true;
            this.DgvFuncionario.AutoGenerateColumns = false;
            this.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.id,
            this.descricao});
            this.DgvFuncionario.DataSource = this.funcargoBindingSource;
            this.DgvFuncionario.Location = new System.Drawing.Point(13, 122);
            this.DgvFuncionario.MultiSelect = false;
            this.DgvFuncionario.Name = "DgvFuncionario";
            this.DgvFuncionario.ReadOnly = true;
            this.DgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionario.Size = new System.Drawing.Size(320, 169);
            this.DgvFuncionario.TabIndex = 16;
            this.DgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 140;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Cargo";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 140;
            // 
            // funcargoBindingSource
            // 
            this.funcargoBindingSource.DataMember = "fun_cargo";
            this.funcargoBindingSource.DataSource = this.comandasDataSet;
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "funcionario";
            this.funcionarioBindingSource1.DataSource = this.comandasDataSet;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.comandasDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // fun_cargoTableAdapter
            // 
            this.fun_cargoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 301);
            this.Controls.Add(this.DgvFuncionario);
            this.Controls.Add(this.BTAlterar);
            this.Controls.Add(this.BTRemover);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxCargo);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFuncionario";
            this.Text = "FrmCadastroFuncionario";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.ComboBox CbxCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.Button BTAlterar;
        private System.Windows.Forms.DataGridView DgvFuncionario;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private comandasDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private comandasDataSetTableAdapters.cargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
        private System.Windows.Forms.BindingSource funcargoBindingSource;
        private comandasDataSetTableAdapters.fun_cargoTableAdapter fun_cargoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}