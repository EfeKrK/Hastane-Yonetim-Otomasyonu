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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneOtomasyonu
{
    public partial class HastaneDuyuruları2 : Form
    {

        private Database db;
        public HastaneDuyuruları2()
        {
            InitializeComponent();
            db = new Database();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Konu", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Duyuru", 393, HorizontalAlignment.Left);
            listView1.Columns.Add("Tarih", 100, HorizontalAlignment.Left);
            LoadDuyurular();
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiPaneli yoneticiPaneliGecis = new YoneticiPaneli();
            yoneticiPaneliGecis.Show();
        }
    }
}
