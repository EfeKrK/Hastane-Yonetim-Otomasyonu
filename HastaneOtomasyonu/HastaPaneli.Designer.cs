namespace HastaneOtomasyonu
{
    partial class HastaPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_RandevuAl = new System.Windows.Forms.Button();
            this.btn_MevcutRandevular = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 99);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 22);
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
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_RandevuAl);
            this.panel2.Controls.Add(this.btn_MevcutRandevular);
            this.panel2.Location = new System.Drawing.Point(1, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 353);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(11, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reçetelerim";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_RandevuAl
            // 
            this.btn_RandevuAl.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_RandevuAl.Location = new System.Drawing.Point(11, 96);
            this.btn_RandevuAl.Name = "btn_RandevuAl";
            this.btn_RandevuAl.Size = new System.Drawing.Size(137, 65);
            this.btn_RandevuAl.TabIndex = 2;
            this.btn_RandevuAl.Text = "Randevu Al";
            this.btn_RandevuAl.UseVisualStyleBackColor = true;
            this.btn_RandevuAl.Click += new System.EventHandler(this.btn_RandevuAl_Click);
            // 
            // btn_MevcutRandevular
            // 
            this.btn_MevcutRandevular.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_MevcutRandevular.Location = new System.Drawing.Point(11, 8);
            this.btn_MevcutRandevular.Name = "btn_MevcutRandevular";
            this.btn_MevcutRandevular.Size = new System.Drawing.Size(137, 65);
            this.btn_MevcutRandevular.TabIndex = 1;
            this.btn_MevcutRandevular.Text = "Mevcut Randevularım";
            this.btn_MevcutRandevular.UseVisualStyleBackColor = true;
            this.btn_MevcutRandevular.Click += new System.EventHandler(this.btn_MevcutRandevular_Click);
            // 
            // HastaPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HastaPaneli";
            this.Text = "HastaPaneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HastaPaneli_FormClosing);
            this.Load += new System.EventHandler(this.HastaPaneli_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_RandevuAl;
        private System.Windows.Forms.Button btn_MevcutRandevular;
    }
}