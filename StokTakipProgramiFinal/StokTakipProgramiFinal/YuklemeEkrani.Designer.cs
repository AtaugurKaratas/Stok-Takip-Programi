
namespace StokTakipProgramiFinal
{
    partial class YuklemeEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YuklemeEkrani));
            this.yuklemeBari = new System.Windows.Forms.ProgressBar();
            this.AnaLogo = new System.Windows.Forms.PictureBox();
            this.tmrYukleme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AnaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // yuklemeBari
            // 
            this.yuklemeBari.Location = new System.Drawing.Point(0, 419);
            this.yuklemeBari.Name = "yuklemeBari";
            this.yuklemeBari.Size = new System.Drawing.Size(665, 20);
            this.yuklemeBari.TabIndex = 0;
            // 
            // AnaLogo
            // 
            this.AnaLogo.Image = ((System.Drawing.Image)(resources.GetObject("AnaLogo.Image")));
            this.AnaLogo.Location = new System.Drawing.Point(154, 71);
            this.AnaLogo.Name = "AnaLogo";
            this.AnaLogo.Size = new System.Drawing.Size(343, 244);
            this.AnaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnaLogo.TabIndex = 1;
            this.AnaLogo.TabStop = false;
            // 
            // tmrYukleme
            // 
            this.tmrYukleme.Interval = 3000;
            this.tmrYukleme.Tick += new System.EventHandler(this.tmrYukleme_Tick);
            // 
            // YuklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(665, 439);
            this.Controls.Add(this.AnaLogo);
            this.Controls.Add(this.yuklemeBari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YuklemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yüklenme Ekranı";
            this.Load += new System.EventHandler(this.yuklemeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar yuklemeBari;
        private System.Windows.Forms.PictureBox AnaLogo;
        private System.Windows.Forms.Timer tmrYukleme;
    }
}

