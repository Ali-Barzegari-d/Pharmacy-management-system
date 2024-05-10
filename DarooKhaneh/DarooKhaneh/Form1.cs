using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DarooKhaneh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void __Click(object sender, EventArgs e)
        {

        }

        private void btnUser_ItemClick(object sender, EventArgs e)
        {
            new frmUser().ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_ItemClick(object sender, EventArgs e)
        {
            new frmInfo().ShowDialog();
        }
    }
}
