
namespace StokTakipProgramiFinal
{
    partial class StokAlis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokAlis));
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblBirimFiyati = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cbbKategori = new System.Windows.Forms.ComboBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.picStokResim = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.lblUrunResmi = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.cbbBirim = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirimMiktari = new System.Windows.Forms.Label();
            this.txtBirimMiktari = new System.Windows.Forms.TextBox();
            this.lblDepo = new System.Windows.Forms.Label();
            this.cbbDepoBilgisi = new System.Windows.Forms.ComboBox();
            this.lblFirma = new System.Windows.Forms.Label();
            this.cbbFirma = new System.Windows.Forms.ComboBox();
            this.ofdResimEkle = new System.Windows.Forms.OpenFileDialog();
            this.btnBarkod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStokResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(10, 64);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 13);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı : ";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(10, 39);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(78, 13);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "Barkod Kodu : ";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(10, 89);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(45, 13);
            this.lblMiktar.TabIndex = 2;
            this.lblMiktar.Text = "Miktar : ";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(10, 115);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(55, 13);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori : ";
            // 
            // lblBirimFiyati
            // 
            this.lblBirimFiyati.AutoSize = true;
            this.lblBirimFiyati.Location = new System.Drawing.Point(302, 67);
            this.lblBirimFiyati.Name = "lblBirimFiyati";
            this.lblBirimFiyati.Size = new System.Drawing.Size(65, 13);
            this.lblBirimFiyati.TabIndex = 5;
            this.lblBirimFiyati.Text = "Birim Fiyatı : ";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(90, 36);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(104, 20);
            this.txtUrunKodu.TabIndex = 0;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(90, 62);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(104, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(90, 87);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(104, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "0";
            // 
            // cbbKategori
            // 
            this.cbbKategori.FormattingEnabled = true;
            this.cbbKategori.Location = new System.Drawing.Point(90, 113);
            this.cbbKategori.Name = "cbbKategori";
            this.cbbKategori.Size = new System.Drawing.Size(104, 21);
            this.cbbKategori.TabIndex = 4;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(387, 64);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(104, 20);
            this.txtBirimFiyati.TabIndex = 8;
            this.txtBirimFiyati.Text = "0";
            // 
            // picStokResim
            // 
            this.picStokResim.Image = ((System.Drawing.Image)(resources.GetObject("picStokResim.Image")));
            this.picStokResim.Location = new System.Drawing.Point(580, 39);
            this.picStokResim.Name = "picStokResim";
            this.picStokResim.Size = new System.Drawing.Size(167, 94);
            this.picStokResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStokResim.TabIndex = 13;
            this.picStokResim.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(580, 139);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(167, 21);
            this.btnResimEkle.TabIndex = 12;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // lblUrunResmi
            // 
            this.lblUrunResmi.AutoSize = true;
            this.lblUrunResmi.Location = new System.Drawing.Point(509, 43);
            this.lblUrunResmi.Name = "lblUrunResmi";
            this.lblUrunResmi.Size = new System.Drawing.Size(71, 13);
            this.lblUrunResmi.TabIndex = 15;
            this.lblUrunResmi.Text = "Ürün Resmi : ";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(10, 166);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(38, 13);
            this.lblBirim.TabIndex = 18;
            this.lblBirim.Text = "Birim : ";
            // 
            // cbbBirim
            // 
            this.cbbBirim.FormattingEnabled = true;
            this.cbbBirim.Location = new System.Drawing.Point(90, 164);
            this.cbbBirim.Name = "cbbBirim";
            this.cbbBirim.Size = new System.Drawing.Size(104, 21);
            this.cbbBirim.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(580, 165);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 20);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // lblBirimMiktari
            // 
            this.lblBirimMiktari.AutoSize = true;
            this.lblBirimMiktari.Location = new System.Drawing.Point(302, 44);
            this.lblBirimMiktari.Name = "lblBirimMiktari";
            this.lblBirimMiktari.Size = new System.Drawing.Size(72, 13);
            this.lblBirimMiktari.TabIndex = 24;
            this.lblBirimMiktari.Text = "Birim Miktarı : ";
            // 
            // txtBirimMiktari
            // 
            this.txtBirimMiktari.Location = new System.Drawing.Point(387, 39);
            this.txtBirimMiktari.Name = "txtBirimMiktari";
            this.txtBirimMiktari.Size = new System.Drawing.Size(104, 20);
            this.txtBirimMiktari.TabIndex = 7;
            this.txtBirimMiktari.Text = "0";
            // 
            // lblDepo
            // 
            this.lblDepo.AutoSize = true;
            this.lblDepo.Location = new System.Drawing.Point(302, 92);
            this.lblDepo.Name = "lblDepo";
            this.lblDepo.Size = new System.Drawing.Size(71, 13);
            this.lblDepo.TabIndex = 26;
            this.lblDepo.Text = "Depo Bilgisi : ";
            // 
            // cbbDepoBilgisi
            // 
            this.cbbDepoBilgisi.FormattingEnabled = true;
            this.cbbDepoBilgisi.Location = new System.Drawing.Point(387, 90);
            this.cbbDepoBilgisi.Name = "cbbDepoBilgisi";
            this.cbbDepoBilgisi.Size = new System.Drawing.Size(104, 21);
            this.cbbDepoBilgisi.TabIndex = 11;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(10, 141);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(41, 13);
            this.lblFirma.TabIndex = 28;
            this.lblFirma.Text = "Firma : ";
            // 
            // cbbFirma
            // 
            this.cbbFirma.FormattingEnabled = true;
            this.cbbFirma.Location = new System.Drawing.Point(90, 139);
            this.cbbFirma.Name = "cbbFirma";
            this.cbbFirma.Size = new System.Drawing.Size(104, 21);
            this.cbbFirma.TabIndex = 5;
            // 
            // ofdResimEkle
            // 
            this.ofdResimEkle.FileName = "ofdResimEkle";
            // 
            // btnBarkod
            // 
            this.btnBarkod.Image = ((System.Drawing.Image)(resources.GetObject("btnBarkod.Image")));
            this.btnBarkod.Location = new System.Drawing.Point(201, 36);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(48, 23);
            this.btnBarkod.TabIndex = 29;
            this.btnBarkod.UseVisualStyleBackColor = true;
            this.btnBarkod.Click += new System.EventHandler(this.btnBarkod_Click_1);
            // 
            // StokAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(768, 225);
            this.Controls.Add(this.btnBarkod);
            this.Controls.Add(this.cbbFirma);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.cbbDepoBilgisi);
            this.Controls.Add(this.lblDepo);
            this.Controls.Add(this.txtBirimMiktari);
            this.Controls.Add(this.lblBirimMiktari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbbBirim);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblUrunResmi);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.picStokResim);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.cbbKategori);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.lblBirimFiyati);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblUrunAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokAlis";
            this.Text = "STOK ALIŞ";
            this.Load += new System.EventHandler(this.StokAlis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStokResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblBirimFiyati;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cbbKategori;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.PictureBox picStokResim;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Label lblUrunResmi;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.ComboBox cbbBirim;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirimMiktari;
        private System.Windows.Forms.TextBox txtBirimMiktari;
        private System.Windows.Forms.Label lblDepo;
        private System.Windows.Forms.ComboBox cbbDepoBilgisi;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.ComboBox cbbFirma;
        private System.Windows.Forms.OpenFileDialog ofdResimEkle;
        private System.Windows.Forms.Button btnBarkod;
    }
}