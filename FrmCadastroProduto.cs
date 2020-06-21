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
    public partial class FrmCadastroProduto : Form
    {
        int rowIndex = -1;
        //public NpgsqlConnection conexao = new NpgsqlConnection();
        private NpgsqlConnection conn;
        private string sql;
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string connstring = String.Format("username = postgres; password = postgres; host = localhost; Port = 5432; Database = Comandas");

        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            TxtNome.Text = TxtValor.Text = null;
            TxtNome.Enabled = TxtValor.Enabled = false;
            conn = new NpgsqlConnection(connstring);
            Select();

        }

        private void dvgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                TxtNome.Text = dvgData.Rows[e.RowIndex].Cells["prod_nome"].Value.ToString();
                TxtValor.Text = dvgData.Rows[e.RowIndex].Cells["prod_preco"].Value.ToString();
            }
        }
        private void Select()
        {
            conn.Open();
            sql = @"SELECT * FROM PRODUTO";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dvgData.DataSource = null;
            dvgData.DataSource = dt;
        }
        private void Delete()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM PROD_DELETE(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dvgData.Rows[rowIndex].Cells["id"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Removido com sucesso!");
                    rowIndex = -1;
                    conn.Close();
                    Select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTRemover_Click(object sender, EventArgs e)
        {
            Delete();
            // Select();
        }

        private void BTAdicionar_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = TxtValor.Enabled = true;
            TxtNome.Text = "";
            TxtValor.Text = "";
            rowIndex = -1;
        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            if ((TxtNome.Text != "") && (TxtValor.Text != ""))
            {
                int result = 0;
                if (rowIndex < 0) //insert
                {
                    try
                    {
                        conn.Open();
                        sql = @"SELECT * FROM PROD_INSERT( '" + TxtNome.Text + "' , " + TxtValor.Text + ")";
                        cmd = new NpgsqlCommand(sql, conn);
                        //cmd.Parameters.AddWithValue("descricao", TxtNome.Text); ;
                        //cmd.Parameters.AddWithValue("valor", TxtValor.Text);
                        result = (int)cmd.ExecuteScalar();
                        conn.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Adicionado com sucesso!");
                            TxtNome.Enabled = TxtValor.Enabled = false;
                            Select();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao adicionar");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        conn.Close();
                    }

                }
                else// update
                {
                    try
                    {
                        conn.Open();
                        int codigo = int.Parse(dvgData.Rows[rowIndex].Cells["id"].Value.ToString());
                        string descricao = TxtNome.Text;
                        string x = TxtValor.Text;
                        if (x.Contains(","))
                        {
                            x = x.Replace(",", ".");
                        }
                        //decimal valor = decimal.Parse(x);
                        sql = @"SELECT * FROM PROD_UPDATE(" + codigo + ",'" + descricao + "'," + x + ")";
                        cmd = new NpgsqlCommand(sql, conn);
                        result = (int)cmd.ExecuteScalar();
                        conn.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Alterado com sucesso!");
                            TxtNome.Enabled = TxtValor.Enabled = false;
                            Select();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao alterar");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha ao alterar, Erro: " + ex.Message);
                        conn.Close();
                    }
                    result = 0;
                }
            }
        }
    
        private void BTAlterar_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = TxtValor.Enabled = true;
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
