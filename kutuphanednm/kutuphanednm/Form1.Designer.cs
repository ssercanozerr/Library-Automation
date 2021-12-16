
namespace kutuphanednm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnYayinevleri = new System.Windows.Forms.Button();
            this.btnYazarlar = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnBasim = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnKutuphaneler = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyeler
            // 
            this.btnUyeler.BackColor = System.Drawing.Color.White;
            this.btnUyeler.Location = new System.Drawing.Point(466, 47);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(102, 31);
            this.btnUyeler.TabIndex = 18;
            this.btnUyeler.Text = "ÜYELER";
            this.btnUyeler.UseVisualStyleBackColor = false;
            this.btnUyeler.Click += new System.EventHandler(this.btnUyeler_Click);
            // 
            // btnYayinevleri
            // 
            this.btnYayinevleri.BackColor = System.Drawing.Color.White;
            this.btnYayinevleri.Location = new System.Drawing.Point(321, 47);
            this.btnYayinevleri.Name = "btnYayinevleri";
            this.btnYayinevleri.Size = new System.Drawing.Size(102, 31);
            this.btnYayinevleri.TabIndex = 17;
            this.btnYayinevleri.Text = "YAYINEVLERİ";
            this.btnYayinevleri.UseVisualStyleBackColor = false;
            this.btnYayinevleri.Click += new System.EventHandler(this.btnYayinevleri_Click);
            // 
            // btnYazarlar
            // 
            this.btnYazarlar.BackColor = System.Drawing.Color.White;
            this.btnYazarlar.Location = new System.Drawing.Point(188, 47);
            this.btnYazarlar.Name = "btnYazarlar";
            this.btnYazarlar.Size = new System.Drawing.Size(102, 31);
            this.btnYazarlar.TabIndex = 16;
            this.btnYazarlar.Text = "YAZARLAR";
            this.btnYazarlar.UseVisualStyleBackColor = false;
            this.btnYazarlar.Click += new System.EventHandler(this.btnYazarlar_Click);
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackColor = System.Drawing.Color.White;
            this.btnKitaplar.Location = new System.Drawing.Point(41, 47);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(102, 31);
            this.btnKitaplar.TabIndex = 12;
            this.btnKitaplar.Text = "KİTAPLAR";
            this.btnKitaplar.UseVisualStyleBackColor = false;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnBasim
            // 
            this.btnBasim.BackColor = System.Drawing.Color.White;
            this.btnBasim.Location = new System.Drawing.Point(321, 114);
            this.btnBasim.Name = "btnBasim";
            this.btnBasim.Size = new System.Drawing.Size(102, 31);
            this.btnBasim.TabIndex = 30;
            this.btnBasim.Text = "BASIM TÜRLERİ";
            this.btnBasim.UseVisualStyleBackColor = false;
            this.btnBasim.Click += new System.EventHandler(this.btnBasim_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(188, 114);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(102, 31);
            this.btnKategori.TabIndex = 29;
            this.btnKategori.Text = "KATEGORİLER";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnKutuphaneler
            // 
            this.btnKutuphaneler.BackColor = System.Drawing.Color.White;
            this.btnKutuphaneler.Location = new System.Drawing.Point(41, 114);
            this.btnKutuphaneler.Name = "btnKutuphaneler";
            this.btnKutuphaneler.Size = new System.Drawing.Size(102, 31);
            this.btnKutuphaneler.TabIndex = 28;
            this.btnKutuphaneler.Text = "KÜTÜPHANELER";
            this.btnKutuphaneler.UseVisualStyleBackColor = false;
            this.btnKutuphaneler.Click += new System.EventHandler(this.btnKutuphaneler_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(466, 114);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 31);
            this.btnCikis.TabIndex = 31;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 191);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBasim);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnKutuphaneler);
            this.Controls.Add(this.btnUyeler);
            this.Controls.Add(this.btnYayinevleri);
            this.Controls.Add(this.btnYazarlar);
            this.Controls.Add(this.btnKitaplar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.Button btnYayinevleri;
        private System.Windows.Forms.Button btnYazarlar;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnBasim;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnKutuphaneler;
        private System.Windows.Forms.Button btnCikis;
    }
}

