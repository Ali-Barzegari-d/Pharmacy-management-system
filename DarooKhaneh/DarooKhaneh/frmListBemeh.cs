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
    public partial class frmListBemeh : Form
    {
        public frmListBemeh()
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
            adp.SelectCommand.CommandText = "Select * from Bemeh";
            adp.Fill(ds, "Bemeh");
            dgvBemeh.DataSource = ds;
            dgvBemeh.DataMember = "Bemeh";
            //***************************
            dgvBemeh.Columns[0].HeaderText = "کد";
            dgvBemeh.Columns[1].HeaderText = "نام";
            dgvBemeh.Columns[2].HeaderText = "تعرفه";
            dgvBemeh.Columns[3].HeaderText = "توضیحات";
            dgvBemeh.Columns[3].Width = 150;
            dgvBemeh.Columns[1].Width = 150;
        }

        private void frmListBemeh_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptBemeh.mrt");
            Report.Compile();
            Report.ShowWithRibbonGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvBemeh.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Bemeh where Id=@N";
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
            adp.SelectCommand.CommandText = "Select * from Bemeh where NameB like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtName.Text + "%");
            adp.Fill(ds, "Bemeh");
            dgvBemeh.DataSource = ds;
            dgvBemeh.DataMember = "Bemeh";
        }
    }
}
