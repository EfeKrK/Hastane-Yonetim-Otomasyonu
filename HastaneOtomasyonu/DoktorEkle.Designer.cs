namespace HastaneOtomasyonu
{
    partial class DoktorEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_bolumler = new System.Windows.Forms.ComboBox();
            this.lb_bolum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_tekrarSifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DoktoruEkle = new System.Windows.Forms.Button();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_doktoruSil = new System.Windows.Forms.Button();
            this.cb_doktorlar = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 95);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Ekle/Sil";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cb_bolumler);
            this.panel2.Controls.Add(this.lb_bolum);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_tekrarSifre);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_Sifre);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cb_cinsiyet);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_telefon);
            this.panel2.Controls.Add(this.txt_tc);
            this.panel2.Controls.Add(this.txt_soyisim);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_DoktoruEkle);
            this.panel2.Controls.Add(this.txt_isim);
            this.panel2.Location = new System.Drawing.Point(12, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 326);
            this.panel2.TabIndex = 6;
            // 
            // cb_bolumler
            // 
            this.cb_bolumler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bolumler.FormattingEnabled = true;
            this.cb_bolumler.Location = new System.Drawing.Point(147, 282);
            this.cb_bolumler.Name = "cb_bolumler";
            this.cb_bolumler.Size = new System.Drawing.Size(138, 28);
            this.cb_bolumler.TabIndex = 23;
            this.cb_bolumler.Text = "Bölüm Seçiniz";
            // 
            // lb_bolum
            // 
            this.lb_bolum.AutoSize = true;
            this.lb_bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_bolum.Location = new System.Drawing.Point(18, 285);
            this.lb_bolum.Name = "lb_bolum";
            this.lb_bolum.Size = new System.Drawing.Size(58, 20);
            this.lb_bolum.TabIndex = 22;
            this.lb_bolum.Text = "Bölüm:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txt_tekrarSifre
            // 
            this.txt_tekrarSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tekrarSifre.Location = new System.Drawing.Point(147, 247);
            this.txt_tekrarSifre.Name = "txt_tekrarSifre";
            this.txt_tekrarSifre.Size = new System.Drawing.Size(103, 26);
            this.txt_tekrarSifre.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tekrar Şifre:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(147, 214);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(103, 26);
            this.txt_Sifre.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Şifre:";
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(147, 147);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(103, 26);
            this.cb_cinsiyet.TabIndex = 16;
            this.cb_cinsiyet.Text = "Seçiniz...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "TC:";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.Location = new System.Drawing.Point(147, 179);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(103, 26);
            this.txt_telefon.TabIndex = 11;
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(147, 83);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(103, 26);
            this.txt_tc.TabIndex = 8;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyisim.Location = new System.Drawing.Point(147, 51);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(103, 26);
            this.txt_soyisim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "İsim:";
            // 
            // btn_DoktoruEkle
            // 
            this.btn_DoktoruEkle.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_DoktoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DoktoruEkle.Location = new System.Drawing.Point(302, 206);
            this.btn_DoktoruEkle.Name = "btn_DoktoruEkle";
            this.btn_DoktoruEkle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DoktoruEkle.Size = new System.Drawing.Size(135, 41);
            this.btn_DoktoruEkle.TabIndex = 2;
            this.btn_DoktoruEkle.Text = "Doktoru Ekle";
            this.btn_DoktoruEkle.UseVisualStyleBackColor = false;
            this.btn_DoktoruEkle.Click += new System.EventHandler(this.btn_DoktoruEkle_Click);
            // 
            // txt_isim
            // 
            this.txt_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim.Location = new System.Drawing.Point(147, 16);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(103, 26);
            this.txt_isim.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btn_doktoruSil);
            this.panel3.Controls.Add(this.cb_doktorlar);
            this.panel3.Location = new System.Drawing.Point(530, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 326);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // btn_doktoruSil
            // 
            this.btn_doktoruSil.BackColor = System.Drawing.Color.Crimson;
            this.btn_doktoruSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktoruSil.Location = new System.Drawing.Point(57, 264);
            this.btn_doktoruSil.Name = "btn_doktoruSil";
            this.btn_doktoruSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_doktoruSil.Size = new System.Drawing.Size(135, 41);
            this.btn_doktoruSil.TabIndex = 24;
            this.btn_doktoruSil.Text = "Doktoru Sil";
            this.btn_doktoruSil.UseVisualStyleBackColor = false;
            this.btn_doktoruSil.Click += new System.EventHandler(this.btn_doktoruSil_Click_1);
            // 
            // cb_doktorlar
            // 
            this.cb_doktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_doktorlar.FormattingEnabled = true;
            this.cb_doktorlar.Location = new System.Drawing.Point(45, 22);
            this.cb_doktorlar.Name = "cb_doktorlar";
            this.cb_doktorlar.Size = new System.Drawing.Size(156, 28);
            this.cb_doktorlar.TabIndex = 0;
            this.cb_doktorlar.Text = "Doktoru Seçiniz";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DoktorEkle";
            this.Text = "DoktorEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorEkle_FormClosing);
            this.Load += new System.EventHandler(this.DoktorEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_bolum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_tekrarSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_cinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DoktoruEkle;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_doktoruSil;
        private System.Windows.Forms.ComboBox cb_doktorlar;
        private System.Windows.Forms.ComboBox cb_bolumler;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}