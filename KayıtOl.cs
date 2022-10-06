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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void KayıtOl_Load(object sender, EventArgs e)
        {
            textBox6.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit1 = "insert into Musteri (ad,soyad,adres,telefon) values (@ad,@soyad,@adres,@telefon)";
                SqlCommand komut = new SqlCommand(kayit1, connect);

                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@adres", textBox3.Text);
                komut.Parameters.AddWithValue("@telefon", textBox4.Text);

                string kayit2 = "insert into kullanıcıBilgileri (kullanıcıAdi,sifre) values (@kullanıcıAdi,@sifre)";
                SqlCommand komut2 = new SqlCommand(kayit2, connect);

                komut2.Parameters.AddWithValue("@kullanıcıAdi", textBox5.Text);
                komut2.Parameters.AddWithValue("@sifre", textBox6.Text);

                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Kayıt oldunuz.Artık üye girişi yapabilirsiniz.");

            }

            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi.Kayıt olma işlemi tamamlanamadı.Lütfen daha sonra tekrar deneyin." + hata.Message);
            }

            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked)
                {
                    textBox6.PasswordChar = '\0';
                }
                else
                {
                    textBox6.PasswordChar = '*';
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBaslangic form3 = new FormBaslangic();
            form3.Show();
            this.Hide();
        }
    }
}
