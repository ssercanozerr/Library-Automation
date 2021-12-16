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
    public partial class FrmYayinevleri : Form
    {
        public FrmYayinevleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbKutuphane; user ID=postgres; password=birdendokuza");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from yayinevleri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into yayinevleri(yayinevi_id,yayineviad,yayinevisehir) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut1.Parameters.AddWithValue("@p2", txtAd.Text);
            komut1.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yayınevi Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from yayinevleri where yayinevi_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yayınevi Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update yayinevleri set yayineviad=@p2, yayinevisehir=@p3  where yayinevi_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut3.Parameters.AddWithValue("@p2", txtAd.Text);
            komut3.Parameters.AddWithValue("@p3", txtSehir.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yayınevi Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from listeleyayin()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into yayin(yayin_id,yayinevi_id,kitap_id) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtYayinevi.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from yayin where yayin_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update yayin set yayinevi_id=@p2, kitap_id=@p3 where yayin_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtYayinevi.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from yayinevleri where yayinevi_id=@p1", baglanti);
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
            NpgsqlCommand komut = new NpgsqlCommand("select * from yayin where yayin_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtYayin.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
