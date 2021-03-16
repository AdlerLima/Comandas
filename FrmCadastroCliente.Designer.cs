namespace SistemDeCaixa
{
    partial class FrmCadastroCliente
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
            this.CbxCidade = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTAdicionar = new System.Windows.Forms.Button();
            this.BTAlterar = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.BTRemover = new System.Windows.Forms.Button();
            this.dtvClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTPesquisar = new System.Windows.Forms.Button();
            this.BTNovoCidade = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.clienteTableAdapter();
            this.cli_cidTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.cli_cidTableAdapter();
            this.cidadeTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.cidadeTableAdapter();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clicidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // CbxCidade
            // 
            this.CbxCidade.DataSource = this.cidadeBindingSource;
            this.CbxCidade.DisplayMember = "nome";
            this.CbxCidade.FormattingEnabled = true;
            this.CbxCidade.Location = new System.Drawing.Point(322, 97);
            this.CbxCidade.Name = "CbxCidade";
            this.CbxCidade.Size = new System.Drawing.Size(105, 21);
            this.CbxCidade.TabIndex = 1;
            this.CbxCidade.ValueMember = "id";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.comandasDataSet;
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(15, 40);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(207, 20);
            this.TxtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cidade:";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(228, 40);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(104, 20);
            this.mskDataNascimento.TabIndex = 4;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // MskCPF
            // 
            this.MskCPF.Location = new System.Drawing.Point(338, 40);
            this.MskCPF.Mask = "000.000.000-00";
            this.MskCPF.Name = "MskCPF";
            this.MskCPF.Size = new System.Drawing.Size(118, 20);
            this.MskCPF.TabIndex = 7;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(15, 98);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(141, 20);
            this.TxtBairro.TabIndex = 8;
            // 
            // TxtRua
            // 
            this.TxtRua.Location = new System.Drawing.Point(162, 98);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(116, 20);
            this.TxtRua.TabIndex = 9;
            this.TxtRua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rua:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(284, 98);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(32, 20);
            this.TxtNumero.TabIndex = 12;
            this.TxtNumero.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nº";
            // 
            // BTAdicionar
            // 
            this.BTAdicionar.Location = new System.Drawing.Point(15, 143);
            this.BTAdicionar.Name = "BTAdicionar";
            this.BTAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BTAdicionar.TabIndex = 14;
            this.BTAdicionar.Text = "Adicionar";
            this.BTAdicionar.UseVisualStyleBackColor = true;
            this.BTAdicionar.Click += new System.EventHandler(this.BTAdicionar_Click);
            // 
            // BTAlterar
            // 
            this.BTAlterar.Location = new System.Drawing.Point(96, 143);
            this.BTAlterar.Name = "BTAlterar";
            this.BTAlterar.Size = new System.Drawing.Size(75, 23);
            this.BTAlterar.TabIndex = 15;
            this.BTAlterar.Text = "Alterar";
            this.BTAlterar.UseVisualStyleBackColor = true;
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(177, 143);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTSalvar.TabIndex = 16;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // BTRemover
            // 
            this.BTRemover.Location = new System.Drawing.Point(258, 143);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(75, 23);
            this.BTRemover.TabIndex = 17;
            this.BTRemover.Text = "Remover";
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // dtvClientes
            // 
            this.dtvClientes.AllowUserToAddRows = false;
            this.dtvClientes.AllowUserToDeleteRows = false;
            this.dtvClientes.AllowUserToOrderColumns = true;
            this.dtvClientes.AutoGenerateColumns = false;
            this.dtvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cidade,
            this.cpf,
            this.nascimento,
            this.rua,
            this.numero,
            this.bairro,
            this.NomeCidade,
            this.uf});
            this.dtvClientes.DataSource = this.clicidBindingSource;
            this.dtvClientes.Location = new System.Drawing.Point(12, 198);
            this.dtvClientes.MultiSelect = false;
            this.dtvClientes.Name = "dtvClientes";
            this.dtvClientes.ReadOnly = true;
            this.dtvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvClientes.Size = new System.Drawing.Size(440, 196);
            this.dtvClientes.TabIndex = 18;
            this.dtvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvClientes_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 180;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "id_cidade";
            this.cidade.HeaderText = "id_cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Visible = false;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // nascimento
            // 
            this.nascimento.DataPropertyName = "nascimento";
            this.nascimento.HeaderText = "nascimento";
            this.nascimento.Name = "nascimento";
            this.nascimento.ReadOnly = true;
            this.nascimento.Visible = false;
            // 
            // rua
            // 
            this.rua.DataPropertyName = "rua";
            this.rua.HeaderText = "rua";
            this.rua.Name = "rua";
            this.rua.ReadOnly = true;
            this.rua.Visible = false;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Visible = false;
            // 
            // NomeCidade
            // 
            this.NomeCidade.DataPropertyName = "cidade";
            this.NomeCidade.HeaderText = "Cidade";
            this.NomeCidade.Name = "NomeCidade";
            this.NomeCidade.ReadOnly = true;
            this.NomeCidade.Width = 130;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "uf";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Visible = false;
            // 
            // clicidBindingSource
            // 
            this.clicidBindingSource.DataMember = "cli_cid";
            this.clicidBindingSource.DataSource = this.comandasDataSet;
            // 
            // BTPesquisar
            // 
            this.BTPesquisar.Location = new System.Drawing.Point(339, 143);
            this.BTPesquisar.Name = "BTPesquisar";
            this.BTPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BTPesquisar.TabIndex = 19;
            this.BTPesquisar.Text = "Pesquisar";
            this.BTPesquisar.UseVisualStyleBackColor = true;
            // 
            // BTNovoCidade
            // 
            this.BTNovoCidade.Location = new System.Drawing.Point(433, 95);
            this.BTNovoCidade.Name = "BTNovoCidade";
            this.BTNovoCidade.Size = new System.Drawing.Size(23, 23);
            this.BTNovoCidade.TabIndex = 20;
            this.BTNovoCidade.Text = "+";
            this.BTNovoCidade.UseVisualStyleBackColor = true;
            this.BTNovoCidade.Click += new System.EventHandler(this.BTNovoCidade_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.comandasDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cli_cidTableAdapter
            // 
            this.cli_cidTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(413, 172);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(39, 20);
            this.TxtCidade.TabIndex = 21;
            this.TxtCidade.Visible = false;
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 406);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.BTNovoCidade);
            this.Controls.Add(this.BTPesquisar);
            this.Controls.Add(this.dtvClientes);
            this.Controls.Add(this.BTRemover);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.BTAlterar);
            this.Controls.Add(this.BTAdicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.MskCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.CbxCidade);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroCliente";
            this.Text = "FrmCadastroCliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clicidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxCidade;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskCPF;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTAdicionar;
        private System.Windows.Forms.Button BTAlterar;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.DataGridView dtvClientes;
        private System.Windows.Forms.Button BTPesquisar;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private comandasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button BTNovoCidade;
        private System.Windows.Forms.BindingSource clicidBindingSource;
        private comandasDataSetTableAdapters.cli_cidTableAdapter cli_cidTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private comandasDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.TextBox TxtCidade;
    }
}