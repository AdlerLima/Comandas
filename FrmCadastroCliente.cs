using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemDeCaixa
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cli_cid'. Você pode movê-la ou removê-la conforme necessário.
            this.cli_cidTableAdapter.Fill(this.comandasDataSet.cli_cid);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.comandasDataSet.cliente);

        }

        private void BTNovoCidade_Click(object sender, EventArgs e)
        {
            FrmCadastroCidade cidade = new FrmCadastroCidade();
            cidade.Show();
        }
    }
}
