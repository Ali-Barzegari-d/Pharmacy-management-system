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
namespace DarooKhaneh
{
    public partial class frmDaroo : Form
    {
        public frmDaroo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=Darookhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();

        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        private void frmDaroo_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select NameG from Grooh", con);
            da.Fill(dt);
            bs.DataSource = dt;
            cmbGrooh.DataSource = bs;
            cmbGrooh.DisplayMember = "NameG";

            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            mskEX.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
            mskTarikh.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into Daroo (NameG,NameD,Company,Tarikh,EXP,Tedad,GKharid,GFroosh,Tozih)values(@a,@b,@c,@d,@e,@f,@g,@h,@i)";
                cmd.Parameters.AddWithValue("@a", cmbGrooh.Text);
                cmd.Parameters.AddWithValue("@b", txtName.Text);
                cmd.Parameters.AddWithValue("@c", txtCompany.Text);
                cmd.Parameters.AddWithValue("@d", mskTarikh.Text);
                cmd.Parameters.AddWithValue("@e", mskEX.Text);
                cmd.Parameters.AddWithValue("@f", txtTedad.Text);
                cmd.Parameters.AddWithValue("@g", txtGKharid.Text);
                cmd.Parameters.AddWithValue("@h", txtGfroosh.Text);
                cmd.Parameters.AddWithValue("@i", txtTozih.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("دارو ثبت شد");
                //****************************
                
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Delete from Daroo where id=" + txtCode.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("دارو حذف شد");
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Update Daroo set NameG='" + cmbGrooh.Text + "',NameD='" + txtName.Text + "',Company='" + txtCompany.Text + "',Tarikh='" + mskTarikh.Text + "',EXP='" + mskEX.Text + "',Tedad='" + txtTedad.Text + "',GKharid='" + txtGKharid.Text + "',GFroosh='" + txtGfroosh.Text + "',Tozih='" + txtTozih.Text + "' where id=" + txtCode.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("دارو ویرایش شد");
                //****************************
                
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //new frmListDaroo().ShowDialog();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "select * from Daroo where Id=" + txtCode.Text;
            //cmd.Parameters.AddWithValue("@N", txtCode.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCode.Text = dr["id"].ToString();
                cmbGrooh.Text = dr["NameG"].ToString();
                txtName.Text = dr["NameD"].ToString();
                txtCompany.Text = dr["Company"].ToString();
                mskTarikh.Text = dr["Tarikh"].ToString();
                mskEX.Text = dr["EXP"].ToString();
                txtTedad.Text = dr["Tedad"].ToString();
                txtGKharid.Text = dr["GKharid"].ToString();
                txtGfroosh.Text = dr["GFroosh"].ToString();
                txtTozih.Text = dr["Tozih"].ToString();
            }
            else
            {
                txtCode.Text = "";
                txtCode.Focus();
                MessageBox.Show("برای کد وارد شده اطلاعاتی یافت نشد");
            }
            con.Close();
        }
    }
}
