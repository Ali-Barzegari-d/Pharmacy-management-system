using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Stimulsoft.Report;

namespace DarooKhaneh
{
    public partial class frmListPersenel : Form
    {
        public frmListPersenel()
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
            adp.SelectCommand.CommandText = "Select * from Persenel";
            adp.Fill(ds, "Persenel");
            dgvPersenel.DataSource = ds;
            dgvPersenel.DataMember = "Persenel";
            //***************************
            dgvPersenel.Columns[0].HeaderText = "کد";
            dgvPersenel.Columns[1].HeaderText = "نام";
            dgvPersenel.Columns[2].HeaderText = "تلفن";
            dgvPersenel.Columns[3].HeaderText = "سمت";
            dgvPersenel.Columns[4].HeaderText = "حقوق ماهانه";
            dgvPersenel.Columns[5].HeaderText = "تاریخ استخدام";
            dgvPersenel.Columns[6].HeaderText = "توضیحات";
            dgvPersenel.Columns[1].Width = 150;
        }
        private void frmListPersenel_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptPersenel.mrt");
            Report.Compile();
            Report.ShowWithRibbonGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvPersenel.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Persenel where Id=@N";
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Persenel where NameP like '%'+@S+'%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtName.Text + "%");
            adp.Fill(ds, "Persenel");
            dgvPersenel.DataSource = ds;
            dgvPersenel.DataMember = "Persenel";
        }

        private void txtPost_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Persenel where Post like '%'+@S+'%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtPost.Text + "%");
            adp.Fill(ds, "Persenel");
            dgvPersenel.DataSource = ds;
            dgvPersenel.DataMember = "Persenel";
        }
    }
}
