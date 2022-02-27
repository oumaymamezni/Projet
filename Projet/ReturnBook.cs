using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library;Integrated Security=True; ");
        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
        private void FillBook()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty>" + 0 + "", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            cbBook.ValueMember = "BookName";
            cbBook.DataSource = dt;
            con.Close();
        }
        private void populate()
        {
            //con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBookIssue.DataSource = ds.Tables[0];
            con.Close();
        }

        private void populateReturn()
        {
            //con.Open();
            string query = "select * from ReturnTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBookReturn.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            populate();
            populateReturn();
            FillBook();
        }

        private void dgvBookIssue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtNum.Text = dgvBookIssue.SelectedRows[0].Cells[0].Value.ToString();
            cbStudent.Text = dgvBookIssue.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dgvBookIssue.SelectedRows[0].Cells[2].Value.ToString();
            txtDepartment.Text = dgvBookIssue.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = dgvBookIssue.SelectedRows[0].Cells[4].Value.ToString();
            cbBook.Text = dgvBookIssue.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void updateBook()
        {
            int Qty, newQty;
            con.Open();
            string query = "select * from BookTbl where BookName='" + cbBook.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty=" + newQty + " where BookName='" + cbBook.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ReturntxtNum.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string DateIssue = dateIssue.Value.Day.ToString() + "/" + dateIssue.Value.Month.ToString() + "/" + dateIssue.Value.Year.ToString();
                string DateReturn = dateReturn.Value.Day.ToString() + "/" + dateIssue.Value.Month.ToString() + "/" + dateIssue.Value.Year.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ReturnTbl values(" + ReturntxtNum.Text + "," + cbStudent.Text + ",'" + txtName.Text + "','" + txtDepartment.Text + "','" + txtPhone.Text + "','" + cbBook.SelectedValue.ToString() + "','" + DateIssue + "','" + DateReturn + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully Returned");
                con.Close();
                updateBook();
                populate();
                populateReturn();
            }
        }
    }
}
