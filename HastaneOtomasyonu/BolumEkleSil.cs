using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class BolumEkleSil : Form
    {
        public BolumEkleSil()
        {
            InitializeComponent();

            // Form yüklendiğinde ComboBox'ı doldur
            BolumleriComboBoxDoldur();
        }

        private void BolumleriComboBoxDoldur()
        {
            // ComboBox'ı temizle
            cb_doktorlar.Items.Clear();

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
                            // Her bir bölüm adını ComboBox'a ekle
                            cb_doktorlar.Items.Add(reader["BolumAdi"].ToString());
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiPaneli yoneticiPaneliGecis = new YoneticiPaneli();
            yoneticiPaneliGecis.Show();
        }

        private void btn_BolumuSil_Click(object sender, EventArgs e)
        {
            // Seçili bölüm adını al
            string seciliBolum = cb_doktorlar.SelectedItem?.ToString();

            // Eğer bir bölüm seçilmemişse uyarı ver
            if (string.IsNullOrWhiteSpace(seciliBolum))
            {
                MessageBox.Show("Lütfen silmek istediğiniz bölümü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanından bölümü sil
            bool silmeBasarili = BolumuSil(seciliBolum);

            if (silmeBasarili)
            {
                MessageBox.Show("Bölüm başarıyla silindi!");
                // ComboBox'ı güncelle
                BolumleriComboBoxDoldur();
            }
            else
            {
                MessageBox.Show("Bölüm silinirken bir hata oluştu!");
            }
        }

        private bool BolumuSil(string bolumAdi)
        {
            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // SQL sorgusunu hazırla
                string sql = "DELETE FROM bolumler WHERE BolumAdi = @bolumAdi";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    // Parametreleri ata
                    komut.Parameters.AddWithValue("@bolumAdi", bolumAdi);

                    // Sorguyu çalıştır
                    int affectedRows = komut.ExecuteNonQuery();

                    return affectedRows > 0;
                }
            }
        }

        private void cb_doktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'ta seçili bölüm adını kullanabilirsiniz
            // Örneğin: string seciliBolum = cb_doktorlar.SelectedItem?.ToString();
        }

        private void txt_BolumAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_BolumuEkle_Click(object sender, EventArgs e)
        {
            // Bölüm adını al
            string bolumAdi = txt_BolumAdi.Text;

            // Eksik bilgi kontrolü
            if (string.IsNullOrWhiteSpace(bolumAdi))
            {
                MessageBox.Show("Lütfen bölüm adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına bağlan
            using (MySqlConnection baglanti = new MySqlConnection(Database.ConnectionString))
            {
                baglanti.Open();

                // SQL sorgusunu hazırla
                string sql = "INSERT INTO bolumler (BolumAdi) VALUES (@bolumAdi)";
                using (MySqlCommand komut = new MySqlCommand(sql, baglanti))
                {
                    // Parametreyi ata
                    komut.Parameters.AddWithValue("@bolumAdi", bolumAdi);

                    // Sorguyu çalıştır
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Bölüm başarıyla eklendi!");
                        // ComboBox'ı güncelle
                        BolumleriComboBoxDoldur();
                        txt_BolumAdi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bölüm eklenirken bir hata oluştu!");
                    }
                }
            }
        }
    }
}
