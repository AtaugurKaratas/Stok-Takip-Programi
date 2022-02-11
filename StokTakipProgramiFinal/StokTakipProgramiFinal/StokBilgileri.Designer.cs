
namespace StokTakipProgramiFinal
{
    partial class StokBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokBilgileri));
            this.cbbDepoBilgisi = new System.Windows.Forms.ComboBox();
            this.lblDepo = new System.Windows.Forms.Label();
            this.txtBirimMiktari = new System.Windows.Forms.TextBox();
            this.lblBirimMiktari = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbbBirim = new System.Windows.Forms.ComboBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblUrunResmi = new System.Windows.Forms.Label();
            this.btnResimGuncelle = new System.Windows.Forms.Button();
            this.picStokResim = new System.Windows.Forms.PictureBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.cbbKategori = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBirimFiyati = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwStokBilgileri = new System.Windows.Forms.DataGridView();
            this.ofdResimGuncelle = new System.Windows.Forms.OpenFileDialog();
            this.lblFirma = new System.Windows.Forms.Label();
            this.cbbFirma = new System.Windows.Forms.ComboBox();
            this.btnUrunleriListeleme = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStokResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStokBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDepoBilgisi
            // 
            this.cbbDepoBilgisi.FormattingEnabled = true;
            this.cbbDepoBilgisi.Location = new System.Drawing.Point(389, 84);
            this.cbbDepoBilgisi.Name = "cbbDepoBilgisi";
            this.cbbDepoBilgisi.Size = new System.Drawing.Size(104, 21);
            this.cbbDepoBilgisi.TabIndex = 10;
            // 
            // lblDepo
            // 
            this.lblDepo.AutoSize = true;
            this.lblDepo.Location = new System.Drawing.Point(311, 87);
            this.lblDepo.Name = "lblDepo";
            this.lblDepo.Size = new System.Drawing.Size(71, 13);
            this.lblDepo.TabIndex = 51;
            this.lblDepo.Text = "Depo Bilgisi : ";
            // 
            // txtBirimMiktari
            // 
            this.txtBirimMiktari.Location = new System.Drawing.Point(389, 29);
            this.txtBirimMiktari.Name = "txtBirimMiktari";
            this.txtBirimMiktari.Size = new System.Drawing.Size(104, 20);
            this.txtBirimMiktari.TabIndex = 6;
            this.txtBirimMiktari.Text = "0";
            // 
            // lblBirimMiktari
            // 
            this.lblBirimMiktari.AutoSize = true;
            this.lblBirimMiktari.Location = new System.Drawing.Point(311, 32);
            this.lblBirimMiktari.Name = "lblBirimMiktari";
            this.lblBirimMiktari.Size = new System.Drawing.Size(72, 13);
            this.lblBirimMiktari.TabIndex = 49;
            this.lblBirimMiktari.Text = "Birim Miktarı : ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(565, 161);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 20);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbbBirim
            // 
            this.cbbBirim.FormattingEnabled = true;
            this.cbbBirim.Location = new System.Drawing.Point(105, 136);
            this.cbbBirim.Name = "cbbBirim";
            this.cbbBirim.Size = new System.Drawing.Size(104, 21);
            this.cbbBirim.TabIndex = 5;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(25, 140);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(38, 13);
            this.lblBirim.TabIndex = 44;
            this.lblBirim.Text = "Birim : ";
            // 
            // lblUrunResmi
            // 
            this.lblUrunResmi.AutoSize = true;
            this.lblUrunResmi.Location = new System.Drawing.Point(519, 34);
            this.lblUrunResmi.Name = "lblUrunResmi";
            this.lblUrunResmi.Size = new System.Drawing.Size(71, 13);
            this.lblUrunResmi.TabIndex = 41;
            this.lblUrunResmi.Text = "Ürün Resmi : ";
            // 
            // btnResimGuncelle
            // 
            this.btnResimGuncelle.Location = new System.Drawing.Point(590, 128);
            this.btnResimGuncelle.Name = "btnResimGuncelle";
            this.btnResimGuncelle.Size = new System.Drawing.Size(167, 21);
            this.btnResimGuncelle.TabIndex = 11;
            this.btnResimGuncelle.Text = "Resim Güncelle";
            this.btnResimGuncelle.UseVisualStyleBackColor = true;
            this.btnResimGuncelle.Click += new System.EventHandler(this.btnResimGuncelle_Click);
            // 
            // picStokResim
            // 
            this.picStokResim.Image = ((System.Drawing.Image)(resources.GetObject("picStokResim.Image")));
            this.picStokResim.Location = new System.Drawing.Point(590, 29);
            this.picStokResim.Name = "picStokResim";
            this.picStokResim.Size = new System.Drawing.Size(167, 94);
            this.picStokResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStokResim.TabIndex = 39;
            this.picStokResim.TabStop = false;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(389, 58);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(104, 20);
            this.txtBirimFiyati.TabIndex = 7;
            this.txtBirimFiyati.Text = "0";
            // 
            // cbbKategori
            // 
            this.cbbKategori.FormattingEnabled = true;
            this.cbbKategori.Location = new System.Drawing.Point(105, 110);
            this.cbbKategori.Name = "cbbKategori";
            this.cbbKategori.Size = new System.Drawing.Size(104, 21);
            this.cbbKategori.TabIndex = 4;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(105, 84);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(104, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "0";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(105, 59);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(104, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(105, 34);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(104, 20);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // lblBirimFiyati
            // 
            this.lblBirimFiyati.AutoSize = true;
            this.lblBirimFiyati.Location = new System.Drawing.Point(311, 61);
            this.lblBirimFiyati.Name = "lblBirimFiyati";
            this.lblBirimFiyati.Size = new System.Drawing.Size(65, 13);
            this.lblBirimFiyati.TabIndex = 32;
            this.lblBirimFiyati.Text = "Birim Fiyatı : ";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(25, 113);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(55, 13);
            this.lblKategori.TabIndex = 31;
            this.lblKategori.Text = "Kategori : ";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(25, 87);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(45, 13);
            this.lblMiktar.TabIndex = 30;
            this.lblMiktar.Text = "Miktar : ";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(25, 37);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(78, 13);
            this.lblBarkod.TabIndex = 29;
            this.lblBarkod.Text = "Barkod Kodu : ";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(25, 62);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 13);
            this.lblUrunAdi.TabIndex = 28;
            this.lblUrunAdi.Text = "Ürün Adı : ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(697, 161);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 20);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwStokBilgileri
            // 
            this.dgwStokBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStokBilgileri.Location = new System.Drawing.Point(16, 263);
            this.dgwStokBilgileri.Name = "dgwStokBilgileri";
            this.dgwStokBilgileri.RowTemplate.Height = 25;
            this.dgwStokBilgileri.Size = new System.Drawing.Size(741, 130);
            this.dgwStokBilgileri.TabIndex = 14;
            this.dgwStokBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStokBilgileri_CellClick);
            // 
            // ofdResimGuncelle
            // 
            this.ofdResimGuncelle.FileName = "ofdResimGuncelle";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(25, 166);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(41, 13);
            this.lblFirma.TabIndex = 52;
            this.lblFirma.Text = "Firma : ";
            // 
            // cbbFirma
            // 
            this.cbbFirma.FormattingEnabled = true;
            this.cbbFirma.Location = new System.Drawing.Point(105, 163);
            this.cbbFirma.Name = "cbbFirma";
            this.cbbFirma.Size = new System.Drawing.Size(104, 21);
            this.cbbFirma.TabIndex = 53;
            // 
            // btnUrunleriListeleme
            // 
            this.btnUrunleriListeleme.Location = new System.Drawing.Point(16, 219);
            this.btnUrunleriListeleme.Name = "btnUrunleriListeleme";
            this.btnUrunleriListeleme.Size = new System.Drawing.Size(184, 23);
            this.btnUrunleriListeleme.TabIndex = 54;
            this.btnUrunleriListeleme.Text = "ÜRÜNLERİ LİSTELE";
            this.btnUrunleriListeleme.UseVisualStyleBackColor = true;
            this.btnUrunleriListeleme.Click += new System.EventHandler(this.btnUrunleriListeleme_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(682, 187);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 70);
            this.btnExcel.TabIndex = 55;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // StokBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(780, 405);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnUrunleriListeleme);
            this.Controls.Add(this.cbbFirma);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.dgwStokBilgileri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cbbDepoBilgisi);
            this.Controls.Add(this.lblDepo);
            this.Controls.Add(this.txtBirimMiktari);
            this.Controls.Add(this.lblBirimMiktari);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbbBirim);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblUrunResmi);
            this.Controls.Add(this.btnResimGuncelle);
            this.Controls.Add(this.picStokResim);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.cbbKategori);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBirimFiyati);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblUrunAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokBilgileri";
            this.Text = "STOK BILGILERI";
            this.Load += new System.EventHandler(this.StokBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStokResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStokBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDepoBilgisi;
        private System.Windows.Forms.Label lblDepo;
        private System.Windows.Forms.TextBox txtBirimMiktari;
        private System.Windows.Forms.Label lblBirimMiktari;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbbBirim;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblUrunResmi;
        private System.Windows.Forms.Button btnResimGuncelle;
        private System.Windows.Forms.PictureBox picStokResim;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.ComboBox cbbKategori;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBirimFiyati;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwStokBilgileri;
        private System.Windows.Forms.OpenFileDialog ofdResimGuncelle;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.ComboBox cbbFirma;
        private System.Windows.Forms.Button btnUrunleriListeleme;
        private System.Windows.Forms.Button btnExcel;
    }
}