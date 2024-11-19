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
    public partial class AktiviteEkle : Form
    {
        public AktiviteEkle()
        {
            InitializeComponent();
        }

        private void comboBoxGiderEkle_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnGiderekle_Click(object sender, EventArgs e)
        {
            // TextBox boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtGiderekleTutar.Text))
            {
                MessageBox.Show("Lütfen bir gider tutarı girin!");
                return;
            }

            // TextBox'taki veriyi sayıya dönüştürüp geçerli olup olmadığını kontrol et
            if (!decimal.TryParse(txtGiderekleTutar.Text, out decimal giderTutarı))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
                return;
            }

            // ComboBox boşluk kontrolü
            if (comboBoxGiderEkle.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kategori seçin!");
                return;
            }

            // Gider açıklaması boşluk kontrolü
            if (string.IsNullOrWhiteSpace(txtGiderAçıklama.Text))
            {
                MessageBox.Show("Lütfen bir gider açıklaması girin!");
                return;
            }

            // Verileri al
            string giderTarih = dateTimePickerGiderekle.Value.ToString("yyyy-MM-dd"); // Tarihi istediğin formatta alabilirsin
            string giderKategori = comboBoxGiderEkle.SelectedItem.ToString();
            string giderAçıklama = txtGiderAçıklama.Text;

            // Dosya yolları
            string giderTutarıDosyaYolu = "GiderTutarı.txt";
            string giderTarihDosyaYolu = "GiderTarih.txt";
            string giderKategoriDosyaYolu = "GiderKategorisi.txt";
            string giderAçıklamaDosyaYolu = "GiderAçıklama.txt";

            try
            {
                // GiderTutarı.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(giderTutarıDosyaYolu, true))
                {
                    sw.WriteLine(giderTutarı);
                }

                // GiderTarih.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(giderTarihDosyaYolu, true))
                {
                    sw.WriteLine(giderTarih);
                }

              /*  // GiderKategorisi.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(giderKategoriDosyaYolu, true))
                {
                    sw.WriteLine(giderKategori);
                }
                */
                // GiderAçıklama.txt dosyasına yaz
                using (StreamWriter sw = new StreamWriter(giderAçıklamaDosyaYolu, true))
                {
                    sw.WriteLine(giderAçıklama);
                }

                MessageBox.Show("Veriler başarıyla kaydedildi!");

                // TextBox'ları ve ComboBox'ı temizle
                txtGiderekleTutar.Text = string.Empty;
                txtGiderAçıklama.Text = string.Empty;
                comboBoxGiderEkle.SelectedIndex = -1; // ComboBox seçimini kaldır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void AktiviteEkle_Load(object sender, EventArgs e)
        {
            // Not defterinden veriyi ComboBox'a ekle
            string dosyaYolu = "GiderKategorisi.txt";

            try
            {
                // Dosyayı oku ve her satırı ComboBox'a ekle
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        comboBoxGiderEkle.Items.Add(satir); // Her satırı ComboBox'a ekle
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void txtGiderekleTutar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
