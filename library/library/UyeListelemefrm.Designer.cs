namespace library
{
    partial class UyeListelemefrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textOkunanSayi = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.textYas = new System.Windows.Forms.TextBox();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.textTc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAraTc = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(490, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 547);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(188, 577);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(171, 56);
            this.btnIptal.TabIndex = 38;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(11, 577);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(156, 56);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboCinsiyet.Location = new System.Drawing.Point(161, 271);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(290, 24);
            this.comboCinsiyet.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = " Kitap Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(27, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yaş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "TC:";
            // 
            // textOkunanSayi
            // 
            this.textOkunanSayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOkunanSayi.Location = new System.Drawing.Point(161, 488);
            this.textOkunanSayi.Multiline = true;
            this.textOkunanSayi.Name = "textOkunanSayi";
            this.textOkunanSayi.Size = new System.Drawing.Size(290, 49);
            this.textOkunanSayi.TabIndex = 27;
            this.textOkunanSayi.Text = "0";
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Location = new System.Drawing.Point(161, 438);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(290, 36);
            this.textEmail.TabIndex = 26;
            // 
            // textAdres
            // 
            this.textAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAdres.Location = new System.Drawing.Point(161, 380);
            this.textAdres.Multiline = true;
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(290, 35);
            this.textAdres.TabIndex = 25;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Location = new System.Drawing.Point(161, 317);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(290, 40);
            this.txtTelefon.TabIndex = 24;
            // 
            // textYas
            // 
            this.textYas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textYas.Location = new System.Drawing.Point(161, 208);
            this.textYas.Multiline = true;
            this.textYas.Name = "textYas";
            this.textYas.Size = new System.Drawing.Size(290, 38);
            this.textYas.TabIndex = 23;
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAdSoyad.Location = new System.Drawing.Point(161, 147);
            this.textAdSoyad.Multiline = true;
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(290, 40);
            this.textAdSoyad.TabIndex = 22;
            // 
            // textTc
            // 
            this.textTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTc.Location = new System.Drawing.Point(161, 86);
            this.textTc.Multiline = true;
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(290, 40);
            this.textTc.TabIndex = 21;
            this.textTc.TextChanged += new System.EventHandler(this.textTc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(745, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "ARA:";
            // 
            // txtAraTc
            // 
            this.txtAraTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAraTc.Location = new System.Drawing.Point(833, 12);
            this.txtAraTc.Multiline = true;
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(290, 40);
            this.txtAraTc.TabIndex = 39;
            this.txtAraTc.TextChanged += new System.EventHandler(this.txtAraTc_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1210, 134);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 53);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // UyeListelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1451, 735);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAraTc);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textOkunanSayi);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.textYas);
            this.Controls.Add(this.textAdSoyad);
            this.Controls.Add(this.textTc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListelemefrm";
            this.Text = "Uye Listeleme";
            this.Load += new System.EventHandler(this.UyeListelemefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOkunanSayi;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox textYas;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAraTc;
        private System.Windows.Forms.Button btnSil;
    }
}