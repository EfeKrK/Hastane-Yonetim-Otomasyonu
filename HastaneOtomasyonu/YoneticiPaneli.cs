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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Gecis = new Form1();
            Form1Gecis.Show();
        }

        private void btn_doktorekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorEkle doktorEkleGecis = new DoktorEkle();
            doktorEkleGecis.Show();
        }

        private void SekreterPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiEkle yoneticiEkleGecis = new YoneticiEkle();
            yoneticiEkleGecis .Show();  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this .Hide();
            BolumEkleSil bolumEkleSilGecis = new BolumEkleSil();
            bolumEkleSilGecis .Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DuyuruGonder duyuruGonderGecis = new DuyuruGonder();
            duyuruGonderGecis .Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide ();
            HastaneDuyuruları2 hastaneDuyuruları2Gecis = new HastaneDuyuruları2();
            hastaneDuyuruları2Gecis .Show();
        }
    }
}
