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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Database database = new Database();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Otomasyondan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kullanıcı "Evet" butonuna tıklarsa
            if (result == DialogResult.Yes)
            {
                // Uygulamadan çık
                Application.Exit();
            }
        }

        private void btn_hastagiris_Click(object sender, EventArgs e)
        {

            this.Hide();
            HastaGiris HastaLoginGecis = new HastaGiris();
            HastaLoginGecis.Show();
            
            
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_doktorgiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorLogin DoktorLoginGecis = new DoktorLogin();
            DoktorLoginGecis.Show();
        }

        private void btn_sekretergiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiLogin SekreterLoginGecis = new YoneticiLogin();
            SekreterLoginGecis.Show();

        }

        private void btn_hastakayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            HastaKayıt HastaKayıtGecis = new HastaKayıt();
            HastaKayıtGecis.Show();
        }
    }
}
