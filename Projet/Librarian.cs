﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H8N9P9A\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
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
            }
        }
    }
}
