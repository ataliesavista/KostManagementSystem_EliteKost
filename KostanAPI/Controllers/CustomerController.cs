using KostanAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;
using KostanAPI.Models;

namespace KostanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase //inherit dari ControllerBase
    {
        public readonly IConfiguration _configuration; //field untuk membaca konfigurasi dari appsettings.json
        public CustomerController(IConfiguration Configuration)
        {
            _configuration = Configuration; //menyimpan konfigurasi 
        }

        //Endpoint HTTP GET (mengambil semua data penghuni kost)
        [HttpGet]
        [Route("GetAllCustomers")]
        public string GetCustomer()
        {
            //Koneksikan dan ambil data dari database SQL Server Management
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("CustomerAppCon").ToString());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", con);
            
            //DataTable : menyimpan dan mengisi data penghuni dari database yang sudah terhubung
            DataTable dt = new DataTable(); 
            da.Fill(dt);

            List<Customer> Custlist = new List<Customer>();
            Response response = new Response();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //Mengisi tiap atribut pada Customer
                    Customer customer = new Customer();
                    customer.CustomerId = Convert.ToInt32(dt.Rows[i]["CustomerID"]);
                    customer.NamaCust = Convert.ToString(dt.Rows[i]["NamaCust"]);
                    customer.NIK = Convert.ToString(dt.Rows[i]["NIK"]);
                    customer.TelpNum = Convert.ToString(dt.Rows[i]["TelpNum"]);
                    customer.TglMasuk = Convert.ToString(dt.Rows[i]["TglMasuk"]);
                    customer.TipeKamar = Convert.ToString(dt.Rows[i]["TipeKamar"]);
                    customer.Durasi = Convert.ToString(dt.Rows[i]["Durasi"]);
                    customer.KamarNum = Convert.ToString(dt.Rows[i]["KamarNum"]);
                    customer.NamaKer = Convert.ToString(dt.Rows[i]["NamaKer"]);
                    customer.KerTelpNum = Convert.ToString(dt.Rows[i]["KerTelpNum"]);

                    Custlist.Add(customer);
                }
            }

            //Apabila terdapat data di dalam CustList, data akan diubah menjadi JSON dan akan ditampilkan.
            if (Custlist.Count > 0)
            {
                return JsonConvert.SerializeObject(Custlist, Formatting.Indented);
            }
            //Apabila tidak ada data, akan mengembalikan status dan pesan error.
            else
            {
                response.StatusCode = 100;
                response.ErrorMessage = "Tidak ada data ditemukan";
                return JsonConvert.SerializeObject(response);
            }
        }
    }
}
