namespace Asrama_Management_System
{
    partial class Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.labelKost = new System.Windows.Forms.Label();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.Question = new System.Windows.Forms.PictureBox();
            this.LatarGambar = new System.Windows.Forms.PictureBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDataSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatarGambar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 31);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.MovePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Question);
            this.panel1.Controls.Add(this.labelKost);
            this.panel1.Controls.Add(this.lblJabatan);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.LatarGambar);
            this.panel1.Controls.Add(this.btnRegistration);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnDataSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1024);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Black;
            this.MovePanel.Location = new System.Drawing.Point(14, 250);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(21, 87);
            this.MovePanel.TabIndex = 19;
            this.MovePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelKost
            // 
            this.labelKost.AutoSize = true;
            this.labelKost.BackColor = System.Drawing.Color.Transparent;
            this.labelKost.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.labelKost.Location = new System.Drawing.Point(15, 28);
            this.labelKost.Name = "labelKost";
            this.labelKost.Size = new System.Drawing.Size(173, 38);
            this.labelKost.TabIndex = 15;
            this.labelKost.Text = "ÉLITE KOST";
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.BackColor = System.Drawing.Color.Transparent;
            this.lblJabatan.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJabatan.Location = new System.Drawing.Point(145, 150);
            this.lblJabatan.MinimumSize = new System.Drawing.Size(120, 14);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(120, 24);
            this.lblJabatan.TabIndex = 14;
            this.lblJabatan.Text = "admin";
            this.lblJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(145, 118);
            this.lblUsername.MinimumSize = new System.Drawing.Size(120, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 24);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::Asrama_Management_System.Properties.Resources.latar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1624, 1024);
            this.panel3.TabIndex = 2;
            this.panel3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel3_Scroll);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDashboard.Image = global::Asrama_Management_System.Properties.Resources.icons8_home_30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(35, 250);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 87);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asrama_Management_System.Properties.Resources.cloud_moon;
            this.pictureBox1.Location = new System.Drawing.Point(215, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Image = global::Asrama_Management_System.Properties.Resources.icons8_logout_35;
            this.Logout.Location = new System.Drawing.Point(234, 946);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(82, 39);
            this.Logout.TabIndex = 17;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Question
            // 
            this.Question.Image = global::Asrama_Management_System.Properties.Resources.icons8_question_50;
            this.Question.Location = new System.Drawing.Point(44, 726);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(34, 35);
            this.Question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Question.TabIndex = 16;
            this.Question.TabStop = false;
            // 
            // LatarGambar
            // 
            this.LatarGambar.BackColor = System.Drawing.Color.Transparent;
            this.LatarGambar.Image = global::Asrama_Management_System.Properties.Resources._132;
            this.LatarGambar.Location = new System.Drawing.Point(23, 109);
            this.LatarGambar.Name = "LatarGambar";
            this.LatarGambar.Size = new System.Drawing.Size(106, 102);
            this.LatarGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LatarGambar.TabIndex = 12;
            this.LatarGambar.TabStop = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Image = global::Asrama_Management_System.Properties.Resources.icons8_registration_32;
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(28, 475);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRegistration.Size = new System.Drawing.Size(237, 87);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "   Registration";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = global::Asrama_Management_System.Properties.Resources.icons8_male_user_35;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(28, 577);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(237, 87);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "   Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDataSearch
            // 
            this.btnDataSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnDataSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataSearch.FlatAppearance.BorderSize = 0;
            this.btnDataSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataSearch.Image = global::Asrama_Management_System.Properties.Resources.icons8_search_35;
            this.btnDataSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataSearch.Location = new System.Drawing.Point(28, 360);
            this.btnDataSearch.Name = "btnDataSearch";
            this.btnDataSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDataSearch.Size = new System.Drawing.Size(237, 87);
            this.btnDataSearch.TabIndex = 1;
            this.btnDataSearch.Text = "   Data Search";
            this.btnDataSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataSearch.UseVisualStyleBackColor = false;
            this.btnDataSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LatarGambar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnDataSearch;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox LatarGambar;
        private System.Windows.Forms.Label lblJabatan;
        private System.Windows.Forms.Label labelKost;
        private System.Windows.Forms.PictureBox Question;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MovePanel;
    }
}