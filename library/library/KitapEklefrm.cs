﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8HJ2GO0;Initial Catalog=Kütüphane;Integrated Security=True");
        private void KitapEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayittarihi) values (@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtkitapadi.Text);
            komut.Parameters.AddWithValue("@yazari", txtyazari.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtsayfasayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboturu.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@kayittarihi",DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap kaydı yapıldı.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    
                        item.Text = "";
                    

                }
            }
        }
    }
}
