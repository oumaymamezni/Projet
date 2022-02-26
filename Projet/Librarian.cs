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
    public partial class Librarian : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library;Integrated Security=True; ");
        public Librarian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'libraryDataSet.LibrarianTbl'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.librarianTblTableAdapter.Fill(this.libraryDataSet.LibrarianTbl);
            populate();
        }
       private void populate()
        {
            con.Open();
            string query = "select * from LibrarianTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvLibrarians.DataSource = ds.Tables[0];
            con.Close();
        } 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="" || txtName.Text =="" || txtPassword.Text =="" || txtPhone.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into LibrarianTbl values("+ txtId.Text+",'"+txtName.Text+"','"+txtPassword.Text+"','"+txtPhone.Text+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian added successfully");
                con.Close();
                populate();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Entre the librarian Id");
            }
            else
            {
                con.Open();
                string query = "delete from librarianTbl where LibId="+txtId.Text+";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian successfully deleted");
                con.Close();
                populate();
            }
        }

        private void dgvLibrarians_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvLibrarians.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvLibrarians.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = dgvLibrarians.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = dgvLibrarians.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "update LibrarianTbl set LibName='"+txtName.Text+ "',LibPassword='" + txtPassword.Text + "',LibPhone='" + txtPhone.Text + "' where LibId=" + txtId.Text + "; ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian successfully updated ");
                con.Close();
                populate();
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }
    }
}
