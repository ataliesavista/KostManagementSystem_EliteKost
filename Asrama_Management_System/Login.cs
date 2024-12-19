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
 LOGIN (Login.cs) : 
    1. Masuk ke aplikasi data admin kost
    2. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class FormLogin : Form
    {
        public string Username { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rounded.SetRounded(groupBoxLogin, 40);
            Rounded.SetRounded(buttonLogin, 30);
        }
        
        //label2 (labelSignUp) : akan masuk ke dalam page SignUp.cs apabila admin belum memiliki akun admin kost.
        private void label2_Click(object sender, EventArgs e)
        {
            SignUp SignUpForm = new SignUp();
            SignUpForm.Show();
            //this.Hide();
        }

        //button1 (ButtonLogin) : masuk ke aplikasi.
        private void button1_Click(object sender, EventArgs e)
        {
            //dijalankan apabila textBoxUser tidak memiliki input
            if (string.IsNullOrEmpty(textBoxUser.Text))
            {
                MessageBox.Show("Tolong masukkan username anda.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser.Focus();
                return;
            }

            //Memeriksa apakah terdapat data admin yang sama ataupun benar sesuai dengan database Admin (AdminDBEntites pada tabel SQL Server Management)
            try
            {
                using (AdminDBEntities db = new AdminDBEntities())
                {
                    var query = from o in db.Admins
                                where o.username == textBoxUser.Text && o.password == textBoxPass.Text
                                select o;
                    var admin = query.SingleOrDefault();
                    if (admin != null)
                    {
                        MessageBox.Show("Berhasil logged in!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Username = admin.username;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username atau sandi yang anda masukkan salah!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //KeyPress : mengklik Enter pada keyboard akan berganti Focus.
        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                textBoxPass.Focus();
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                buttonLogin.PerformClick();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
