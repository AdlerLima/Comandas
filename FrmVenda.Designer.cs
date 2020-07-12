namespace SistemDeCaixa
{
    partial class FrmVenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxCliente = new System.Windows.Forms.ComboBox();
            this.CbxPagamento = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxFuncionario = new System.Windows.Forms.ComboBox();
            this.BTFinalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtComanda = new System.Windows.Forms.TextBox();
            this.BTAdicionarCliente = new System.Windows.Forms.Button();
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.clienteTableAdapter();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.funcionarioTableAdapter();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.pagamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forma de Pagamento:";
            // 
            // CbxCliente
            // 
            this.CbxCliente.DataSource = this.clienteBindingSource;
            this.CbxCliente.DisplayMember = "nome";
            this.CbxCliente.FormattingEnabled = true;
            this.CbxCliente.Location = new System.Drawing.Point(17, 80);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(131, 21);
            this.CbxCliente.TabIndex = 3;
            this.CbxCliente.ValueMember = "id";
            // 
            // CbxPagamento
            // 
            this.CbxPagamento.DataSource = this.pagamentoBindingSource;
            this.CbxPagamento.DisplayMember = "descricao";
            this.CbxPagamento.FormattingEnabled = true;
            this.CbxPagamento.Location = new System.Drawing.Point(191, 141);
            this.CbxPagamento.Name = "CbxPagamento";
            this.CbxPagamento.Size = new System.Drawing.Size(121, 21);
            this.CbxPagamento.TabIndex = 4;
            this.CbxPagamento.ValueMember = "id";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 141);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Funcionario:";
            // 
            // CbxFuncionario
            // 
            this.CbxFuncionario.DataSource = this.funcionarioBindingSource;
            this.CbxFuncionario.DisplayMember = "nome";
            this.CbxFuncionario.FormattingEnabled = true;
            this.CbxFuncionario.Location = new System.Drawing.Point(191, 80);
            this.CbxFuncionario.Name = "CbxFuncionario";
            this.CbxFuncionario.Size = new System.Drawing.Size(121, 21);
            this.CbxFuncionario.TabIndex = 7;
            this.CbxFuncionario.ValueMember = "id";
            // 
            // BTFinalizar
            // 
            this.BTFinalizar.Location = new System.Drawing.Point(237, 177);
            this.BTFinalizar.Name = "BTFinalizar";
            this.BTFinalizar.Size = new System.Drawing.Size(75, 23);
            this.BTFinalizar.TabIndex = 8;
            this.BTFinalizar.Text = "Finalizar";
            this.BTFinalizar.UseVisualStyleBackColor = true;
            this.BTFinalizar.Click += new System.EventHandler(this.BTFinalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comanda:";
            // 
            // TxtComanda
            // 
            this.TxtComanda.Location = new System.Drawing.Point(17, 25);
            this.TxtComanda.Name = "TxtComanda";
            this.TxtComanda.Size = new System.Drawing.Size(75, 20);
            this.TxtComanda.TabIndex = 10;
            // 
            // BTAdicionarCliente
            // 
            this.BTAdicionarCliente.Location = new System.Drawing.Point(152, 80);
            this.BTAdicionarCliente.Name = "BTAdicionarCliente";
            this.BTAdicionarCliente.Size = new System.Drawing.Size(22, 23);
            this.BTAdicionarCliente.TabIndex = 11;
            this.BTAdicionarCliente.Text = "+";
            this.BTAdicionarCliente.UseVisualStyleBackColor = true;
            this.BTAdicionarCliente.Click += new System.EventHandler(this.BTAdicionarCliente_Click);
            // 
            // comandasDataSet
            // 
            this.comandasDataSet.DataSetName = "comandasDataSet";
            this.comandasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.comandasDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "pagamento";
            this.pagamentoBindingSource.DataSource = this.comandasDataSet;
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 291);
            this.Controls.Add(this.BTAdicionarCliente);
            this.Controls.Add(this.TxtComanda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTFinalizar);
            this.Controls.Add(this.CbxFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.CbxPagamento);
            this.Controls.Add(this.CbxCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVenda";
            this.Text = "FrmVenda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxCliente;
        private System.Windows.Forms.ComboBox CbxPagamento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxFuncionario;
        private System.Windows.Forms.Button BTFinalizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtComanda;
        private System.Windows.Forms.Button BTAdicionarCliente;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private comandasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private comandasDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private comandasDataSetTableAdapters.pagamentoTableAdapter pagamentoTableAdapter;
    }
}