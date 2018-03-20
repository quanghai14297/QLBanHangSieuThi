using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void line1_Click(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
