namespace SistemDeCaixa
{
    partial class FrmRelatorioVendas
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
            this.DgvRelatorio = new System.Windows.Forms.DataGridView();
            this.relatoriovendasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.relatoriovendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relatoriovendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CbxCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CbxPagamento = new System.Windows.Forms.ComboBox();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.CbxFuncionario = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.vendaTableAdapter();
            this.clienteTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.clienteTableAdapter();
            this.pagamentoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.pagamentoTableAdapter();
            this.funcionarioTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.funcionarioTableAdapter();
            this.CbxComanda = new System.Windows.Forms.ComboBox();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comandaTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.comandaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.relatorio_vendasTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.relatorio_vendasTableAdapter();
            this.numero_comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRelatorio
            // 
            this.DgvRelatorio.AllowUserToAddRows = false;
            this.DgvRelatorio.AllowUserToDeleteRows = false;
            this.DgvRelatorio.AutoGenerateColumns = false;
            this.DgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_comanda,
            this.cliente,
            this.pagamento,
            this.funcionario,
            this.valor_total});
            this.DgvRelatorio.DataSource = this.relatoriovendasBindingSource2;
            this.DgvRelatorio.Location = new System.Drawing.Point(12, 70);
            this.DgvRelatorio.Name = "DgvRelatorio";
            this.DgvRelatorio.ReadOnly = true;
            this.DgvRelatorio.Size = new System.Drawing.Size(624, 340);
            this.DgvRelatorio.TabIndex = 0;
            // 
            // relatoriovendasBindingSource2
            // 
            this.relatoriovendasBindingSource2.DataMember = "relatorio_vendas";
            this.relatoriovendasBindingSource2.DataSource = this.comandasDataSet;
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatoriovendasBindingSource1
            // 
            this.relatoriovendasBindingSource1.DataMember = "relatorio_vendas";
            this.relatoriovendasBindingSource1.DataSource = this.comandasDataSet;
            // 
            // relatoriovendasBindingSource
            // 
            this.relatoriovendasBindingSource.DataMember = "relatorio_vendas";
            this.relatoriovendasBindingSource.DataSource = this.comandasDataSet;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "venda";
            this.vendaBindingSource1.DataSource = this.comandasDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // CbxCliente
            // 
            this.CbxCliente.DataSource = this.clienteBindingSource;
            this.CbxCliente.DisplayMember = "nome";
            this.CbxCliente.FormattingEnabled = true;
            this.CbxCliente.Location = new System.Drawing.Point(139, 30);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(129, 21);
            this.CbxCliente.TabIndex = 2;
            this.CbxCliente.ValueMember = "id";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.comandasDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pagamento:";
            // 
            // CbxPagamento
            // 
            this.CbxPagamento.DataSource = this.pagamentoBindingSource;
            this.CbxPagamento.DisplayMember = "descricao";
            this.CbxPagamento.FormattingEnabled = true;
            this.CbxPagamento.Location = new System.Drawing.Point(274, 30);
            this.CbxPagamento.Name = "CbxPagamento";
            this.CbxPagamento.Size = new System.Drawing.Size(121, 21);
            this.CbxPagamento.TabIndex = 4;
            this.CbxPagamento.ValueMember = "id";
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "pagamento";
            this.pagamentoBindingSource.DataSource = this.comandasDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionario:";
            // 
            // CbxFuncionario
            // 
            this.CbxFuncionario.DataSource = this.funcionarioBindingSource;
            this.CbxFuncionario.DisplayMember = "nome";
            this.CbxFuncionario.FormattingEnabled = true;
            this.CbxFuncionario.Location = new System.Drawing.Point(401, 30);
            this.CbxFuncionario.Name = "CbxFuncionario";
            this.CbxFuncionario.Size = new System.Drawing.Size(121, 21);
            this.CbxFuncionario.TabIndex = 6;
            this.CbxFuncionario.ValueMember = "id";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.comandasDataSet;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.comandasDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // CbxComanda
            // 
            this.CbxComanda.DataSource = this.comandaBindingSource;
            this.CbxComanda.DisplayMember = "numero_comanda";
            this.CbxComanda.FormattingEnabled = true;
            this.CbxComanda.Location = new System.Drawing.Point(12, 30);
            this.CbxComanda.Name = "CbxComanda";
            this.CbxComanda.Size = new System.Drawing.Size(121, 21);
            this.CbxComanda.TabIndex = 8;
            this.CbxComanda.ValueMember = "numero_comanda";
            // 
            // comandaBindingSource
            // 
            this.comandaBindingSource.DataMember = "comanda";
            this.comandaBindingSource.DataSource = this.comandasDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comanda:";
            // 
            // comandaTableAdapter
            // 
            this.comandaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // relatorio_vendasTableAdapter
            // 
            this.relatorio_vendasTableAdapter.ClearBeforeFill = true;
            // 
            // numero_comanda
            // 
            this.numero_comanda.DataPropertyName = "numero_comanda";
            this.numero_comanda.HeaderText = "Nº Comanda";
            this.numero_comanda.Name = "numero_comanda";
            this.numero_comanda.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Nome Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 140;
            // 
            // pagamento
            // 
            this.pagamento.DataPropertyName = "pagamento";
            this.pagamento.HeaderText = "Pagamento Via";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 120;
            // 
            // funcionario
            // 
            this.funcionario.DataPropertyName = "funcionario";
            this.funcionario.HeaderText = "Funcionario";
            this.funcionario.Name = "funcionario";
            this.funcionario.ReadOnly = true;
            this.funcionario.Width = 120;
            // 
            // valor_total
            // 
            this.valor_total.DataPropertyName = "valor_total";
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            // 
            // FrmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbxComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvRelatorio);
            this.Name = "FrmRelatorioVendas";
            this.Text = "FrmRelatorioVendas";
            this.Load += new System.EventHandler(this.FrmRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxFuncionario;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private comandasDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private comandasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private comandasDataSetTableAdapters.pagamentoTableAdapter pagamentoTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private comandasDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.ComboBox CbxComanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private comandasDataSetTableAdapters.comandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource relatoriovendasBindingSource;
        private comandasDataSetTableAdapters.relatorio_vendasTableAdapter relatorio_vendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource relatoriovendasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource relatoriovendasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
    }
}