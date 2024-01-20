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

namespace HastaneOtomasyonu
{
    public partial class DoktorLogin : Form
    {
        public DoktorLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Gecis = new Form1();
            Form1Gecis.Show();
        }

        private void DoktorLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = txt_tc.Text;
            string sifre = txt_Sifre.Text;

            // Veritabanına bağlan
            using (MySqlConnection connection = new MySqlConnection(Database.ConnectionString))
            {
                connection.Open();

                // SQL sorgusunu hazırla
                string sql = "SELECT * FROM doktorlar WHERE Tc = @tc AND Sifre = @sifre";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    // Parametreleri ata
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    // Sorguyu çalıştır
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Eğer veri varsa giriş yapılmıştır
                        if (reader.Read())
                        {
                            // Doktorun ID'sini al
                            int doktorId = Convert.ToInt32(reader["Id"]);

                            // Formu gizle
                            this.Hide();

                            // DoktorPaneli formunu başlatırken doktor ID'sini sağla
                            DoktorPaneli DoktorPaneliGecis = new DoktorPaneli(doktorId);
                            DoktorPaneliGecis.Show();

                            DialogResult result = MessageBox.Show("Giriş yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("TC veya şifre hatalı!");
                        }
                    }
                }
            }
        }
    


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_Sifre.UseSystemPasswordChar = false; // Şifreyi düz metin olarak göster
            }
            else
            {
                txt_Sifre.UseSystemPasswordChar = true; // Şifreyi '*' karakteri ile gizle
            }
        }

        private void txt_Sifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DoktorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
