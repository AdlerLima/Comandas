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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTComandas_Click(object sender, EventArgs e)
        {
            FrmComandas comandas = new FrmComandas();
            comandas.Show();
        }

        private void BTCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario funcionario = new FrmCadastroFuncionario();
            funcionario.Show();
        }

        private void BTCadastroProduto_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto produto = new FrmCadastroProduto();
            produto.Show();
        }
    }
}
