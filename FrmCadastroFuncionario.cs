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
    public partial class FrmCadastroFuncionario : Form
    {
        int rowIndex = -1;
        string sql = "";
        clnConexao conexao = new clnConexao();
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.fun_cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.fun_cargoTableAdapter.Fill(this.comandasDataSet.fun_cargo);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cargo'. Você pode movê-la ou removê-la conforme necessário.
            this.cargoTableAdapter.Fill(this.comandasDataSet.cargo);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.comandasDataSet.funcionario);
            TxtNome.Enabled = CbxCargo.Enabled = false;

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroCargo cargo = new FrmCadastroCargo();
            cargo.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                TxtNome.Text = DgvFuncionario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                CbxCargo.Text = "";
                CbxCargo.SelectedText = DgvFuncionario.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            }
        }

        private void BTAdicionar_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = CbxCargo.Enabled = true;
            TxtNome.Text = CbxCargo.Text = null;
            rowIndex = -1;
        }

        private void BTAlterar_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = CbxCargo.Enabled = true;
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            if ((TxtNome.Text != "") && (CbxCargo.Text != ""))
            {
                int result = 0;
                if (rowIndex < 0)//insert
                {
                    try
                    {
                      //  conexao.connection();
                        sql = @"SELECT * FROM FUNCIONARIO_INSERT('" + TxtNome.Text + "'," + CbxCargo.SelectedValue + ")";                        
                        if(conexao.funcoes(sql) == 1)
                        {
                            MessageBox.Show("Adicionado com Sucesso");
                            this.fun_cargoTableAdapter.Fill(this.comandasDataSet.fun_cargo);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao adicionar");
                        }
                        
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else//update
                {
                    try
                    {
                        conexao.connection();
                        int codigo = int.Parse(DgvFuncionario.Rows[rowIndex].Cells["id"].Value.ToString());
                        //var cargo = CbxCargo.SelectedValue;
                        sql = @"SELECT * FROM FUNCIONARIO_UPDATE(" + codigo + ",'"+TxtNome.Text+"',"+ CbxCargo.SelectedValue + ")";
                        //sql = @"UPDATE FUNCIONARIO SET NOME = '" + TxtNome.Text + "', ID_CARGO = " + CbxCargo.SelectedValue + " WHERE ID = " + codigo + "";
                        if (conexao.funcoes(sql) == 1)
                        {
                            MessageBox.Show("Alterado com Sucesso!");
                            this.fun_cargoTableAdapter.Fill(this.comandasDataSet.fun_cargo);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar!");
                        }

                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private void BTRemover_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.connection();
                int codigo = int.Parse(DgvFuncionario.Rows[rowIndex].Cells["id"].Value.ToString());
                sql = @"SELECT * FROM FUNCIONARIO_DELETE(" + codigo + ")";
                if (conexao.funcoes(sql) == 1)
                {
                    MessageBox.Show("Removido com Sucesso!");
                    this.fun_cargoTableAdapter.Fill(this.comandasDataSet.fun_cargo);
                }
                else
                {
                    MessageBox.Show("Falha ao Remover");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}
