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

/*
 PROFILE (Profile.cs) : 
    1. Menampilkan profile dari admin saat ini.
    2. Menampilkan email, username, dan password admin
    3. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class Profile : Form
    {
        //Pengoperan username dari page Login.cs
        public string CurrentAdminUser { get; set; }
        public Profile(string username)
        {
            InitializeComponent();
            CurrentAdminUser = username;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Rounded.SetRounded(PanelProfile, 20);
            Rounded.SetRounded(txtEmailProf, 5);
            Rounded.SetRounded(txtUserProf, 5);
            Rounded.SetRounded(txtPassProf, 5);

            //Menampilkan data admin (email, username, dan password) dari database AdminDBEntities (table AdminDB SQL Server Management)
            try
            {
                using(var db = new AdminDBEntities())
                {
                    var admin = db.Admins.FirstOrDefault(a => a.username == CurrentAdminUser);
                    if (admin != null)
                    {
                        txtEmailProf.Text = admin.email;
                        txtUserProf.Text = admin.username;
                        txtPassProf.Text = admin.password;
                    }
                    else
                    {
                        MessageBox.Show("Data admin tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void labelTitleSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
