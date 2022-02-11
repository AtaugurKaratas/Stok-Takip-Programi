
namespace StokTakipProgramiFinal
{
    partial class DepoEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoEkle));
            this.lblDepoAdi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDepoYeri = new System.Windows.Forms.Label();
            this.lblDepoSorumlusu = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.txtDepoYeri = new System.Windows.Forms.TextBox();
            this.txtDepoAdresi = new System.Windows.Forms.TextBox();
            this.txtDepoSorumlusu = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepoAdi
            // 
            this.lblDepoAdi.AutoSize = true;
            this.lblDepoAdi.Location = new System.Drawing.Point(63, 31);
            this.lblDepoAdi.Name = "lblDepoAdi";
            this.lblDepoAdi.Size = new System.Drawing.Size(60, 13);
            this.lblDepoAdi.TabIndex = 0;
            this.lblDepoAdi.Text = "Depo Adı : ";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(63, 101);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(43, 13);
            this.lblAdres.TabIndex = 1;
            this.lblAdres.Text = "Adres : ";
            // 
            // lblDepoYeri
            // 
            this.lblDepoYeri.AutoSize = true;
            this.lblDepoYeri.Location = new System.Drawing.Point(63, 68);
            this.lblDepoYeri.Name = "lblDepoYeri";
            this.lblDepoYeri.Size = new System.Drawing.Size(63, 13);
            this.lblDepoYeri.TabIndex = 2;
            this.lblDepoYeri.Text = "Depo Yeri : ";
            // 
            // lblDepoSorumlusu
            // 
            this.lblDepoSorumlusu.AutoSize = true;
            this.lblDepoSorumlusu.Location = new System.Drawing.Point(63, 139);
            this.lblDepoSorumlusu.Name = "lblDepoSorumlusu";
            this.lblDepoSorumlusu.Size = new System.Drawing.Size(94, 13);
            this.lblDepoSorumlusu.TabIndex = 3;
            this.lblDepoSorumlusu.Text = "Depo Sorumlusu : ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(63, 169);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 13);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon : ";
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(153, 29);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(130, 20);
            this.txtDepoAdi.TabIndex = 0;
            // 
            // txtDepoYeri
            // 
            this.txtDepoYeri.Location = new System.Drawing.Point(153, 55);
            this.txtDepoYeri.Name = "txtDepoYeri";
            this.txtDepoYeri.Size = new System.Drawing.Size(130, 20);
            this.txtDepoYeri.TabIndex = 1;
            // 
            // txtDepoAdresi
            // 
            this.txtDepoAdresi.Location = new System.Drawing.Point(153, 81);
            this.txtDepoAdresi.Multiline = true;
            this.txtDepoAdresi.Name = "txtDepoAdresi";
            this.txtDepoAdresi.Size = new System.Drawing.Size(130, 56);
            this.txtDepoAdresi.TabIndex = 2;
            // 
            // txtDepoSorumlusu
            // 
            this.txtDepoSorumlusu.Location = new System.Drawing.Point(153, 142);
            this.txtDepoSorumlusu.Name = "txtDepoSorumlusu";
            this.txtDepoSorumlusu.Size = new System.Drawing.Size(130, 20);
            this.txtDepoSorumlusu.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(153, 168);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(130, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(131, 211);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(70, 27);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DepoEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(338, 249);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtDepoSorumlusu);
            this.Controls.Add(this.txtDepoAdresi);
            this.Controls.Add(this.txtDepoYeri);
            this.Controls.Add(this.txtDepoAdi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblDepoSorumlusu);
            this.Controls.Add(this.lblDepoYeri);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblDepoAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepoEkle";
            this.Text = "DEPO EKLE";
            this.Load += new System.EventHandler(this.DepoEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepoAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDepoYeri;
        private System.Windows.Forms.Label lblDepoSorumlusu;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.TextBox txtDepoYeri;
        private System.Windows.Forms.TextBox txtDepoAdresi;
        private System.Windows.Forms.TextBox txtDepoSorumlusu;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnKaydet;
    }
}