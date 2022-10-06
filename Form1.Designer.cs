
namespace ArabaKiralamaHoşgeldiniz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arabaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiradaOlanAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konumaGöreKiralananAraçListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçFiltrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatHesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabaToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.kiralamaToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem,
            this.sorgulamaToolStripMenuItem,
            this.yedeklemeToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.iletişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // arabaToolStripMenuItem
            // 
            this.arabaToolStripMenuItem.Name = "arabaToolStripMenuItem";
            this.arabaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.arabaToolStripMenuItem.Text = "Araba";
            this.arabaToolStripMenuItem.Visible = false;
            this.arabaToolStripMenuItem.Click += new System.EventHandler(this.arabaToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            this.müşteriToolStripMenuItem.Visible = false;
            this.müşteriToolStripMenuItem.Click += new System.EventHandler(this.müşteriToolStripMenuItem_Click);
            // 
            // kiralamaToolStripMenuItem
            // 
            this.kiralamaToolStripMenuItem.Name = "kiralamaToolStripMenuItem";
            this.kiralamaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.kiralamaToolStripMenuItem.Text = "Kiralama";
            this.kiralamaToolStripMenuItem.Click += new System.EventHandler(this.kiralamaToolStripMenuItem_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Visible = false;
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // sorgulamaToolStripMenuItem
            // 
            this.sorgulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiradaOlanAraçlarToolStripMenuItem,
            this.konumaGöreKiralananAraçListesiToolStripMenuItem,
            this.araçFiltrelemeToolStripMenuItem,
            this.fiyatHesaplaToolStripMenuItem});
            this.sorgulamaToolStripMenuItem.Name = "sorgulamaToolStripMenuItem";
            this.sorgulamaToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.sorgulamaToolStripMenuItem.Text = "Sorgulama";
            // 
            // kiradaOlanAraçlarToolStripMenuItem
            // 
            this.kiradaOlanAraçlarToolStripMenuItem.Name = "kiradaOlanAraçlarToolStripMenuItem";
            this.kiradaOlanAraçlarToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.kiradaOlanAraçlarToolStripMenuItem.Text = "Belirlenen Tarihte Kiralanan Arabalar Listesi";
            this.kiradaOlanAraçlarToolStripMenuItem.Visible = false;
            this.kiradaOlanAraçlarToolStripMenuItem.Click += new System.EventHandler(this.kiradaOlanAraçlarToolStripMenuItem_Click);
            // 
            // konumaGöreKiralananAraçListesiToolStripMenuItem
            // 
            this.konumaGöreKiralananAraçListesiToolStripMenuItem.Name = "konumaGöreKiralananAraçListesiToolStripMenuItem";
            this.konumaGöreKiralananAraçListesiToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.konumaGöreKiralananAraçListesiToolStripMenuItem.Text = "Konuma Göre Kiralanan Araba Listesi";
            this.konumaGöreKiralananAraçListesiToolStripMenuItem.Visible = false;
            this.konumaGöreKiralananAraçListesiToolStripMenuItem.Click += new System.EventHandler(this.konumaGöreKiralananAraçListesiToolStripMenuItem_Click);
            // 
            // araçFiltrelemeToolStripMenuItem
            // 
            this.araçFiltrelemeToolStripMenuItem.Name = "araçFiltrelemeToolStripMenuItem";
            this.araçFiltrelemeToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.araçFiltrelemeToolStripMenuItem.Text = "Araba Filtreleme";
            this.araçFiltrelemeToolStripMenuItem.Click += new System.EventHandler(this.araçFiltrelemeToolStripMenuItem_Click);
            // 
            // fiyatHesaplaToolStripMenuItem
            // 
            this.fiyatHesaplaToolStripMenuItem.Name = "fiyatHesaplaToolStripMenuItem";
            this.fiyatHesaplaToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.fiyatHesaplaToolStripMenuItem.Text = "Kiralanan Arabanın Kirasını Hesapla";
            this.fiyatHesaplaToolStripMenuItem.Click += new System.EventHandler(this.fiyatHesaplaToolStripMenuItem_Click);
            // 
            // yedeklemeToolStripMenuItem
            // 
            this.yedeklemeToolStripMenuItem.Name = "yedeklemeToolStripMenuItem";
            this.yedeklemeToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.yedeklemeToolStripMenuItem.Text = "Backup ve Restore";
            this.yedeklemeToolStripMenuItem.Visible = false;
            this.yedeklemeToolStripMenuItem.Click += new System.EventHandler(this.yedeklemeToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(891, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::ArabaKiralamaHoşgeldiniz.Properties.Resources.Ekran_Alıntısı1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kiralamaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sorgulamaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yedeklemeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kiradaOlanAraçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem konumaGöreKiralananAraçListesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçFiltrelemeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fiyatHesaplaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem arabaToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

