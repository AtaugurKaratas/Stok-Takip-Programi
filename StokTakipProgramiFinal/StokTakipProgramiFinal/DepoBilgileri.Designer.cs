
namespace StokTakipProgramiFinal
{
    partial class DepoBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoBilgileri));
            this.lblDepoAdi = new System.Windows.Forms.Label();
            this.txtDepoAdi = new System.Windows.Forms.TextBox();
            this.dgwDepoBilgileri = new System.Windows.Forms.DataGridView();
            this.lblDepoYeri = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDepoSorumlusu = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtDepoYeri = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtDepoSorumlusu = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepoBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepoAdi
            // 
            this.lblDepoAdi.AutoSize = true;
            this.lblDepoAdi.Location = new System.Drawing.Point(27, 40);
            this.lblDepoAdi.Name = "lblDepoAdi";
            this.lblDepoAdi.Size = new System.Drawing.Size(60, 13);
            this.lblDepoAdi.TabIndex = 0;
            this.lblDepoAdi.Text = "Depo Adı : ";
            // 
            // txtDepoAdi
            // 
            this.txtDepoAdi.Location = new System.Drawing.Point(28, 55);
            this.txtDepoAdi.Name = "txtDepoAdi";
            this.txtDepoAdi.Size = new System.Drawing.Size(118, 20);
            this.txtDepoAdi.TabIndex = 0;
            this.txtDepoAdi.TextChanged += new System.EventHandler(this.txtDepoAdi_TextChanged);
            // 
            // dgwDepoBilgileri
            // 
            this.dgwDepoBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepoBilgileri.Location = new System.Drawing.Point(27, 153);
            this.dgwDepoBilgileri.Name = "dgwDepoBilgileri";
            this.dgwDepoBilgileri.RowTemplate.Height = 25;
            this.dgwDepoBilgileri.Size = new System.Drawing.Size(578, 153);
            this.dgwDepoBilgileri.TabIndex = 7;
            this.dgwDepoBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepoBilgileri_CellClick);
            // 
            // lblDepoYeri
            // 
            this.lblDepoYeri.AutoSize = true;
            this.lblDepoYeri.Location = new System.Drawing.Point(27, 78);
            this.lblDepoYeri.Name = "lblDepoYeri";
            this.lblDepoYeri.Size = new System.Drawing.Size(63, 13);
            this.lblDepoYeri.TabIndex = 3;
            this.lblDepoYeri.Text = "Depo Yeri : ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(469, 127);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(64, 20);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(541, 127);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 20);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(168, 40);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(43, 13);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres : ";
            // 
            // lblDepoSorumlusu
            // 
            this.lblDepoSorumlusu.AutoSize = true;
            this.lblDepoSorumlusu.Location = new System.Drawing.Point(386, 40);
            this.lblDepoSorumlusu.Name = "lblDepoSorumlusu";
            this.lblDepoSorumlusu.Size = new System.Drawing.Size(94, 13);
            this.lblDepoSorumlusu.TabIndex = 7;
            this.lblDepoSorumlusu.Text = "Depo Sorumlusu : ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(386, 78);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 13);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "Telefon : ";
            // 
            // txtDepoYeri
            // 
            this.txtDepoYeri.Location = new System.Drawing.Point(28, 94);
            this.txtDepoYeri.Name = "txtDepoYeri";
            this.txtDepoYeri.Size = new System.Drawing.Size(118, 20);
            this.txtDepoYeri.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(212, 40);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(161, 74);
            this.txtAdres.TabIndex = 2;
            // 
            // txtDepoSorumlusu
            // 
            this.txtDepoSorumlusu.Location = new System.Drawing.Point(498, 40);
            this.txtDepoSorumlusu.Name = "txtDepoSorumlusu";
            this.txtDepoSorumlusu.Size = new System.Drawing.Size(107, 20);
            this.txtDepoSorumlusu.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(498, 78);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(107, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // DepoBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(632, 339);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtDepoSorumlusu);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtDepoYeri);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblDepoSorumlusu);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblDepoYeri);
            this.Controls.Add(this.dgwDepoBilgileri);
            this.Controls.Add(this.txtDepoAdi);
            this.Controls.Add(this.lblDepoAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepoBilgileri";
            this.Text = "DEPO BİLGİLERİ";
            this.Load += new System.EventHandler(this.DepoBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepoBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepoAdi;
        private System.Windows.Forms.TextBox txtDepoAdi;
        private System.Windows.Forms.DataGridView dgwDepoBilgileri;
        private System.Windows.Forms.Label lblDepoYeri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDepoSorumlusu;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtDepoYeri;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtDepoSorumlusu;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}