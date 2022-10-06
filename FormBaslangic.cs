using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaKiralamaHoşgeldiniz
{
    public partial class FormBaslangic : Form
    {
        public FormBaslangic()
        {
            InitializeComponent();
        }

        private void FormBaslangic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form3 = new Form1();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtOl form3 = new KayıtOl();
            form3.Show();
            this.Hide();
        }
    }
}
