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
    public partial class Arabaİslemleri : Form
    {
        public Arabaİslemleri()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand komut;


        void ArabaBGetir()
        {
           
            da = new SqlDataAdapter("SELECT * FROM Arac ", baglanti); //tüm kayıtlı araçları gösteren sorgu
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo; //tablodan datagride veri aktar
            baglanti.Close();
        }

        private void Arabaİslemleri_Load(object sender, EventArgs e)
        {


            ArabaBGetir();

            
        }




        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                string sorgu = " INSERT INTO arac (aracplakano, marka, model,renk, kirabedeli, vitestipi, satisyerno)  VALUES" +
               " (@aracplakano, @marka, @model,@renk, @kirabedeli, @vitestipi, @adres)";


                komut = new SqlCommand(sorgu, baglanti);
               

                komut.Parameters.AddWithValue("@aracplakano", textBox1.Text);
                komut.Parameters.AddWithValue("@marka", textBox2.Text);
                komut.Parameters.AddWithValue("@model", textBox3.Text);
                komut.Parameters.AddWithValue("@renk", textBox7.Text);
                komut.Parameters.AddWithValue("@kirabedeli", textBox4.Text);

                if (textBox5.Text != "")
                    komut.Parameters.AddWithValue("@vitestipi", textBox5.Text);

                else
                    komut.Parameters.AddWithValue("@vitestipi", "manuel");



                komut.Parameters.AddWithValue("@adres", textBox6.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                ArabaBGetir();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklenmiştir.");
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem sırasında hata oluştu." + hata.Message);
                baglanti.Close();

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                string sorgu = "DELETE FROM arac WHERE aracplakano= @aracplakano";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@aracplakano", Convert.ToString(textBox1.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                ArabaBGetir();
                baglanti.Close();


                MessageBox.Show("Kayıt Silinmiştir.");

            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem sırasında hata oluştu." + hata.Message);
                baglanti.Close();

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //araç tablosunu aracplakanoya göre güncelle
                string sorgu = "UPDATE arac SET aracplakano= @aracplakano, marka=@marka, model= @model,renk =@renk, kirabedeli= @kirabedeli, vitestipi= @vitestipi, satisyerno= @satisyerno WHERE aracplakano=@aracplakano ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@aracplakano", Convert.ToString(textBox1.Text));
                komut.Parameters.AddWithValue("@marka", textBox2.Text);
                komut.Parameters.AddWithValue("@model", textBox3.Text);
                komut.Parameters.AddWithValue("@renk", textBox7.Text);
                komut.Parameters.AddWithValue("@kirabedeli", textBox4.Text);

                if (textBox5.Text != "")
                    komut.Parameters.AddWithValue("@vitestipi", textBox5.Text);

                else
                    komut.Parameters.AddWithValue("@vitestipi", "manuel");


                komut.Parameters.AddWithValue("@satisyerno", textBox6.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                ArabaBGetir();
                baglanti.Close();

              

                MessageBox.Show("Seçilen Kayıt Güncellenmiştir.");
            }
            catch (Exception hata)
            {

                MessageBox.Show("İşlem sırasında hata oluştu." + hata.Message);
                baglanti.Close();
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SilinenAracBilgileri sarac = new SilinenAracBilgileri();
            sarac.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            exportform frm = new exportform();
            frm.Show();
        }
    }
}
