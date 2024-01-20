using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
            // Şifre alanlarında karakterleri gösterme
            txt_Sifre.PasswordChar = '*';
            txt_tekrarSifre.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiPaneli SekreterPaneliGecis = new YoneticiPaneli();
            SekreterPaneliGecis.Show();
        }

        private void DoktorEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            // Veritabanından doktorları çek
            List<string> doktorListesi = GetDoktorListesi();

            // ComboBox'a doktorları ekle
            cb_doktorlar.Items.AddRange(doktorListesi.ToArray());

            // Bölüm adlarını ComboBox'a ekle
            List<string> bolumListesi = GetBolumListesi();
            cb_bolumler.Items.AddRange(bolumListesi.ToArray());
        }

        private List<string> GetDoktorListesi()
        {
            List<string> doktorListesi = new List<string>();

            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // SQL sorgusunu hazırla
                string sql = "SELECT Isim, Soyisim FROM doktorlar";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    using (MySqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string doktorAdiSoyadi = $"{reader["Isim"]} {reader["Soyisim"]}";
                            doktorListesi.Add(doktorAdiSoyadi);
                        }
                    }
                }
            }

            return doktorListesi;
        }

        private List<string> GetBolumListesi()
        {
            List<string> bolumListesi = new List<string>();

            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // SQL sorgusunu hazırla
                string sql = "SELECT BolumAdi FROM bolumler";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    using (MySqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string bolumAdi = reader["BolumAdi"].ToString();
                            bolumListesi.Add(bolumAdi);
                        }
                    }
                }
            }

            return bolumListesi;
        }

        private void btn_DoktoruEkle_Click(object sender, EventArgs e)
        {
            // Doktor bilgilerini al
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tc = txt_tc.Text;
            DateTime dogumTarihi = dateTimePicker1.Value;
            string cinsiyet = cb_cinsiyet.SelectedItem?.ToString();
            string telefon = txt_telefon.Text;
            string sifre = txt_Sifre.Text;
            string tekrarSifre = txt_tekrarSifre.Text;
            string bolum = cb_bolumler.Text;

            // Eksik bilgi kontrolü
            if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) ||
                string.IsNullOrWhiteSpace(tc) || 
                cinsiyet == null || string.IsNullOrWhiteSpace(telefon) ||
                string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(tekrarSifre) ||
                string.IsNullOrWhiteSpace(bolum))
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
                string sql = "INSERT INTO doktorlar (Isim, Soyisim, TC, DogumTarihi, Cinsiyet, Telefon, Sifre, Bolum_Id) " +
             "VALUES (@isim, @soyisim, @tc, @dogumTarihi, @cinsiyet, @telefon, @sifre, (SELECT Id FROM bolumler WHERE BolumAdi = @bolum))";
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
                    komut.Parameters.AddWithValue("@bolum", bolum);


                    // Sorguyu çalıştır
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Doktor başarıyla eklendi!");
                        Temizle();
                        // ComboBox'ı güncelle
                        cb_doktorlar.Items.Clear();
                        List<string> doktorListesi = GetDoktorListesi();
                        cb_doktorlar.Items.AddRange(doktorListesi.ToArray());
                    }
                    else
                    {
                        MessageBox.Show("Doktor eklenirken bir hata oluştu!");
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
            txt_Sifre.Clear();
            txt_tekrarSifre.Clear();
        }

        

        private bool DoktorVeRandevulariniSil(string doktorAdiSoyadi)
        {
            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // Doktor adı ve soyadını ayır
                string[] isimSoyisim = doktorAdiSoyadi.Split(' ');
                string isim = isimSoyisim[0];
                string soyisim = isimSoyisim[1];

                using (MySqlTransaction transaction = baglanti.BeginTransaction())
                {
                    try
                    {
                        // 1. Doktora ait randevuları sil
                        string randevuSilSql = "DELETE FROM randevular WHERE Doktor_Id IN (SELECT Id FROM doktorlar WHERE Isim = @isim AND Soyisim = @soyisim)";
                        using (MySqlCommand randevuSilKomut = new MySqlCommand(randevuSilSql, baglanti, transaction))
                        {
                            randevuSilKomut.Parameters.AddWithValue("@isim", isim);
                            randevuSilKomut.Parameters.AddWithValue("@soyisim", soyisim);

                            randevuSilKomut.ExecuteNonQuery();
                        }

                        // 2. Doktoru sil
                        string doktorSilSql = "DELETE FROM doktorlar WHERE Isim = @isim AND Soyisim = @soyisim";
                        using (MySqlCommand doktorSilKomut = new MySqlCommand(doktorSilSql, baglanti, transaction))
                        {
                            doktorSilKomut.Parameters.AddWithValue("@isim", isim);
                            doktorSilKomut.Parameters.AddWithValue("@soyisim", soyisim);

                            doktorSilKomut.ExecuteNonQuery();
                        }

                        // İşlemleri tamamla
                        transaction.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda geri al
                        transaction.Rollback();
                        MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private void btn_doktoruSil_Click_1(object sender, EventArgs e)
        {
            // Seçili doktor adını al
            string seciliDoktor = cb_doktorlar.SelectedItem?.ToString();

            // Eğer bir doktor seçilmemişse uyarı ver
            if (string.IsNullOrWhiteSpace(seciliDoktor))
            {
                MessageBox.Show("Lütfen silmek istediğiniz doktoru seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıya onay al
            DialogResult result = MessageBox.Show("Doktoru ve ona ait randevuları silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Eğer kullanıcı evet derse doktoru ve randevularını sil
            if (result == DialogResult.Yes)
            {
                bool silmeBasarili = DoktorVeRandevulariniSil(seciliDoktor);

                if (silmeBasarili)
                {
                    MessageBox.Show("Doktor ve ona ait randevular başarıyla silindi!");
                    // ComboBox'ı güncelle
                    cb_doktorlar.Items.Clear();
                    List<string> doktorListesi = GetDoktorListesi();
                    cb_doktorlar.Items.AddRange(doktorListesi.ToArray());

                    // DoktorEkle formunu kapat ve tekrar aç
                    this.Hide();
                    DoktorEkle doktoreklegecis = new DoktorEkle();
                    doktoreklegecis.Show();
                }
                else
                {
                    MessageBox.Show("Doktor ve randevuları silinirken bir hata oluştu!");
                }
            }
        }

    }
}
