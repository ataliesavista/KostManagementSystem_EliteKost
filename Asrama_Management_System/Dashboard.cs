using RoundedShape2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 DASHBOARD FORM (dashboard.cs) : 
    1. Menangani navigation bar untuk mengatur dan berpindah posisi antar page (form)
    2. Log Out dari aplikasi
    3. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class Dashboard : Form
    {
        //CurrentAdminUsser untuk menentukan profil admin yang saat ini membuka aplikasi
        private string CurrentAdminUser { get; set; }
        public Dashboard(string username)
        {
            InitializeComponent();
            CurrentAdminUser = username;
        }

        //Refactoring => Single Responsibility Principle (SRP). Hanya fokus pada satu tugas spesifik.
        //MovingPanel : mengatur pergerakan panel untuk memberi tanda posisi page saat ini
        private void MovingPanel (Control btn)
        {
            MovePanel.Top = btn.Top;
        }

        //Refactoring => ShowPageInPanel => Polimorfisme (overload method). Menangani skenario beda (UserContol & Form) untuk menampilkan panel3.
        private void ShowPageInPanel(Form page)
        {
            panel3.Controls.Clear();

            page.TopLevel = false; 
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            panel3.Controls.Add(page); 
            page.Show(); 
        }

        private void ShowPageInPanel(UserControl page)
        {
            panel3.Controls.Clear();

            page.Dock = DockStyle.Fill;
            panel3.Controls.Add(page);
        }

        //Kontrol Page Dashboard saat page terbuka
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Rounded.SetRounded(btnDashboard, 50);
            Rounded.SetRounded(btnDataSearch, 50);
            Rounded.SetRounded(btnRegistration, 50);
            Rounded.SetRounded(btnProfile, 50);
            Rounded.SetRounded(MovePanel, 15);
            lblUsername.Text = CurrentAdminUser;

            //Posisi pertama ketika membuka aplikasi
            MovingPanel(btnDashboard);
            UserControlDash dashb = new UserControlDash(CurrentAdminUser);
            ShowPageInPanel(dashb);
        }

        //btnDashboard : menampilkan page UserControlDash (dashboard)
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            MovingPanel(btnDashboard);
            UserControlDash dashb = new UserControlDash(CurrentAdminUser);
            ShowPageInPanel(dashb);
        }

        //button1 (btnDataSearch) : menampilkan page Data Search 
        private void button1_Click(object sender, EventArgs e)
        {
            MovingPanel(btnDataSearch);

            DataPenghuni dataPenghuniPage = new DataPenghuni();
            ShowPageInPanel(dataPenghuniPage);
        }

        //btnRegistration : menampilkan page Registrasi (Add, Update, Delete database untuk penghuni)
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel(btnRegistration);

            Registrationcs registrationcs = new Registrationcs();
            ShowPageInPanel(registrationcs);
        }

        //btnProfile : menampilkan page Profile dari admin (berdasarkan CurrentAdminUser)
        private void btnProfile_Click(object sender, EventArgs e)
        {
            MovingPanel(btnProfile);

            Profile profile = new Profile(CurrentAdminUser);
            ShowPageInPanel(profile);
        }

        //btnLogut (komponen PictureBox) : keluar dari aplikasi (ditampilkan MessageBox)
        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel3_Scroll(object sender, ScrollEventArgs e)
        {
            panel3.Scroll += new ScrollEventHandler(panel3_Scroll);
        }

        private void MovePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
