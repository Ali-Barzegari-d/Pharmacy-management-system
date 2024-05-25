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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=Darookhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();

        private void frmCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Company(NameC,Tel,Address,Tozih)values(@a,@b,@c,@d)";
                cmd.Parameters.AddWithValue("@a", txtName.Text);
                cmd.Parameters.AddWithValue("@b", txtTel.Text);
                cmd.Parameters.AddWithValue("@c", txtAddress.Text);
                cmd.Parameters.AddWithValue("@d", txtTel.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ثبت انجام شد");
                //*******************************
                
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
                cmd.CommandText = "Delete from Company where id=" + txtCode.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("حذف انجام شد");
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
                cmd.CommandText = "Update Company set NameC='" + txtName.Text + "',Tel='" + txtTel.Text + "',Address='" + txtAddress.Text + "',Tozih='" + txtTozih.Text + "' where id=" + txtCode.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ویرایش انجام شد");
                //*******************************
                
            }
            catch (Exception)
            {
                MessageBox.Show("مشکلی پیش آمده است");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //new frmListCompany().ShowDialog();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "select * from Company where Id="+txtCode.Text;
            //cmd.Parameters.AddWithValue("@N", txtCode.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCode.Text = dr["id"].ToString();
                txtName.Text = dr["NameC"].ToString();
                txtTel.Text = dr["Tel"].ToString();
                txtAddress.Text = dr["Address"].ToString();
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
