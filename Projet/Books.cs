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
    public partial class Books : Form
    {
        public Books()
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

        private void Books_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "" || txtBublisher.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into BookTbl values('" + txtName.Text + "','" + txtAuthor.Text + "','" + txtBublisher.Text + "'," + txtPrice.Text + "," + txtQuantity.Text + ")", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book added successfully");
                con.Close();
                populate();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Entre the Book Name");
            }
            else
            {
                con.Open();
                string query = "delete from BookTbl where BookName='" + txtName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully deleted");
                con.Close();
                populate();
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
            txtAuthor.Text = dgvBook.SelectedRows[0].Cells[1].Value.ToString();
            txtBublisher.Text = dgvBook.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = dgvBook.SelectedRows[0].Cells[3].Value.ToString();
            txtQuantity.Text = dgvBook.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "" || txtBublisher.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "update BookTbl set Author='" + txtAuthor.Text + "',Publisher='" + txtBublisher.Text + "',Price='" + txtPrice.Text + "',Qty='" + txtQuantity.Text + "' where BookName='" + txtName.Text + "'; ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully updated ");
                con.Close();
                populate();
            }
        }
    }
}