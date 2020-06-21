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
            login.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
            
        }
    }
}
