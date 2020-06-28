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
    public partial class FrmCadastroCidade : Form
    {
        public FrmCadastroCidade()
        {
            InitializeComponent();
        }

        private void CbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.comandasDataSet.cidade);

        }
    }
}
