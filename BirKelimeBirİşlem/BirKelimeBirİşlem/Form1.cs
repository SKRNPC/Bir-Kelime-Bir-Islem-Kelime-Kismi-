using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirKelimeBirİşlem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            // Dosya yolu ve adı
            string dosyaYolu = "C:\\Users\\sinan\\Desktop\\Yazılım Yapımı\\BirKelimeBirİşlem\\Kelimeler\\kelimeler.txt";

            // Dosya var mı yok mu kontrolü
            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Dosya bulunamadı.");
                return;
            }

            // Dosyayı oku
            string dosyaIcerigi = File.ReadAllText(dosyaYolu);

            // Dosyadaki kelimeleri ayır
            kelimeler = dosyaIcerigi.Split(new[] { ' ','\t','\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Kelimeleri listeye ekle
            
            kelimelerListesi.AddRange(kelimeler);
            
            
            
        }
        List<string> kelimelerListesi = new List<string>();
        string[] kelimeler;
        char[] girilenHarf;


        char[] karakter = new char[9];
        
        
        public void Temizle()
        {
            lstKelimeler.Items.Clear();
            txtHarf1.Clear();
            txtHarf2.Clear();
            txtHarf3.Clear();
            txtHarf4.Clear();
            txtHarf5.Clear();
            txtHarf6.Clear();
            txtHarf7.Clear();
            txtHarf8.Clear();
            txtHarf9.Clear();
        }
        public void RandomHarf()
        {
            Random rastgele = new Random();
            char[] karakter = new char[9];

            for (int i = 0; i < 9; i++)
            {
                string harfler = "abcçdefgğhıijklmnoöprsştuüvyz";
                int sayi = rastgele.Next(0, 29);
                char harf = Convert.ToChar(harfler.Substring(sayi, 1));
                karakter[i] = harf;
            }
            txtHarf1.Text = karakter[0].ToString();
            txtHarf2.Text = karakter[1].ToString();
            txtHarf3.Text = karakter[2].ToString();
            txtHarf4.Text = karakter[3].ToString();
            txtHarf5.Text = karakter[4].ToString();
            txtHarf6.Text = karakter[5].ToString();
            txtHarf7.Text = karakter[6].ToString();
            txtHarf8.Text = karakter[7].ToString();
            txtHarf9.Text = karakter[8].ToString();
            
        }
        public void KelimeBul()
        {
                girilenHarf = new char[] { Convert.ToChar(txtHarf1.Text), Convert.ToChar(txtHarf2.Text),
                Convert.ToChar(txtHarf3.Text),Convert.ToChar(txtHarf4.Text), Convert.ToChar(txtHarf5.Text),
                Convert.ToChar(txtHarf6.Text), Convert.ToChar(txtHarf7.Text),
                Convert.ToChar(txtHarf8.Text), Convert.ToChar(txtHarf9.Text),};

            HashSet<string> eklenenKelimeler = new HashSet<string>();
            foreach (string kelime in kelimelerListesi)
            {
                bool uygun = true;
                foreach (char harf in kelime)
                {
                    if (!girilenHarf.Contains(harf))
                    {
                        uygun = false;
                        break;
                    }
                }
                // Kelime sadece seçilen harfleri içeriyorsa ve tam bir kelimeyse, ListBox'a ekleyin
                if (uygun && !eklenenKelimeler.Contains(kelime)&&kelime.Length>2)
                {
                    lstKelimeler.Items.Add(kelime);
                    eklenenKelimeler.Add(kelime);
                }
            }
        }



    

                

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomHarf();
            lstKelimeler.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //KelimeYazdir();
        }

        private void btnKelime_Click(object sender, EventArgs e)
        {
            KelimeBul();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}

