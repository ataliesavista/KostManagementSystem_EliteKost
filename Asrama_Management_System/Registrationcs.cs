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
 REGISTRATION (Registrationcs.cs) : 
    1. Menampilkan daftar penghuni kost.
    2. Merubah data penghuni kost (Add, Update, Delete).
    3. Menggunakan nuget package RoundedShape2 untuk mengatur sudut lengkung beberapa komponen
 */

namespace Asrama_Management_System
{
    public partial class Registrationcs : Form
    {
        Customer model = new Customer();
        public Registrationcs()
        {
            InitializeComponent();
            this.ActiveControl = txtNama;
        }

        private void Registrationcs_Load(object sender, EventArgs e)
        {
            Rounded.SetRounded(panelInput, 30);
            Rounded.SetRounded(dataGridView2, 30);

            Clear();
            this.ActiveControl = txtNama;
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //button3 (ButtonCancel) : membatalkan pemasukan data (mengosongkan input textBox. Mengambil function Clear()).
        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Fungsi untuk membatalkan penambahan data penghuni (menghapus kolom registrasi)
        void Clear()
        {
            txtNama.Text = txtNIK.Text = txtNokamar.Text = txtNamaKer.Text = txtTelp.Text = txtNoKer.Text = txtRuang.Text = dateTTL.Text = txtDurasi.Text = "";
            btnSubmit.Text = "Submit";
            btnDelete.Enabled = false;
            model.CustomerID = 0;
        }

        //Fungsi LoadData : menampilkan Data Penghuni secara langsung
        void LoadData()
        {
            dataGridView2.AutoGenerateColumns = false;
            using (CustomerDBEntities2 Custdb = new CustomerDBEntities2())
            {
                dataGridView2.DataSource = Custdb.Customers.ToList<Customer>();
            }
        }

        //btnSubmit : menambah penghuni baru.
        //Memasukkan Text dan Value dari textBox input ke dalam model data untuk disimpan ke dalam database. 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            model.NamaCust = txtNama.Text.Trim();
            model.NIK = txtNIK.Text.Trim();
            model.TelpNum = txtTelp.Text.Trim();
            model.TglMasuk = dateTTL.Value.ToString("yyyy-MM-dd"); //mengubah Value ke String
            model.TipeKamar = txtRuang.Text.Trim();
            model.Durasi = txtDurasi.Text.Trim();
            model.KamarNum = txtNokamar.Text.Trim();
            model.NamaKer = txtNamaKer.Text.Trim();
            model.KerTelpNum = txtNoKer.Text.Trim();

            using (CustomerDBEntities2 Custdb  = new CustomerDBEntities2())
            {
                if (model.CustomerID == 0) //tambah data
                    Custdb.Customers.Add(model);
                else //update data
                    Custdb.Entry(model).State = System.Data.Entity.EntityState.Modified;
                Custdb.SaveChanges();
            }
            Clear();
            LoadData();
            MessageBox.Show("Data Berhasil Ditambahkan!");
        }

        //dataGridView2 : menampilkan tabel dari seluruh data penghuni kost.
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            //Dapat memperbarui dan menghapus data apabila index tidak sama dengan -1
            if (dataGridView2.CurrentRow.Index != -1)
            {
                model.CustomerID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["dgCustomerID"].Value);
                using (CustomerDBEntities2 Custdb = new CustomerDBEntities2())
                {
                    model = Custdb.Customers.Where(x => x.CustomerID == model.CustomerID).FirstOrDefault();
                    txtNama.Text = model.NamaCust;
                    txtNIK.Text = model.NIK;
                    txtTelp.Text = model.TelpNum;
                    dateTTL.Text = model.TglMasuk;
                    txtRuang.Text = model.TipeKamar;
                    txtDurasi.Text = model.Durasi;
                    txtNokamar.Text = model.KamarNum;
                    txtNamaKer.Text = model.NamaKer;
                    txtNoKer.Text = model.KerTelpNum;
                }
                btnSubmit.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        //btnDelete : menghapus data penghuni dari database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin akan menghapus data ini?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CustomerDBEntities2 Custdb = new CustomerDBEntities2())
                {
                    var entry = Custdb.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        Custdb.Customers.Attach(model);
                        Custdb.Customers.Remove(model);
                        Custdb.SaveChanges();
                        LoadData(); //mengupdate data
                        Clear(); //membersihkan input text
                        MessageBox.Show("Data Berhasil Dihapus!");
                    }
                }
            }
        }

        private void labelTitleDash_Click(object sender, EventArgs e)
        {

        }

        private void panelInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
