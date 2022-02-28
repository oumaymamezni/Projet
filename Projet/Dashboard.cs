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
namespace Projet
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

       SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library;Integrated Security=True; ");


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from BookTbl", con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            Booklbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from StudentTbl", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Stdlbl.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from LibrarianTbl", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            Liblbl.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from ReturnTbl", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            Retlbl.Text = dt4.Rows[0][0].ToString();
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from IssueTbl", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            Isslbl.Text = dt5.Rows[0][0].ToString();

            con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
