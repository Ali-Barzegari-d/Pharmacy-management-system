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
    public partial class frmKambod : Form
    {
        public frmKambod()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data source=(local);initial catalog=Darookhaneh;integrated security=true");
        SqlCommand cmd = new SqlCommand();

        void DisplayTedad()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Daroo where Tedad Between '" + txtTedad1.Text + "' AND '" + txtTedad1.Text + "'";
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

        void Display0()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "Select * from Daroo where Tedad ='" + 0 + "'";
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

        private void frmKambod_Load(object sender, EventArgs e)
        {
            Display0();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Display0();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DisplayTedad();
        }
    }
}
