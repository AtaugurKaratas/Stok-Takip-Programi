
namespace StokTakipProgramiFinal
{
    partial class KullaniciEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkrani));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.cmsAyarlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ayarlarYeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStokTransfer = new System.Windows.Forms.Button();
            this.cmsTransferBilgisi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transferBilgisiYeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStokSatis = new System.Windows.Forms.Button();
            this.cmsStokSatis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokSatışYeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStokBilgileri = new System.Windows.Forms.Button();
            this.cmsStokBilgileri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokBilgileriYeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStokAlis = new System.Windows.Forms.Button();
            this.cmsStokAlis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokAlışYeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMarka = new System.Windows.Forms.Panel();
            this.lblZaman = new System.Windows.Forms.Label();
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lblAnasayfa = new System.Windows.Forms.Label();
            this.pnlAna = new System.Windows.Forms.Panel();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.tmrPara = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.cmsAyarlar.SuspendLayout();
            this.cmsTransferBilgisi.SuspendLayout();
            this.cmsStokSatis.SuspendLayout();
            this.cmsStokBilgileri.SuspendLayout();
            this.cmsStokAlis.SuspendLayout();
            this.pnlMarka.SuspendLayout();
            this.pnlBaslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.pnlMenu.Controls.Add(this.lblPara);
            this.pnlMenu.Controls.Add(this.btnAyarlar);
            this.pnlMenu.Controls.Add(this.btnStokTransfer);
            this.pnlMenu.Controls.Add(this.btnStokSatis);
            this.pnlMenu.Controls.Add(this.btnStokBilgileri);
            this.pnlMenu.Controls.Add(this.btnStokAlis);
            this.pnlMenu.Controls.Add(this.pnlMarka);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(223, 577);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.Location = new System.Drawing.Point(3, 548);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(110, 20);
            this.lblPara.TabIndex = 5;
            this.lblPara.Text = "Para Birimi : ";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.ContextMenuStrip = this.cmsAyarlar;
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAyarlar.ForeColor = System.Drawing.Color.Black;
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.Location = new System.Drawing.Point(0, 384);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(223, 77);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // cmsAyarlar
            // 
            this.cmsAyarlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarYeniPencereToolStripMenuItem});
            this.cmsAyarlar.Name = "contextMenuStrip5";
            this.cmsAyarlar.Size = new System.Drawing.Size(190, 26);
            // 
            // ayarlarYeniPencereToolStripMenuItem
            // 
            this.ayarlarYeniPencereToolStripMenuItem.Name = "ayarlarYeniPencereToolStripMenuItem";
            this.ayarlarYeniPencereToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ayarlarYeniPencereToolStripMenuItem.Text = "Ayarlar (Yeni Pencere)";
            this.ayarlarYeniPencereToolStripMenuItem.Click += new System.EventHandler(this.ayarlarYeniPencereToolStripMenuItem_Click);
            // 
            // btnStokTransfer
            // 
            this.btnStokTransfer.ContextMenuStrip = this.cmsTransferBilgisi;
            this.btnStokTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStokTransfer.FlatAppearance.BorderSize = 0;
            this.btnStokTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokTransfer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnStokTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnStokTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnStokTransfer.Image")));
            this.btnStokTransfer.Location = new System.Drawing.Point(0, 307);
            this.btnStokTransfer.Name = "btnStokTransfer";
            this.btnStokTransfer.Size = new System.Drawing.Size(223, 77);
            this.btnStokTransfer.TabIndex = 3;
            this.btnStokTransfer.Text = "TRANSFER BILGISI";
            this.btnStokTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStokTransfer.UseVisualStyleBackColor = true;
            this.btnStokTransfer.Click += new System.EventHandler(this.btnStokTransfer_Click);
            // 
            // cmsTransferBilgisi
            // 
            this.cmsTransferBilgisi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferBilgisiYeniPencereToolStripMenuItem});
            this.cmsTransferBilgisi.Name = "contextMenuStrip4";
            this.cmsTransferBilgisi.Size = new System.Drawing.Size(228, 26);
            // 
            // transferBilgisiYeniPencereToolStripMenuItem
            // 
            this.transferBilgisiYeniPencereToolStripMenuItem.Name = "transferBilgisiYeniPencereToolStripMenuItem";
            this.transferBilgisiYeniPencereToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.transferBilgisiYeniPencereToolStripMenuItem.Text = "Transfer Bilgisi (Yeni Pencere)";
            this.transferBilgisiYeniPencereToolStripMenuItem.Click += new System.EventHandler(this.transferBilgisiYeniPencereToolStripMenuItem_Click);
            // 
            // btnStokSatis
            // 
            this.btnStokSatis.ContextMenuStrip = this.cmsStokSatis;
            this.btnStokSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStokSatis.FlatAppearance.BorderSize = 0;
            this.btnStokSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokSatis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnStokSatis.ForeColor = System.Drawing.Color.Black;
            this.btnStokSatis.Image = ((System.Drawing.Image)(resources.GetObject("btnStokSatis.Image")));
            this.btnStokSatis.Location = new System.Drawing.Point(0, 230);
            this.btnStokSatis.Name = "btnStokSatis";
            this.btnStokSatis.Size = new System.Drawing.Size(223, 77);
            this.btnStokSatis.TabIndex = 2;
            this.btnStokSatis.Text = "STOK SATIS";
            this.btnStokSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStokSatis.UseVisualStyleBackColor = true;
            this.btnStokSatis.Click += new System.EventHandler(this.btnStokSatis_Click);
            // 
            // cmsStokSatis
            // 
            this.cmsStokSatis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokSatışYeniPencereToolStripMenuItem});
            this.cmsStokSatis.Name = "contextMenuStrip3";
            this.cmsStokSatis.Size = new System.Drawing.Size(203, 26);
            // 
            // stokSatışYeniPencereToolStripMenuItem
            // 
            this.stokSatışYeniPencereToolStripMenuItem.Name = "stokSatışYeniPencereToolStripMenuItem";
            this.stokSatışYeniPencereToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.stokSatışYeniPencereToolStripMenuItem.Text = "Stok Satış (Yeni Pencere)";
            this.stokSatışYeniPencereToolStripMenuItem.Click += new System.EventHandler(this.stokSatışYeniPencereToolStripMenuItem_Click);
            // 
            // btnStokBilgileri
            // 
            this.btnStokBilgileri.ContextMenuStrip = this.cmsStokBilgileri;
            this.btnStokBilgileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStokBilgileri.FlatAppearance.BorderSize = 0;
            this.btnStokBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokBilgileri.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnStokBilgileri.ForeColor = System.Drawing.Color.Black;
            this.btnStokBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnStokBilgileri.Image")));
            this.btnStokBilgileri.Location = new System.Drawing.Point(0, 153);
            this.btnStokBilgileri.Name = "btnStokBilgileri";
            this.btnStokBilgileri.Size = new System.Drawing.Size(223, 77);
            this.btnStokBilgileri.TabIndex = 1;
            this.btnStokBilgileri.Text = "STOK BILGILERI";
            this.btnStokBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStokBilgileri.UseVisualStyleBackColor = true;
            this.btnStokBilgileri.Click += new System.EventHandler(this.btnStokBilgileri_Click);
            // 
            // cmsStokBilgileri
            // 
            this.cmsStokBilgileri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokBilgileriYeniPencereToolStripMenuItem});
            this.cmsStokBilgileri.Name = "contextMenuStrip2";
            this.cmsStokBilgileri.Size = new System.Drawing.Size(218, 26);
            // 
            // stokBilgileriYeniPencereToolStripMenuItem
            // 
            this.stokBilgileriYeniPencereToolStripMenuItem.Name = "stokBilgileriYeniPencereToolStripMenuItem";
            this.stokBilgileriYeniPencereToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.stokBilgileriYeniPencereToolStripMenuItem.Text = "Stok Bilgileri (Yeni Pencere)";
            this.stokBilgileriYeniPencereToolStripMenuItem.Click += new System.EventHandler(this.stokBilgileriYeniPencereToolStripMenuItem_Click);
            // 
            // btnStokAlis
            // 
            this.btnStokAlis.ContextMenuStrip = this.cmsStokAlis;
            this.btnStokAlis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStokAlis.FlatAppearance.BorderSize = 0;
            this.btnStokAlis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokAlis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnStokAlis.ForeColor = System.Drawing.Color.Black;
            this.btnStokAlis.Image = ((System.Drawing.Image)(resources.GetObject("btnStokAlis.Image")));
            this.btnStokAlis.Location = new System.Drawing.Point(0, 76);
            this.btnStokAlis.Name = "btnStokAlis";
            this.btnStokAlis.Size = new System.Drawing.Size(223, 77);
            this.btnStokAlis.TabIndex = 0;
            this.btnStokAlis.Text = "STOK ALIS";
            this.btnStokAlis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStokAlis.UseVisualStyleBackColor = true;
            this.btnStokAlis.Click += new System.EventHandler(this.btnStokAlis_Click);
            // 
            // cmsStokAlis
            // 
            this.cmsStokAlis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokAlışYeniPencereToolStripMenuItem});
            this.cmsStokAlis.Name = "contextMenuStrip1";
            this.cmsStokAlis.Size = new System.Drawing.Size(198, 26);
            // 
            // stokAlışYeniPencereToolStripMenuItem
            // 
            this.stokAlışYeniPencereToolStripMenuItem.Name = "stokAlışYeniPencereToolStripMenuItem";
            this.stokAlışYeniPencereToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.stokAlışYeniPencereToolStripMenuItem.Text = "Stok Alış (Yeni Pencere)";
            this.stokAlışYeniPencereToolStripMenuItem.Click += new System.EventHandler(this.stokAlışYeniPencereToolStripMenuItem_Click);
            // 
            // pnlMarka
            // 
            this.pnlMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlMarka.Controls.Add(this.lblZaman);
            this.pnlMarka.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMarka.Location = new System.Drawing.Point(0, 0);
            this.pnlMarka.Name = "pnlMarka";
            this.pnlMarka.Size = new System.Drawing.Size(223, 76);
            this.pnlMarka.TabIndex = 0;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(3, 30);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(120, 20);
            this.lblZaman.TabIndex = 0;
            this.lblZaman.Text = "01 Ocak 2022";
            // 
            // pnlBaslik
            // 
            this.pnlBaslik.BackColor = System.Drawing.Color.Turquoise;
            this.pnlBaslik.Controls.Add(this.lblAnasayfa);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.Location = new System.Drawing.Point(223, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Size = new System.Drawing.Size(855, 76);
            this.pnlBaslik.TabIndex = 1;
            // 
            // lblAnasayfa
            // 
            this.lblAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(219)))), ((int)(((byte)(240)))));
            this.lblAnasayfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnasayfa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblAnasayfa.Location = new System.Drawing.Point(0, 0);
            this.lblAnasayfa.Name = "lblAnasayfa";
            this.lblAnasayfa.Size = new System.Drawing.Size(855, 76);
            this.lblAnasayfa.TabIndex = 0;
            this.lblAnasayfa.Text = "KULLANICI ANASAYFA";
            this.lblAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAna
            // 
            this.pnlAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.pnlAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAna.Location = new System.Drawing.Point(223, 76);
            this.pnlAna.Name = "pnlAna";
            this.pnlAna.Size = new System.Drawing.Size(855, 501);
            this.pnlAna.TabIndex = 2;
            // 
            // tmrZaman
            // 
            this.tmrZaman.Interval = 1000;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // tmrPara
            // 
            this.tmrPara.Interval = 10000;
            this.tmrPara.Tick += new System.EventHandler(this.tmrPara_Tick);
            // 
            // KullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 577);
            this.Controls.Add(this.pnlAna);
            this.Controls.Add(this.pnlBaslik);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1098, 620);
            this.Name = "KullaniciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciEkrani_FormClosed);
            this.Load += new System.EventHandler(this.KullaniciEkrani_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.cmsAyarlar.ResumeLayout(false);
            this.cmsTransferBilgisi.ResumeLayout(false);
            this.cmsStokSatis.ResumeLayout(false);
            this.cmsStokBilgileri.ResumeLayout(false);
            this.cmsStokAlis.ResumeLayout(false);
            this.pnlMarka.ResumeLayout(false);
            this.pnlMarka.PerformLayout();
            this.pnlBaslik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStokAlis;
        private System.Windows.Forms.Panel pnlMarka;
        private System.Windows.Forms.Button btnStokSatis;
        private System.Windows.Forms.Button btnStokBilgileri;
        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label lblAnasayfa;
        private System.Windows.Forms.Panel pnlAna;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnStokTransfer;
        private System.Windows.Forms.ContextMenuStrip cmsAyarlar;
        private System.Windows.Forms.ToolStripMenuItem ayarlarYeniPencereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTransferBilgisi;
        private System.Windows.Forms.ToolStripMenuItem transferBilgisiYeniPencereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsStokSatis;
        private System.Windows.Forms.ToolStripMenuItem stokSatışYeniPencereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsStokBilgileri;
        private System.Windows.Forms.ToolStripMenuItem stokBilgileriYeniPencereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsStokAlis;
        private System.Windows.Forms.ToolStripMenuItem stokAlışYeniPencereToolStripMenuItem;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Timer tmrPara;
    }
}