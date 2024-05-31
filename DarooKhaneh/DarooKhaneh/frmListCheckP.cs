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
    public partial class frmListCheckP : Form
    {
        public frmListCheckP()
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
            adp.SelectCommand.CommandText = "Select * from CheckP where SarResid between '" + mskSarResid1.Text + "' AND '" + mskSarResid2.Text + "'";
            adp.Fill(ds, "CheckP");
            dgvCheckP.DataSource = ds;
            dgvCheckP.DataMember = "CheckP";
            //***************************
            dgvCheckP.Columns[0].HeaderText = "سریال چک";
            dgvCheckP.Columns[1].HeaderText = "شماره حساب";
            dgvCheckP.Columns[2].HeaderText = "نام حساب";
            dgvCheckP.Columns[3].HeaderText = "نام شخص";
            dgvCheckP.Columns[4].HeaderText = "مبلغ چک";
            dgvCheckP.Columns[5].HeaderText = "تاریخ صدور";
            dgvCheckP.Columns[6].HeaderText = "سررسید";
            dgvCheckP.Columns[7].HeaderText = "وضعیت";
            dgvCheckP.Columns[8].HeaderText = "توضیحات";
            dgvCheckP.Columns[3].Width = 150;
            dgvCheckP.Columns[4].Width = 150;
        }

        private void frmListCheckP_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            mskSarResid1.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskSarResid2.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dgvCheckP.SelectedCells[0].Value);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from CheckP where IdS="+x;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report.Load("Report/rptCheckP.mrt");
            Report.Compile();
            Report["SarResid1"] = mskSarResid1.Text;
            Report["SarResid2"] = mskSarResid2.Text;
            Report.ShowWithRibbonGUI();
        }

        private void btnVosol_Click(object sender, EventArgs e)
        {
            string str;
            int str1;
            con.Open();
            SqlCommand sqlcmd = new SqlCommand("select Mablagh from hesab where ShH='" + Convert.ToInt32(dgvCheckP.SelectedCells[1].Value) + "'", con);
            str = Convert.ToString((int)sqlcmd.ExecuteScalar());//مبلغ حساب
            str1 = Convert.ToInt32(dgvCheckP.SelectedCells[4].Value);//مبلغ چک
            if (str1 > Convert.ToInt32(str))
            {
                MessageBox.Show("موجودی حساب کمتر از مبلغ چک است.موجودی کافی نمی باشد");
            }
            else
            {
                int sum = Int32.Parse(str) - str1;//مبلغ نهایی حساب
                                                  //**********************************ویرایش موجودی حساب
                string UpdateMablagh = "Update Hesab set Mablagh='" + sum + "' where ShH='" + Convert.ToInt32(dgvCheckP.SelectedCells[1].Value) + "'";
                SqlCommand com = new SqlCommand(UpdateMablagh, con);
                com.ExecuteNonQuery();
                //**********************************ویرایش وضعیت چک
                string UpdateVaziyat = "Update CheckP set Vaziyat='" + "وصول شده" + "' where ids='" + Convert.ToInt32(dgvCheckP.SelectedCells[0].Value) + "'";
                SqlCommand cmd = new SqlCommand(UpdateVaziyat, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("وصول چک انجام شد و مبلغ از حساب کسر شد");
            }
            con.Close();
            Display();
        }

        private void mskSarResid1_TextChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void mskSarResid2_TextChanged(object sender, EventArgs e)
        {
            Display();
        }
    }
}
