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
    public partial class HastaPaneli : Form
    {
        private int hastaId;
        public HastaPaneli(int hastaId)
        {
            InitializeComponent();
            this.hastaId = hastaId;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Gecis = new Form1();
            Form1Gecis.Show();
        }

        private void HastaPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HastaPaneli_Load(object sender, EventArgs e)
        {

        }

        private void btn_MevcutRandevular_Click(object sender, EventArgs e)
        {
            this.Hide();
            MevcutRandevularım mevcutRandevularımGecis = new MevcutRandevularım(hastaId);
            mevcutRandevularımGecis.Show();
        }

        private void btn_RandevuAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuAl randevuAlGecis = new RandevuAl(hastaId);
            randevuAlGecis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reçetelerim ReçetelerimGecis = new Reçetelerim(hastaId);
            ReçetelerimGecis.Show();
        }
    }
}
