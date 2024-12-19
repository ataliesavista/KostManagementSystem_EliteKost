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
 DATA PENGHUNI (DataPenghuni.cs) : 
    1. Melihat data dari seluruh penghuni kost.
    2. Mencari data penghuni kost
    3. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class DataPenghuni : Form
    {
        //CustomerDBEntites2 => database dari ADO.NET (Entity Framework) untuk melihat dan mengambil data penghuni dari database.
        CustomerDBEntities2 db = new CustomerDBEntities2();
        public DataPenghuni()
        {
            InitializeComponent();
        }

        private void DataPenghuni_Load(object sender, EventArgs e)
        {
            Rounded.SetRounded(dataGridView1, 30);

            //DataGridView1 : menampilkan tabel data penghuni kost dengan menglist data dari CustomerDB (tabel Customer dari Database SQL Server Management)
            dataGridView1.AutoGenerateColumns = false;
            List<Customer> customers = new List<Customer>();
            customers = db.Customers.ToList();
            dataGridView1.DataSource = customers;
        }

        //ButtonSearch : melakukan pencarian dengan mengklik button Search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                //menampilkan data sesuai dengan query yang ditulis untuk seluruh jenis data
                string searchInput = txtSearch.Text.ToLower();

                List<Customer> customers = db.Customers
                    .Where(m =>
                        m.NamaCust.ToLower().Contains(searchInput) ||
                        m.NIK.ToLower().Contains(searchInput) ||
                        m.TelpNum.ToLower().Contains(searchInput) ||
                        m.TglMasuk.ToLower().Contains(searchInput) ||
                        m.TipeKamar.ToLower().Contains(searchInput) ||
                        m.Durasi.ToLower().Contains(searchInput) ||
                        m.KamarNum.ToLower().Contains(searchInput) ||
                        m.NamaKer.ToLower().Contains(searchInput) ||
                        m.KerTelpNum.ToLower().Contains(searchInput)
                    )
                    .ToList();

                dataGridView1.DataSource = customers;
            }
            else
            {
                //ketika input text kosong, maka akan ditampilkan daftar penghuni seluruhnya
                dataGridView1.DataSource = db.Customers.ToList();
            }
        }

        //dijalankan ButtonSearch apabila mengklik keyboard Enter
        private void txtSearch_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ButtonSearch_Click(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
