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
    public partial class ArabaFiltreleme : Form
    {
        public ArabaFiltreleme()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);


        public void listele(SqlCommand komut3)
        {
            listView1.Items.Clear();

            SqlDataAdapter adap = new SqlDataAdapter(komut3);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["aracplakano"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["marka"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["model"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["renk"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["kirabedeli"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["vitestipi"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["adres"].ToString());

            }


            textBox1.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listView1.Items.Clear();
                SqlCommand komut3 = new SqlCommand(" select a.aracplakano,a.marka,a.model,a.renk, a.kirabedeli,a.vitestipi,ky.adres from arac a inner join kiralananYer ky on a.satisyerno=ky.satisyerno where ky.adres=@adres", baglanti);

                komut3.Parameters.AddWithValue("@adres", textBox1.Text);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();

                listele(komut3);


               
            }
            else if (radioButton2.Checked == true)
            {
                listView1.Items.Clear();
                SqlCommand komut3 = new SqlCommand(" select a.aracplakano,a.marka,a.model,a.renk, a.kirabedeli,a.vitestipi, ky.adres from arac a inner join kiralananYer ky on a.satisyerno=ky.satisyerno where a.marka=@marka", baglanti);

                komut3.Parameters.AddWithValue("@marka", textBox1.Text);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();

                listele(komut3);

            }

            else if (radioButton3.Checked == true)
            {
                listView1.Items.Clear();
                SqlCommand komut3 = new SqlCommand(" select a.aracplakano,a.marka,a.model,a.renk, a.kirabedeli,a.vitestipi ,ky.adres from arac a inner join kiralananYer ky on a.satisyerno=ky.satisyerno where a.renk=@renk", baglanti);

                komut3.Parameters.AddWithValue("@renk", textBox1.Text);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();


                listele(komut3);

            }

            else if (radioButton4.Checked == true)
            {

                listView1.Items.Clear();

                SqlCommand komut3 = new SqlCommand(" select a.aracplakano,a.marka,a.model,a.renk, a.kirabedeli,a.vitestipi ,ky.adres from arac a inner join kiralananYer ky on a.satisyerno=ky.satisyerno where a.vitestipi=@vites", baglanti);

                komut3.Parameters.AddWithValue("@vites", textBox1.Text);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();

                listele(komut3);
            }

            else
                MessageBox.Show("Bir kriter seçiniz.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Adres Giriniz :";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Marka Giriniz :";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Renk Giriniz :";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Vites Tipini Giriniz :";
        }

        private void ArabaFiltreleme_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
