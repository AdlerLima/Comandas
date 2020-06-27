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
    public partial class FrmCadastroCargo : Form
    {
        clnConexao conexao = new clnConexao();
        string sql = "";
        public FrmCadastroCargo()
        {
            InitializeComponent();
            conexao.connection();
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM CARGO_INSERT('" + TxtCargo.Text + "')";
                if (conexao.funcoes(sql) == 1)
                {
                    MessageBox.Show("Adicionado com Sucesso!");
                    this.cargoTableAdapter.Fill(this.comandasDataSet.cargo);
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar");
                }
            }catch(Exception ex)
            { MessageBox.Show("Falha: " + ex.Message); }
        }

        private void BTRemover_Click(object sender, EventArgs e)
        {
            //cmd.Parameters.AddWithValue("_id", int.Parse(dvgData.Rows[rowIndex].Cells["idDataGridViewTextBoxColumn"].Value.ToString()));
            var id = CbxCargo.SelectedValue;
            sql = "SELECT * FROM CARGO_DELETE(" + id + ")";
            conexao.funcoes(sql);
        }

        private void FrmCadastroCargo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.comandasDataSet.cargo);

        }
    }
}
