using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DoktorPaneli : Form
    {
        private Database db;
        private int doktorId;

        public DoktorPaneli(int doktorId)
        {
            InitializeComponent();
            db = new Database();
            this.doktorId = doktorId;
            VerileriListVieweEkle();
        }

        private void VerileriListVieweEkle()
        {
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            // Sütun başlıklarını ekle
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Isim", 50);
            listView1.Columns.Add("Soyisim", 50);
            listView1.Columns.Add("Şikayet", 50);
            listView1.Columns.Add("Tarih", 50);
            listView1.Columns.Add("Saat", 50);
            listView1.Columns.Add("hasta_id", 50);

            // Randevu verilerini ListView'e ekle
            List<Randevu> doktorRandevular = GetDoktorRandevular(doktorId);
            foreach (Randevu randevu in doktorRandevular)
            {
                ListViewItem item = new ListViewItem(randevu.Id.ToString());
                item.SubItems.Add(randevu.Isim);
                item.SubItems.Add(randevu.Soyisim);
                item.SubItems.Add(randevu.Sikayet);
                item.SubItems.Add(randevu.TarihString);
                item.SubItems.Add(randevu.Saat);
                item.SubItems.Add(randevu.hasta_id.ToString());
                listView1.Items.Add(item);
            }
        }

        private List<Randevu> GetDoktorRandevular(int doktorId)
        {
            List<Randevu> doktorRandevular = new List<Randevu>();

            try
            {
                db.OpenConnection();

                string query = "SELECT * FROM randevular WHERE doktor_id = @DoktorId";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@DoktorId", doktorId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Randevu randevu = new Randevu
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Isim = reader["Isim"].ToString(),
                                Soyisim = reader["Soyisim"].ToString(),
                                Sikayet = reader["Sikayet"].ToString(),
                                Saat = reader["Saat"].ToString(),
                                hasta_id = Convert.ToInt32(reader["hasta_id"]),
                                TarihString = reader["Tarih"] != DBNull.Value ? reader["Tarih"].ToString() : string.Empty

                            };

                            doktorRandevular.Add(randevu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına erişim hatası: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return doktorRandevular;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Gecis = new Form1();
            Form1Gecis.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListView'da bir öğe seçildiğinde yapılacak işlemler buraya eklenebilir.
        }

        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemleri buraya ekleyin
            // Örneğin, VerileriListVieweEkle() metodunu çağırabilirsiniz:
            VerileriListVieweEkle();
        }

        private void DoktorPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public class Randevu
        {
            public int Id { get; set; }
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public string Sikayet { get; set; }
            public string Saat { get; set; }
            public int hasta_id { get; set; }

            private string _tarihString;

            public string TarihString
            {
                get { return _tarihString; }
                set
                {
                    _tarihString = value;
                    // "-" karakterini içeren tarihleri DateTime türüne dönüştür
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (value.Contains("-"))
                        {
                            // "-" karakteri içeriyorsa uygun bir şekilde ayrıştır ve DateTime'a çevir
                            if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                            {
                                Tarih = parsedDate;
                                _tarihString = parsedDate.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                Tarih = DateTime.MinValue; // Hata durumunda varsayılan bir değer kullanabilirsiniz
                            }
                        }
                        else
                        {
                            // "-" karakteri yoksa doğrudan DateTime'a çevir
                            if (DateTime.TryParse(value, out DateTime parsedDate))
                            {
                                Tarih = parsedDate;
                                _tarihString = parsedDate.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                Tarih = DateTime.MinValue; // Hata durumunda varsayılan bir değer kullanabilirsiniz
                            }
                        }
                    }
                    else
                    {
                        Tarih = DateTime.MinValue; // Boş ise varsayılan bir değer kullanabilirsiniz
                    }
                }
            }

            public DateTime Tarih { get; private set; }
        }

        private void DoktorPaneli_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_randevusil_Click(object sender, EventArgs e)
        {
            // Seçili bir randevu var mı kontrol et
            if (listView1.SelectedItems.Count > 0)
            {
                // Kullanıcıdan emin olup olmadığını sor
                DialogResult result = MessageBox.Show("Randevuyu silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Seçili randevunun ID'sini al
                    int selectedRandevuId = int.Parse(listView1.SelectedItems[0].Text);

                    // Randevuyu veritabanından sil
                    if (SilRandevu(selectedRandevuId))
                    {
                        // Başarılı bir şekilde silindiği durumunda ListView'den de kaldır
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                    else
                    {
                        MessageBox.Show("Randevu silinirken bir hata oluştu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SilRandevu(int randevuId)
        {
            try
            {
                db.OpenConnection();

                string query = "DELETE FROM randevular WHERE Id = @RandevuId";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@RandevuId", randevuId);

                    int affectedRows = cmd.ExecuteNonQuery();

                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu silme hatası: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_receteyaz_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceteYaz ReceteYazGecis = new ReceteYaz(doktorId);
            ReceteYazGecis.Show();

        }

        private void DoktorPaneli_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaneDuyuruları hastaneDuyurularıGecis = new HastaneDuyuruları(doktorId);
            hastaneDuyurularıGecis.Show();
        }

        private void DoktorPaneli_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit( );
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide( );
            Form1 form1Gecis = new Form1(); 
            form1Gecis.Show();  
        }
    }
}