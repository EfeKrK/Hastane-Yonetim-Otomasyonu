using System;

namespace HastaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_hastakayit = new System.Windows.Forms.Button();
            this.btn_sekretergiris = new System.Windows.Forms.Button();
            this.btn_doktorgiris = new System.Windows.Forms.Button();
            this.btn_hastagiris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 94);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(673, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(195, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Otomasyonu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btn_Cikis);
            this.panel2.Controls.Add(this.btn_hastakayit);
            this.panel2.Controls.Add(this.btn_sekretergiris);
            this.panel2.Controls.Add(this.btn_doktorgiris);
            this.panel2.Controls.Add(this.btn_hastagiris);
            this.panel2.Location = new System.Drawing.Point(-4, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 366);
            this.panel2.TabIndex = 1;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Cikis.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(16, 289);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(126, 63);
            this.btn_Cikis.TabIndex = 5;
            this.btn_Cikis.Text = "ÇIKIŞ";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_hastakayit
            // 
            this.btn_hastakayit.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastakayit.Location = new System.Drawing.Point(16, 221);
            this.btn_hastakayit.Name = "btn_hastakayit";
            this.btn_hastakayit.Size = new System.Drawing.Size(126, 62);
            this.btn_hastakayit.TabIndex = 3;
            this.btn_hastakayit.Text = "Hasta \r\nKayıt";
            this.btn_hastakayit.UseVisualStyleBackColor = true;
            this.btn_hastakayit.Click += new System.EventHandler(this.btn_hastakayit_Click);
            // 
            // btn_sekretergiris
            // 
            this.btn_sekretergiris.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_sekretergiris.Location = new System.Drawing.Point(16, 152);
            this.btn_sekretergiris.Name = "btn_sekretergiris";
            this.btn_sekretergiris.Size = new System.Drawing.Size(126, 63);
            this.btn_sekretergiris.TabIndex = 2;
            this.btn_sekretergiris.Text = "Yönetici \r\nGiriş";
            this.btn_sekretergiris.UseVisualStyleBackColor = true;
            this.btn_sekretergiris.Click += new System.EventHandler(this.btn_sekretergiris_Click);
            // 
            // btn_doktorgiris
            // 
            this.btn_doktorgiris.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_doktorgiris.Location = new System.Drawing.Point(16, 80);
            this.btn_doktorgiris.Name = "btn_doktorgiris";
            this.btn_doktorgiris.Size = new System.Drawing.Size(126, 66);
            this.btn_doktorgiris.TabIndex = 1;
            this.btn_doktorgiris.Text = "Doktor \r\nGiriş";
            this.btn_doktorgiris.UseVisualStyleBackColor = true;
            this.btn_doktorgiris.Click += new System.EventHandler(this.btn_doktorgiris_Click);
            // 
            // btn_hastagiris
            // 
            this.btn_hastagiris.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_hastagiris.Location = new System.Drawing.Point(16, 9);
            this.btn_hastagiris.Name = "btn_hastagiris";
            this.btn_hastagiris.Size = new System.Drawing.Size(126, 65);
            this.btn_hastagiris.TabIndex = 0;
            this.btn_hastagiris.Text = "Hasta \r\nGiriş";
            this.btn_hastagiris.UseVisualStyleBackColor = true;
            this.btn_hastagiris.Click += new System.EventHandler(this.btn_hastagiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hastane Otomasyonu";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_hastakayit;
        private System.Windows.Forms.Button btn_sekretergiris;
        private System.Windows.Forms.Button btn_doktorgiris;
        private System.Windows.Forms.Button btn_hastagiris;
        private System.Windows.Forms.Button btn_Cikis;
    }
}

