namespace Asrama_Management_System
{
    partial class UserControlDash
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTitleDash = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.ChartKapasitas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelK = new System.Windows.Forms.Label();
            this.labelKosong = new System.Windows.Forms.Label();
            this.txtTerpakai = new System.Windows.Forms.Label();
            this.txtKosong = new System.Windows.Forms.Label();
            this.labelKost = new System.Windows.Forms.Label();
            this.panelTabel = new System.Windows.Forms.Panel();
            this.PicKost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartKapasitas)).BeginInit();
            this.panelTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicKost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleDash
            // 
            this.labelTitleDash.AutoSize = true;
            this.labelTitleDash.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleDash.Font = new System.Drawing.Font("Futura Md BT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleDash.ForeColor = System.Drawing.Color.Black;
            this.labelTitleDash.Location = new System.Drawing.Point(471, 57);
            this.labelTitleDash.Name = "labelTitleDash";
            this.labelTitleDash.Size = new System.Drawing.Size(812, 56);
            this.labelTitleDash.TabIndex = 4;
            this.labelTitleDash.Text = "Welcome Admin Atalie Savista ...";
            this.labelTitleDash.Click += new System.EventHandler(this.labelTitleDash_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ChartKapasitas
            // 
            this.ChartKapasitas.BackColor = System.Drawing.Color.LemonChiffon;
            chartArea2.Name = "ChartArea1";
            this.ChartKapasitas.ChartAreas.Add(chartArea2);
            this.ChartKapasitas.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Name = "Legend1";
            this.ChartKapasitas.Legends.Add(legend2);
            this.ChartKapasitas.Location = new System.Drawing.Point(0, 0);
            this.ChartKapasitas.Name = "ChartKapasitas";
            this.ChartKapasitas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartKapasitas.Series.Add(series2);
            this.ChartKapasitas.Size = new System.Drawing.Size(737, 509);
            this.ChartKapasitas.TabIndex = 5;
            this.ChartKapasitas.Text = "chart1";
            this.ChartKapasitas.Click += new System.EventHandler(this.ChartKapasitas_Click);
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelK.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labelK.Location = new System.Drawing.Point(48, 559);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(193, 23);
            this.labelK.TabIndex = 6;
            this.labelK.Text = "Kamar Terpakai : ";
            // 
            // labelKosong
            // 
            this.labelKosong.AutoSize = true;
            this.labelKosong.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKosong.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelKosong.Location = new System.Drawing.Point(475, 559);
            this.labelKosong.Name = "labelKosong";
            this.labelKosong.Size = new System.Drawing.Size(171, 23);
            this.labelKosong.TabIndex = 8;
            this.labelKosong.Text = "Kamar Kosong :";
            // 
            // txtTerpakai
            // 
            this.txtTerpakai.AutoSize = true;
            this.txtTerpakai.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerpakai.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtTerpakai.Location = new System.Drawing.Point(247, 559);
            this.txtTerpakai.Name = "txtTerpakai";
            this.txtTerpakai.Size = new System.Drawing.Size(34, 23);
            this.txtTerpakai.TabIndex = 9;
            this.txtTerpakai.Text = "00";
            this.txtTerpakai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKosong
            // 
            this.txtKosong.AutoSize = true;
            this.txtKosong.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKosong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtKosong.Location = new System.Drawing.Point(654, 559);
            this.txtKosong.Name = "txtKosong";
            this.txtKosong.Size = new System.Drawing.Size(34, 23);
            this.txtKosong.TabIndex = 10;
            this.txtKosong.Text = "00";
            this.txtKosong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKost
            // 
            this.labelKost.AutoSize = true;
            this.labelKost.BackColor = System.Drawing.Color.White;
            this.labelKost.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.labelKost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelKost.Location = new System.Drawing.Point(55, 160);
            this.labelKost.MinimumSize = new System.Drawing.Size(1570, 70);
            this.labelKost.Name = "labelKost";
            this.labelKost.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelKost.Size = new System.Drawing.Size(1570, 70);
            this.labelKost.TabIndex = 16;
            this.labelKost.Text = "ÉLITE KOST";
            this.labelKost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTabel
            // 
            this.panelTabel.Controls.Add(this.ChartKapasitas);
            this.panelTabel.Controls.Add(this.labelK);
            this.panelTabel.Controls.Add(this.txtKosong);
            this.panelTabel.Controls.Add(this.labelKosong);
            this.panelTabel.Controls.Add(this.txtTerpakai);
            this.panelTabel.Location = new System.Drawing.Point(866, 283);
            this.panelTabel.Name = "panelTabel";
            this.panelTabel.Size = new System.Drawing.Size(737, 639);
            this.panelTabel.TabIndex = 17;
            this.panelTabel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTabel_Paint);
            // 
            // PicKost
            // 
            this.PicKost.BackColor = System.Drawing.Color.Transparent;
            this.PicKost.Image = global::Asrama_Management_System.Properties.Resources.Frame_2;
            this.PicKost.InitialImage = global::Asrama_Management_System.Properties.Resources.Frame_2;
            this.PicKost.Location = new System.Drawing.Point(85, 283);
            this.PicKost.Name = "PicKost";
            this.PicKost.Size = new System.Drawing.Size(701, 639);
            this.PicKost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKost.TabIndex = 18;
            this.PicKost.TabStop = false;
            this.PicKost.Click += new System.EventHandler(this.PicKost_Click);
            // 
            // UserControlDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Asrama_Management_System.Properties.Resources.latar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PicKost);
            this.Controls.Add(this.panelTabel);
            this.Controls.Add(this.labelKost);
            this.Controls.Add(this.labelTitleDash);
            this.Name = "UserControlDash";
            this.Size = new System.Drawing.Size(1671, 990);
            this.Load += new System.EventHandler(this.UserControlDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartKapasitas)).EndInit();
            this.panelTabel.ResumeLayout(false);
            this.panelTabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicKost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleDash;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartKapasitas;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelKosong;
        private System.Windows.Forms.Label txtTerpakai;
        private System.Windows.Forms.Label txtKosong;
        private System.Windows.Forms.Label labelKost;
        private System.Windows.Forms.Panel panelTabel;
        private System.Windows.Forms.PictureBox PicKost;
    }
}
