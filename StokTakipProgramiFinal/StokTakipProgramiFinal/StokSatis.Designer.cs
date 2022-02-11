
namespace StokTakipProgramiFinal
{
    partial class StokSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokSatis));
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblNetFiyat = new System.Windows.Forms.Label();
            this.dgwStokSatis = new System.Windows.Forms.DataGridView();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtNetFiyat = new System.Windows.Forms.TextBox();
            this.cmbFirma = new System.Windows.Forms.ComboBox();
            this.btnSatisIslemi = new System.Windows.Forms.Button();
            this.lblDepolar = new System.Windows.Forms.Label();
            this.cbbBulunduguDepo = new System.Windows.Forms.ComboBox();
            this.lblKdvOran = new System.Windows.Forms.Label();
            this.lblOtvOran = new System.Windows.Forms.Label();
            this.lblBrutFiyat = new System.Windows.Forms.Label();
            this.txtKdvOran = new System.Windows.Forms.TextBox();
            this.txtOtvOran = new System.Windows.Forms.TextBox();
            this.txtBrutFiyat = new System.Windows.Forms.TextBox();
            this.printSatisBelge = new System.Drawing.Printing.PrintDocument();
            this.printDialogSatis = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStokSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(18, 28);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(50, 13);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Barkod : ";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(18, 53);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(41, 13);
            this.lblFirma.TabIndex = 1;
            this.lblFirma.Text = "Firma : ";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(18, 103);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(45, 13);
            this.lblMiktar.TabIndex = 2;
            this.lblMiktar.Text = "Miktar : ";
            // 
            // lblNetFiyat
            // 
            this.lblNetFiyat.AutoSize = true;
            this.lblNetFiyat.Location = new System.Drawing.Point(18, 128);
            this.lblNetFiyat.Name = "lblNetFiyat";
            this.lblNetFiyat.Size = new System.Drawing.Size(58, 13);
            this.lblNetFiyat.TabIndex = 3;
            this.lblNetFiyat.Text = "Net Fiyat : ";
            // 
            // dgwStokSatis
            // 
            this.dgwStokSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStokSatis.Location = new System.Drawing.Point(9, 249);
            this.dgwStokSatis.Name = "dgwStokSatis";
            this.dgwStokSatis.RowTemplate.Height = 25;
            this.dgwStokSatis.Size = new System.Drawing.Size(665, 145);
            this.dgwStokSatis.TabIndex = 9;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(72, 25);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(157, 20);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(66, 101);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(163, 20);
            this.txtMiktar.TabIndex = 4;
            this.txtMiktar.Text = "0";
            // 
            // txtNetFiyat
            // 
            this.txtNetFiyat.Location = new System.Drawing.Point(81, 126);
            this.txtNetFiyat.Name = "txtNetFiyat";
            this.txtNetFiyat.Size = new System.Drawing.Size(148, 20);
            this.txtNetFiyat.TabIndex = 5;
            this.txtNetFiyat.Text = "0";
            this.txtNetFiyat.TextChanged += new System.EventHandler(this.txtNetFiyat_TextChanged);
            // 
            // cmbFirma
            // 
            this.cmbFirma.FormattingEnabled = true;
            this.cmbFirma.Location = new System.Drawing.Point(72, 50);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.Size = new System.Drawing.Size(157, 21);
            this.cmbFirma.TabIndex = 2;
            // 
            // btnSatisIslemi
            // 
            this.btnSatisIslemi.Location = new System.Drawing.Point(250, 21);
            this.btnSatisIslemi.Name = "btnSatisIslemi";
            this.btnSatisIslemi.Size = new System.Drawing.Size(184, 20);
            this.btnSatisIslemi.TabIndex = 6;
            this.btnSatisIslemi.Text = "SATIŞ İŞLEMİNİ GERÇEKLEŞTİR";
            this.btnSatisIslemi.UseVisualStyleBackColor = true;
            this.btnSatisIslemi.Click += new System.EventHandler(this.btnListeyeEkle_Click);
            // 
            // lblDepolar
            // 
            this.lblDepolar.AutoSize = true;
            this.lblDepolar.Location = new System.Drawing.Point(18, 78);
            this.lblDepolar.Name = "lblDepolar";
            this.lblDepolar.Size = new System.Drawing.Size(107, 13);
            this.lblDepolar.TabIndex = 13;
            this.lblDepolar.Text = "Bulunduğu Depolar : ";
            // 
            // cbbBulunduguDepo
            // 
            this.cbbBulunduguDepo.FormattingEnabled = true;
            this.cbbBulunduguDepo.Location = new System.Drawing.Point(125, 75);
            this.cbbBulunduguDepo.Name = "cbbBulunduguDepo";
            this.cbbBulunduguDepo.Size = new System.Drawing.Size(104, 21);
            this.cbbBulunduguDepo.TabIndex = 3;
            // 
            // lblKdvOran
            // 
            this.lblKdvOran.AutoSize = true;
            this.lblKdvOran.Location = new System.Drawing.Point(18, 156);
            this.lblKdvOran.Name = "lblKdvOran";
            this.lblKdvOran.Size = new System.Drawing.Size(66, 13);
            this.lblKdvOran.TabIndex = 14;
            this.lblKdvOran.Text = "KDV Oranı : ";
            // 
            // lblOtvOran
            // 
            this.lblOtvOran.AutoSize = true;
            this.lblOtvOran.Location = new System.Drawing.Point(18, 183);
            this.lblOtvOran.Name = "lblOtvOran";
            this.lblOtvOran.Size = new System.Drawing.Size(66, 13);
            this.lblOtvOran.TabIndex = 15;
            this.lblOtvOran.Text = "ÖTV Oranı : ";
            // 
            // lblBrutFiyat
            // 
            this.lblBrutFiyat.AutoSize = true;
            this.lblBrutFiyat.Location = new System.Drawing.Point(18, 210);
            this.lblBrutFiyat.Name = "lblBrutFiyat";
            this.lblBrutFiyat.Size = new System.Drawing.Size(60, 13);
            this.lblBrutFiyat.TabIndex = 16;
            this.lblBrutFiyat.Text = "Brüt Fiyat : ";
            // 
            // txtKdvOran
            // 
            this.txtKdvOran.Location = new System.Drawing.Point(81, 153);
            this.txtKdvOran.Name = "txtKdvOran";
            this.txtKdvOran.Size = new System.Drawing.Size(148, 20);
            this.txtKdvOran.TabIndex = 17;
            this.txtKdvOran.Text = "0";
            this.txtKdvOran.TextChanged += new System.EventHandler(this.txtKdvOran_TextChanged);
            // 
            // txtOtvOran
            // 
            this.txtOtvOran.Location = new System.Drawing.Point(81, 180);
            this.txtOtvOran.Name = "txtOtvOran";
            this.txtOtvOran.Size = new System.Drawing.Size(148, 20);
            this.txtOtvOran.TabIndex = 18;
            this.txtOtvOran.Text = "0";
            this.txtOtvOran.TextChanged += new System.EventHandler(this.txtOtvOran_TextChanged);
            // 
            // txtBrutFiyat
            // 
            this.txtBrutFiyat.Enabled = false;
            this.txtBrutFiyat.Location = new System.Drawing.Point(81, 207);
            this.txtBrutFiyat.Name = "txtBrutFiyat";
            this.txtBrutFiyat.Size = new System.Drawing.Size(148, 20);
            this.txtBrutFiyat.TabIndex = 19;
            this.txtBrutFiyat.Text = "0";
            // 
            // printSatisBelge
            // 
            this.printSatisBelge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSatisBelge_PrintPage);
            // 
            // printDialogSatis
            // 
            this.printDialogSatis.Document = this.printSatisBelge;
            this.printDialogSatis.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printSatisBelge;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(585, 170);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(89, 73);
            this.btnExcel.TabIndex = 56;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // StokSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(686, 406);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtBrutFiyat);
            this.Controls.Add(this.txtOtvOran);
            this.Controls.Add(this.txtKdvOran);
            this.Controls.Add(this.lblBrutFiyat);
            this.Controls.Add(this.lblOtvOran);
            this.Controls.Add(this.lblKdvOran);
            this.Controls.Add(this.cbbBulunduguDepo);
            this.Controls.Add(this.lblDepolar);
            this.Controls.Add(this.btnSatisIslemi);
            this.Controls.Add(this.cmbFirma);
            this.Controls.Add(this.txtNetFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.dgwStokSatis);
            this.Controls.Add(this.lblNetFiyat);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblBarkod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokSatis";
            this.Text = "STOK SATIS";
            this.Load += new System.EventHandler(this.StokSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStokSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblNetFiyat;
        private System.Windows.Forms.DataGridView dgwStokSatis;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtNetFiyat;
        private System.Windows.Forms.ComboBox cmbFirma;
        private System.Windows.Forms.Button btnSatisIslemi;
        private System.Windows.Forms.Label lblDepolar;
        private System.Windows.Forms.ComboBox cbbBulunduguDepo;
        private System.Windows.Forms.Label lblKdvOran;
        private System.Windows.Forms.Label lblOtvOran;
        private System.Windows.Forms.Label lblBrutFiyat;
        private System.Windows.Forms.TextBox txtKdvOran;
        private System.Windows.Forms.TextBox txtOtvOran;
        private System.Windows.Forms.TextBox txtBrutFiyat;
        private System.Drawing.Printing.PrintDocument printSatisBelge;
        private System.Windows.Forms.PrintDialog printDialogSatis;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnExcel;
    }
}