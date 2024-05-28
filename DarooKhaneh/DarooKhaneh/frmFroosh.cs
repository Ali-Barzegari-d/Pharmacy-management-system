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
    public partial class frmFroosh : Form
    {
        public frmFroosh()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=Darookhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();

        string NameDA;
        string Tel;
        string Address;
        private void frmFroosh_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            mskTarikh.Text = p.GetYear(DateTime.Now).ToString() + p.GetMonth(DateTime.Now).ToString("0#") + p.GetDayOfMonth(DateTime.Now).ToString("0#");

            SqlDataReader dr;
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "select * from Info";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NameDA = dr["NameD"].ToString();
                Tel = dr["Telefon"].ToString();
                Address = dr["Address"].ToString();
            }
            else
            {
                MessageBox.Show("برای کد وارد شده اطلاعاتی یافت نشد");
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTedad.Value > Convert.ToInt32(lblTedad.Text))
            {
                MessageBox.Show("تعداد موجودی انبار کمتر از تعداد مورد نظر برای فروش است");
                return;
            }
            if (txtKhadamat.Text == "" || txtTakhfif.Text == "")
            {
                MessageBox.Show("لطفا هزینه خدمات یا تخفیف را وارد کنید");
                return;
            }
            dgvFactor.Rows.Add(txtCode.Text, txtName.Text, txtTedad.Text, txtFroosh.Text);
            
            //***********************
            int JameDaroo = 0;
            int JameKol = 0;
            int GKol = 0;
            for (int i = 0; i < dgvFactor.Rows.Count; i++)
            {
                JameDaroo = JameDaroo + (Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvFactor.Rows[i].Cells[3].Value));
                txtJameDaroo.Text = JameDaroo.ToString();

                GKol = Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvFactor.Rows[i].Cells[3].Value);
                dgvFactor.Rows[i].Cells[4].Value = GKol;

                JameKol = (JameDaroo + Convert.ToInt32(txtKhadamat.Text)) - Convert.ToInt32(txtTakhfif.Text);
                txtJameKol.Text = JameKol.ToString();
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlDataReader dr;
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "select * from Daroo where Id=@N";
            cmd.Parameters.AddWithValue("@N", txtCode.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCode.Text = dr["id"].ToString();
                txtName.Text = dr["NameD"].ToString();
                txtTedad.Text = dr["Tedad"].ToString();
                lblTedad.Text = dr["Tedad"].ToString();
                txtFroosh.Text = dr["GFroosh"].ToString();
            }
            else
            {
                txtCode.Text = "";
                txtCode.Focus();
                MessageBox.Show("برای کد وارد شده اطلاعاتی یافت نشد");
            }
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int JameDaroo = 0;
            int JameDaroo2 = 0;
            int jameKol = 0;
            JameDaroo = Convert.ToInt32(dgvFactor.CurrentRow.Cells[4].Value);
            JameDaroo2 = Convert.ToInt32(txtJameDaroo.Text) - JameDaroo;
            txtJameDaroo.Text = JameDaroo2.ToString();
            jameKol = Convert.ToInt32(txtJameKol.Text) - JameDaroo;
            txtJameKol.Text = jameKol.ToString();
            dgvFactor.Rows.RemoveAt(dgvFactor.CurrentRow.Index);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int JameKol = 0;
            JameKol = (Convert.ToInt32(txtJameDaroo.Text) + Convert.ToInt32(txtKhadamat.Text)) - Convert.ToInt32(txtTakhfif.Text);
            txtJameKol.Text = JameKol.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdFactor.Text == "")
                {
                    MessageBox.Show(" لطفا شماره فاکتور را وارد کنید");
                    return;
                }
                StiReport Report = new StiReport();
                Report.Load("Report/rptFroosh.mrt");
                Report.Compile();
                Report["CodeFactor"] = Convert.ToInt32(txtIdFactor.Text);
                Report["strNameDA"] = NameDA;
                Report["strTel"] = Tel;
                Report["strAddress"] = Address;
                Report.ShowWithRibbonGUI();
            }
            catch (Exception)
            {
                MessageBox.Show(" مشکلی پیش آمده است");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdFactor.Text == "")
                {
                    MessageBox.Show("کد فاکتور وارد نشده است");
                    txtIdFactor.Focus();
                    return;
                }
                //******************
                con.Close();
                SqlDataReader dr;
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "select CodeFactor from Froosh where CodeFactor=@N";
                cmd.Parameters.AddWithValue("@N", txtIdFactor.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIdFactor.Text = "";
                    txtIdFactor.Focus();
                    MessageBox.Show("این کد فاکتور قبلا ثبت شده است");
                    con.Close();
                    return;
                }
                con.Close();
                //**************************
                for (int i = 0; i < dgvFactor.Rows.Count; i++)
                {
                    con.Close();
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    cmd.CommandText = "insert into Froosh (CodeFactor,Tarikh,NameM,Tel,Address,id,NameD,Tedad,GFroosh,GKolFroosh,GKolDaroo,Khadamat,Takhfif,JameKol,Tozih)values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o)";
                    cmd.Parameters.AddWithValue("@a", txtIdFactor.Text);
                    cmd.Parameters.AddWithValue("@b", mskTarikh.Text);
                    cmd.Parameters.AddWithValue("@c", txtNameM.Text);
                    cmd.Parameters.AddWithValue("@d", txtTel.Text);
                    cmd.Parameters.AddWithValue("@e", txtAddress.Text);

                    cmd.Parameters.AddWithValue("@f", Convert.ToInt32(dgvFactor.Rows[i].Cells[0].Value));
                    cmd.Parameters.AddWithValue("@g", dgvFactor.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@h", Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value));
                    cmd.Parameters.AddWithValue("@i", Convert.ToInt32(dgvFactor.Rows[i].Cells[3].Value));
                    cmd.Parameters.AddWithValue("@j", Convert.ToInt32(dgvFactor.Rows[i].Cells[4].Value));

                    cmd.Parameters.AddWithValue("@k", txtJameDaroo.Text);
                    cmd.Parameters.AddWithValue("@l", txtKhadamat.Text);
                    cmd.Parameters.AddWithValue("@m", txtTakhfif.Text);
                    cmd.Parameters.AddWithValue("@n", txtJameKol.Text);
                    cmd.Parameters.AddWithValue("@o", txtTozih.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    //************************کاهش موجودی داروها
                    string str;
                    int str1;
                    SqlCommand sqlcmd = new SqlCommand("select Tedad from Daroo where id='" + Convert.ToInt32(dgvFactor.Rows[i].Cells[0].Value) + "'", con);
                    str = Convert.ToString((int)sqlcmd.ExecuteScalar());//موجودی دارو
                    str1 = Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value);//تعداد فروش
                    int sum = Int32.Parse(str) - str1;//تعداد نهایی دارو
                    //**********************************ویرایش موجودی دارو
                    string UpdateTedad = "Update Daroo set Tedad='" + sum + "' where id='" + Convert.ToInt32(dgvFactor.Rows[i].Cells[0].Value) + "'";
                    SqlCommand com = new SqlCommand(UpdateTedad, con);
                    com.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ثبت با موفقیت انجام شد");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            new frmListFroosh().ShowDialog();
        }

        private void btnNagd_Click(object sender, EventArgs e)
        {
            con.Close();
            if (txtShH.Text == "")
            {
                MessageBox.Show("لطفا شماره حساب را وارد کنید");
                return;
            }
            string str;
            int str1;
            con.Open();
            SqlCommand sqlcmd = new SqlCommand("select Mablagh from hesab where ShH='" + txtShH.Text + "'", con);
            str = Convert.ToString((int)sqlcmd.ExecuteScalar());//مبلغ حساب
            str1 = Convert.ToInt32(txtJameKol.Text);//مبلغ فاکتور
            int sum = Int32.Parse(str) + str1;//مبلغ نهایی حساب
            //**********************************ویرایش موجودی حساب
            string UpdateMablagh = "Update Hesab set Mablagh='" + sum + "' where ShH='" + txtShH.Text + "'";
            SqlCommand com = new SqlCommand(UpdateMablagh, con);
            com.ExecuteNonQuery();

            MessageBox.Show(" مبلغ به حساب واریز شد");
            con.Close();
        }

        private void btnCheckD_Click(object sender, EventArgs e)
        {
            frmCheckD frm = new frmCheckD();
            frm.txtTozih.Text = "دریافت مبلغ فاکتور فروش به صورت چک به شماره فاکتور" + txtIdFactor.Text;
            frm.txtNameM.Text = txtNameM.Text;
            frm.txtMablagh.Text = txtJameKol.Text;
            frm.ShowDialog();
        }
    }
}
