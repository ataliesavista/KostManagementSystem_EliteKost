namespace Asrama_Management_System
{
    partial class DataPenghuni
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelpNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTglMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipeKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgKamarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNamaKer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelpNumKer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.labelTitleSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCustomerID,
            this.dgNama,
            this.dgNIK,
            this.dgTelpNum,
            this.dgTglMasuk,
            this.dgTipeKamar,
            this.dgKamarNum,
            this.dgDurasi,
            this.dgNamaKer,
            this.dgTelpNumKer});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(35, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 537);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgCustomerID
            // 
            this.dgCustomerID.DataPropertyName = "CustomerID";
            this.dgCustomerID.HeaderText = "Customer ID";
            this.dgCustomerID.MinimumWidth = 6;
            this.dgCustomerID.Name = "dgCustomerID";
            this.dgCustomerID.Visible = false;
            this.dgCustomerID.Width = 125;
            // 
            // dgNama
            // 
            this.dgNama.DataPropertyName = "NamaCust";
            this.dgNama.HeaderText = "Nama Penghuni";
            this.dgNama.MinimumWidth = 6;
            this.dgNama.Name = "dgNama";
            this.dgNama.Width = 249;
            // 
            // dgNIK
            // 
            this.dgNIK.DataPropertyName = "NIK";
            this.dgNIK.HeaderText = "NIK";
            this.dgNIK.MinimumWidth = 6;
            this.dgNIK.Name = "dgNIK";
            this.dgNIK.Width = 125;
            // 
            // dgTelpNum
            // 
            this.dgTelpNum.DataPropertyName = "TelpNum";
            this.dgTelpNum.HeaderText = "No. Telp";
            this.dgTelpNum.MinimumWidth = 6;
            this.dgTelpNum.Name = "dgTelpNum";
            this.dgTelpNum.Width = 249;
            // 
            // dgTglMasuk
            // 
            this.dgTglMasuk.DataPropertyName = "TglMasuk";
            this.dgTglMasuk.HeaderText = "Tanggal Masuk";
            this.dgTglMasuk.MinimumWidth = 6;
            this.dgTglMasuk.Name = "dgTglMasuk";
            this.dgTglMasuk.Width = 125;
            // 
            // dgTipeKamar
            // 
            this.dgTipeKamar.DataPropertyName = "TipeKamar";
            this.dgTipeKamar.HeaderText = "Tipe Kamar";
            this.dgTipeKamar.MinimumWidth = 6;
            this.dgTipeKamar.Name = "dgTipeKamar";
            this.dgTipeKamar.Width = 125;
            // 
            // dgKamarNum
            // 
            this.dgKamarNum.DataPropertyName = "KamarNum";
            this.dgKamarNum.HeaderText = "No. Kamar";
            this.dgKamarNum.MinimumWidth = 6;
            this.dgKamarNum.Name = "dgKamarNum";
            this.dgKamarNum.Width = 125;
            // 
            // dgDurasi
            // 
            this.dgDurasi.DataPropertyName = "Durasi";
            this.dgDurasi.HeaderText = "Durasi";
            this.dgDurasi.MinimumWidth = 6;
            this.dgDurasi.Name = "dgDurasi";
            this.dgDurasi.Width = 125;
            // 
            // dgNamaKer
            // 
            this.dgNamaKer.DataPropertyName = "NamaKer";
            this.dgNamaKer.HeaderText = "Nama Kerabat";
            this.dgNamaKer.MinimumWidth = 6;
            this.dgNamaKer.Name = "dgNamaKer";
            this.dgNamaKer.Width = 249;
            // 
            // dgTelpNumKer
            // 
            this.dgTelpNumKer.DataPropertyName = "KerTelpNum";
            this.dgTelpNumKer.HeaderText = "No. Telp Kerabat";
            this.dgTelpNumKer.MinimumWidth = 6;
            this.dgTelpNumKer.Name = "dgTelpNumKer";
            this.dgTelpNumKer.Width = 249;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(378, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(456, 28);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_Keydown);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonSearch.Location = new System.Drawing.Point(867, 126);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(91, 28);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelTitleSearch
            // 
            this.labelTitleSearch.AutoSize = true;
            this.labelTitleSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleSearch.Font = new System.Drawing.Font("Futura Md BT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSearch.ForeColor = System.Drawing.Color.Black;
            this.labelTitleSearch.Location = new System.Drawing.Point(486, 41);
            this.labelTitleSearch.Name = "labelTitleSearch";
            this.labelTitleSearch.Size = new System.Drawing.Size(355, 56);
            this.labelTitleSearch.TabIndex = 5;
            this.labelTitleSearch.Text = "DATA SEARCH";
            // 
            // DataPenghuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = global::Asrama_Management_System.Properties.Resources.latar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.labelTitleSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "DataPenghuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Penghuni";
            this.Load += new System.EventHandler(this.DataPenghuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelpNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTglMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipeKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgKamarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNamaKer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelpNumKer;
        private System.Windows.Forms.Label labelTitleSearch;
    }
}