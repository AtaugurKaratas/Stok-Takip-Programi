
namespace StokTakipProgramiFinal
{
    partial class BarkodOkuyucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarkodOkuyucu));
            this.cbbKamera = new System.Windows.Forms.ComboBox();
            this.lblKamera = new System.Windows.Forms.Label();
            this.picKameraGoruntusu = new System.Windows.Forms.PictureBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnOku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picKameraGoruntusu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbKamera
            // 
            this.cbbKamera.FormattingEnabled = true;
            this.cbbKamera.Location = new System.Drawing.Point(62, 25);
            this.cbbKamera.Margin = new System.Windows.Forms.Padding(2);
            this.cbbKamera.Name = "cbbKamera";
            this.cbbKamera.Size = new System.Drawing.Size(159, 21);
            this.cbbKamera.TabIndex = 0;
            // 
            // lblKamera
            // 
            this.lblKamera.AutoSize = true;
            this.lblKamera.Location = new System.Drawing.Point(7, 27);
            this.lblKamera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKamera.Name = "lblKamera";
            this.lblKamera.Size = new System.Drawing.Size(52, 13);
            this.lblKamera.TabIndex = 1;
            this.lblKamera.Text = "Kamera : ";
            // 
            // picKameraGoruntusu
            // 
            this.picKameraGoruntusu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picKameraGoruntusu.Location = new System.Drawing.Point(7, 58);
            this.picKameraGoruntusu.Margin = new System.Windows.Forms.Padding(2);
            this.picKameraGoruntusu.Name = "picKameraGoruntusu";
            this.picKameraGoruntusu.Size = new System.Drawing.Size(258, 128);
            this.picKameraGoruntusu.TabIndex = 2;
            this.picKameraGoruntusu.TabStop = false;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(7, 202);
            this.lblBarkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(50, 13);
            this.lblBarkod.TabIndex = 3;
            this.lblBarkod.Text = "Barkod : ";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(62, 199);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(203, 20);
            this.txtBarkod.TabIndex = 4;
            // 
            // btnOku
            // 
            this.btnOku.Image = ((System.Drawing.Image)(resources.GetObject("btnOku.Image")));
            this.btnOku.Location = new System.Drawing.Point(223, 26);
            this.btnOku.Margin = new System.Windows.Forms.Padding(2);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(42, 20);
            this.btnOku.TabIndex = 5;
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // BarkodOkuyucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(174)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(283, 227);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.picKameraGoruntusu);
            this.Controls.Add(this.lblKamera);
            this.Controls.Add(this.cbbKamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BarkodOkuyucu";
            this.Text = "BARKOD OKUYUCU";
            this.Load += new System.EventHandler(this.BarkodOkuyucu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKameraGoruntusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKamera;
        private System.Windows.Forms.Label lblKamera;
        private System.Windows.Forms.PictureBox picKameraGoruntusu;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnOku;
    }
}