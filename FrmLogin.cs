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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            if (TxtUsuario.Text.ToUpper() == "ADMIN")
            {
                if (TxtSenha.Text == "admin")
                {
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                    
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha incorretos");
                }
            }
            else
            {
                MessageBox.Show("Usuario ou Senha incorretos");
            }
                       
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtSenha.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Dispose();
            login.Close();
            login.Hide();
            login.Visible = false;
        }
    }
}
