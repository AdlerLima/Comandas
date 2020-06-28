namespace SistemDeCaixa
{
    partial class FrmMenu
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
            this.BTCadastroProduto = new System.Windows.Forms.Button();
            this.BTCadastroFuncionario = new System.Windows.Forms.Button();
            this.BTComandas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTCadastroProduto
            // 
            this.BTCadastroProduto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTCadastroProduto.Image = global::SistemDeCaixa.Properties.Resources.cadastro2;
            this.BTCadastroProduto.Location = new System.Drawing.Point(6, 23);
            this.BTCadastroProduto.Name = "BTCadastroProduto";
            this.BTCadastroProduto.Size = new System.Drawing.Size(109, 81);
            this.BTCadastroProduto.TabIndex = 2;
            this.BTCadastroProduto.UseVisualStyleBackColor = false;
            this.BTCadastroProduto.Click += new System.EventHandler(this.BTCadastroProduto_Click);
            // 
            // BTCadastroFuncionario
            // 
            this.BTCadastroFuncionario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTCadastroFuncionario.Image = global::SistemDeCaixa.Properties.Resources.cadastro1;
            this.BTCadastroFuncionario.Location = new System.Drawing.Point(6, 23);
            this.BTCadastroFuncionario.Name = "BTCadastroFuncionario";
            this.BTCadastroFuncionario.Size = new System.Drawing.Size(109, 81);
            this.BTCadastroFuncionario.TabIndex = 1;
            this.BTCadastroFuncionario.UseVisualStyleBackColor = false;
            this.BTCadastroFuncionario.Click += new System.EventHandler(this.BTCadastroFuncionario_Click);
            // 
            // BTComandas
            // 
            this.BTComandas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTComandas.Image = global::SistemDeCaixa.Properties.Resources.purchaseorderapplication_compra_orde_4474;
            this.BTComandas.Location = new System.Drawing.Point(6, 23);
            this.BTComandas.Name = "BTComandas";
            this.BTComandas.Size = new System.Drawing.Size(109, 81);
            this.BTComandas.TabIndex = 0;
            this.BTComandas.Text = " ";
            this.BTComandas.UseVisualStyleBackColor = false;
            this.BTComandas.Click += new System.EventHandler(this.BTComandas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTComandas);
            this.groupBox1.Location = new System.Drawing.Point(25, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTCadastroFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(191, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro de Funcionario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTCadastroProduto);
            this.groupBox3.Location = new System.Drawing.Point(360, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro de Produtos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTComandas;
        private System.Windows.Forms.Button BTCadastroFuncionario;
        private System.Windows.Forms.Button BTCadastroProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}