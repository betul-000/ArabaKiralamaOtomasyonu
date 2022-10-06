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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");
        
        

        private void arabaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arabaİslemleri form2 = new Arabaİslemleri();
            form2.MdiParent = this;//bu formu parent olarak veriyoruz.
            form2.Show();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Müşteriişlem form2 = new Müşteriişlem();
            form2.MdiParent = this;//bu formu parent olarak veriyoruz.
            form2.Show();
        }

        private void yedeklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yedekleme_YedektenDön form3 = new Yedekleme_YedektenDön();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void kiradaOlanAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TariheGöreKiralananAracListesi form3 = new TariheGöreKiralananAracListesi();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void konumaGöreKiralananAraçListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YereGöreKiralananArac form3 = new YereGöreKiralananArac();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void araçFiltrelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ArabaFiltreleme form3 = new ArabaFiltreleme();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            KullaniciGiris frm_Giris = new KullaniciGiris();
            frm_Giris.MdiParent = this;
            frm_Giris.Show();
        }

        private void fiyatHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiyatHesapla form3 = new FiyatHesapla();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında form3 = new Hakkında();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {

            iletisim form3 = new iletisim();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıBilgileri form3 = new KullanıcıBilgileri();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBaslangic frm = new FormBaslangic();
            frm.Show();
            this.Hide();
        
        }

        private void kiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaSayfası form3 = new KiralamaSayfası();
            form3.MdiParent = this;//bu formu parent olarak veriyoruz.
            form3.Show();
        }
    }
}
