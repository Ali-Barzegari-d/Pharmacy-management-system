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
    public partial class frmListCompany : Form
    {
        public frmListCompany()
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
            adp.SelectCommand.CommandText = "Select * from Company";
            adp.Fill(ds, "Company");
            dgvCompany.DataSource = ds;
            dgvCompany.DataMember = "Company";
            //***************************
            dgvCompany.Columns[0].HeaderText = "کد";
            dgvCompany.Columns[1].HeaderText = "نام";
            dgvCompany.Columns[2].HeaderText = "تلفن";
            dgvCompany.Columns[3].HeaderText = "آدرس";
            dgvCompany.Columns[4].HeaderText = "توضیحات";
            dgvCompany.Columns[4].Width = 150;
            dgvCompany.Columns[3].Width = 150;
            dgvCompany.Columns[1].Width = 150;
        }

        private void frmListCompany_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Company where Name Like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtName.Text + "%");
            adp.Fill(ds, "Company");
            dgvCompany.DataSource = ds;
            dgvCompany.DataMember = "Company";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvCompany.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Company where Id="+x;
                //cmd.Parameters.AddWithValue("@N", x);
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
