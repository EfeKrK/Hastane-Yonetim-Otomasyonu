namespace HastaneOtomasyonu
{
    partial class BolumEkleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BolumEkleSil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_BolumuSil = new System.Windows.Forms.Button();
            this.cb_doktorlar = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BolumuEkle = new System.Windows.Forms.Button();
            this.txt_BolumAdi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(236, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Ekle/Sil";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btn_BolumuSil);
            this.panel3.Controls.Add(this.cb_doktorlar);
            this.panel3.Location = new System.Drawing.Point(522, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 326);
            this.panel3.TabIndex = 8;
            // 
            // btn_BolumuSil
            // 
            this.btn_BolumuSil.BackColor = System.Drawing.Color.Crimson;
            this.btn_BolumuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BolumuSil.Location = new System.Drawing.Point(57, 264);
            this.btn_BolumuSil.Name = "btn_BolumuSil";
            this.btn_BolumuSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_BolumuSil.Size = new System.Drawing.Size(135, 41);
            this.btn_BolumuSil.TabIndex = 24;
            this.btn_BolumuSil.Text = "Bölümü Sil";
            this.btn_BolumuSil.UseVisualStyleBackColor = false;
            this.btn_BolumuSil.Click += new System.EventHandler(this.btn_BolumuSil_Click);
            // 
            // cb_doktorlar
            // 
            this.cb_doktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_doktorlar.FormattingEnabled = true;
            this.cb_doktorlar.Location = new System.Drawing.Point(45, 22);
            this.cb_doktorlar.Name = "cb_doktorlar";
            this.cb_doktorlar.Size = new System.Drawing.Size(156, 28);
            this.cb_doktorlar.TabIndex = 0;
            this.cb_doktorlar.SelectedIndexChanged += new System.EventHandler(this.cb_doktorlar_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_BolumuEkle);
            this.panel2.Controls.Add(this.txt_BolumAdi);
            this.panel2.Location = new System.Drawing.Point(48, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 326);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölüm Adı:";
            // 
            // btn_BolumuEkle
            // 
            this.btn_BolumuEkle.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_BolumuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BolumuEkle.Location = new System.Drawing.Point(64, 264);
            this.btn_BolumuEkle.Name = "btn_BolumuEkle";
            this.btn_BolumuEkle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_BolumuEkle.Size = new System.Drawing.Size(135, 41);
            this.btn_BolumuEkle.TabIndex = 2;
            this.btn_BolumuEkle.Text = "Bölümü Ekle";
            this.btn_BolumuEkle.UseVisualStyleBackColor = false;
            this.btn_BolumuEkle.Click += new System.EventHandler(this.btn_BolumuEkle_Click);
            // 
            // txt_BolumAdi
            // 
            this.txt_BolumAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BolumAdi.Location = new System.Drawing.Point(110, 13);
            this.txt_BolumAdi.Name = "txt_BolumAdi";
            this.txt_BolumAdi.Size = new System.Drawing.Size(151, 26);
            this.txt_BolumAdi.TabIndex = 0;
            this.txt_BolumAdi.TextChanged += new System.EventHandler(this.txt_BolumAdi_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // BolumEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "BolumEkleSil";
            this.Text = "BolumEkleSil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_BolumuSil;
        private System.Windows.Forms.ComboBox cb_doktorlar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BolumuEkle;
        private System.Windows.Forms.TextBox txt_BolumAdi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}