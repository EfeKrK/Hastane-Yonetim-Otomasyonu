using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuAl : Form
    {
        private int hastaId;
        private Database db;

        public RandevuAl(int hastaId)
        {
            InitializeComponent();
            this.hastaId = hastaId;
            db = new Database();

            // ComboBox'ları doldur
            LoadBolumler();
            LoadDoktorlar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaPaneli hastaPaneligecis = new HastaPaneli(hastaId);
            hastaPaneligecis.Show();
        }

        private void RandevuAl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadBolumler()
        {
            try
            {
                db.OpenConnection();

                // Bolumler tablosundan bolumleri çek
                string query = "SELECT Id, BolumAdi FROM bolumler";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bolumId = Convert.ToInt32(reader["Id"]);
                            string bolumAdi = reader["BolumAdi"].ToString();
                            cb_bolumler.Items.Add(new BolumItem { BolumAdi = $"{bolumId} - {bolumAdi}", BolumId = bolumId });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölümleri yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void cb_bolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bölüm seçildiğinde doktorları yükle
            LoadDoktorlar();
        }

        private void LoadDoktorlar()
        {
            cb_Doktorlar.Items.Clear();

            if (cb_bolumler.SelectedItem != null)
            {
                BolumItem selectedBolum = (BolumItem)cb_bolumler.SelectedItem;

                try
                {
                    db.OpenConnection();

                    // Seçilen bölüme ait doktorları getir
                    string query = "SELECT Id, Isim, Soyisim FROM doktorlar WHERE Bolum_Id = @BolumId";
                    using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@BolumId", selectedBolum.BolumId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int doktorId = Convert.ToInt32(reader["Id"]);
                                string doktorIsim = reader["Isim"].ToString();
                                string doktorSoyisim = reader["Soyisim"].ToString();
                                cb_Doktorlar.Items.Add(new DoktorItem { DoktorAdi = $"{doktorId} - {doktorIsim} {doktorSoyisim}", DoktorId = doktorId });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doktorları yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private class BolumItem
        {
            public string BolumAdi { get; set; }
            public int BolumId { get; set; }

            public override string ToString()
            {
                return BolumAdi;
            }
        }

        private class DoktorItem
        {
            public string DoktorAdi { get; set; }
            public int DoktorId { get; set; }

            public override string ToString()
            {
                return DoktorAdi;
            }
        }

        private void cb_bolumler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadDoktorlar();
        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            RandevuKaydet();
        }

        private void RandevuKaydet()
        {
            // DateTimePicker'dan seçilen tarihi al
            DateTime randevuTarihi = dateTimePicker1.Value.Date;

            // ComboBox'tan seçilen doktoru al
            DoktorItem selectedDoktor = (DoktorItem)cb_Doktorlar.SelectedItem;

            // RichTextBox'ten alınan şikayeti al
            string sikayet = richTextBox1.Text;

            // ComboBox'tan seçilen saat
            string selectedSaat = Cb_Saat.SelectedItem?.ToString();

            // Boş alan kontrolü yap
            if (selectedDoktor == null || string.IsNullOrEmpty(selectedSaat) || string.IsNullOrEmpty(sikayet))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tarih ve saat bilgisini birleştir
            DateTime randevuTarihiVeSaat = randevuTarihi.Add(TimeSpan.Parse(selectedSaat));

            try
            {
                db.OpenConnection();

                // Aynı tarih ve saatte randevu var mı kontrol et
                if (RandevuVarMi(selectedDoktor.DoktorAdi, randevuTarihiVeSaat))
                {
                    MessageBox.Show("Seçilen tarih ve saatte randevu mevcut. Lütfen başka bir tarih veya saat seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Randevu kaydetme işlemi
                string query = "INSERT INTO randevular (Isim, Soyisim, Bolum_Id, Sikayet, doktor_id, Tarih, Saat, hasta_id) " +
                               "VALUES (@Isim, @Soyisim, @BolumId, @Sikayet, @DoktorId, @Tarih, @Saat, @HastaId)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    // Hasta bilgilerini al
                    string hastaIsim = GetHastaIsim(hastaId);
                    string hastaSoyisim = GetHastaSoyisim(hastaId);

                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@Isim", hastaIsim);
                    cmd.Parameters.AddWithValue("@Soyisim", hastaSoyisim);
                    cmd.Parameters.AddWithValue("@BolumId", ((BolumItem)cb_bolumler.SelectedItem).BolumId); // Seçilen bölümün Id'sini ekledik
                    cmd.Parameters.AddWithValue("@Sikayet", sikayet);
                    cmd.Parameters.AddWithValue("@DoktorId", selectedDoktor.DoktorId);
                    cmd.Parameters.AddWithValue("@Tarih", randevuTarihiVeSaat.Date);
                    cmd.Parameters.AddWithValue("@Saat", randevuTarihiVeSaat.ToString("HH:mm"));
                    cmd.Parameters.AddWithValue("@HastaId", hastaId);

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Randevu başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private string GetHastaIsim(int hastaId)
        {
            string query = "SELECT Isim FROM hastalar WHERE Id = @HastaId";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@HastaId", hastaId);
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        private string GetHastaSoyisim(int hastaId)
        {
            string query = "SELECT Soyisim FROM hastalar WHERE Id = @HastaId";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@HastaId", hastaId);
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        private bool RandevuVarMi(string doktor, DateTime randevuTarihiVeSaat)
        {
            // Seçilen doktorun id'sini al
            string[] doktorAdSoyad = doktor.Split(' ');
            int doktorId = Convert.ToInt32(doktorAdSoyad[0]);

            // Aynı tarih ve saatte randevu var mı kontrol et
            string query = "SELECT COUNT(*) FROM randevular WHERE doktor_id = @DoktorId AND Tarih = @Tarih AND Saat = @Saat";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@DoktorId", doktorId);
                cmd.Parameters.AddWithValue("@Tarih", randevuTarihiVeSaat.Date);
                cmd.Parameters.AddWithValue("@Saat", randevuTarihiVeSaat.ToString("HH:mm"));

                int randevuSayisi = Convert.ToInt32(cmd.ExecuteScalar());

                // Eğer randevu sayısı 0'dan büyükse aynı tarih ve saatte randevu var demektir
                return randevuSayisi > 0;
            }
        }

        private void Temizle()
        {
            // Form üzerindeki kontrolleri temizle
            cb_bolumler.SelectedIndex = -1;
            cb_Doktorlar.Items.Clear();
            richTextBox1.Clear();
            Cb_Saat.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
