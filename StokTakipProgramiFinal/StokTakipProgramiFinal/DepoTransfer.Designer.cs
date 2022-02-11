
namespace StokTakipProgramiFinal
{
    partial class DepoTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoTransfer));
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblTransferTarihi = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblBulunduguDepo = new System.Windows.Forms.Label();
            this.lblGidecegiDepo = new System.Windows.Forms.Label();
            this.cbbBulunduguDepo = new System.Windows.Forms.ComboBox();
            this.cbbGidecegiDepo = new System.Windows.Forms.ComboBox();
            this.dgwDepoTransfer = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepoTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(29, 50);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(50, 13);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Barkod : ";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(261, 53);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(45, 13);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "Miktar : ";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(29, 76);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(57, 13);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adı : ";
            // 
            // lblTransferTarihi
            // 
            this.lblTransferTarihi.AutoSize = true;
            this.lblTransferTarihi.Location = new System.Drawing.Point(422, 53);
            this.lblTransferTarihi.Name = "lblTransferTarihi";
            this.lblTransferTarihi.Size = new System.Drawing.Size(84, 13);
            this.lblTransferTarihi.TabIndex = 3;
            this.lblTransferTarihi.Text = "Transfer Tarihi : ";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(90, 48);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(109, 20);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Location = new System.Drawing.Point(90, 74);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(109, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Enabled = false;
            this.txtMiktar.Location = new System.Drawing.Point(309, 50);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(108, 20);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "0";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(502, 50);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(174, 20);
            this.dtpTarih.TabIndex = 4;
            // 
            // lblBulunduguDepo
            // 
            this.lblBulunduguDepo.AutoSize = true;
            this.lblBulunduguDepo.Location = new System.Drawing.Point(29, 153);
            this.lblBulunduguDepo.Name = "lblBulunduguDepo";
            this.lblBulunduguDepo.Size = new System.Drawing.Size(96, 13);
            this.lblBulunduguDepo.TabIndex = 8;
            this.lblBulunduguDepo.Text = "Bulunduğu Depo : ";
            // 
            // lblGidecegiDepo
            // 
            this.lblGidecegiDepo.AutoSize = true;
            this.lblGidecegiDepo.Location = new System.Drawing.Point(302, 155);
            this.lblGidecegiDepo.Name = "lblGidecegiDepo";
            this.lblGidecegiDepo.Size = new System.Drawing.Size(87, 13);
            this.lblGidecegiDepo.TabIndex = 9;
            this.lblGidecegiDepo.Text = "Gideceği Depo : ";
            // 
            // cbbBulunduguDepo
            // 
            this.cbbBulunduguDepo.FormattingEnabled = true;
            this.cbbBulunduguDepo.Location = new System.Drawing.Point(143, 150);
            this.cbbBulunduguDepo.Name = "cbbBulunduguDepo";
            this.cbbBulunduguDepo.Size = new System.Drawing.Size(153, 21);
            this.cbbBulunduguDepo.TabIndex = 5;
            // 
            // cbbGidecegiDepo
            // 
            this.cbbGidecegiDepo.FormattingEnabled = true;
            this.cbbGidecegiDepo.Location = new System.Drawing.Point(387, 152);
            this.cbbGidecegiDepo.Name = "cbbGidecegiDepo";
            this.cbbGidecegiDepo.Size = new System.Drawing.Size(142, 21);
            this.cbbGidecegiDepo.TabIndex = 6;
            // 
            // dgwDepoTransfer
            // 
            this.dgwDepoTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepoTransfer.Location = new System.Drawing.Point(12, 263);
            this.dgwDepoTransfer.Name = "dgwDepoTransfer";
            this.dgwDepoTransfer.RowTemplate.Height = 25;
            this.dgwDepoTransfer.Size = new System.Drawing.Size(656, 130);
            this.dgwDepoTransfer.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(535, 153);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 20);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(584, 189);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(84, 68);
            this.btnExcel.TabIndex = 57;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // DepoTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(682, 405);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgwDepoTransfer);
            this.Controls.Add(this.cbbGidecegiDepo);
            this.Controls.Add(this.cbbBulunduguDepo);
            this.Controls.Add(this.lblGidecegiDepo);
            this.Controls.Add(this.lblBulunduguDepo);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblTransferTarihi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblBarkod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepoTransfer";
            this.Text = " DEPO TRANSFER";
            this.Load += new System.EventHandler(this.DepoTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepoTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblTransferTarihi;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblBulunduguDepo;
        private System.Windows.Forms.Label lblGidecegiDepo;
        private System.Windows.Forms.ComboBox cbbBulunduguDepo;
        private System.Windows.Forms.ComboBox cbbGidecegiDepo;
        private System.Windows.Forms.DataGridView dgwDepoTransfer;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnExcel;
    }
}