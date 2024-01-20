using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class MevcutRandevularım : Form
    {
        private int hastaId;

        public MevcutRandevularım(int hastaId)
        {
            InitializeComponent();
            this.hastaId = hastaId;
            RandevulariListele();
            listView1.View = View.Details; // listView'in detay görünümüne geç
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Left); // Sütunlarını ekle
            listView1.Columns.Add("İsim", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Soyisim", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Doktor", 200, HorizontalAlignment.Left); // Doktor adını ve soyadını göstermek için genişletildi
            listView1.Columns.Add("Bölüm", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Tarih", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Saat", 50, HorizontalAlignment.Left);
        }

        private void RandevulariListele()
        {
            listView1.Items.Clear(); // Listeyi temizle

            // Veritabanına bağlan
            using (MySqlConnection connection = new MySqlConnection(Database.ConnectionString))
            {
                connection.Open();

                // SQL sorgusunu hazırla
                string sql = @"SELECT randevular.Id, randevular.Isim, randevular.Soyisim, 
                       CONCAT(doktorlar.Isim, ' ', doktorlar.Soyisim) AS DoktorAdi, 
                       bolumler.BolumAdi, 
                       DATE_FORMAT(randevular.Tarih, '%d.%m.%Y') AS Tarih, 
                       randevular.Saat
                FROM randevular
                INNER JOIN doktorlar ON randevular.doktor_id = doktorlar.Id
                INNER JOIN bolumler ON randevular.Bolum_Id = bolumler.Id
                WHERE randevular.hasta_id = @hastaId;";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    // Parametreleri ata
                    cmd.Parameters.AddWithValue("@hastaId", hastaId);

                    // Sorguyu çalıştır
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Verileri listview'e ekle
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["Isim"].ToString());
                            item.SubItems.Add(reader["Soyisim"].ToString());
                            item.SubItems.Add(reader["DoktorAdi"].ToString()); // Doktor adını ve soyadını ekleyin
                            item.SubItems.Add(reader["BolumAdi"].ToString()); // Bölüm adını ekleyin
                            item.SubItems.Add(reader["Tarih"].ToString());
                            item.SubItems.Add(reader["Saat"].ToString());

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaPaneli hastaPaneligecis = new HastaPaneli(hastaId);
            hastaPaneligecis.Show();
        }

        private void MevcutRandevularım_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_RandevumuSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili bir randevu varsa
                int randevuId = int.Parse(listView1.SelectedItems[0].Text);
                RandevuSil(randevuId);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.");
            }
        }

        private void MevcutRandevularım_Load(object sender, EventArgs e)
        {

        }

        private void RandevuSil(int randevuId)
        {
            // Veritabanına bağlan
            using (MySqlConnection connection = new MySqlConnection(Database.ConnectionString))
            {
                connection.Open();

                // SQL sorgusunu hazırla
                string sql = "DELETE FROM randevular WHERE Id = @randevuId";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    // Parametreleri ata
                    cmd.Parameters.AddWithValue("@randevuId", randevuId);

                    // Sorguyu çalıştır
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        // Başarıyla silindi
                        MessageBox.Show("Randevu başarıyla silindi.");
                        RandevulariListele(); // Listeyi güncelle
                    }
                    else
                    {
                        // Silme başarısız
                        MessageBox.Show("Randevu silinirken bir hata oluştu.");
                    }
                }
            }
        }
    }
}
