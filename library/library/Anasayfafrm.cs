﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Anasayfafrm : Form
    {
        public Anasayfafrm()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEklefrm uyeekle = new UyeEklefrm();
            uyeekle.ShowDialog();

        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyeliste = new UyeListelemefrm();
            uyeliste.ShowDialog();

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapekle=new KitapEklefrm();
            kitapekle.ShowDialog();


        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitaplistele = new KitapListelefrm();
            kitaplistele.ShowDialog();

        }

        private void Anasayfafrm_Load(object sender, EventArgs e)
        {

        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            //EmanetKitapVerfrm emanetkitapver = new EmanetKitapVerfrm();
            //emanetkitapver.ShowDialog();

        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
          
            //EmanetKitapListelefrm listele = new EmanetKitapListelefrm();
           // listele.ShowDialog();
        }

        private void btnEmanetiade_Click(object sender, EventArgs e)
        {
          //  emanetkitapiadefrm iade = new emanetkitapiadefrm();
           // iade.ShowDialog();
        }
    }
}
