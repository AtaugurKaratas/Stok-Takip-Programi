
namespace StokTakipProgramiFinal
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.grpOnayKodu = new System.Windows.Forms.GroupBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtOnayKodu = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblOnayKodu = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnOnayKodu = new System.Windows.Forms.Button();
            this.grpOnayKodu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOnayKodu
            // 
            this.grpOnayKodu.Controls.Add(this.txtKullaniciAdi);
            this.grpOnayKodu.Controls.Add(this.txtOnayKodu);
            this.grpOnayKodu.Controls.Add(this.lblKullaniciAdi);
            this.grpOnayKodu.Controls.Add(this.txtEmail);
            this.grpOnayKodu.Controls.Add(this.lblEmail);
            this.grpOnayKodu.Controls.Add(this.lblOnayKodu);
            this.grpOnayKodu.Controls.Add(this.btnGonder);
            this.grpOnayKodu.Controls.Add(this.btnOnayKodu);
            this.grpOnayKodu.Location = new System.Drawing.Point(12, 12);
            this.grpOnayKodu.Name = "grpOnayKodu";
            this.grpOnayKodu.Size = new System.Drawing.Size(318, 222);
            this.grpOnayKodu.TabIndex = 5;
            this.grpOnayKodu.TabStop = false;
            this.grpOnayKodu.Text = "Onay Kodu";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(116, 43);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(186, 20);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtOnayKodu
            // 
            this.txtOnayKodu.Location = new System.Drawing.Point(116, 133);
            this.txtOnayKodu.Name = "txtOnayKodu";
            this.txtOnayKodu.Size = new System.Drawing.Size(186, 20);
            this.txtOnayKodu.TabIndex = 3;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(13, 45);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(73, 13);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail : ";
            // 
            // lblOnayKodu
            // 
            this.lblOnayKodu.AutoSize = true;
            this.lblOnayKodu.Location = new System.Drawing.Point(13, 135);
            this.lblOnayKodu.Name = "lblOnayKodu";
            this.lblOnayKodu.Size = new System.Drawing.Size(69, 13);
            this.lblOnayKodu.TabIndex = 2;
            this.lblOnayKodu.Text = "Onay Kodu : ";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(128, 168);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(68, 22);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnOnayKodu
            // 
            this.btnOnayKodu.Location = new System.Drawing.Point(164, 93);
            this.btnOnayKodu.Name = "btnOnayKodu";
            this.btnOnayKodu.Size = new System.Drawing.Size(111, 35);
            this.btnOnayKodu.TabIndex = 2;
            this.btnOnayKodu.Text = "Onay Kodu Gönder";
            this.btnOnayKodu.UseVisualStyleBackColor = true;
            this.btnOnayKodu.Click += new System.EventHandler(this.btnOnayKodu_Click);
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(346, 246);
            this.Controls.Add(this.grpOnayKodu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttum";
            this.Text = "Şifre mi Unuttum ?";
            this.grpOnayKodu.ResumeLayout(false);
            this.grpOnayKodu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOnayKodu;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtOnayKodu;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblOnayKodu;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnOnayKodu;
    }
}