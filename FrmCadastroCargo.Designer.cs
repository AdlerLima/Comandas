namespace SistemDeCaixa
{
    partial class FrmCadastroCargo
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
            this.BTSalvar = new System.Windows.Forms.Button();
            this.BTRemover = new System.Windows.Forms.Button();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.CbxCargo = new System.Windows.Forms.ComboBox();
            this.comandasDataSet = new SistemDeCaixa.comandasDataSet();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoTableAdapter = new SistemDeCaixa.comandasDataSetTableAdapters.cargoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(12, 61);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTSalvar.TabIndex = 0;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // BTRemover
            // 
            this.BTRemover.Location = new System.Drawing.Point(12, 133);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(75, 23);
            this.BTRemover.TabIndex = 1;
            this.BTRemover.Text = "Remover";
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(13, 28);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(156, 20);
            this.TxtCargo.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Cargo";
            // 
            // CbxCargo
            // 
            this.CbxCargo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comandasDataSet, "cargo.id", true));
            this.CbxCargo.DataSource = this.cargoBindingSource;
            this.CbxCargo.DisplayMember = "descricao";
            this.CbxCargo.FormattingEnabled = true;
            this.CbxCargo.Location = new System.Drawing.Point(13, 106);
            this.CbxCargo.Name = "CbxCargo";
            this.CbxCargo.Size = new System.Drawing.Size(156, 21);
            this.CbxCargo.TabIndex = 4;
            this.CbxCargo.ValueMember = "id";
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
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadastroCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 168);
            this.Controls.Add(this.CbxCargo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.BTRemover);
            this.Controls.Add(this.BTSalvar);
            this.Name = "FrmCadastroCargo";
            this.Text = "FrmCadastroCargo";
            this.Load += new System.EventHandler(this.FrmCadastroCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comandasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox CbxCargo;
        private comandasDataSet comandasDataSet;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private comandasDataSetTableAdapters.cargoTableAdapter cargoTableAdapter;
    }
}