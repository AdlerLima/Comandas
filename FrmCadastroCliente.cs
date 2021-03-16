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
        clnConexao conexao = new clnConexao();
        string sql = "";
        int rowIndex = -1;
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
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.comandasDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cli_cid'. Você pode movê-la ou removê-la conforme necessário.
            this.cli_cidTableAdapter.Fill(this.comandasDataSet.cli_cid);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.comandasDataSet.cliente);
            TxtNome.Enabled = TxtBairro.Enabled = TxtCidade.Enabled = TxtNumero.Enabled = TxtRua.Enabled = mskDataNascimento.Enabled = MskCPF.Enabled = CbxCidade.Enabled = false;

        }

        private void BTNovoCidade_Click(object sender, EventArgs e)
        {
            FrmCadastroCidade cidade = new FrmCadastroCidade();
            cidade.Show();
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1) //Adicionar
            {
                if (TxtNome.Text != "")
                {
                    try
                    {
                        conexao.connection();
                        sql = @"SELECT * FROM CLIENTE_INSERT('" + TxtNome.Text + "'," + CbxCidade.SelectedValue
                            + ",'" + MskCPF.Text + "','" + mskDataNascimento.Text + "','" + TxtRua.Text + "',"
                            + TxtNumero.Text + ",'" + TxtBairro.Text + "')";
                        if (conexao.funcoes(sql) == 1)
                        {
                            MessageBox.Show("Cliente adicionado com sucesso!");
                            
                            TxtNome.Text =
                            TxtBairro.Text =
                            TxtNumero.Text =
                            TxtRua.Text =
                            MskCPF.Text =
                            mskDataNascimento.Text = "";
                            this.cli_cidTableAdapter.Fill(this.comandasDataSet.cli_cid);
                            conexao.closeconnection();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao adicionar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CPF Ja cadastrado no Sistema!");
                    }
                }
            }
            else if(rowIndex >= 0)
            {
                try
                {
                    conexao.connection();
                    int codigo = int.Parse(dtvClientes.Rows[rowIndex].Cells["id"].Value.ToString());
                    string cpf = MskCPF.Text;
                   // var id = CbxCidade.SelectedValue;
                    cpf = cpf.Replace(",", ".");
                    sql = "SELECT * FROM CLIENTE_UPDATE(" + codigo
                                + ",'" + TxtNome.Text + "'," + CbxCidade.SelectedValue
                                + ",'" + cpf + "','" + mskDataNascimento.Text
                                + "','" + TxtRua.Text + "',"
                                + TxtNumero.Text + ",'" + TxtBairro.Text + "')";
                    
                    if (conexao.funcoes(sql) == 1)
                    {
                        MessageBox.Show("Alterado com Sucesso!");
                        this.cli_cidTableAdapter.Fill(this.comandasDataSet.cli_cid);
                        conexao.closeconnection();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
        }

        private void dtvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                CbxCidade.Text = "";
                TxtNome.Text = dtvClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                CbxCidade.SelectedText = dtvClientes.Rows[e.RowIndex].Cells["NomeCidade"].Value.ToString();
                TxtCidade.Text = dtvClientes.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                TxtBairro.Text = dtvClientes.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                TxtNumero.Text = dtvClientes.Rows[e.RowIndex].Cells["numero"].Value.ToString();
                TxtRua.Text = dtvClientes.Rows[e.RowIndex].Cells["rua"].Value.ToString();
                MskCPF.Text = dtvClientes.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                mskDataNascimento.Text = dtvClientes.Rows[e.RowIndex].Cells["nascimento"].Value.ToString();
            }
        }

        private void BTRemover_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.connection();
                int codigo = int.Parse(dtvClientes.Rows[rowIndex].Cells["id"].Value.ToString());
                sql = @"SELECT * FROM CLIENTE_DELETE(" + codigo + ")";
                if (conexao.funcoes(sql) == 1)
                {
                    MessageBox.Show("Removido com Sucesso!");
                    this.cli_cidTableAdapter.Fill(this.comandasDataSet.cli_cid);
                }
                else
                {
                    MessageBox.Show("Falha ao Remover");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BTAdicionar_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            TxtNome.Enabled = TxtBairro.Enabled = TxtCidade.Enabled = TxtNumero.Enabled = TxtRua.Enabled = mskDataNascimento.Enabled = MskCPF.Enabled = CbxCidade.Enabled = true;
            TxtNome.Text = TxtBairro.Text = TxtCidade.Text = TxtNumero.Text = TxtRua.Text =mskDataNascimento.Text = MskCPF.Text ="";
            CbxCidade.SelectedIndex = 0;
        }
    }
}
