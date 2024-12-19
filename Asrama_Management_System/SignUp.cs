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
 SIGN UP (SignUp.cs) : 
    1. Mendaftarkan data admin baru ke dalam database admin.
    2. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class SignUp : Form
    {
        Admin model = new Admin();
        public SignUp()
        {
            InitializeComponent();
        }

        //Masuk ke Page Login apabila sudah memiliki akun admin.
        private void labelLogin_Click(object sender, EventArgs e)
        {
            FormLogin LoginForm = new FormLogin();
            LoginForm.Show();
            this.Close();
        }

        //buttonSignUp : menambahkan data admin baru ke dalam database AdminDBEntities pada tabel AdminDB SQL Server Management
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            model.email = txtEmailUp.Text.Trim();
            model.username = txtUserUp.Text.Trim();
            model.password = txtPassUp.Text.Trim();

            using (AdminDBEntities Admindb = new AdminDBEntities())
            {
                Admindb.Admins.Add(model);
                Admindb.SaveChanges();
            }
            MessageBox.Show("Anda telah berhasil Sign Up!");
            FormLogin LoginForm = new FormLogin(); 
            LoginForm.Show(); //langsung masuk ke page Login
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Rounded.SetRounded(groupBoxSignUp, 30);
            Rounded.SetRounded(buttonSignUp, 30);
        }
    }
}
