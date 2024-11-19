using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFinans
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            dataGridView2.RowPostPaint += dataGridView1_RowPostPaint;



            // DataGridView'e sütun ekle
            dataGridView2.Columns.Add("Tarih", "Tarih");
            //  dataGridView2.Columns.Add("Kategori", "Kategori");
            dataGridView2.Columns.Add("Açıklama", "Açıklama");
            dataGridView2.Columns.Add("Tutar", "Tutar");
            dataGridView2.Columns[0].Width = 90;
            dataGridView2.Columns[1].Width = 90;
            dataGridView2.Columns[2].Width = 127;
            // dataGridView2.Columns[2].Width = 80;

            dataGridView1.Columns.Add("Tarih", "Tarih");
            //  dataGridView1.Columns.Add("Kategori", "Kategori");
            dataGridView1.Columns.Add("Açıklama", "Açıklama");
            dataGridView1.Columns.Add("Tutar", "Tutar");
            dataGridView1.Columns[0].Width = 96;
            //   dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 121;
            dataGridView1.Columns[2].Width = 111;


        }
        decimal GiderToplam = 0;
        decimal GelirToplam = 0;
        decimal toplamGelirGider = 0;
        private void btnGelirRapor_Click(object sender, EventArgs e)
        {
            try
            {
                // DateTimePicker'dan seçilen başlangıç ve bitiş tarihlerini al
                DateTime baslangicTarihi = dateTimePicker1.Value.Date;
                DateTime bitisTarihi = dateTimePicker2.Value.Date;

                // Dosya yolları
                string gelirTarihDosya = "GelirTarih.txt";
                string gelirTutarDosya = "GelirTutarı.txt";
                string gelirAciklamaDosya = "GelirAçıklama.txt";
                string gelirKategoriDosya = "GelirKategorisi.txt";

                // DataGridView'i temizle
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();

                // DataGridView kolonlarını ekle
                dataGridView2.Columns.Add("Tarih", "Tarih");
                dataGridView2.Columns.Add("Tutar", "Tutar");
                dataGridView2.Columns.Add("Açıklama", "Açıklama");
                dataGridView2.Columns[2].Width = 107;
                // dataGridView2.Columns.Add("Kategori", "Kategori");

                // Dosyaları oku
                string[] gelirTarihler = File.Exists(gelirTarihDosya) ? File.ReadAllLines(gelirTarihDosya) : new string[0];
                string[] gelirTutarlar = File.Exists(gelirTutarDosya) ? File.ReadAllLines(gelirTutarDosya) : new string[0];
                string[] gelirAciklamalar = File.Exists(gelirAciklamaDosya) ? File.ReadAllLines(gelirAciklamaDosya) : new string[0];
                string[] gelirKategoriler = File.Exists(gelirKategoriDosya) ? File.ReadAllLines(gelirKategoriDosya) : new string[0];

                // Tüm dosyalar arasında en uzun olanın satır sayısını al
                int toplamSatirSayisi = Math.Max(
                    Math.Max(gelirTarihler.Length, gelirTutarlar.Length),
                    Math.Max(gelirAciklamalar.Length, gelirKategoriler.Length)
                );

                decimal toplamTutar = 0;

                // Verileri DataGridView'e ekle
                for (int i = 0; i < toplamSatirSayisi; i++)
                {
                    string tarih = i < gelirTarihler.Length ? gelirTarihler[i] : "";
                    string tutarStr = i < gelirTutarlar.Length ? gelirTutarlar[i] : "0";
                    string aciklama = i < gelirAciklamalar.Length ? gelirAciklamalar[i] : "";
                    string kategori = i < gelirKategoriler.Length ? gelirKategoriler[i] : "";

                    // Tarih kontrolü
                    DateTime tarihValue;
                    if (!string.IsNullOrEmpty(tarih) && DateTime.TryParse(tarih, out tarihValue) &&
                        tarihValue >= baslangicTarihi && tarihValue <= bitisTarihi)
                    {
                        decimal tutar = decimal.TryParse(tutarStr, out decimal parsedTutar) ? parsedTutar : 0;
                        toplamTutar += tutar;

                        dataGridView2.Rows.Add(
                            tarihValue.ToString("yyyy-MM-dd"),
                            tutar.ToString("C"), // Para formatında
                            aciklama,
                            kategori
                        );
                    }
                }

                label4.Text = "₺ " + toplamTutar.ToString("N0");
                GelirToplam = toplamTutar;
                toplamGelirGider = GelirToplam - GiderToplam;
                label6.Text = "₺ " +toplamGelirGider.ToString("N0");

                // Toplam satırını ekle
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows.Add("TOPLAM", toplamTutar.ToString("C"), "", "");
                }
                else
                {
                    MessageBox.Show("Seçilen tarihler arasında veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGiderRapor_Click(object sender, EventArgs e)
        {
            try
            {
                // DateTimePicker'dan seçilen başlangıç ve bitiş tarihlerini al
                DateTime baslangicTarihi = dateTimePicker4.Value.Date;
                DateTime bitisTarihi = dateTimePicker3.Value.Date;

                // Dosya yolları
                string giderTarihDosya = "GiderTarih.txt";
                string giderTutarDosya = "GiderTutarı.txt";
                string giderAciklamaDosya = "GiderAçıklama.txt";
                string giderKategoriDosya = "GiderKategorisi.txt";

                // DataGridView'i temizle
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // DataGridView kolonlarını ekle
                dataGridView1.Columns.Add("Tarih", "Tarih");
                dataGridView1.Columns.Add("Tutar", "Tutar");
                dataGridView1.Columns.Add("Açıklama", "Açıklama");
                dataGridView1.Columns[2].Width = 90;
                //  dataGridView1.Columns.Add("Kategori", "Kategori");

                // Dosyaları oku
                string[] giderTarihler = File.Exists(giderTarihDosya) ? File.ReadAllLines(giderTarihDosya) : new string[0];
                string[] giderTutarlar = File.Exists(giderTutarDosya) ? File.ReadAllLines(giderTutarDosya) : new string[0];
                string[] giderAciklamalar = File.Exists(giderAciklamaDosya) ? File.ReadAllLines(giderAciklamaDosya) : new string[0];
                string[] giderKategoriler = File.Exists(giderKategoriDosya) ? File.ReadAllLines(giderKategoriDosya) : new string[0];

                // Tüm dosyalar arasında en uzun olanın satır sayısını al
                int toplamSatirSayisi = Math.Max(
                    Math.Max(giderTarihler.Length, giderTutarlar.Length),
                    Math.Max(giderAciklamalar.Length, giderKategoriler.Length)
                );

                decimal toplamTutar = 0;

                // Verileri DataGridView'e ekle
                for (int i = 0; i < toplamSatirSayisi; i++)
                {
                    string tarih = i < giderTarihler.Length ? giderTarihler[i] : "";
                    string tutarStr = i < giderTutarlar.Length ? giderTutarlar[i] : "0";
                    string aciklama = i < giderAciklamalar.Length ? giderAciklamalar[i] : "";
                    string kategori = i < giderKategoriler.Length ? giderKategoriler[i] : "";

                    // Tarih kontrolü
                    DateTime tarihValue;
                    if (!string.IsNullOrEmpty(tarih) && DateTime.TryParse(tarih, out tarihValue) &&
                        tarihValue >= baslangicTarihi && tarihValue <= bitisTarihi)
                    {
                        decimal tutar = decimal.TryParse(tutarStr, out decimal parsedTutar) ? parsedTutar : 0;
                        toplamTutar += tutar;

                        dataGridView1.Rows.Add(
                            tarihValue.ToString("yyyy-MM-dd"),
                            tutar.ToString("C"), // Para formatında
                            aciklama,
                            kategori
                        );
                    }
                }
                label5.Text = "₺ " + toplamTutar.ToString("N0");
                GiderToplam = toplamTutar;
                toplamGelirGider = GelirToplam - GiderToplam;
                label6.Text = "₺ " +toplamGelirGider.ToString("N0");

                // Toplam satırını ekle
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Add("TOPLAM", toplamTutar.ToString("C"), "", "");
                }
                else
                {
                    MessageBox.Show("Seçilen tarihler arasında veri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Satır numarasını hesapla
            string rowNumber = (e.RowIndex + 1).ToString();

            // Yazı formatını belirle
            using (SolidBrush brush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridView1.DefaultCellStyle.Font,
                    brush,
                    e.RowBounds.Location.X + 10, // X konumu
                    e.RowBounds.Location.Y + 4  // Y konumu
                );
            }
        }
        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Satır numarasını hesapla
            string rowNumber = (e.RowIndex + 1).ToString();

            // Yazı formatını belirle
            using (SolidBrush brush = new SolidBrush(dataGridView2.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridView2.DefaultCellStyle.Font,
                    brush,
                    e.RowBounds.Location.X + 1, // X konumu
                    e.RowBounds.Location.Y + 4 // Y konumu
                );
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
