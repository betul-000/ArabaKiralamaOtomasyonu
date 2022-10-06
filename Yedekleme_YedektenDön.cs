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
    public partial class Yedekleme_YedektenDön : Form
    {
        public Yedekleme_YedektenDön()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS01;Initial Catalog=ArabaKiralama;Integrated Security=True");

        private void Yedekleme_YedektenDön_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();

            if(dig.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = dig.SelectedPath;
                //button2.Enabled = true;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String database = con.Database.ToString();
            if(textBox1.Text== string.Empty)
            {
                MessageBox.Show("Lütfen backup dosyası giriniz.");
            }

            else
            {
                string cmd = "backup database [" + database + "] to disk = '" + textBox1.Text + "\\" + "ArabaKiralama" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Veritabanın başarılı bir şekilde yedeği alınmıştır");
                con.Close();

               //button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|.bak";
            dlg.Title = "database restore";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                //button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {
                string str1 = string.Format("alter database [" + database + "] set single_user with rollback immediate");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "use master restore database [" + database + "] from disk ='" + textBox2.Text + "' with replace;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();


                string str3 = string.Format("alter database [" + database + "] set multi_user");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("veritabanı başarılı bir şekile yüklenmiştir.");

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
