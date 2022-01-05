using System;
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
    public partial class KitapListelefrm : Form
    {
        public KitapListelefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8HJ2GO0;Initial Catalog=Kütüphane;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }








        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;

            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme islemi gerceklesti.");
                daset.Tables["kitap"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }


            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapadi=@kitapadi, yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtkitapadi.Text);
            komut.Parameters.AddWithValue("@yazari",txtyazari.Text);
            komut.Parameters.AddWithValue("@yayinevi",txtyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",txtsayfasayisi.Text);
            komut.Parameters.AddWithValue("@turu",comboturu.Text);
            komut.Parameters.AddWithValue("@stoksayisi",txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno",txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama",txtAciklama.Text);
     

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Guncelleme islemi gerceklesti.");


            daset.Tables["Uye"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }



            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where barkodno like '%" + txtbarkodno.Text+ "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];

            baglanti.Close();
        
    }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like '" + txtBarkodAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapadi.Text = read["kitapadi"].ToString();
                txtyazari.Text = read["yazari"].ToString();
                txtyayinevi.Text = read["yayinevi"].ToString();
                txtsayfasayisi.Text = read["sayfasayisi"].ToString();
                comboturu.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();

            }
            baglanti.Close();
        }

        }
}
