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
    public partial class FrmVenda : Form
    {
        string sql = "";
        clnConexao conexao = new clnConexao();
        private DataTable dt;
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.pagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentoTableAdapter.Fill(this.comandasDataSet.pagamento);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.comandasDataSet.funcionario);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.comandasDataSet.cliente);
            carregaComanda(0);
            carregarValor(0);
            TxtComanda.Enabled = txtValor.Enabled = false;
           // txtValor.Text = txtValor.Text.Replace(",", ".");
        }
        public void carregaComanda(int comanda)
        {
            TxtComanda.Text = comanda.ToString();
        }
        public void carregarValor(decimal valor)
        {
            txtValor.Text = valor.ToString();
        }

        private void BTAdicionarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cliente = new FrmCadastroCliente();
            cliente.ShowDialog();
            this.clienteTableAdapter.Fill(this.comandasDataSet.cliente);
        }



        private void BTFinalizar_Click(object sender, EventArgs e)
        {
            

            string valor = txtValor.Text;
            valor = valor.Replace(",", ".");
            
            int pagamento = Convert.ToInt32(CbxPagamento.SelectedValue);
            int comanda = Convert.ToInt32(TxtComanda.Text);
            int cliente = Convert.ToInt32(CbxCliente.SelectedValue);
            int funcionario = Convert.ToInt32(CbxFuncionario.SelectedValue);
            conexao.connection();
            conexao.selectfinalizar(cliente);
            if (!string.IsNullOrEmpty(this.comandasDataSet.cliente.Rows[0]["CPF"].ToString()))
            {

                this.clienteTableAdapter.SelectCliente(this.comandasDataSet.cliente, cliente);
                var cpf = this.comandasDataSet.cliente.Rows[0]["CPF"].ToString();
                var rua = this.comandasDataSet.cliente.Rows[0]["RUA"].ToString();
                var bairro = this.comandasDataSet.cliente.Rows[0]["BAIRRO"].ToString();
                if (CbxPagamento.SelectedIndex == 3)
                {
                    if (cpf == "")
                    {
                        MessageBox.Show("Cadastro do cliente deve estar completo para gerar um boleto.");
                    }
                    else if (rua == "")
                    {
                        MessageBox.Show("Cadastro do cliente deve estar completo para gerar um boleto.");
                    }
                    else if (bairro == "")
                    {
                        MessageBox.Show("Cadastro do cliente deve estar completo para gerar um boleto.");
                    }
                    else
                    {
                        sql = @"SELECT * FROM VENDA_INSERT(" + valor + "," + pagamento + "," + comanda + "," + cliente + "," + funcionario + ")";
                        conexao.connection();
                        if (conexao.funcoes(sql) == 1)
                        {
                            sql = @"SELECT * FROM STATUS_UPDATE(" + comanda + ",'" + 'F' + "')";
                            conexao.connection();
                            if (conexao.funcoes(sql) == 1)
                            {
                                MessageBox.Show("Venda Finalizada com Sucesso!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falha ao registrar a venda");
                        }
                    }
                }
                else
                {
                    sql = @"SELECT * FROM VENDA_INSERT(" + valor + "," + pagamento + "," + comanda + "," + cliente + "," + funcionario + ")";
                    conexao.connection();
                    if (conexao.funcoes(sql) == 1)
                    {
                        sql = @"SELECT * FROM STATUS_UPDATE(" + comanda + ",'" + 'F' + "')";
                        conexao.connection();
                        if (conexao.funcoes(sql) == 1)
                        {
                            MessageBox.Show("Venda Finalizada com Sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao registrar a venda");
                    }
                }
            }


        }
    }
}
