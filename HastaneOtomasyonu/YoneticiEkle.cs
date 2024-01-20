using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class YoneticiEkle : Form
    {
        public YoneticiEkle()
        {
            InitializeComponent();
            MevcutYoneticileriYukle(); // Form yüklendiğinde mevcut yöneticileri ComboBox'a yükle
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiPaneli yoneticiPaneliGecis = new YoneticiPaneli();
            yoneticiPaneliGecis.Show();
        }

        private void YoneticiEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void YoneticiEkle_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde mevcut yöneticileri ComboBox'a yükle
            MevcutYoneticileriYukle();
        }

        private void btn_yoneticiekle_Click(object sender, EventArgs e)
        {
            // Hasta bilgilerini al
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tc = txt_tc.Text;
            DateTime dogumTarihi = dateTimePicker1.Value;
            string cinsiyet = cb_cinsiyet.SelectedItem?.ToString();
            string telefon = txt_telefon.Text;
            string sifre = txt_sifre.Text;
            string tekrarSifre = txt_tekrarsifre.Text;

            // Eksik bilgi kontrolü
            if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) ||
                string.IsNullOrWhiteSpace(tc) || 
                cinsiyet == null || string.IsNullOrWhiteSpace(telefon) ||
                string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(tekrarSifre))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TC Kimlik kontrolü
            if (tc.Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakterden oluşmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (telefon.Length != 11)
            {
                MessageBox.Show("Telefon Numaranız 11 karakterden oluşmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Şifre kontrolü
            if (sifre != tekrarSifre)
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına bağlan
            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // SQL sorgusunu hazırla
                string sql = "INSERT INTO yoneticiler (Isim, Soyisim, TC, DogumTarihi, Cinsiyet, Telefon, Sifre) " +
                             "VALUES (@isim, @soyisim, @tc, @dogumTarihi, @cinsiyet, @telefon, @sifre)";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    // Parametreleri ata
                    komut.Parameters.AddWithValue("@isim", isim);
                    komut.Parameters.AddWithValue("@soyisim", soyisim);
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                    komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    komut.Parameters.AddWithValue("@telefon", telefon);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    // Sorguyu çalıştır
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Yönetici başarıyla kaydedildi!");
                        Temizle(); // TextBox'ları temizle
                        MevcutYoneticileriYukle(); // Yöneticileri ComboBox'a güncel olarak yükle
                    }
                    else
                    {
                        MessageBox.Show("Yönetici kaydedilirken bir hata oluştu!");
                    }
                }
            }
        }

        private void Temizle()
        {
            txt_isim.Clear();
            txt_soyisim.Clear();
            txt_tc.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cb_cinsiyet.SelectedIndex = -1;
            txt_telefon.Clear();
            txt_sifre.Clear();
            txt_tekrarsifre.Clear();
        }

        private void MevcutYoneticileriYukle()
        {
            // ComboBox'ı temizle
            cb_yoneticiler.Items.Clear();

            // Veritabanından mevcut yöneticileri çek
            List<Yonetici> yoneticiler = VeritabaniIslemleri.MevcutYoneticileriGetir();

            // Yönetici isimlerini ComboBox'a ekle
            foreach (Yonetici yonetici in yoneticiler)
            {
                cb_yoneticiler.Items.Add($"{yonetici.Isim} {yonetici.Soyisim}");
            }
        }

       

        private void btn_yoneticiSil_Click(object sender, EventArgs e)
        {
            // Seçili yöneticiyi al
            string seciliYonetici = cb_yoneticiler.SelectedItem?.ToString();

            // Eğer bir yönetici seçilmemişse uyarı ver
            if (string.IsNullOrEmpty(seciliYonetici))
            {
                MessageBox.Show("Lütfen silmek istediğiniz yöneticiyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili yönetici adını isim ve soyisim olarak ayır
            string[] isimSoyisim = seciliYonetici.Split(' ');
            string isim = isimSoyisim[0];
            string soyisim = isimSoyisim[1];

            // Veritabanına bağlan
            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // SQL sorgusunu hazırla
                string sql = "DELETE FROM yoneticiler WHERE Isim = @isim AND Soyisim = @soyisim";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    // Parametreleri ata
                    komut.Parameters.AddWithValue("@isim", isim);
                    komut.Parameters.AddWithValue("@soyisim", soyisim);

                    // Sorguyu çalıştır
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Yönetici başarıyla silindi!");
                        MevcutYoneticileriYukle(); // Yöneticileri ComboBox'a güncel olarak yükle
                    }
                    else
                    {
                        MessageBox.Show("Yönetici silinirken bir hata oluştu!");
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class Yonetici
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        // Diğer özellikleri buraya ekleyin
    }

    public static class VeritabaniIslemleri
    {
        public static List<Yonetici> MevcutYoneticileriGetir()
        {
            List<Yonetici> yoneticiler = new List<Yonetici>();

            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                string sql = "SELECT Isim, Soyisim FROM yoneticiler";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    using (MySqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Yonetici yonetici = new Yonetici
                            {
                                Isim = reader["Isim"].ToString(),
                                Soyisim = reader["Soyisim"].ToString()
                                // Diğer özellikleri de buraya ekleyin
                            };

                            yoneticiler.Add(yonetici);
                        }
                    }
                }
            }

            return yoneticiler;
        }
    }
}
