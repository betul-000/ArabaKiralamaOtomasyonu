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
    public partial class TariheGöreKiralananAracListesi : Form
    {
        public TariheGöreKiralananAracListesi()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut2 = new SqlCommand("sp_tarihegörekiralananarac", baglanti);
                komut2.CommandType = CommandType.StoredProcedure;
                komut2.Parameters.AddWithValue("@kiraBaslangıc", SqlDbType.SmallDateTime).Value = textBox1.Text;

                komut2.ExecuteNonQuery();

                SqlDataAdapter adap = new SqlDataAdapter(komut2);
                DataTable tablo = new DataTable();

                adap.Fill(tablo);

                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView1.Items.Add(tablo.Rows[i]["aracplakano"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["marka"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["model"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["telefon"].ToString());

                }


                baglanti.Close();


            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                baglanti.Close();
            }



        }

        
    }
}
