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
    public partial class frmListSandoog : Form
    {
        public frmListSandoog()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=Darookhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        void Display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Sandoog";
            adp.Fill(ds, "Sandoog");
            dgvSandoog.DataSource = ds;
            dgvSandoog.DataMember = "Sandoog";
            //***************************
            dgvSandoog.Columns[0].HeaderText = "کد";
            dgvSandoog.Columns[1].HeaderText = "نام صندوق";
            dgvSandoog.Columns[2].HeaderText = "موجودی";
            dgvSandoog.Columns[3].HeaderText = "توضیحات";
            dgvSandoog.Columns[1].Width = 150;
            dgvSandoog.Columns[2].Width = 150;
            dgvSandoog.Columns[3].Width = 300;
        }
        private void frmListSandoog_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Sandoog where NameS like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtName.Text + "%");
            adp.Fill(ds, "Sandoog");
            dgvSandoog.DataSource = ds;
            dgvSandoog.DataMember = "Sandoog";
        }

        private void txtShH_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Sandoog where Ids like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtShH.Text + "%");
            adp.Fill(ds, "Sandoog");
            dgvSandoog.DataSource = ds;
            dgvSandoog.DataMember = "Sandoog";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvSandoog.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Sandoog where IdS=@N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                MessageBox.Show("حذف انجام شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }
    }
}
