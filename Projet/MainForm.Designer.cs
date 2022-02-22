namespace Projet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnStudent = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLibrarian = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReturn = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnIssue = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBooks = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAbout = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDashboard = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTips = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 55);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnBooks);
            this.panel3.Controls.Add(this.btnIssue);
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Controls.Add(this.btnLibrarian);
            this.panel3.Controls.Add(this.btnStudent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 55);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.btnTips);
            this.panel4.Controls.Add(this.btnDashboard);
            this.panel4.Controls.Add(this.btnAbout);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 61);
            this.panel4.TabIndex = 2;
            // 
            // btnStudent
            // 
            this.btnStudent.AutoSize = true;
            this.btnStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudent.Depth = 0;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(380, 9);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Primary = false;
            this.btnStudent.Size = new System.Drawing.Size(81, 36);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Students";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.AutoSize = true;
            this.btnLibrarian.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLibrarian.Depth = 0;
            this.btnLibrarian.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Location = new System.Drawing.Point(708, 9);
            this.btnLibrarian.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLibrarian.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Primary = false;
            this.btnLibrarian.Size = new System.Drawing.Size(89, 36);
            this.btnLibrarian.TabIndex = 1;
            this.btnLibrarian.Text = "LIBRARIANS";
            this.btnLibrarian.UseVisualStyleBackColor = true;
            this.btnLibrarian.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturn.Depth = 0;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(602, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Primary = false;
            this.btnReturn.Size = new System.Drawing.Size(112, 36);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "RETURN BOOKS";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.AutoSize = true;
            this.btnIssue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIssue.Depth = 0;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(508, 9);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIssue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Primary = false;
            this.btnIssue.Size = new System.Drawing.Size(97, 36);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.Text = "ISSUE BOOKS";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.AutoSize = true;
            this.btnBooks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBooks.Depth = 0;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(456, 9);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBooks.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Primary = false;
            this.btnBooks.Size = new System.Drawing.Size(57, 36);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "BOOKS";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbout.Depth = 0;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(61, 10);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Primary = false;
            this.btnAbout.Size = new System.Drawing.Size(77, 36);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "about us";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSize = true;
            this.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashboard.Depth = 0;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(361, 10);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Primary = false;
            this.btnDashboard.Size = new System.Drawing.Size(93, 36);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnTips
            // 
            this.btnTips.AutoSize = true;
            this.btnTips.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTips.Depth = 0;
            this.btnTips.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTips.Location = new System.Drawing.Point(682, 10);
            this.btnTips.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTips.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTips.Name = "btnTips";
            this.btnTips.Primary = false;
            this.btnTips.Size = new System.Drawing.Size(41, 36);
            this.btnTips.TabIndex = 7;
            this.btnTips.Text = "tips";
            this.btnTips.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "UniLibrary";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialFlatButton btnBooks;
        private MaterialSkin.Controls.MaterialFlatButton btnIssue;
        private MaterialSkin.Controls.MaterialFlatButton btnReturn;
        private MaterialSkin.Controls.MaterialFlatButton btnLibrarian;
        private MaterialSkin.Controls.MaterialFlatButton btnStudent;
        private MaterialSkin.Controls.MaterialFlatButton btnTips;
        private MaterialSkin.Controls.MaterialFlatButton btnDashboard;
        private MaterialSkin.Controls.MaterialFlatButton btnAbout;
        private System.Windows.Forms.Label label1;
    }
}