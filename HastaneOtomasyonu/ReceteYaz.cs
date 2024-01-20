using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class ReceteYaz : Form
    {
        private Database db;
        private int doktorId;

        public ReceteYaz(int doktorId)
        {
            InitializeComponent();
            db = new Database();
            this.doktorId = doktorId;

            // Form yüklendiğinde hastaları DataGridView'a ekleyin
            LoadHastalar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorPaneli DoktorPaneliGecis = new DoktorPaneli(doktorId);
            DoktorPaneliGecis.Show();
        }

        private void ReceteYaz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadHastalar()
        {
            try
            {
                db.OpenConnection();

                // DataGridView'a hastaların bilgilerini çek
                string query = "SELECT Isim, Soyisim, Sikayet, hasta_id FROM randevular WHERE doktor_id = @DoktorId";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@DoktorId", doktorId);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // DataGridView'a verileri bind et
                        dataGridView1.DataSource = dt;

                        // DataGridView'da sadece belirli sütunları göster
                        dataGridView1.Columns["Isim"].HeaderText = "İsim";
                        dataGridView1.Columns["Soyisim"].HeaderText = "Soyisim";
                        dataGridView1.Columns["Sikayet"].HeaderText = "Şikayet";
                        dataGridView1.Columns["hasta_id"].HeaderText = "Hasta ID";

                  

                   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hastaları yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btn_receteyaz_Click_1(object sender, EventArgs e)
        {
            // DataGridView'dan seçili satırı al
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Seçili satırdan hasta bilgilerini al
                int hastaId = Convert.ToInt32(selectedRow.Cells["hasta_Id"].Value);
                string isim = selectedRow.Cells["Isim"].Value.ToString();
                string soyisim = selectedRow.Cells["Soyisim"].Value.ToString();
                string sikayet = selectedRow.Cells["Sikayet"].Value.ToString();
         

                // Reçete bilgilerini al
                string receteIcerik = richtxtbox_icerik.Text;

                // Veritabanı bağlantısını aç
                db.OpenConnection();

                try
                {
                    // Reçeteyi veritabanına ekleme
                    string insertQuery = "INSERT INTO receteler (doktor_id, hasta_id, icerik) VALUES (@DoktorId, @HastaId, @Icerik)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@DoktorId", doktorId);
                        cmd.Parameters.AddWithValue("@HastaId", hastaId);
                        cmd.Parameters.AddWithValue("@Icerik", receteIcerik);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Reçete başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reçete eklenirken bir hata oluştu veya etkilenen satır sayısı 0.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Reçete eklenirken bir hata oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Veritabanı bağlantısını kapat
                    db.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}

