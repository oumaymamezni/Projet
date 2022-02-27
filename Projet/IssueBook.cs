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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library;Integrated Security=True; ");
        private void FillStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StdId from StudentTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(rdr);
            cbStudent.ValueMember = "StdId";
            cbStudent.DataSource = dt;
            con.Close();
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
        private void fetchstddata()
        {
            con.Open();
            string query = "select * from StudentTbl where StdId=" + cbStudent.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                txtName.Text = dr["StdName"].ToString();
                txtDepartement.Text = dr["StdDep"].ToString();
                txtPhone.Text = dr["StdPhone"].ToString();

            }
            con.Close();
        }
        private void IssueBook_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            populate();
        }
        private void populate()
        {
            //con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvIssue.DataSource = ds.Tables[0];
            con.Close();
        }
        /*private void populate()
        {
            con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvIssue.DataSource = ds.Tables[0];
            con.Close();
        }*/
        private void btnIss_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string Date = date.Value.Day.ToString() + "/" + date.Value.Month.ToString() + "/" + date.Value.Year.ToString(); 
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into IssueTbl values('" + txtNum.Text + "','" + cbStudent.SelectedValue.ToString() + "','" + txtName.Text + "','" + txtDepartement.Text + "','" + txtPhone.Text + "','" + cbBook.SelectedValue.ToString() + "','" + Date + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully Issued");
                con.Close();
                updateBook();
                populate();
            }
        }

        private void cbStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
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
                newQty = Qty - 1;
                string query1 = "update BookTbl set Qty=" + newQty + " where BookName='" + cbBook.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
        }

        private void updateBookCancellation()
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                MessageBox.Show("Entre the Book Id");
            }
            else
            {
                con.Open();
                string query = "delete from IssueTbl where IssueNum=" + txtNum.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Issue successfully canceled");
                con.Close();
                updateBookCancellation();
                populate();
            }
        }

        private void dgvIssue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNum.Text = dgvIssue.SelectedRows[0].Cells[0].Value.ToString();
            cbStudent.Text = dgvIssue.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dgvIssue.SelectedRows[0].Cells[2].Value.ToString();
            txtDepartement.Text = dgvIssue.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = dgvIssue.SelectedRows[0].Cells[4].Value.ToString();
            cbBook.Text = dgvIssue.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
