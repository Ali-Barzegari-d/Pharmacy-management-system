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
    public partial class frmListHesab : Form
    {
        public frmListHesab()
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
            adp.SelectCommand.CommandText = "Select * from Hesab";
            adp.Fill(ds, "Hesab");
            dgvHesab.DataSource = ds;
            dgvHesab.DataMember = "Hesab";
            //***************************
            dgvHesab.Columns[0].HeaderText = "کد";
            dgvHesab.Columns[1].HeaderText = "نام حساب";
            dgvHesab.Columns[2].HeaderText = "شماره حساب";
            dgvHesab.Columns[3].HeaderText = "موجودی";
            dgvHesab.Columns[4].HeaderText = "توضیحات";
            dgvHesab.Columns[1].Width = 150;
            dgvHesab.Columns[2].Width = 150;
            dgvHesab.Columns[4].Width = 200;
        }

        private void frmListHesab_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptHesab.mrt");
            Report.Compile();
            Report.ShowWithRibbonGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvHesab.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Hesab where Id=@N";
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
            adp.SelectCommand.CommandText = "Select * from Hesab where NameH like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtName.Text + "%");
            adp.Fill(ds, "Hesab");
            dgvHesab.DataSource = ds;
            dgvHesab.DataMember = "Hesab";
        }

        private void txtShH_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Hesab where ShH like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtShH.Text + "%");
            adp.Fill(ds, "Hesab");
            dgvHesab.DataSource = ds;
            dgvHesab.DataMember = "Hesab";
        }
    }
}
