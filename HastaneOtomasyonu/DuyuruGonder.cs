using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DuyuruGonder : Form
    {
        private Database db;

        public DuyuruGonder()
        {
            InitializeComponent();
            db = new Database();
        }

        private void DuyuruGonder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            string konu = txt_konu.Text;
            string duyuru = richTextBox_duyuru.Text;
            string tarih = DateTime.Now.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(konu) || string.IsNullOrEmpty(duyuru))
            {
                MessageBox.Show("Konu ve duyuru boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();

                string query = "INSERT INTO duyurular (Konu, Duyuru, Tarih) VALUES (@Konu, @Duyuru, @Tarih)";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Konu", konu);
                    cmd.Parameters.AddWithValue("@Duyuru", duyuru);
                    cmd.Parameters.AddWithValue("@Tarih", tarih);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Duyuru başarıyla gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gönderilen duyurudan sonra alanları temizle
                txt_konu.Clear();
                richTextBox_duyuru.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuru gönderme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yoneticiPaneliGecis = new YoneticiPaneli();
            yoneticiPaneliGecis.Show();
        }
    }
}