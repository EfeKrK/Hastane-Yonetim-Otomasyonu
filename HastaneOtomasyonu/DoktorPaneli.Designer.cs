using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    partial class DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_receteyaz = new System.Windows.Forms.Button();
            this.btn_randevusil = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 100);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(247, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(408, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "RANDEVULARIM";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(192, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(603, 158);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_receteyaz);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 342);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(21, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hastane Duyuruları";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_receteyaz
            // 
            this.btn_receteyaz.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_receteyaz.Location = new System.Drawing.Point(12, 22);
            this.btn_receteyaz.Name = "btn_receteyaz";
            this.btn_receteyaz.Size = new System.Drawing.Size(140, 65);
            this.btn_receteyaz.TabIndex = 1;
            this.btn_receteyaz.Text = "Reçete Yaz";
            this.btn_receteyaz.UseVisualStyleBackColor = true;
            this.btn_receteyaz.Click += new System.EventHandler(this.btn_receteyaz_Click);
            // 
            // btn_randevusil
            // 
            this.btn_randevusil.BackColor = System.Drawing.Color.Firebrick;
            this.btn_randevusil.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevusil.Location = new System.Drawing.Point(632, 368);
            this.btn_randevusil.Name = "btn_randevusil";
            this.btn_randevusil.Size = new System.Drawing.Size(146, 47);
            this.btn_randevusil.TabIndex = 9;
            this.btn_randevusil.Text = "Randevu Sil";
            this.btn_randevusil.UseVisualStyleBackColor = false;
            this.btn_randevusil.Click += new System.EventHandler(this.btn_randevusil_Click);
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 448);
            this.Controls.Add(this.btn_randevusil);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DoktorPaneli";
            this.Text = "DoktorPaneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktorPaneli_FormClosing_1);
            this.Load += new System.EventHandler(this.DoktorPaneli_Load_2);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private Panel panel2;
        private Button btn_receteyaz;
        private Button btn_randevusil;
        private Button button1;
    }
}