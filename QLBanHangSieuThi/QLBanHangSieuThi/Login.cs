using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanHangSieuThi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btminimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string user = tfuser.Text.ToLower();
            string pass = tfpass.Text.ToLower();
            if(cn.ktlogin(user,"Select * from USERS",0)==true && cn.ktlogin(pass,"Select * from USERS",1)==true)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
                
            }
            
        }
    }
}
