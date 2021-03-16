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
    public partial class FrmRelatorioVendas : Form
    {
        public FrmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.relatorio_vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.relatorio_vendasTableAdapter.Fill(this.comandasDataSet.relatorio_vendas);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.comanda'. Você pode movê-la ou removê-la conforme necessário.
            this.comandaTableAdapter.Fill(this.comandasDataSet.comanda);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.comandasDataSet.funcionario);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.pagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentoTableAdapter.Fill(this.comandasDataSet.pagamento);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.comandasDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'comandasDataSet.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.comandasDataSet.venda);
            //CbxComanda.DataSource = carregaComandas();
            //CbxComanda.DisplayMember = "Nome";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comandasDataSet.relatorio_vendasDataTable dtRelatorio = new comandasDataSet.relatorio_vendasDataTable();
           // DgvRelatorio.DataSource =  this.relatorio_vendasTableAdapter.FiltroRelatorio(dtRelatorio, CbxComanda.SelectedValue);
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
    }
}
