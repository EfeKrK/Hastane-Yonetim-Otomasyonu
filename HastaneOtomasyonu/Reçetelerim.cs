using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Reçetelerim : Form
    {
        private int hastaId;
        private Database db;

        public Reçetelerim(int hastaId)
        {
            InitializeComponent();
            this.hastaId = hastaId;
            db = new Database();
            LoadReceteler();
            listView1.View = View.Details;
            listView1.Columns.Add("Doktor", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Reçete", 250, HorizontalAlignment.Left);
        }

        private void LoadReceteler()
        {
            try
            {
                db.OpenConnection();

                // HastaId'ye ve DoktorId'ye göre reçeteleri çek
                string query = "SELECT r.Icerik, d.Isim, d.Soyisim " +
                               "FROM receteler r " +
                               "JOIN doktorlar d ON r.doktor_id = d.Id " +
                               "WHERE r.hasta_id = @HastaId";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@HastaId", hastaId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string icerik = reader["Icerik"].ToString();
                            string doktorIsimSoyisim = $"{reader["Isim"]} {reader["Soyisim"]}";

                            // Ekranı güncelle
                            ListViewItem item = new ListViewItem(new[] { doktorIsimSoyisim, icerik });
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reçeteleri yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaPaneli hastaPaneliGecis = new HastaPaneli(hastaId);
            hastaPaneliGecis.Show();
        }

        private void Reçetelerim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
