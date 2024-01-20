using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HastaneDuyuruları : Form
    {
        private int doktorId;
        private Database db;

        public HastaneDuyuruları(int doktorId)
        {
            InitializeComponent();
            this.doktorId = doktorId;
            db = new Database();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Konu", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Duyuru", 393, HorizontalAlignment.Left);
            listView1.Columns.Add("Tarih", 100, HorizontalAlignment.Left);
            LoadDuyurular();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorPaneli doktorPaneliGecis = new DoktorPaneli(doktorId);
            doktorPaneliGecis.Show();
        }

        private void LoadDuyurular()
        {
            try
            {
                db.OpenConnection();

                // Duyuruları çek
                string query = "SELECT Konu, Duyuru, DATE_FORMAT(Tarih, '%Y-%m-%d') AS Tarih FROM duyurular";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string konu = reader["Konu"].ToString();
                            string duyuru = reader["Duyuru"].ToString();
                            string tarih = reader["Tarih"].ToString();

                            // Ekranı güncelle
                            ListViewItem item = new ListViewItem(new[] { konu, duyuru, tarih });
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Duyuruları yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void HastaneDuyuruları_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HastaneDuyuruları_Load(object sender, EventArgs e)
        {

        }
    }
}
