namespace Bilp224_Hafta4_Ornek01
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
            this.menuAna = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuİzleme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGerial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYinele = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuTumunuSec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHkkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtYazi = new System.Windows.Forms.RichTextBox();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.lblKaydedilmedi = new System.Windows.Forms.Label();
            this.menuAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAna
            // 
            this.menuAna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuYardim});
            this.menuAna.Location = new System.Drawing.Point(0, 0);
            this.menuAna.Name = "menuAna";
            this.menuAna.Size = new System.Drawing.Size(800, 24);
            this.menuAna.TabIndex = 0;
            this.menuAna.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuAc,
            this.toolStripSeparator1,
            this.menuKaydet,
            this.menuFarkliKaydet,
            this.toolStripSeparator2,
            this.menuYazdir,
            this.menuİzleme,
            this.toolStripSeparator3,
            this.menuCikis});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "D&osya";
            // 
            // menuYeni
            // 
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuYeni.Size = new System.Drawing.Size(180, 22);
            this.menuYeni.Text = "Yeni";
            this.menuYeni.Click += new System.EventHandler(this.menuYeni_Click);
            // 
            // menuAc
            // 
            this.menuAc.Name = "menuAc";
            this.menuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuAc.Size = new System.Drawing.Size(180, 22);
            this.menuAc.Text = "Aç";
            this.menuAc.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(180, 22);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // menuFarkliKaydet
            // 
            this.menuFarkliKaydet.Name = "menuFarkliKaydet";
            this.menuFarkliKaydet.Size = new System.Drawing.Size(180, 22);
            this.menuFarkliKaydet.Text = "Farklı Kaydet";
            this.menuFarkliKaydet.Click += new System.EventHandler(this.menuFarkliKaydet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuYazdir
            // 
            this.menuYazdir.Name = "menuYazdir";
            this.menuYazdir.Size = new System.Drawing.Size(180, 22);
            this.menuYazdir.Text = "Yazdır";
            this.menuYazdir.Click += new System.EventHandler(this.menuYazdir_Click);
            // 
            // menuİzleme
            // 
            this.menuİzleme.Name = "menuİzleme";
            this.menuİzleme.Size = new System.Drawing.Size(180, 22);
            this.menuİzleme.Text = "Baskı Ön İzleme";
            this.menuİzleme.Click += new System.EventHandler(this.menuİzleme_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuCikis.Size = new System.Drawing.Size(180, 22);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // menuDuzen
            // 
            this.menuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGerial,
            this.menuYinele,
            this.toolStripSeparator4,
            this.menuKes,
            this.menuKopyala,
            this.menuYapistir,
            this.toolStripSeparator5,
            this.menuTumunuSec});
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(52, 20);
            this.menuDuzen.Text = "Dü&zen";
            // 
            // menuGerial
            // 
            this.menuGerial.Name = "menuGerial";
            this.menuGerial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuGerial.Size = new System.Drawing.Size(182, 22);
            this.menuGerial.Text = "Geri al";
            this.menuGerial.Click += new System.EventHandler(this.menuGerial_Click);
            // 
            // menuYinele
            // 
            this.menuYinele.Name = "menuYinele";
            this.menuYinele.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuYinele.Size = new System.Drawing.Size(182, 22);
            this.menuYinele.Text = "Yinele";
            this.menuYinele.Click += new System.EventHandler(this.menuYinele_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(182, 22);
            this.menuKes.Text = "Kes";
            this.menuKes.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopyala.Size = new System.Drawing.Size(182, 22);
            this.menuKopyala.Text = "Kopyala";
            this.menuKopyala.Click += new System.EventHandler(this.menuKopyala_Click);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(182, 22);
            this.menuYapistir.Text = "Yapıştır";
            this.menuYapistir.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(179, 6);
            // 
            // menuTumunuSec
            // 
            this.menuTumunuSec.Name = "menuTumunuSec";
            this.menuTumunuSec.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuTumunuSec.Size = new System.Drawing.Size(182, 22);
            this.menuTumunuSec.Text = "Tümünü Seç";
            this.menuTumunuSec.Click += new System.EventHandler(this.menuTumunuSec_Click);
            // 
            // menuYardim
            // 
            this.menuYardim.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHkkinda});
            this.menuYardim.Name = "menuYardim";
            this.menuYardim.Size = new System.Drawing.Size(56, 20);
            this.menuYardim.Text = "Yardı&m";
            // 
            // menuHkkinda
            // 
            this.menuHkkinda.Name = "menuHkkinda";
            this.menuHkkinda.Size = new System.Drawing.Size(124, 22);
            this.menuHkkinda.Text = "Hakkında";
            this.menuHkkinda.Click += new System.EventHandler(this.menuHkkinda_Click);
            // 
            // rtxtYazi
            // 
            this.rtxtYazi.Location = new System.Drawing.Point(0, 27);
            this.rtxtYazi.Name = "rtxtYazi";
            this.rtxtYazi.Size = new System.Drawing.Size(800, 424);
            this.rtxtYazi.TabIndex = 1;
            this.rtxtYazi.Text = "";
            this.rtxtYazi.TextChanged += new System.EventHandler(this.rtxtYazi_TextChanged);
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // lblKaydedilmedi
            // 
            this.lblKaydedilmedi.AutoSize = true;
            this.lblKaydedilmedi.Location = new System.Drawing.Point(168, 6);
            this.lblKaydedilmedi.Name = "lblKaydedilmedi";
            this.lblKaydedilmedi.Size = new System.Drawing.Size(16, 13);
            this.lblKaydedilmedi.TabIndex = 2;
            this.lblKaydedilmedi.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKaydedilmedi);
            this.Controls.Add(this.rtxtYazi);
            this.Controls.Add(this.menuAna);
            this.MainMenuStrip = this.menuAna;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuAna.ResumeLayout(false);
            this.menuAna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAna;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuYardim;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuAc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripMenuItem menuFarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuYazdir;
        private System.Windows.Forms.ToolStripMenuItem menuİzleme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem menuGerial;
        private System.Windows.Forms.ToolStripMenuItem menuYinele;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuTumunuSec;
        private System.Windows.Forms.ToolStripMenuItem menuHkkinda;
        private System.Windows.Forms.RichTextBox rtxtYazi;
        private System.Drawing.Printing.PrintDocument belge;
        private System.Windows.Forms.Label lblKaydedilmedi;
    }
}

