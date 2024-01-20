namespace HastaneOtomasyonu
{
    partial class DuyuruGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyuruGonder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.richTextBox_duyuru = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_konu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 95);
            this.panel1.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duyuru Gönder";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btn_Gonder);
            this.panel2.Controls.Add(this.richTextBox_duyuru);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_konu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(116, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 314);
            this.panel2.TabIndex = 6;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Gonder.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gonder.Location = new System.Drawing.Point(394, 255);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(126, 41);
            this.btn_Gonder.TabIndex = 10;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = false;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // richTextBox_duyuru
            // 
            this.richTextBox_duyuru.Location = new System.Drawing.Point(120, 65);
            this.richTextBox_duyuru.Name = "richTextBox_duyuru";
            this.richTextBox_duyuru.Size = new System.Drawing.Size(400, 173);
            this.richTextBox_duyuru.TabIndex = 3;
            this.richTextBox_duyuru.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duyuru:";
            // 
            // txt_konu
            // 
            this.txt_konu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_konu.Location = new System.Drawing.Point(120, 14);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(400, 24);
            this.txt_konu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Konu:";
            // 
            // DuyuruGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DuyuruGonder";
            this.Text = "Duyuru Gönder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DuyuruGonder_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox_duyuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_konu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Gonder;
    }
}