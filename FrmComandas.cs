using SistemDeCaixa.comandasDataSetTableAdapters;
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
    public partial class FrmComandas : Form
    {
        int rowIndex = -1;
        string sql = "";
        clnConexao conexao = new clnConexao();
        public FrmComandas()
        {
            InitializeComponent();

        }

        private void FrmComandas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.v_comandas'. Você pode movê-la ou removê-la conforme necessário.
            this.v_comandasTableAdapter.Fill(this.comandasDataSet.v_comandas);
            CbxComandas.DataSource = carregaComandas();
            CbxComandas.DisplayMember = "Nome";
            txtValor.Enabled = false;
            valorTotal();
        }

        public ArrayList carregaComandas()
        {
            ArrayList num = new ArrayList();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            return num;
        }

        private void CbxComandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            v_comandasTableAdapter ta = new v_comandasTableAdapter();
            ta.SelectComanda(this.comandasDataSet.v_comandas,CbxComandas.SelectedValue);
            valorTotal();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void valorTotal()
        {
            sql = "SELECT SUM(P.prod_preco * C.quantidade) AS TOTAL " +
                "FROM comanda C LEFT OUTER JOIN " +
                "produto P ON C.id_produto = P.id " +
                "WHERE(C.situacao = 'A') AND(C.numero_comanda = "+CbxComandas.SelectedValue+") ";
            conexao.connection();
            txtValor.Text = conexao.teste(sql).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.Show();
            venda.carregaComanda(Convert.ToInt32(CbxComandas.SelectedValue));
            venda.carregarValor(Convert.ToDecimal(txtValor.Text));
           // this.v_comandasTableAdapter.Fill(this.comandasDataSet.v_comandas);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            v_comandasTableAdapter ta = new v_comandasTableAdapter();
            ta.SelectComanda(this.comandasDataSet.v_comandas, CbxComandas.SelectedValue);
            valorTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRelatorioVendas relatorio = new FrmRelatorioVendas();
            relatorio.Show();
        }
    }
}
