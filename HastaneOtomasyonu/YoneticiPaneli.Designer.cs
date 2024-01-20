namespace HastaneOtomasyonu
{
    partial class YoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_yoneticiekle = new System.Windows.Forms.Button();
            this.btn_doktorekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 95);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 13);
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
            this.label1.Location = new System.Drawing.Point(242, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_yoneticiekle);
            this.panel2.Controls.Add(this.btn_doktorekle);
            this.panel2.Location = new System.Drawing.Point(-4, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 359);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(9, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "Duyuru Gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(9, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "Bölüm Ekle/Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_yoneticiekle
            // 
            this.btn_yoneticiekle.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_yoneticiekle.Location = new System.Drawing.Point(9, 71);
            this.btn_yoneticiekle.Name = "btn_yoneticiekle";
            this.btn_yoneticiekle.Size = new System.Drawing.Size(126, 65);
            this.btn_yoneticiekle.TabIndex = 11;
            this.btn_yoneticiekle.Text = "Yönetici Ekle/Sil";
            this.btn_yoneticiekle.UseVisualStyleBackColor = true;
            this.btn_yoneticiekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_doktorekle
            // 
            this.btn_doktorekle.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_doktorekle.Location = new System.Drawing.Point(9, 0);
            this.btn_doktorekle.Name = "btn_doktorekle";
            this.btn_doktorekle.Size = new System.Drawing.Size(126, 65);
            this.btn_doktorekle.TabIndex = 10;
            this.btn_doktorekle.Text = "Doktor Ekle/Sil";
            this.btn_doktorekle.UseVisualStyleBackColor = true;
            this.btn_doktorekle.Click += new System.EventHandler(this.btn_doktorekle_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(9, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 65);
            this.button3.TabIndex = 14;
            this.button3.Text = "Duyurular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "YoneticiPaneli";
            this.Text = "Yönetici Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekreterPaneli_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_doktorekle;
        private System.Windows.Forms.Button btn_yoneticiekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}