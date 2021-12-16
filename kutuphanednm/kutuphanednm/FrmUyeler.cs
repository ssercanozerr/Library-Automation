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
    public partial class FrmUyeler : Form
    {
        public FrmUyeler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbKutuphane; user ID=postgres; password=birdendokuza");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from viewuyeler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into uyeler(uye_id,uyead,uyesoyad,uyecinsiyet,uyemail,uyetipi_id) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut1.Parameters.AddWithValue("@p2", txtAd.Text);
            komut1.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@p4", txtCinsiyet.Text);
            komut1.Parameters.AddWithValue("@p5", txtMail.Text);
            komut1.Parameters.AddWithValue("@p6", int.Parse(txtTip.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from uyeler where uye_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update uyeler set uyead=@p2, uyesoyad=@p3, uyecinsiyet=@p4, uyemail=@p5, uyetipi_id=@p6 where uye_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut3.Parameters.AddWithValue("@p2", txtAd.Text);
            komut3.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut3.Parameters.AddWithValue("@p4", txtCinsiyet.Text);
            komut3.Parameters.AddWithValue("@p5", txtMail.Text);
            komut3.Parameters.AddWithValue("@p6", int.Parse(txtTip.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from listeleodunc()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into odunc(odunc_id,uye_id,kitap_id) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtOdunc.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtUye.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from odunc where odunc_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtOdunc.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update odunc set uye_id=@p2, kitap_id=@p3 where odunc_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtOdunc.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtUye.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from toplamuye";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void btnAra1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from uyeler where uye_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnAra2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from odunc where odunc_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtOdunc.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
