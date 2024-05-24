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
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=DarooKhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            cmd.Connection = con;
            cmd.CommandText = "Select * from Info where id=" + txtCode.Text;
            //cmd.Parameters.AddWithValue("@N", txtCode.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCode.Text = dr["Id"].ToString();
                txtName.Text = dr["NameD"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtModir.Text = dr["Modir"].ToString();
            }
            else
            {
                txtCode.Text = "";
                txtCode.Focus();
                MessageBox.Show("برای کد وارد شده اطلاعاتی پیدا نشد");
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "insert into Info(NameD,Telefon,Modir,Address)values(@a,@b,@c,@d)";
            cmd.Parameters.AddWithValue("@a", txtName.Text);
            cmd.Parameters.AddWithValue("@b", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@c", txtModir.Text);
            cmd.Parameters.AddWithValue("@d", txtAddress.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("اطلاعات با موفقعبت ثبت شد");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Info where Id="+txtCode.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("اطلاعات با موفقعبت حذف شد");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Update Info Set NameD'"+txtName.Text+ "',Telefon'" + txtTelefon.Text + "',Modir'" + txtModir.Text + "',Address'" + txtAddress.Text + "'where Id="+txtCode.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("اطلاعات با موفقعبت ویرایش شد");
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
