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
    public partial class KiralamaSayfası : Form
    {

        public KiralamaSayfası()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");



        private void KiralamaSayfası_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "KİRALAMA SAYFASI";
            tabPage2.Text = "SİL";
            tabPage3.Text = "GÜNCELLE";


            aracListesiniYukle();
            silmeListesiniYukle();
            guncellemeListesiniYukle();

        }


        private void aracListesiniYukle()
        {
            try
            {
               listView1.Items.Clear();
                SqlCommand komut = new SqlCommand("select aracplakano,marka,model,renk,kirabedeli,vitestipi,satisyerno from arac where Durum ='Boş' ", baglanti);

                SqlDataAdapter adap = new SqlDataAdapter(komut);
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
                    listView1.Items[i].SubItems.Add(tablo.Rows[i]["satisyerno"].ToString());
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu ! "+ hata.Message);
            }
            
        }


        private void silmeListesiniYukle()
        {
            try
            {
                listView2.Items.Clear();
                SqlCommand komut = new SqlCommand("select k.aracplakano,k.KiraBaslangıc,k.TeslimEdilenGün,k.kiraNo,m.ad, m.soyad from kiralama k inner join Musteri m on m.musno= k.musno ", baglanti);

                SqlDataAdapter adap = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();

                adap.Fill(tablo);

                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView2.Items.Add(tablo.Rows[i]["aracplakano"].ToString());
                    listView2.Items[i].SubItems.Add(tablo.Rows[i]["KiraBaslangıc"].ToString());
                    listView2.Items[i].SubItems.Add(tablo.Rows[i]["TeslimEdilenGün"].ToString());
                    listView2.Items[i].SubItems.Add(tablo.Rows[i]["kiraNo"].ToString());
                    listView2.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                    listView2.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu ! " + hata.Message);
            }

        }


        private void guncellemeListesiniYukle()
        {
            try
            {
                listView3.Items.Clear();
                SqlCommand komut = new SqlCommand("select k.aracplakano," +
                    "k.KiraBaslangıc,k.TeslimEdilenGün,k.kiraNo,m.ad," +
                    " m.soyad from kiralama k inner join Musteri m" +
                    " on m.musno= k.musno  ", baglanti);

                SqlDataAdapter adap = new SqlDataAdapter(komut);
                DataTable tablo = new DataTable();

                adap.Fill(tablo);

                for (int i = 0; i < tablo.Rows.Count; i++)
                {
                    listView3.Items.Add(tablo.Rows[i]["aracplakano"].ToString());
                    listView3.Items[i].SubItems.Add(tablo.Rows[i]["KiraBaslangıc"].ToString());
                    listView3.Items[i].SubItems.Add(tablo.Rows[i]["TeslimEdilenGün"].ToString());
                    listView3.Items[i].SubItems.Add(tablo.Rows[i]["kiraNo"].ToString());
                    listView3.Items[i].SubItems.Add(tablo.Rows[i]["ad"].ToString());
                    listView3.Items[i].SubItems.Add(tablo.Rows[i]["soyad"].ToString());
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu ! " + hata.Message);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Lütfen listeden araç seçiniz.");
                else
                {
                    if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
                        MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz.");
                    else
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        string kayit = "insert into kiralama(KiraBaslangıc,TeslimEdilenGün,musno,aracplakano)" +
                            " values (@baslangic,@bitis, (select musno from Musteri where ad= @ad) ,@plaka)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);

                        komut.Parameters.AddWithValue("@baslangic", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@bitis", dateTimePicker2.Value);
                        komut.Parameters.AddWithValue("@ad", textBox4.Text);
                        komut.Parameters.AddWithValue("@plaka", textBox1.Text);

                        komut.ExecuteNonQuery();

                        baglanti.Close();
                        MessageBox.Show("Araç Kiralama İşlemi Gerçekleşti.");

                        aracListesiniYukle();

                        silmeListesiniYukle();

                        guncellemeListesiniYukle();

                    }
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu ! " + hata.Message);
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem secim in listView2.SelectedItems)
                    {
                        string kiraNo = secim.SubItems[3].Text;
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("delete from kiralama where kiraNo = @kiraNo ", baglanti);
                        komut.Parameters.AddWithValue("@kiraNo", Convert.ToInt32(kiraNo));
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    MessageBox.Show("Araç kiralama kayıtları silindi.");
                    aracListesiniYukle();
                    silmeListesiniYukle();
                    guncellemeListesiniYukle();
                }
            }

            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu ! " + hata.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                    MessageBox.Show("Lütfen listeden eleman seçiniz.");
                else
                {
                    if (dateTimePicker4.Value.Date > dateTimePicker3.Value.Date)
                        MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz.");
                    else
                    {
                        string kiraNo = textBox2.Text;
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update Kiralama set KiraBaslangıc = @baslangic, " +
                            "TeslimEdilenGün = @bitis" +
                            " where aracplakano = @plaka and " +
                            "musno = (select k.musno from kiralama k inner join Musteri m on m.musno= k.musno where m.ad= @ad)", baglanti);

                        komut.Parameters.AddWithValue("@baslangic", dateTimePicker4.Value);
                        komut.Parameters.AddWithValue("@bitis", dateTimePicker3.Value);
                        komut.Parameters.AddWithValue("@ad", textBox3.Text);
                        komut.Parameters.AddWithValue("@plaka", textBox2.Text);

                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Araç kiralama kaydı güncellendi.");
                        aracListesiniYukle();
                        silmeListesiniYukle();
                        guncellemeListesiniYukle();

                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata Oluştu ! " + hata.Message);
            }

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                textBox2.Text = listView3.SelectedItems[0].SubItems[0].Text;
                dateTimePicker4.Value = DateTime.Parse(listView3.SelectedItems[0].SubItems[1].Text);
                dateTimePicker3.Value = DateTime.Parse(listView3.SelectedItems[0].SubItems[2].Text);
                textBox3.Text = listView3.SelectedItems[0].SubItems[4].Text;



            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
