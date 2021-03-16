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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.vendaTableAdapter();
            this.clienteTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.clienteTableAdapter();
            this.pagamentoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.pagamentoTableAdapter();
            this.funcionarioTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.funcionarioTableAdapter();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.comandaTableAdapter();
            this.relatorio_vendasTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.relatorio_vendasTableAdapter();
            this.numero_comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocomandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.valor_total,
            this.idDataGridViewTextBoxColumn,
            this.valortotalDataGridViewTextBoxColumn,
            this.numerocomandaDataGridViewTextBoxColumn,
            this.idcomandaDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.idpagamentoDataGridViewTextBoxColumn,
            this.pagamentoDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.idfuncionarioDataGridViewTextBoxColumn});
            this.DgvRelatorio.DataSource = this.relatoriovendasBindingSource2;
            this.DgvRelatorio.Location = new System.Drawing.Point(12, 12);
            this.DgvRelatorio.Name = "DgvRelatorio";
            this.DgvRelatorio.ReadOnly = true;
            this.DgvRelatorio.Size = new System.Drawing.Size(624, 398);
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
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.comandasDataSet;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "pagamento";
            this.pagamentoBindingSource.DataSource = this.comandasDataSet;
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
            // comandaBindingSource
            // 
            this.comandaBindingSource.DataMember = "comanda";
            this.comandaBindingSource.DataSource = this.comandasDataSet;
            // 
            // comandaTableAdapter
            // 
            this.comandaTableAdapter.ClearBeforeFill = true;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // valortotalDataGridViewTextBoxColumn
            // 
            this.valortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.HeaderText = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.Name = "valortotalDataGridViewTextBoxColumn";
            this.valortotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valortotalDataGridViewTextBoxColumn.Visible = false;
            // 
            // numerocomandaDataGridViewTextBoxColumn
            // 
            this.numerocomandaDataGridViewTextBoxColumn.DataPropertyName = "numero_comanda";
            this.numerocomandaDataGridViewTextBoxColumn.HeaderText = "numero_comanda";
            this.numerocomandaDataGridViewTextBoxColumn.Name = "numerocomandaDataGridViewTextBoxColumn";
            this.numerocomandaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerocomandaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcomandaDataGridViewTextBoxColumn
            // 
            this.idcomandaDataGridViewTextBoxColumn.DataPropertyName = "id_comanda";
            this.idcomandaDataGridViewTextBoxColumn.HeaderText = "id_comanda";
            this.idcomandaDataGridViewTextBoxColumn.Name = "idcomandaDataGridViewTextBoxColumn";
            this.idcomandaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomandaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpagamentoDataGridViewTextBoxColumn
            // 
            this.idpagamentoDataGridViewTextBoxColumn.DataPropertyName = "id_pagamento";
            this.idpagamentoDataGridViewTextBoxColumn.HeaderText = "id_pagamento";
            this.idpagamentoDataGridViewTextBoxColumn.Name = "idpagamentoDataGridViewTextBoxColumn";
            this.idpagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pagamentoDataGridViewTextBoxColumn
            // 
            this.pagamentoDataGridViewTextBoxColumn.DataPropertyName = "pagamento";
            this.pagamentoDataGridViewTextBoxColumn.HeaderText = "pagamento";
            this.pagamentoDataGridViewTextBoxColumn.Name = "pagamentoDataGridViewTextBoxColumn";
            this.pagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "funcionario";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            this.funcionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            this.idfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfuncionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 422);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRelatorio;
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
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private comandasDataSetTableAdapters.comandaTableAdapter comandaTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocomandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
    }
}