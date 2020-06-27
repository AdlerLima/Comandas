using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistemDeCaixa
{
    public partial class FrmCadastroCategoria : Form
    {
        string sql;
        private NpgsqlCommand cmd;

        clnConexao conexao = new clnConexao();
        public FrmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (TxtDescricao.Text != "")
            {
                int result = 0;
                    try
                    {
                        sql = @"SELECT * FROM CATEGORIA_INSERT( '" + TxtDescricao.Text + "')";
                        conexao.funcoes(sql);
                        //cmd = new NpgsqlCommand(sql, conn);
                        if (result == 0)
                        {
                            MessageBox.Show("Adicionado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao adicionar");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                }
            }

        private void FrmCadastroCategoria_Load(object sender, EventArgs e)
        {
            conexao.connection();
        }

        private void FrmCadastroCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexao.closeconnection();
        }
    }
}
