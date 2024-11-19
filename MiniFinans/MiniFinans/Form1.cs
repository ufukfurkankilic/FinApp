using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace MiniFinans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            AktiviteEkle giderekle = new AktiviteEkle();
            giderekle.Show();

        }

        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriEkle = new KategoriEkle();
            kategoriEkle.Show();
        }
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));

                lblDolar.Text = dolar.ToString();
                lblEuro.Text = euro.ToString();

            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView'e sütun ekle
            dataGridView2.Columns.Add("Tarih", "Tarih");
            dataGridView2.Columns.Add("Tutar", "Tutar");
            dataGridView2.Columns.Add("Açıklama", "Açıklama");
            dataGridView2.Columns[0].Width = 70;
            dataGridView2.Columns[1].Width = 70;
            dataGridView2.Columns[2].Width = 101;

            dataGridView1.Columns.Add("Tarih", "Tarih");
            dataGridView1.Columns.Add("Tutar", "Tutar");
            dataGridView1.Columns.Add("Açıklama", "Açıklama");
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 99;
            double GiderToplam = 0;
            double GelirToplam = 0;

        }

        public double toplamGider = 0;
        private void btnlistele_Click(object sender, EventArgs e)
        {// DataGridView'i temizle
         // DataGridView'i temizle
            dataGridView2.Rows.Clear();

            // DateTimePicker1'den seçilen tarihi al
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Dosya yollarını belirle
            string dosyaYoluTarih = "GiderTarih.txt";
            string dosyaYoluTutar = "GiderTutarı.txt";
            string dosyaYoluAciklama = "GiderAçıklama.txt";

            // Dosyaların varlığını kontrol et ve satırları oku
            if (File.Exists(dosyaYoluTarih) && File.Exists(dosyaYoluTutar) && File.Exists(dosyaYoluAciklama))
            {
                try
                {
                    // Her dosyadaki satırları oku
                    string[] tarihSatirlar = File.ReadAllLines(dosyaYoluTarih);
                    string[] tutarSatirlar = File.ReadAllLines(dosyaYoluTutar);
                    string[] aciklamaSatirlar = File.ReadAllLines(dosyaYoluAciklama);

                    // Dosyaların uzunluklarının eşit olup olmadığını kontrol et
                    if (tarihSatirlar.Length == tutarSatirlar.Length && tutarSatirlar.Length == aciklamaSatirlar.Length)
                    {
                        // Tutarların toplamını hesaplamak için bir değişken
                        double toplamTutar = 0;

                        // Her satırı DataGridView'e ekle (tarih, tutar ve açıklama)
                        for (int i = 0; i < tarihSatirlar.Length; i++)
                        {
                            // Dosyadaki tarihlerle DateTimePicker'dan seçilen tarihi karşılaştır
                            if (DateTime.TryParse(tarihSatirlar[i], out DateTime tarih) && tarih.Date == selectedDate)
                            {
                                // Tutarı double'a çevir ve toplamı güncelle
                                double tutar = 0;
                                if (double.TryParse(tutarSatirlar[i], out tutar))
                                {
                                    toplamTutar += tutar;
                                }

                                // DataGridView'e satır ekle (tarih, tutar, açıklama)
                                dataGridView2.Rows.Add(tarih.ToShortDateString(), tutarSatirlar[i], aciklamaSatirlar[i]);
                            }
                        }

                        // Toplam tutarı public değişkene ata ve en alt satıra ekle
                        toplamGider = toplamTutar;
                        dataGridView2.Rows.Add("Toplam", toplamTutar.ToString("0.00"), "");

                        // Toplam gideri Label7'ye yaz
                        label7.Text = "₺ " + toplamGider.ToString("N0");

                        MessageBox.Show("Veriler başarıyla yüklendi!");
                    }
                    else
                    {
                        MessageBox.Show("Dosyalar arasında satır sayısı uyumsuzluğu var. Lütfen dosyaları kontrol edin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bazı dosyalar bulunamadı. Lütfen dosyaların mevcut olduğundan emin olun.");
            }


        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            GelirEkle gelirEkle = new GelirEkle();
            gelirEkle.ShowDialog();
        }
        public double toplamGelir = 0;
        private void btnGelirListele_Click(object sender, EventArgs e)
        {
            // DataGridView'i temizle
            dataGridView1.Rows.Clear();

            // DateTimePicker1'den seçilen tarihi al
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Dosya yollarını belirle
            string dosyaYoluTarih = "GelirTarih.txt";
            string dosyaYoluTutar = "GelirTutarı.txt";
            string dosyaYoluAçıklama = "GelirAçıklama.txt";

            // Dosyaların varlığını kontrol et ve satırları oku
            if (File.Exists(dosyaYoluTarih) && File.Exists(dosyaYoluTutar) && File.Exists(dosyaYoluAçıklama))
            {
                try
                {
                    // Her dosyadaki satırları oku
                    string[] tarihSatirlar = File.ReadAllLines(dosyaYoluTarih);
                    string[] tutarSatirlar = File.ReadAllLines(dosyaYoluTutar);
                    string[] açıklamaSatirlar = File.ReadAllLines(dosyaYoluAçıklama);

                    // Dosyaların uzunluklarının eşit olup olmadığını kontrol et
                    if (tarihSatirlar.Length == tutarSatirlar.Length && tarihSatirlar.Length == açıklamaSatirlar.Length)
                    {
                        // Tutarların toplamını hesaplamak için bir değişken
                        double toplamTutar = 0;

                        // Her satırı DataGridView'e ekle (tarih, tutar, açıklama)
                        for (int i = 0; i < tarihSatirlar.Length; i++)
                        {
                            // Dosyadaki tarihlerle DateTimePicker'dan seçilen tarihi karşılaştır
                            if (DateTime.TryParse(tarihSatirlar[i], out DateTime tarih) && tarih.Date == selectedDate)
                            {
                                // Tutarı double'a çevir ve toplamı güncelle
                                double tutar = 0;
                                if (double.TryParse(tutarSatirlar[i], out tutar))
                                {
                                    toplamTutar += tutar;
                                }
                                else
                                {
                                    // Eğer tutar geçerli bir sayı değilse, hata mesajı ver
                                    MessageBox.Show($"Geçersiz tutar: {tutarSatirlar[i]}");
                                }

                                // DataGridView'e satır ekle (tarih, tutar, açıklama)
                                dataGridView1.Rows.Add(tarih.ToShortDateString(), tutarSatirlar[i], açıklamaSatirlar[i]);
                            }
                        }

                        // Toplam tutarı public değişkene ata
                        toplamGelir = toplamTutar;

                        // Toplam tutarı en alt satıra ekle
                        dataGridView1.Rows.Add("Toplam", toplamTutar.ToString("0.00"), "");

                        // Toplam tutarı Label6'ya yaz
                        label6.Text = "₺ " + toplamGelir.ToString("N0");

                        MessageBox.Show("Veriler başarıyla yüklendi!");
                    }
                    else
                    {
                        MessageBox.Show("Dosyalar arasında satır sayısı uyumsuzluğu var. Lütfen dosyaları kontrol edin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bazı dosyalar bulunamadı. Lütfen dosyaların mevcut olduğundan emin olun.");
            }

        }
        public double toplamTutartoplamı = 0;
        private void btnTopla_Click(object sender, EventArgs e)
        {
            toplamTutartoplamı = toplamGelir - toplamGider;
            //label8Toplam.Text = "Toplam :" + toplamTutartoplamı.ToString();

            label8Toplam.Text = "₺ " + toplamTutartoplamı.ToString("N0"); // "₺ 1,500" şeklinde gösterir.


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // DataGridView1 ve DataGridView2'deki tüm satırları sil
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            label6.Text = "";
            label7.Text = "";
            label8Toplam.Text = "";

            // Kullanıcıya bilgi ver
            MessageBox.Show("Tüm veriler temizlendi.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            DovizGoster();
        }

        private void btnTarihGetir_Click(object sender, EventArgs e)
        {

            // DateTimePicker'dan seçilen tarihi alıyoruz.
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Dosyaların yollarını belirliyoruz.
            string gelirTarihPath = "GelirTarih.txt";
            string gelirTutariPath = "GelirTutarı.txt";
            string gelirAciklamaPath = "GelirAçıklama.txt";
            string giderTarihPath = "GiderTarih.txt";
            string giderTutariPath = "GiderTutarı.txt";
            string giderAciklamaPath = "GiderAçıklama.txt";

            double toplamGelir = 0;
            double toplamGider = 0;

            // Dosyaların var olup olmadığını kontrol ediyoruz.
            if (File.Exists(gelirTarihPath) && File.Exists(gelirTutariPath) && File.Exists(gelirAciklamaPath) &&
                File.Exists(giderTarihPath) && File.Exists(giderTutariPath) && File.Exists(giderAciklamaPath))
            {
                // Dosyaları okuyup satırlara ayırıyoruz.
                var gelirTarihLines = File.ReadAllLines(gelirTarihPath);
                var gelirTutariLines = File.ReadAllLines(gelirTutariPath);
                var gelirAciklamaLines = File.ReadAllLines(gelirAciklamaPath);
                var giderTarihLines = File.ReadAllLines(giderTarihPath);
                var giderTutariLines = File.ReadAllLines(giderTutariPath);
                var giderAciklamaLines = File.ReadAllLines(giderAciklamaPath);

                // DataGridView1 ve DataGridView2'yi temizliyoruz.
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                // Gelir dosyasını işlemi başlatıyoruz.
                for (int i = 0; i < gelirTarihLines.Length; i++)
                {
                    if (DateTime.TryParse(gelirTarihLines[i], out DateTime tarih) && tarih.Date == selectedDate)
                    {
                        string tutar = gelirTutariLines[i];
                        string aciklama = gelirAciklamaLines[i];

                        // Eşleşen veriyi DataGridView1'e ekliyoruz.
                        dataGridView1.Rows.Add(tarih.ToShortDateString(), tutar, aciklama);

                        // Gelir tutarını topluyoruz.
                        if (double.TryParse(tutar, out double gelirTutari))
                        {
                            toplamGelir += gelirTutari;
                        }
                    }
                }

                // Gider dosyasını işlemi başlatıyoruz.
                for (int i = 0; i < giderTarihLines.Length; i++)
                {
                    if (DateTime.TryParse(giderTarihLines[i], out DateTime tarih) && tarih.Date == selectedDate)
                    {
                        string tutar = giderTutariLines[i];
                        string aciklama = giderAciklamaLines[i];

                        // Eşleşen veriyi DataGridView2'ye ekliyoruz.
                        dataGridView2.Rows.Add(tarih.ToShortDateString(), tutar, aciklama);

                        // Gider tutarını topluyoruz.
                        if (double.TryParse(tutar, out double giderTutari))
                        {
                            toplamGider += giderTutari;
                        }
                    }
                }

                // Gelir ve gider toplamlarını ekliyoruz.
                dataGridView1.Rows.Add("Toplam", toplamGelir.ToString("C2"), "");
                dataGridView2.Rows.Add("Toplam", toplamGider.ToString("C2"), "");
            }
            else
            {
                MessageBox.Show("Dosyalar bulunamadı veya bozuk.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8Toplam_Click(object sender, EventArgs e)
        {

        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar Raporlar = new Raporlar();
            Raporlar.Show();
        }
    }

}




