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
    public partial class KullanıcıBilgileri : Form
    {
        public KullanıcıBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");
        SqlDataAdapter da;

        void KullanıcıBilgileriGetir()
        {

            da = new SqlDataAdapter("SELECT * FROM kullanıcıBilgileri ", baglanti); //tüm kayıtlı araçları gösteren sorgu
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo; //tablodan datagride veri aktar
            baglanti.Close();
        }


        private void KullanıcıBilgileri_Load(object sender, EventArgs e)
        {
            KullanıcıBilgileriGetir();

            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut;


            try
            {
                string sorgu = " INSERT INTO kullanıcıBilgileri (kullanıcıAdi, sifre, yetki) VALUES" +
               " (@kullanıcıAdi, @sifre, @yetki)";


                komut = new SqlCommand(sorgu, baglanti);


                komut.Parameters.AddWithValue("@kullanıcıAdi", textBox1.Text);
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);

                if (comboBox1.Text=="Admin")
                    komut.Parameters.AddWithValue("@yetki", comboBox1.Text);
                else if (comboBox1.Text == "Çalışan")
                    komut.Parameters.AddWithValue("@yetki", comboBox1.Text);
                else if (comboBox1.Text == "Müşteri")
                {

                    komut.Parameters.AddWithValue("@yetki", comboBox1.Text);

                    try
                    {
                        SqlCommand komut2 = new SqlCommand("insert into Musteri(ad,soyad,adres,telefon) values (@ad,@soyad,@adres,@telefon)", baglanti);


                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut2.Parameters.AddWithValue("@ad", textBox3.Text);
                        komut2.Parameters.AddWithValue("@soyad", textBox4.Text);
                        komut2.Parameters.AddWithValue("@adres", textBox5.Text);
                        komut2.Parameters.AddWithValue("@telefon", textBox6.Text);

                        komut2.ExecuteNonQuery();

                        baglanti.Close();

                    }

                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }

                }
                else
                    MessageBox.Show("Yetki seçiniz.");



                baglanti.Open();
                komut.ExecuteNonQuery();
                KullanıcıBilgileriGetir();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklenmiştir.");
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem sırasında hata oluştu." + hata.Message);
            }

        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text =="Müşteri")
            {

                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }

            else
            {

                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;

                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kullanıcıBilgileri where kullanıcıAdi = @kullanıcıAdi and sifre=@sifre ", baglanti);
                komut.Parameters.AddWithValue("@kullanıcıAdi", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@sifre", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                KullanıcıBilgileriGetir();

                MessageBox.Show("Müşteri silindi.");

            }

            catch
            {
                MessageBox.Show("Müşteri seçmediniz.");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SilinenKullanıcıBilgileri form1 = new SilinenKullanıcıBilgileri();
            form1.Show();
        }
    }
}
