namespace library
{
    partial class Anasayfafrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfafrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Location = new System.Drawing.Point(47, 133);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(336, 36);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listele";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(47, 74);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(336, 32);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Location = new System.Drawing.Point(413, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(49, 134);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(387, 48);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(53, 44);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(383, 43);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 298);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Anasayfafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(879, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anasayfafrm";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfafrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

