
namespace StokTakipProgramiFinal
{
    partial class YeniSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniSifre));
            this.grpYeniSifre = new System.Windows.Forms.GroupBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.grpYeniSifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYeniSifre
            // 
            this.grpYeniSifre.Controls.Add(this.btnOnayla);
            this.grpYeniSifre.Controls.Add(this.txtSifreTekrar);
            this.grpYeniSifre.Controls.Add(this.txtYeniSifre);
            this.grpYeniSifre.Controls.Add(this.lblSifreTekrar);
            this.grpYeniSifre.Controls.Add(this.lblSifre);
            this.grpYeniSifre.Location = new System.Drawing.Point(12, 12);
            this.grpYeniSifre.Name = "grpYeniSifre";
            this.grpYeniSifre.Size = new System.Drawing.Size(275, 184);
            this.grpYeniSifre.TabIndex = 6;
            this.grpYeniSifre.TabStop = false;
            this.grpYeniSifre.Text = "Yeni Şifre";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(98, 125);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(98, 80);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(122, 20);
            this.txtSifreTekrar.TabIndex = 3;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(98, 54);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(122, 20);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Location = new System.Drawing.Point(16, 83);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(71, 13);
            this.lblSifreTekrar.TabIndex = 1;
            this.lblSifreTekrar.Text = "Şifre Tekrar : ";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(16, 57);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(61, 13);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Yeni Şifre : ";
            // 
            // YeniSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(306, 221);
            this.Controls.Add(this.grpYeniSifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YeniSifre";
            this.Text = "Yeni Şifre";
            this.grpYeniSifre.ResumeLayout(false);
            this.grpYeniSifre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYeniSifre;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.Label lblSifre;
    }
}