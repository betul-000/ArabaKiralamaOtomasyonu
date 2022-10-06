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
    public partial class SilinenAracBilgileri : Form
    {
        public SilinenAracBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");
        SqlDataAdapter da;




        private void SilinenAracBilgileri_Load(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                da = new SqlDataAdapter("select * from SilinenAraclar", baglanti); //tüm kayıtlı araçları gösteren sorgu
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo; //tablodan datagride veri aktar
                baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem sırasında hata oluştu." + hata.Message);
            }
            
        }
    }
}
