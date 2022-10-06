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
using System.Data.Sql;

namespace ArabaKiralamaHoşgeldiniz
{
    public partial class KullaniciGiris : Form
    {

        SqlConnection con;
        SqlCommand com;



        public KullaniciGiris()
        {
            InitializeComponent();
        }



        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");
            com = new SqlCommand("select * from kullanıcıBilgileri where kullanıcıAdi = @kullanıcıAdi and sifre = @sifre ", con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.SelectCommand.Parameters.AddWithValue("@kullanıcıAdi", textBox1.Text);
            da.SelectCommand.Parameters.AddWithValue("@sifre", textBox2.Text);
            da.Fill(dt);



            if (dt.Rows.Count > 0)
            {


                //Form1 gecis = new Form1();
                //gecis.Show();
                this.Hide();

                KullaniciBilgileriniTutar degisken = new KullaniciBilgileriniTutar();
               
                degisken.Ad = dt.Rows[0]["kullanıcıAdi"].ToString();
                degisken.Sifre = dt.Rows[0]["sifre"].ToString();
                degisken.Yetki = dt.Rows[0]["yetki"].ToString();

                if (degisken.Yetki == "admin")
                {

                    ((Form1)this.ParentForm).menuStrip1.Visible = true;
                    ((Form1)this.ParentForm).kullanıcıBilgileriToolStripMenuItem.Visible = true;
                    ((Form1)this.ParentForm).arabaToolStripMenuItem.Visible = true;
                    ((Form1)this.ParentForm).müşteriToolStripMenuItem.Visible = true;
                    ((Form1)this.ParentForm).sorgulamaToolStripMenuItem.DropDownItems[0].Visible = true;
                    ((Form1)this.ParentForm).sorgulamaToolStripMenuItem.DropDownItems[1].Visible = true;
                    ((Form1)this.ParentForm).yedeklemeToolStripMenuItem.Visible = true;


                }

                else if (degisken.Yetki == "çalışan")
                {
                    ((Form1)this.ParentForm).menuStrip1.Visible = true;
                    ((Form1)this.ParentForm).arabaToolStripMenuItem.Visible = true;
                    ((Form1)this.ParentForm).müşteriToolStripMenuItem.Visible = true;
                    ((Form1)this.ParentForm).sorgulamaToolStripMenuItem.DropDownItems[0].Visible = true;
                    ((Form1)this.ParentForm).sorgulamaToolStripMenuItem.DropDownItems[1].Visible = true;

                }

                else
                {
                    ((Form1)this.ParentForm).menuStrip1.Visible = true;

                }


                    ((Form1)this.ParentForm).label2.Visible = true;
                    ((Form1)this.ParentForm).label2.Text = "Kullanıcı : " + degisken.Ad;






            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya parola");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtOl form3 = new KayıtOl();
            form3.Show();
            this.Hide();
        }
    }
}
