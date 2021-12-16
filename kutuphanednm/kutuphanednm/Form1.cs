using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphanednm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            FrmKitaplar frmKitaplar = new FrmKitaplar();
            frmKitaplar.ShowDialog();
        }

        private void btnYazarlar_Click(object sender, EventArgs e)
        {
            FrmYazarlar frmYazarlar = new FrmYazarlar();
            frmYazarlar.ShowDialog();
        }

        private void btnYayinevleri_Click(object sender, EventArgs e)
        {
            FrmYayinevleri frmYayinevleri = new FrmYayinevleri();
            frmYayinevleri.ShowDialog();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            FrmUyeler frmUyeler = new FrmUyeler();
            frmUyeler.ShowDialog();
        }

        private void btnKutuphaneler_Click(object sender, EventArgs e)
        {
            FrmKutuphaneler frmKutuphaneler = new FrmKutuphaneler();
            frmKutuphaneler.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategoriler frmKategoriler = new FrmKategoriler();
            frmKategoriler.ShowDialog();
        }

        private void btnBasim_Click(object sender, EventArgs e)
        {
            FrmBasimTuru frmBasimTuru = new FrmBasimTuru();
            frmBasimTuru.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
