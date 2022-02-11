namespace StokTakipProgramiFinal
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lnkLblSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grbGiris = new System.Windows.Forms.GroupBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtDogrulama = new System.Windows.Forms.TextBox();
            this.lblDogrulama = new System.Windows.Forms.Label();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.btnSifreAcKapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.Location = new System.Drawing.Point(43, 49);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(110, 64);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Image = ((System.Drawing.Image)(resources.GetObject("btnYonetici.Image")));
            this.btnYonetici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYonetici.Location = new System.Drawing.Point(166, 49);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(108, 64);
            this.btnYonetici.TabIndex = 1;
            this.btnYonetici.Text = "Yönetici";
            this.btnYonetici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYonetici.UseVisualStyleBackColor = true;
            this.btnYonetici.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(55, 133);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(73, 13);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(55, 168);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 13);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre : ";
            // 
            // lnkLblSifreUnuttum
            // 
            this.lnkLblSifreUnuttum.AutoSize = true;
            this.lnkLblSifreUnuttum.Location = new System.Drawing.Point(105, 296);
            this.lnkLblSifreUnuttum.Name = "lnkLblSifreUnuttum";
            this.lnkLblSifreUnuttum.Size = new System.Drawing.Size(117, 13);
            this.lnkLblSifreUnuttum.TabIndex = 8;
            this.lnkLblSifreUnuttum.TabStop = true;
            this.lnkLblSifreUnuttum.Text = "Şifrenizi mi Unuttunuz ?";
            this.lnkLblSifreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblSifreUnuttum_LinkClicked);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(147, 130);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(113, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(147, 166);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(113, 20);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(128, 266);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(69, 27);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(335, 347);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // grbGiris
            // 
            this.grbGiris.Controls.Add(this.btnYenile);
            this.grbGiris.Controls.Add(this.txtDogrulama);
            this.grbGiris.Controls.Add(this.lblDogrulama);
            this.grbGiris.Controls.Add(this.lblCaptcha);
            this.grbGiris.Controls.Add(this.btnSifreAcKapa);
            this.grbGiris.Controls.Add(this.btnPersonel);
            this.grbGiris.Controls.Add(this.btnYonetici);
            this.grbGiris.Controls.Add(this.lblKullaniciAdi);
            this.grbGiris.Controls.Add(this.btnGiris);
            this.grbGiris.Controls.Add(this.lblSifre);
            this.grbGiris.Controls.Add(this.txtSifre);
            this.grbGiris.Controls.Add(this.lnkLblSifreUnuttum);
            this.grbGiris.Controls.Add(this.txtKullaniciAdi);
            this.grbGiris.Location = new System.Drawing.Point(341, 12);
            this.grbGiris.Name = "grbGiris";
            this.grbGiris.Size = new System.Drawing.Size(316, 323);
            this.grbGiris.TabIndex = 9;
            this.grbGiris.TabStop = false;
            this.grbGiris.Text = "Giriş";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(58, 203);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtDogrulama
            // 
            this.txtDogrulama.Location = new System.Drawing.Point(147, 240);
            this.txtDogrulama.Name = "txtDogrulama";
            this.txtDogrulama.Size = new System.Drawing.Size(113, 20);
            this.txtDogrulama.TabIndex = 6;
            // 
            // lblDogrulama
            // 
            this.lblDogrulama.AutoSize = true;
            this.lblDogrulama.Location = new System.Drawing.Point(55, 243);
            this.lblDogrulama.Name = "lblDogrulama";
            this.lblDogrulama.Size = new System.Drawing.Size(95, 13);
            this.lblDogrulama.TabIndex = 8;
            this.lblDogrulama.Text = "Doğrulama Kodu : ";
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptcha.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCaptcha.Location = new System.Drawing.Point(142, 199);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(118, 27);
            this.lblCaptcha.TabIndex = 7;
            this.lblCaptcha.Text = "Captcha";
            // 
            // btnSifreAcKapa
            // 
            this.btnSifreAcKapa.BackColor = System.Drawing.Color.Lavender;
            this.btnSifreAcKapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreAcKapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSifreAcKapa.FlatAppearance.BorderSize = 0;
            this.btnSifreAcKapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSifreAcKapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSifreAcKapa.Image = ((System.Drawing.Image)(resources.GetObject("btnSifreAcKapa.Image")));
            this.btnSifreAcKapa.Location = new System.Drawing.Point(264, 163);
            this.btnSifreAcKapa.Name = "btnSifreAcKapa";
            this.btnSifreAcKapa.Size = new System.Drawing.Size(39, 30);
            this.btnSifreAcKapa.TabIndex = 4;
            this.btnSifreAcKapa.UseVisualStyleBackColor = false;
            this.btnSifreAcKapa.Click += new System.EventHandler(this.btnSifreAcKapa_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(669, 347);
            this.Controls.Add(this.grbGiris);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(689, 439);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisEkrani_FormClosed);
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grbGiris.ResumeLayout(false);
            this.grbGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.LinkLabel lnkLblSifreUnuttum;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grbGiris;
        private System.Windows.Forms.Button btnSifreAcKapa;
        private System.Windows.Forms.TextBox txtDogrulama;
        private System.Windows.Forms.Label lblDogrulama;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnYenile;
    }
}