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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Library;Integrated Security=True; ");
        private void Student_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvStudent.DataSource = ds.Tables[0];
            con.Close();
        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtStudent.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl values(" + txtStudent.Text + ",'" + txtName.Text + "','" + txtDepartment.Text + "', '"+comboBox1.SelectedItem.ToString()+ "','" + txtPhone.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully");
                con.Close();
                populate();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudent.Text == "")
            {
                MessageBox.Show("Entre the Student Id");
            }
            else
            {
                con.Open();
                string query = "delete from StudentTbl where StdId=" + txtStudent.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student successfully deleted");
                con.Close();
                populate();
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudent.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
            txtDepartment.Text = dgvStudent.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.SelectedItem = dgvStudent.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = dgvStudent.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtStudent.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                string query = "update StudentTbl set StdName='" + txtName.Text + "',StdDep='" + txtDepartment.Text + "',StdPhone='" + txtPhone.Text + "' where StdId=" + txtStudent.Text + "; ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student successfully updated ");
                con.Close();
                populate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
