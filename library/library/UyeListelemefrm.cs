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
    public partial class UyeListelemefrm : Form
    {
        public UyeListelemefrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8HJ2GO0;Initial Catalog=Kütüphane;Integrated Security=True");

        private void textTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where tc like '" + textTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textAdSoyad.Text = read["adsoyad"].ToString();
                textYas.Text = read["yas"].ToString();
                comboCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                textAdres.Text = read["adres"].ToString();
                textEmail.Text = read["email"].ToString();
                textOkunanSayi.Text = read["okukitapsayisi"].ToString();

            }
            baglanti.Close();
        }
        DataSet daset = new DataSet();


        private void UyeListelemefrm_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where tc like '%" + txtAraTc.Text + "%'", baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];

            baglanti.Close();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uyelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye", baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;

            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme islemi gerceklesti.");
                daset.Tables["uye"].Clear();
                uyelistele();
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
            SqlCommand komut = new SqlCommand("update Uye set adsoyad=@adsoyad,yas=@yas, cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okukitapsayisi=@okukitapsayisi where tc=@tc", baglanti); 
            komut.Parameters.AddWithValue("@tc", textTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", textYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", textAdres.Text);
            komut.Parameters.AddWithValue("@email", textEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi",int.Parse(textOkunanSayi.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Guncelleme islemi gerceklesti.");


            daset.Tables["uye"].Clear();
            uyelistele();
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