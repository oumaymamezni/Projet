using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
            this.Hide();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.Show();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Librarian l = new Librarian();
            l.Show();
            this.Hide();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            IssueBook IE = new IssueBook();
            IE.Show();
            this.Hide();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            ReturnBook RB = new ReturnBook();
            RB.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            //this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard DS = new Dashboard();
            DS.Show();
        }
    }
}
