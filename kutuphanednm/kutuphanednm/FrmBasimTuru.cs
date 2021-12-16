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
    public partial class FrmBasimTuru : Form
    {
        public FrmBasimTuru()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbKutuphane; user ID=postgres; password=birdendokuza");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from basimturu";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into basimturu(basim_id,kapakAd) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut1.Parameters.AddWithValue("@p2", txtAd.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kapak Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from basimturu where basim_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kapak Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update basimturu set kapakAd=@p2  where basim_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtId.Text));
            komut3.Parameters.AddWithValue("@p2", txtAd.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kapak Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from listeletur()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnEkle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into tur(tur_id,basim_id,kitap_id) values(@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtTur.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtBasim.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from tur where tur_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtTur.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update tur set basim_id=@p2, kitap_id=@p3 where tur_id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtTur.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(txtBasim.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(txtKitap.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAra1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from basimturu where basim_id=@p1", baglanti);
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
            NpgsqlCommand komut = new NpgsqlCommand("select * from tur where tur_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtTur.Text));
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
