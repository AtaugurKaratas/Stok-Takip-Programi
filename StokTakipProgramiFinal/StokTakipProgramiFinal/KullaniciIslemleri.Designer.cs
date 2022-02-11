
namespace StokTakipProgramiFinal
{
    partial class KullaniciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciIslemleri));
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.dgwKullanicilar = new System.Windows.Forms.DataGridView();
            this.lblKullaniciSoyadi = new System.Windows.Forms.Label();
            this.txtKullaniciSoyadi = new System.Windows.Forms.TextBox();
            this.picProfilResmi = new System.Windows.Forms.PictureBox();
            this.lblResim = new System.Windows.Forms.Label();
            this.btnKullaniciListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(9, 38);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(83, 13);
            this.lblTcNo.TabIndex = 0;
            this.lblTcNo.Text = "T.C. Kimlik No : ";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(112, 36);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(122, 20);
            this.txtTcNo.TabIndex = 0;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(9, 63);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(73, 13);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(112, 61);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(122, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // dgwKullanicilar
            // 
            this.dgwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanicilar.Location = new System.Drawing.Point(9, 178);
            this.dgwKullanicilar.Name = "dgwKullanicilar";
            this.dgwKullanicilar.RowTemplate.Height = 25;
            this.dgwKullanicilar.Size = new System.Drawing.Size(599, 160);
            this.dgwKullanicilar.TabIndex = 3;
            this.dgwKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanicilar_CellClick);
            // 
            // lblKullaniciSoyadi
            // 
            this.lblKullaniciSoyadi.AutoSize = true;
            this.lblKullaniciSoyadi.Location = new System.Drawing.Point(9, 88);
            this.lblKullaniciSoyadi.Name = "lblKullaniciSoyadi";
            this.lblKullaniciSoyadi.Size = new System.Drawing.Size(90, 13);
            this.lblKullaniciSoyadi.TabIndex = 5;
            this.lblKullaniciSoyadi.Text = "Kullanıcı Soyadı : ";
            // 
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(112, 88);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(122, 20);
            this.txtKullaniciSoyadi.TabIndex = 2;
            this.txtKullaniciSoyadi.TextChanged += new System.EventHandler(this.txtKullaniciSoyadi_TextChanged);
            // 
            // picProfilResmi
            // 
            this.picProfilResmi.Image = ((System.Drawing.Image)(resources.GetObject("picProfilResmi.Image")));
            this.picProfilResmi.Location = new System.Drawing.Point(435, 36);
            this.picProfilResmi.Name = "picProfilResmi";
            this.picProfilResmi.Size = new System.Drawing.Size(173, 118);
            this.picProfilResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilResmi.TabIndex = 6;
            this.picProfilResmi.TabStop = false;
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(389, 38);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(45, 13);
            this.lblResim.TabIndex = 7;
            this.lblResim.Text = "Resim : ";
            // 
            // btnKullaniciListele
            // 
            this.btnKullaniciListele.Location = new System.Drawing.Point(12, 149);
            this.btnKullaniciListele.Name = "btnKullaniciListele";
            this.btnKullaniciListele.Size = new System.Drawing.Size(121, 23);
            this.btnKullaniciListele.TabIndex = 8;
            this.btnKullaniciListele.Text = "KULLANICI LİSTELE";
            this.btnKullaniciListele.UseVisualStyleBackColor = true;
            this.btnKullaniciListele.Click += new System.EventHandler(this.btnKullaniciListele_Click);
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(630, 348);
            this.Controls.Add(this.btnKullaniciListele);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.picProfilResmi);
            this.Controls.Add(this.txtKullaniciSoyadi);
            this.Controls.Add(this.lblKullaniciSoyadi);
            this.Controls.Add(this.dgwKullanicilar);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.lblTcNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciIslemleri";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.DataGridView dgwKullanicilar;
        private System.Windows.Forms.Label lblKullaniciSoyadi;
        private System.Windows.Forms.TextBox txtKullaniciSoyadi;
        private System.Windows.Forms.PictureBox picProfilResmi;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.Button btnKullaniciListele;
    }
}