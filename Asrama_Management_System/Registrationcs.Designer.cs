namespace Asrama_Management_System
{
    partial class Registrationcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNokamar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaKer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoKer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTTL = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelpNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTglMasuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipeKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgKamarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNamaKer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelpNumKer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDurasi = new System.Windows.Forms.ComboBox();
            this.txtRuang = new System.Windows.Forms.ComboBox();
            this.labelTitleDash = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(185, 39);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(370, 28);
            this.txtNama.TabIndex = 1;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtTelp
            // 
            this.txtTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelp.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelp.Location = new System.Drawing.Point(185, 155);
            this.txtTelp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(370, 28);
            this.txtTelp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipe Ruang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durasi";
            // 
            // txtNokamar
            // 
            this.txtNokamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNokamar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNokamar.Location = new System.Drawing.Point(185, 377);
            this.txtNokamar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNokamar.Name = "txtNokamar";
            this.txtNokamar.Size = new System.Drawing.Size(370, 28);
            this.txtNokamar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nomor Kamar";
            // 
            // txtNamaKer
            // 
            this.txtNamaKer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaKer.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaKer.Location = new System.Drawing.Point(185, 438);
            this.txtNamaKer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaKer.Name = "txtNamaKer";
            this.txtNamaKer.Size = new System.Drawing.Size(370, 28);
            this.txtNamaKer.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 445);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nama Kerabat";
            // 
            // txtNoKer
            // 
            this.txtNoKer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoKer.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoKer.Location = new System.Drawing.Point(185, 494);
            this.txtNoKer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoKer.Name = "txtNoKer";
            this.txtNoKer.Size = new System.Drawing.Size(370, 28);
            this.txtNoKer.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(34, 501);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "No. Telp Kerabat";
            // 
            // txtNIK
            // 
            this.txtNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIK.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIK.Location = new System.Drawing.Point(185, 95);
            this.txtNIK.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(370, 28);
            this.txtNIK.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "NIK";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(250, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 39);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(427, 601);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 39);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(75, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTTL
            // 
            this.dateTTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTTL.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTTL.Location = new System.Drawing.Point(185, 210);
            this.dateTTL.Name = "dateTTL";
            this.dateTTL.Size = new System.Drawing.Size(370, 28);
            this.dateTTL.TabIndex = 22;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCustomerID,
            this.dgNama,
            this.dgNIK,
            this.dgTelpNum,
            this.dgTglMasuk,
            this.dgTipeKamar,
            this.dgDurasi,
            this.dgKamarNum,
            this.dgNamaKer,
            this.dgTelpNumKer});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Location = new System.Drawing.Point(647, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(636, 671);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // dgCustomerID
            // 
            this.dgCustomerID.DataPropertyName = "CustomerID";
            this.dgCustomerID.HeaderText = "CustomerID";
            this.dgCustomerID.MinimumWidth = 6;
            this.dgCustomerID.Name = "dgCustomerID";
            this.dgCustomerID.ReadOnly = true;
            this.dgCustomerID.Visible = false;
            this.dgCustomerID.Width = 125;
            // 
            // dgNama
            // 
            this.dgNama.DataPropertyName = "NamaCust";
            this.dgNama.HeaderText = "Nama Penghuni";
            this.dgNama.MinimumWidth = 6;
            this.dgNama.Name = "dgNama";
            this.dgNama.ReadOnly = true;
            this.dgNama.Width = 125;
            // 
            // dgNIK
            // 
            this.dgNIK.DataPropertyName = "NIK";
            this.dgNIK.HeaderText = "NIK";
            this.dgNIK.MinimumWidth = 6;
            this.dgNIK.Name = "dgNIK";
            this.dgNIK.ReadOnly = true;
            this.dgNIK.Width = 125;
            // 
            // dgTelpNum
            // 
            this.dgTelpNum.DataPropertyName = "TelpNum";
            this.dgTelpNum.HeaderText = "No. Telp";
            this.dgTelpNum.MinimumWidth = 6;
            this.dgTelpNum.Name = "dgTelpNum";
            this.dgTelpNum.ReadOnly = true;
            this.dgTelpNum.Width = 125;
            // 
            // dgTglMasuk
            // 
            this.dgTglMasuk.DataPropertyName = "TglMasuk";
            this.dgTglMasuk.HeaderText = "Tanggal Masuk";
            this.dgTglMasuk.MinimumWidth = 6;
            this.dgTglMasuk.Name = "dgTglMasuk";
            this.dgTglMasuk.ReadOnly = true;
            this.dgTglMasuk.Width = 125;
            // 
            // dgTipeKamar
            // 
            this.dgTipeKamar.DataPropertyName = "TipeKamar";
            this.dgTipeKamar.HeaderText = "Tipe Kamar";
            this.dgTipeKamar.MinimumWidth = 6;
            this.dgTipeKamar.Name = "dgTipeKamar";
            this.dgTipeKamar.ReadOnly = true;
            this.dgTipeKamar.Width = 125;
            // 
            // dgDurasi
            // 
            this.dgDurasi.DataPropertyName = "Durasi";
            this.dgDurasi.HeaderText = "Durasi";
            this.dgDurasi.MinimumWidth = 6;
            this.dgDurasi.Name = "dgDurasi";
            this.dgDurasi.ReadOnly = true;
            this.dgDurasi.Width = 125;
            // 
            // dgKamarNum
            // 
            this.dgKamarNum.DataPropertyName = "KamarNum";
            this.dgKamarNum.HeaderText = "No. Kamar";
            this.dgKamarNum.MinimumWidth = 6;
            this.dgKamarNum.Name = "dgKamarNum";
            this.dgKamarNum.ReadOnly = true;
            this.dgKamarNum.Width = 125;
            // 
            // dgNamaKer
            // 
            this.dgNamaKer.DataPropertyName = "NamaKer";
            this.dgNamaKer.HeaderText = "Nama Kerabat";
            this.dgNamaKer.MinimumWidth = 6;
            this.dgNamaKer.Name = "dgNamaKer";
            this.dgNamaKer.ReadOnly = true;
            this.dgNamaKer.Width = 125;
            // 
            // dgTelpNumKer
            // 
            this.dgTelpNumKer.DataPropertyName = "KerTelpNum";
            this.dgTelpNumKer.HeaderText = "No. Telp Kerabat";
            this.dgTelpNumKer.MinimumWidth = 6;
            this.dgTelpNumKer.Name = "dgTelpNumKer";
            this.dgTelpNumKer.ReadOnly = true;
            this.dgTelpNumKer.Width = 125;
            // 
            // txtDurasi
            // 
            this.txtDurasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDurasi.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurasi.FormattingEnabled = true;
            this.txtDurasi.Items.AddRange(new object[] {
            "1 bulan",
            "3 bulan",
            "6 bulan",
            "12 bulan"});
            this.txtDurasi.Location = new System.Drawing.Point(185, 320);
            this.txtDurasi.Name = "txtDurasi";
            this.txtDurasi.Size = new System.Drawing.Size(370, 29);
            this.txtDurasi.TabIndex = 24;
            // 
            // txtRuang
            // 
            this.txtRuang.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuang.FormattingEnabled = true;
            this.txtRuang.Items.AddRange(new object[] {
            "A (VIP 1 orang)",
            "B (VIP 2 orang)",
            "C biasa 1 orang)",
            "D (biasa 2 orang)"});
            this.txtRuang.Location = new System.Drawing.Point(185, 267);
            this.txtRuang.Name = "txtRuang";
            this.txtRuang.Size = new System.Drawing.Size(370, 29);
            this.txtRuang.TabIndex = 25;
            // 
            // labelTitleDash
            // 
            this.labelTitleDash.AutoSize = true;
            this.labelTitleDash.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleDash.Font = new System.Drawing.Font("Futura Md BT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleDash.ForeColor = System.Drawing.Color.Black;
            this.labelTitleDash.Location = new System.Drawing.Point(463, 34);
            this.labelTitleDash.Name = "labelTitleDash";
            this.labelTitleDash.Size = new System.Drawing.Size(378, 56);
            this.labelTitleDash.TabIndex = 26;
            this.labelTitleDash.Text = "REGISTRATION";
            this.labelTitleDash.Click += new System.EventHandler(this.labelTitleDash_Click);
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Controls.Add(this.dateTTL);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.btnSubmit);
            this.panelInput.Controls.Add(this.txtNIK);
            this.panelInput.Controls.Add(this.btnDelete);
            this.panelInput.Controls.Add(this.txtRuang);
            this.panelInput.Controls.Add(this.txtNokamar);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtNama);
            this.panelInput.Controls.Add(this.label9);
            this.panelInput.Controls.Add(this.txtDurasi);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.btnCancel);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.txtNoKer);
            this.panelInput.Controls.Add(this.txtTelp);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtNamaKer);
            this.panelInput.Location = new System.Drawing.Point(27, 111);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(593, 671);
            this.panelInput.TabIndex = 27;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInput_Paint);
            // 
            // Registrationcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Asrama_Management_System.Properties.Resources.latar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 850);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.labelTitleDash);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrationcs";
            this.Text = "Registrationcs";
            this.Load += new System.EventHandler(this.Registrationcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtTelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNokamar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamaKer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoKer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTTL;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox txtDurasi;
        private System.Windows.Forms.ComboBox txtRuang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelpNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTglMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipeKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgKamarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNamaKer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelpNumKer;
        private System.Windows.Forms.Label labelTitleDash;
        private System.Windows.Forms.Panel panelInput;
    }
}