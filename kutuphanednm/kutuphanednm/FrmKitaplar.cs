using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kutuphanednm
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbKutuphane; user ID=postgres; password=birdendokuza");

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from viewkitaplar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kitaplar(kitap_id,barkod,kitapAd,sayfaSayisi,yayinTarihi,durum_id) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtBarkod.Text));
            komut1.Parameters.AddWithValue("@p3", txtKitapad.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(txtSayfa.Text));
            komut1.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            komut1.Parameters.AddWithValue("@p6", int.Parse(txtDurumid.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from kitaplar where kitap_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update kitaplar set barkod=@p2, kitapAd=@p3, sayfaSayisi=@p4, yayinTarihi=@p5, durum_id=@p6  where kitap_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtBarkod.Text));
            komut3.Parameters.AddWithValue("@p3", txtKitapad.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(txtSayfa.Text));
            komut3.Parameters.AddWithValue("@p5", dateTimePicker1.Value);
            komut3.Parameters.AddWithValue("@p6", int.Parse(txtDurumid.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from toplamkitap";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from kitaplar where kitap_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtKitapid.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
