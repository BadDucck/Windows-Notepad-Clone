using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilp224_Hafta4_Ornek01
{
    public partial class Form1 : Form
    {
        string dosyaAdi = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istediğinizden emin misiniz?","ÇIKIŞ UYARISI", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuTumunuSec_Click(object sender, EventArgs e)
        {
            rtxtYazi.SelectAll();
        }

        private void menuKes_Click(object sender, EventArgs e)
        {
            rtxtYazi.Cut();
            menuYapistir.Enabled = true;
        }

        private void menuKopyala_Click(object sender, EventArgs e)
        {
            rtxtYazi.Copy();
            menuYapistir.Enabled=true;
        }

        private void menuYapistir_Click(object sender, EventArgs e)
        {
            rtxtYazi.Paste();
        }

        private void menuGerial_Click(object sender, EventArgs e)
        {
            rtxtYazi.Undo();
        }

        private void menuYinele_Click(object sender, EventArgs e)
        {
            rtxtYazi.Redo();
        }

        private void menuHkkinda_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void menuAc_Click(object sender, EventArgs e)
        {           
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Filter = "Text Dosyaları | *.txt";
            dosyaAc.FileName = "Bir Dosya Seç";
            dosyaAc.Title = "Lütfen bir metin dosyası seçin"; // Gelen klasörün
            DialogResult result = dosyaAc.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                rtxtYazi.LoadFile(dosyaAc.FileName,RichTextBoxStreamType.PlainText);
                dosyaAdi = dosyaAc.FileName;

            }
        }

        private void menuKaydet_Click(object sender, EventArgs e)
        {
            if (dosyaAdi=="")
            {
                SaveFileDialog dosyaKaydet = new SaveFileDialog();
                dosyaKaydet.Filter = "Text Dosyaları | *.txt | Tüm dosyalar | *.*";
                DialogResult sonuc = dosyaKaydet.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    rtxtYazi.SaveFile(dosyaKaydet.FileName, RichTextBoxStreamType.PlainText);
                    dosyaAdi = dosyaKaydet.FileName;
                    menuKaydet.Enabled = false;
                    lblKaydedilmedi.Text = "Dosya Kaydedildi";
                }
            }else 
            {
                rtxtYazi.SaveFile(dosyaAdi, RichTextBoxStreamType.PlainText);
                lblKaydedilmedi.Text = "Dosya Kaydedildi";

            }
        }

        private void menuFarkliKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            dosyaKaydet.Filter = "Text Dosyaları | *.txt | Tüm dosyalar | *.*";
            DialogResult sonuc = dosyaKaydet.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                rtxtYazi.SaveFile(dosyaKaydet.FileName, RichTextBoxStreamType.PlainText);
                string dosyaAdi = dosyaKaydet.FileName;
                lblKaydedilmedi.Text = "Dosya Kaydedildi";

            }
            menuKaydet.Enabled = false;
        }

        private void menuYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog dosyaYaz = new PrintDialog();
            DialogResult sonuc = dosyaYaz.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                belge.Print();
            }
            

        }

        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtYazi.Text, rtxtYazi.Font, Brushes.Black, new Point(100, 100));
        }

        private void menuİzleme_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onIzleme = new PrintPreviewDialog();
            onIzleme.Document = belge;
            if(onIzleme.ShowDialog() == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void menuYeni_Click(object sender, EventArgs e)
        {
            rtxtYazi.Clear();
            dosyaAdi = "";
        }

        private void rtxtYazi_TextChanged(object sender, EventArgs e)
        {
            menuKaydet.Enabled = true;
            lblKaydedilmedi.Text = "Kaydedilmemiş Dosyaınız Var";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuYapistir.Enabled = false;
        }
    }
}
