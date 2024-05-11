using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DarooKhaneh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=DarooKhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        int step = 1;
        private void btnout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            cmd = new SqlCommand("select count(*) from Karbar where UName=@N AND Password=@F", con);
            cmd.Parameters.AddWithValue("@N", txtUname.Text);
            cmd.Parameters.AddWithValue("@F", txtPass.Text);
            con.Open();
            i = (int)cmd.ExecuteScalar();
            con.Close();
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
                    Application.Exit();
                }
                step++;
                MessageBox.Show("کاربری با این مشخصات وجود ندارد ");
            }
            
            
            
        }
    }
}
