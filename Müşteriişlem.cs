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
    public partial class Müşteriişlem : Form
    {
        public Müşteriişlem()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into Musteri(ad,soyad,adres,telefon) values (@ad,@soyad,@adres,@telefon)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@adres", textBox3.Text);
                komut.Parameters.AddWithValue("@telefon", textBox4.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

                //silme ve güncelleme sekmelerindeki listview içinde yeni eklenen kaydı da ekleme

                listView1.Items.Clear();
                listView2.Items.Clear();


                SqlCommand komut2 = new SqlCommand("select * from Musteri", baglanti);

                SqlDataAdapter adap = new SqlDataAdapter(komut2);
                DataTable tablo = new DataTable();

                adap.Fill(tablo);

                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView1.Items.Add(tablo.Rows[i]["musno"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["adres"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["telefon"].ToString());

                }


                SqlDataAdapter adap2 = new SqlDataAdapter(komut2);
                DataTable tablo2 = new DataTable();

                adap2.Fill(tablo2);

                for (int i = 0; i < tablo2.Rows.Count; i++)
                {
                    listView2.Items.Add(tablo2.Rows[i]["musno"].ToString());
                    listView2.Items[i].SubItems.Add(tablo2.Rows[i]["ad"].ToString());
                    listView2.Items[i].SubItems.Add(tablo2.Rows[i]["soyad"].ToString());
                    listView2.Items[i].SubItems.Add(tablo2.Rows[i]["adres"].ToString());
                    listView2.Items[i].SubItems.Add(tablo2.Rows[i]["telefon"].ToString());

                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
        }

        private void Müşteriişlem_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Musteri", baglanti);

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["musno"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["adres"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["telefon"].ToString());

            }


            SqlDataAdapter adap2 = new SqlDataAdapter(komut);
            DataTable tablo2 = new DataTable();

            adap2.Fill(tablo2);

            for (int i = 0; i < tablo2.Rows.Count; i++)
            {
                listView2.Items.Add(tablo2.Rows[i]["musno"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["ad"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["soyad"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["adres"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["telefon"].ToString());

            }


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Musteri where musno = @musno ", baglanti);
                komut.Parameters.AddWithValue("@musno", Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Müşteri silindi.");
                

            }

            catch
            {
                MessageBox.Show("Müşteri seçmediniz.");
            }




            listView1.Items.Clear();
            listView2.Items.Clear();


            SqlCommand komut2 = new SqlCommand("select * from Musteri", baglanti);

            SqlDataAdapter adap = new SqlDataAdapter(komut2);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["musno"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["adres"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["telefon"].ToString());

            }



            SqlDataAdapter adap2 = new SqlDataAdapter(komut2);
            DataTable tablo2 = new DataTable();

            adap2.Fill(tablo2);

            for (int i = 0; i < tablo2.Rows.Count; i++)
            {
                listView2.Items.Add(tablo2.Rows[i]["musno"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["ad"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["soyad"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["adres"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["telefon"].ToString());

            }



        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                SqlCommand komut3 = new SqlCommand("select * from Musteri where ad=@ad", baglanti);

                komut3.Parameters.AddWithValue("@ad", textBox5.Text);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();


                listView1.Items.Clear();

                SqlDataAdapter adap = new SqlDataAdapter(komut3);
                DataTable tablo = new DataTable();

                adap.Fill(tablo);

                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView1.Items.Add(tablo.Rows[i]["musno"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["adres"].ToString());
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["telefon"].ToString());

                }


                textBox5.Text = "";

            }

            else
            {
                MessageBox.Show("Lütfen isim giriniz.");
            }
        }



        int musno;


        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 musno = Convert.ToInt32(listView2.SelectedItems[0].Text);

                textBox6.Text = listView2.SelectedItems[0].Text;
                textBox7.Text = listView2.SelectedItems[0].SubItems[1].Text;
                textBox8.Text = listView2.SelectedItems[0].SubItems[2].Text;
                textBox9.Text = listView2.SelectedItems[0].SubItems[3].Text;
                textBox10.Text = listView2.SelectedItems[0].SubItems[4].Text;
            }

            catch
            {

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            SqlCommand komut = new SqlCommand("update Musteri set  ad=@ad,soyad=@soyad,adres=@adres,telefon=@telefon where musno=@musno", baglanti);

           // komut.Parameters.AddWithValue("@musno", Convert.ToInt32(textBox6.Text));
            komut.Parameters.AddWithValue("@ad", textBox7.Text);
            komut.Parameters.AddWithValue("@soyad", textBox8.Text);
            komut.Parameters.AddWithValue("@adres", textBox9.Text);
            komut.Parameters.AddWithValue("@telefon", textBox10.Text);
            komut.Parameters.AddWithValue("@musno", musno);

            baglanti.Open();
            komut.ExecuteNonQuery();




            // MessageBox.Show("Müşteri bilgileri güncellenmiştir.");





            listView1.Items.Clear();
            listView2.Items.Clear();


            SqlCommand komut2 = new SqlCommand("select * from Musteri", baglanti);

            SqlDataAdapter adap = new SqlDataAdapter(komut2);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["musno"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["adres"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["telefon"].ToString());

            }



            SqlDataAdapter adap2 = new SqlDataAdapter(komut2);
            DataTable tablo2 = new DataTable();

            adap2.Fill(tablo2);

            for (int i = 0; i < tablo2.Rows.Count; i++)
            {
                listView2.Items.Add(tablo2.Rows[i]["musno"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["ad"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["soyad"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["adres"].ToString());
                listView2.Items[i].SubItems.Add(tablo2.Rows[i]["telefon"].ToString());

            }

            komut2.ExecuteNonQuery();

            baglanti.Close();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
