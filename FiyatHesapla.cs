using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ArabaKiralamaHoşgeldiniz
{
    public partial class FiyatHesapla : Form
    {
        public FiyatHesapla()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void FiyatHesapla_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("sp_KiraHesapla", baglanti);
            komut2.CommandType = CommandType.StoredProcedure;
            komut2.Parameters.AddWithValue("@musno", SqlDbType.VarChar).Value = textBox1.Text;
            komut2.Parameters.AddWithValue("@kiraBaslangıc", SqlDbType.SmallDateTime).Value = textBox2.Text;
            komut2.Parameters.AddWithValue("@aracplakano", SqlDbType.VarChar).Value = textBox3.Text;

            komut2.ExecuteNonQuery();



            SqlDataAdapter adap = new SqlDataAdapter(komut2);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            label4.Visible = true;

            label4.Text = textBox3.Text+ " plakalı araba için "+ tablo.Rows[0]["Ücret"].ToString()+" TL fiyat çıkmıştır.";


            baglanti.Close();
        }
    }
}
