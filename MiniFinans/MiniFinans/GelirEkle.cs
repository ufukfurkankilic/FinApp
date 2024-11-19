using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniFinans
{
    public partial class GelirEkle : Form
    {
        public GelirEkle()
        {
            InitializeComponent();
        }

        private void GelirEkle_Load(object sender, EventArgs e)
        {
            // Not defterinden veriyi ComboBox'a ekle
            string dosyaYolu = "GelirKategorisi.txt";

            try
            {
                // Dosyayı oku ve her satırı ComboBox'a ekle
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        comboBoxGelirEkle.Items.Add(satir); // Her satırı ComboBox'a ekle
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGelirekle_Click(object sender, EventArgs e)
        {
            // TextBox boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtGelirekleTutar.Text))
            {
                MessageBox.Show("Lütfen bir gelir tutarı girin!");
                return;
            }

            // TextBox'taki veriyi sayıya dönüştürüp geçerli olup olmadığını kontrol et
            if (!decimal.TryParse(txtGelirekleTutar.Text, out decimal gelirTutarı))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
                return;
            }

            // ComboBox boşluk kontrolü
            if (comboBoxGelirEkle.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kategori seçin!");
                return;
            }

            // Gelir açıklaması boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtGelirAçıklama.Text))
            {
                MessageBox.Show("Lütfen bir gelir açıklaması girin!");
                return;
            }

            // Verileri al
            string gelirTarih = dateTimePickerGiderekle.Value.ToString("yyyy-MM-dd"); // Tarihi istediğin formatta alabilirsin
            string gelirKategori = comboBoxGelirEkle.SelectedItem.ToString();
            string GelirTutarı = txtGelirekleTutar.Text;
            string gelirAçıklama = txtGelirAçıklama.Text;

            // Dosya yolları
            string gelirTutarıDosyaYolu = "GelirTutarı.txt";
            string gelirTarihDosyaYolu = "GelirTarih.txt";
            string gelirKategoriDosyaYolu = "GelirKategorisi.txt";
            string gelirAçıklamaDosyaYolu = "GelirAçıklama.txt";

            try
            {
                // GelirTutarı.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(gelirTutarıDosyaYolu, true))
                {
                    sw.WriteLine(gelirTutarı);
                }

                // GelirTarih.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(gelirTarihDosyaYolu, true))
                {
                    sw.WriteLine(gelirTarih);
                }
/*
                // GelirKategorisi.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(gelirKategoriDosyaYolu, true))
                {
                    sw.WriteLine(gelirKategori);
                }
*/
                // GelirAçıklama.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(gelirAçıklamaDosyaYolu, true))
                {
                    sw.WriteLine(gelirAçıklama);
                }

                MessageBox.Show("Veriler başarıyla kaydedildi!");

                // TextBox'ları ve ComboBox'ı temizle
                txtGelirekleTutar.Text = string.Empty;
                txtGelirAçıklama.Text = string.Empty;
                comboBoxGelirEkle.SelectedIndex = -1; // ComboBox seçimini kaldır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }
    }
}
