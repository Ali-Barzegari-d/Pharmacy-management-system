using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarooKhaneh
{
    public partial class frmLModir : Form
    {
        public frmLModir()
        {
            InitializeComponent();
        }
        int step = 1;
        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtPass.Text == "1234" && txtUname.Text == "Modir") i = 5;
            
            if (i > 0)
            {
                step = 1;
                new Form1().ShowDialog();
                this.Close();
            }
            else
            {
                if (step > 3)
                {
                    new Form1().ShowDialog();
                }
                step++;
                MessageBox.Show("کاربری با این مشخصات وجود ندارد ");
            }
        }
    }
}
