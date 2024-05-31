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
using Stimulsoft.Report;
namespace DarooKhaneh
{
    public partial class frmListDaroo : Form
    {
        public frmListDaroo()
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
            adp.SelectCommand.CommandText = "Select * from Daroo";
            adp.Fill(ds, "Daroo");
            dgvDaroo.DataSource = ds;
            dgvDaroo.DataMember = "Daroo";
            //***************************
            dgvDaroo.Columns[0].HeaderText = "کد";
            dgvDaroo.Columns[1].HeaderText = "نام گروه";
            dgvDaroo.Columns[2].HeaderText = "نام دارو";
            dgvDaroo.Columns[3].HeaderText = "شرکت/کشور";
            dgvDaroo.Columns[4].HeaderText = "تاریخ تولید";
            dgvDaroo.Columns[5].HeaderText = "تاریخ انقضاء";
            dgvDaroo.Columns[6].HeaderText = "تعداد";
            dgvDaroo.Columns[7].HeaderText = "قیمت خرید";
            dgvDaroo.Columns[8].HeaderText = "قیمت فروش";
            dgvDaroo.Columns[9].HeaderText = "توضیحات";
            dgvDaroo.Columns[0].Width = 80;
            dgvDaroo.Columns[2].Width = 120;
            dgvDaroo.Columns[9].Width = 150;
        }

        void DisplayEXP()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Daroo where EXP Between '" + mskEX1.Text + "' AND '" + mskEX2.Text + "'";
            adp.Fill(ds, "Daroo");
            dgvDaroo.DataSource = ds;
            dgvDaroo.DataMember = "Daroo";
            //***************************
            dgvDaroo.Columns[0].HeaderText = "کد";
            dgvDaroo.Columns[1].HeaderText = "نام گروه";
            dgvDaroo.Columns[2].HeaderText = "نام دارو";
            dgvDaroo.Columns[3].HeaderText = "شرکت/کشور";
            dgvDaroo.Columns[4].HeaderText = "تاریخ تولید";
            dgvDaroo.Columns[5].HeaderText = "تاریخ انقضاء";
            dgvDaroo.Columns[6].HeaderText = "تعداد";
            dgvDaroo.Columns[7].HeaderText = "قیمت خرید";
            dgvDaroo.Columns[8].HeaderText = "قیمت فروش";
            dgvDaroo.Columns[9].HeaderText = "توضیحات";
            dgvDaroo.Columns[0].Width = 80;
            dgvDaroo.Columns[2].Width = 120;
            dgvDaroo.Columns[9].Width = 150;
        }

        private void frmListDaroo_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            mskEX1.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskEX2.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");

            Display();
        }

        private void mskEX1_TextChanged(object sender, EventArgs e)
        {
            DisplayEXP();
        }

        private void mskEX2_TextChanged(object sender, EventArgs e)
        {
            DisplayEXP();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            DisplayEXP();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Daroo where NameD like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtName.Text + "%");
            adp.Fill(ds, "Daroo");
            dgvDaroo.DataSource = ds;
            dgvDaroo.DataMember = "Daroo";
        }

        private void txtNameG_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Daroo where NameG like '%' + @S + '%'";
            adp.SelectCommand.Parameters.AddWithValue("@S", txtNameG.Text + "%");
            adp.Fill(ds, "Daroo");
            dgvDaroo.DataSource = ds;
            dgvDaroo.DataMember = "Daroo";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvDaroo.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from daroo where id=@N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Display();
                MessageBox.Show("حذف دارو انجام شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptEXP.mrt");
            Report.Compile();
            Report["EXP1"] = mskEX1.Text;
            Report["EXP2"] = mskEX2.Text;
            Report.ShowWithRibbonGUI();
        }
    }
}
