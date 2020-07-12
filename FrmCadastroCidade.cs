using System;
using System.Collections;
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
        clnConexao conexao = new clnConexao();
        string sql = "";
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
            CbxUF.DataSource = Carregaestados();
            CbxUF.DisplayMember = "Nome";
            conexao.connection();
            
        }
        public ArrayList Carregaestados()
        {
            ArrayList uf = new ArrayList();
            uf.Add("SC");
            uf.Add("RS");
            uf.Add("PR");
            uf.Add("SP");
            uf.Add("RJ");
            return uf;
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                sql = @"SELECT * FROM CIDADE_INSERT('" + TxtCidade.Text + "','" + CbxUF.Text + "')";
                if (conexao.funcoes(sql) == 1)
                {
                    MessageBox.Show("Adicionado com Sucesso!");
                    this.cidadeTableAdapter.Fill(this.comandasDataSet.cidade);
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private void BTRemover_Click(object sender, EventArgs e)
        {
            try
            {
                var id = CbxCidade.SelectedValue;
                sql = "SELECT * FROM CIDADE_DELETE(" + id + ")";
                if (conexao.funcoes(sql) == 1)
                {
                    MessageBox.Show("Sucesso na exclusão!");
                    this.cidadeTableAdapter.Fill(this.comandasDataSet.cidade);
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir, verifique se a cidade esta vinculada a um cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
