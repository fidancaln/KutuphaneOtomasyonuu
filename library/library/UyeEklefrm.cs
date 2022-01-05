using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace library
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8HJ2GO0;Initial Catalog=Kütüphane;Integrated Security=True");


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values (@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@tc",textTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", textYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet",comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", textAdres.Text);
            komut.Parameters.AddWithValue("@email", textEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", textOkunanSayi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uye kaydı yapıldı.");
            foreach (Control item in Controls)
            {
                if  (item is TextBox)
                {
                    if (item!=textOkunanSayi)
                    {
                      item.Text = "";
                    }
                   
                }
            }




        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void textTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
