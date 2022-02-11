
namespace StokTakipProgramiFinal
{
    partial class FirmaBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaBilgileri));
            this.btnResimGuncelle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.picFirmaResim = new System.Windows.Forms.PictureBox();
            this.lblFirmaResim = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwFirmaBilgileri = new System.Windows.Forms.DataGridView();
            this.ofdFirma = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFirmaResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmaBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimGuncelle
            // 
            this.btnResimGuncelle.Location = new System.Drawing.Point(496, 125);
            this.btnResimGuncelle.Name = "btnResimGuncelle";
            this.btnResimGuncelle.Size = new System.Drawing.Size(167, 20);
            this.btnResimGuncelle.TabIndex = 6;
            this.btnResimGuncelle.Text = "FİRMA RESMİ GÜNCELLE";
            this.btnResimGuncelle.UseVisualStyleBackColor = true;
            this.btnResimGuncelle.Click += new System.EventHandler(this.btnResimGuncelle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(477, 162);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 20);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(296, 84);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(115, 66);
            this.txtAciklama.TabIndex = 5;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(199, 87);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 13);
            this.lblAciklama.TabIndex = 28;
            this.lblAciklama.Text = "Açıklama : ";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(75, 134);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(115, 20);
            this.txtHesapNo.TabIndex = 2;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(296, 50);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(115, 20);
            this.txtVergiDairesi.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(296, 24);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(115, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(75, 63);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(115, 57);
            this.txtAdres.TabIndex = 1;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(75, 24);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(115, 20);
            this.txtFirmaAdi.TabIndex = 0;
            // 
            // picFirmaResim
            // 
            this.picFirmaResim.Image = ((System.Drawing.Image)(resources.GetObject("picFirmaResim.Image")));
            this.picFirmaResim.Location = new System.Drawing.Point(496, 24);
            this.picFirmaResim.Name = "picFirmaResim";
            this.picFirmaResim.Size = new System.Drawing.Size(167, 94);
            this.picFirmaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirmaResim.TabIndex = 22;
            this.picFirmaResim.TabStop = false;
            // 
            // lblFirmaResim
            // 
            this.lblFirmaResim.AutoSize = true;
            this.lblFirmaResim.Location = new System.Drawing.Point(421, 27);
            this.lblFirmaResim.Name = "lblFirmaResim";
            this.lblFirmaResim.Size = new System.Drawing.Size(73, 13);
            this.lblFirmaResim.TabIndex = 21;
            this.lblFirmaResim.Text = "Firma Resmi : ";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(10, 136);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(64, 13);
            this.lblHesapNo.TabIndex = 20;
            this.lblHesapNo.Text = "Hesap No : ";
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.Location = new System.Drawing.Point(199, 53);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(75, 13);
            this.lblVergiDairesi.TabIndex = 19;
            this.lblVergiDairesi.Text = "Vergi Dairesi : ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(199, 27);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 13);
            this.lblTelefon.TabIndex = 18;
            this.lblTelefon.Text = "Telefon : ";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(10, 65);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(43, 13);
            this.lblAdres.TabIndex = 17;
            this.lblAdres.Text = "Adres : ";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(10, 27);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(59, 13);
            this.lblFirmaAdi.TabIndex = 16;
            this.lblFirmaAdi.Text = "Firma Adı : ";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(599, 162);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 20);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwFirmaBilgileri
            // 
            this.dgwFirmaBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFirmaBilgileri.Location = new System.Drawing.Point(10, 188);
            this.dgwFirmaBilgileri.Name = "dgwFirmaBilgileri";
            this.dgwFirmaBilgileri.RowTemplate.Height = 25;
            this.dgwFirmaBilgileri.Size = new System.Drawing.Size(653, 134);
            this.dgwFirmaBilgileri.TabIndex = 9;
            this.dgwFirmaBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFirmaBilgileri_CellClick);
            // 
            // ofdFirma
            // 
            this.ofdFirma.FileName = "ofdFirma";
            // 
            // FirmaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(678, 332);
            this.Controls.Add(this.dgwFirmaBilgileri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResimGuncelle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.picFirmaResim);
            this.Controls.Add(this.lblFirmaResim);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblVergiDairesi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblFirmaAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirmaBilgileri";
            this.Text = "FİRMA BİLGİLERİ";
            this.Load += new System.EventHandler(this.FirmaBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFirmaResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFirmaBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResimGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.PictureBox picFirmaResim;
        private System.Windows.Forms.Label lblFirmaResim;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwFirmaBilgileri;
        private System.Windows.Forms.OpenFileDialog ofdFirma;
    }
}