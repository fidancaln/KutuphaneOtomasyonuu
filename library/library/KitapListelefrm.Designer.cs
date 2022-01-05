namespace library
{
    partial class KitapListelefrm
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
            this.comboturu = new System.Windows.Forms.ComboBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.txtyazari = new System.Windows.Forms.TextBox();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboturu
            // 
            this.comboturu.FormattingEnabled = true;
            this.comboturu.Items.AddRange(new object[] {
            "Çocuk Kitapları",
            "Hikaye",
            "Roman"});
            this.comboturu.Location = new System.Drawing.Point(144, 243);
            this.comboturu.Name = "comboturu";
            this.comboturu.Size = new System.Drawing.Size(263, 24);
            this.comboturu.TabIndex = 43;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(276, 435);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(126, 43);
            this.btniptal.TabIndex = 42;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(124, 435);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 43);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Raf No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Stok Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Yayınevi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kitap Barkod No:";
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(144, 31);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(263, 22);
            this.txtbarkodno.TabIndex = 31;
            this.txtbarkodno.TextChanged += new System.EventHandler(this.txtbarkodno_TextChanged);
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(144, 75);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(263, 22);
            this.txtkitapadi.TabIndex = 30;
            // 
            // txtyazari
            // 
            this.txtyazari.Location = new System.Drawing.Point(144, 119);
            this.txtyazari.Name = "txtyazari";
            this.txtyazari.Size = new System.Drawing.Size(263, 22);
            this.txtyazari.TabIndex = 29;
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.Location = new System.Drawing.Point(144, 154);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.Size = new System.Drawing.Size(263, 22);
            this.txtyayinevi.TabIndex = 28;
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(144, 198);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(263, 22);
            this.txtsayfasayisi.TabIndex = 27;
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.Location = new System.Drawing.Point(144, 283);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(263, 22);
            this.txtStokSayisi.TabIndex = 26;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(144, 333);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(263, 22);
            this.txtRafNo.TabIndex = 25;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(144, 371);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(263, 22);
            this.txtAciklama.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(463, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 501);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(760, 610);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 51);
            this.btnSil.TabIndex = 45;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Kitap Barkod No Ara:";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(715, 48);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(263, 22);
            this.txtBarkodAra.TabIndex = 46;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // KitapListelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1214, 673);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboturu);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodno);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.txtyazari);
            this.Controls.Add(this.txtyayinevi);
            this.Controls.Add(this.txtsayfasayisi);
            this.Controls.Add(this.txtStokSayisi);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.txtAciklama);
            this.Name = "KitapListelefrm";
            this.Text = "Kitap Listele";
            this.Load += new System.EventHandler(this.KitapListelefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboturu;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.TextBox txtyazari;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarkodAra;
    }
}