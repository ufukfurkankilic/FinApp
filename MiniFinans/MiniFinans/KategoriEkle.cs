using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniFinans
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }


        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            // TextBox'tan veriyi al
            string veri = txtGiderKategori.Text;

            // Not defterine (örneğin "GiderKategorisi.txt" dosyasına) yaz
            string dosyaYolu = "GiderKategorisi.txt";

            // Dosyada aynı verinin olup olmadığını kontrol et
            if (File.Exists(dosyaYolu))
            {
                // Dosyadaki mevcut verileri oku
                string[] mevcutVeriler = File.ReadAllLines(dosyaYolu);

                // Dosyadaki mevcut verilerle karşılaştırma yap
                if (Array.Exists(mevcutVeriler, element => element.Equals(veri, StringComparison.OrdinalIgnoreCase)))
                {
                    // Eğer veri dosyada mevcutsa, kullanıcıya mesaj göster
                    MessageBox.Show("Bu kategori zaten mevcut.");
                    return; // İşlemi durdur
                }
            }

            // Dosyaya yazma işlemi
            try
            {
                // Dosyaya ekleme modu ile yazma işlemi
                using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
                {
                    sw.WriteLine(veri); // TextBox'tan alınan veriyi dosyaya yaz
                }

                // Başarı mesajı
                MessageBox.Show("Veri başarıyla kaydedildi!");

                // TextBox'ı temizle
                txtGiderKategori.Text = string.Empty;
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }


        }

        private void btnGelirKategoriEkle_Click(object sender, EventArgs e)
        {
            // TextBox'tan veriyi al
            string veri = txtGelirKategori.Text;

            // Eğer TextBox boşsa, uyarı mesajı göster
            if (string.IsNullOrWhiteSpace(veri))
            {
                MessageBox.Show("Kategori adı boş olamaz!");
                return; // Veri ekleme işlemine devam etme
            }

            // Not defterine (örneğin "GelirKategorisi.txt" dosyasına) yaz
            string dosyaYolu = "GelirKategorisi.txt";

            try
            {
                // Dosya varsa, mevcut verileri oku
                if (File.Exists(dosyaYolu))
                {
                    // Dosyadaki tüm satırları oku
                    string[] mevcutVeriler = File.ReadAllLines(dosyaYolu);

                    // Girilen veri, dosyadaki verilerle karşılaştırılır
                    if (Array.Exists(mevcutVeriler, item => item.Equals(veri, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("Bu kategori zaten mevcut!");
                    }
                    else
                    {
                        // Dosyaya ekleme modu ile veri yazılır
                        using (StreamWriter sw = new StreamWriter(dosyaYolu, true)) // Dosyaya ekleme modu
                        {
                            sw.WriteLine(veri); // TextBox'tan alınan veriyi satır olarak ekle
                        }

                        MessageBox.Show("Veri başarıyla kaydedildi!");
                    }
                }
                else
                {
                    // Dosya yoksa, yeni dosya oluşturulup veri yazılır
                    using (StreamWriter sw = new StreamWriter(dosyaYolu))
                    {
                        sw.WriteLine(veri);
                    }

                    MessageBox.Show("Veri başarıyla kaydedildi!");
                }

                // TextBox'ı temizle
                txtGelirKategori.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }



        }
    }
}
