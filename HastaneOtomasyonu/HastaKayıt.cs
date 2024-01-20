using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HastaKayıt : Form
    {
        public HastaKayıt()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Gecis = new Form1();
            Form1Gecis.Show();
        }

        private void HastaKayıt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            txt_tekrarsifre.UseSystemPasswordChar = true;
        }

        private void btn_kayıtol_Click(object sender, EventArgs e)
        {

            // Hasta bilgilerini al
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tc = txt_tc.Text;
            DateTime dogumTarihi = dateTimePicker1.Value; // DateTimePicker'dan tarih al
            string cinsiyet = cb_cinsiyet.SelectedItem?.ToString();
            string telefon = txt_telefon.Text;
            string sifre = txt_sifre.Text;
            string tekrarSifre = txt_tekrarsifre.Text;

            // Eksik bilgi kontrolü
            if (string.IsNullOrWhiteSpace(isim) || string.IsNullOrWhiteSpace(soyisim) ||
                string.IsNullOrWhiteSpace(tc) || cinsiyet == null || string.IsNullOrWhiteSpace(telefon) ||
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

            // Doğum tarihi kontrolü
            if (dogumTarihi > DateTime.Now)
            {
                MessageBox.Show("Geçerli bir doğum tarihi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefon numarası kontrolü
            if (telefon.Length != 11)
            {
                MessageBox.Show("Girilen telefon numarası 11 karakterden oluşmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string sql = "INSERT INTO hastalar (Isim, Soyisim, TC, DogumTarihi, Cinsiyet, Telefon, Sifre) " +
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
                        MessageBox.Show("Hasta başarıyla kaydedildi!");
                        Temizle(); // TextBox'ları temizle
                    }
                    else
                    {
                        MessageBox.Show("Hasta kaydedilirken bir hata oluştu!");
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
        private void HastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void txt_telefon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
