using RoundedShape2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

/*
 USER CONTROL DASHBOARD (UserControlDash.cs) : 
    1. Menampilkan dashboard awal ketika masuk ke aplikasi
    2. Menampilkan gambar dan kapasitas dari kamar yang tersedia dan kosong (pie chart)
    3. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class UserControlDash : UserControl
    {
        public UserControlDash(string username)
        {
            InitializeComponent();

            labelTitleDash.Text = "Welcome, Admin " + username;
        }

        //ChartKapasitas : menampilkan Chart persentase kapasitas total pada data penghuni
        private void ChartKapasitas_Click(object sender, EventArgs e)
        {
            int totalKamar = 50;

            using (var db = new CustomerDBEntities2())
            {
                int kamarTerpakai = db.Customers.Count(); //kapasitas terpakai dihitung dari banyaknya Record pada tabel
                int kamarKosong = totalKamar - kamarTerpakai; //kamar kosong dari selisih total kamar dengan kamar terpakai
                if (kamarKosong < 0)
                    kamarKosong = 0;

                //tampilan chart Pie
                ChartKapasitas.Series.Clear();
                Series series = new Series("Kapasitas Kamar");
                series.ChartType = SeriesChartType.Pie;

                series.Points.AddXY("Kamar Terpakai", kamarTerpakai);
                series.Points.AddXY("Kamar Kosong", kamarKosong);

                ChartKapasitas.Series.Add(series);
                series["PieLabelStyle"] = "Outside";
                series.Label = "#PERCENT{P1}";
                series.LegendText = "#VALX";

                if (ChartKapasitas.Legends.Count > 0)
                {
                    ChartKapasitas.Legends[0].Enabled = true;
                }
                else
                {
                    Legend legend = new Legend("Legend");
                    ChartKapasitas.Legends.Add(legend);
                }
            }
        }

        private void UserControlDash_Load(object sender, EventArgs e)
        {
            int totalKamar = 50;
            Rounded.SetRounded(labelKost, 50);
            Rounded.SetRounded(panelTabel, 40);
            Rounded.SetRounded(PicKost, 40);

            using (var db = new CustomerDBEntities2())
            {
                int kamarTerpakai = db.Customers.Count();
                int emptyRooms = totalKamar - kamarTerpakai;
                txtTerpakai.Text = kamarTerpakai.ToString();
                txtKosong.Text = emptyRooms.ToString();
            }
        }

        private void panelTabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicKost_Click(object sender, EventArgs e)
        {

        }

        private void labelTitleDash_Click(object sender, EventArgs e)
        {

        }
    }
}
