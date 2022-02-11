using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        public int kirmizi = 0;
        public int yesil = 0;
        public int mavi = 0;

        public string tema;

        public int kullaniciID;

        class BilgiGuncelleme
        {
            public string resimYolu;
            public string telefon;
            public string email;
        }
        class SifreGuncelleme
        {
            public string eskiSifre;
            public string yeniSifre;
            public string yeniSifreTekrar;
        }
        private void trbYesil_Scroll(object sender, EventArgs e)
        {
            yesil = trbYesil.Value;
            pnlRenk.BackColor = System.Drawing.Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void trbMavi_Scroll(object sender, EventArgs e)
        {
            mavi = trbMavi.Value;
            pnlRenk.BackColor = System.Drawing.Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void trbKırmızı_Scroll(object sender, EventArgs e)
        {
            kirmizi = trbKırmızı.Value;
            pnlRenk.BackColor = System.Drawing.Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void btnRenklendir_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(kirmizi, yesil, mavi);
            var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_id == kullaniciID).FirstOrDefault();
            sonuc.tema = kirmizi + ";" + yesil + ";" + mavi;
            db.SaveChanges();
        }
        BilgiGuncelleme bilgiGuncelleme = new BilgiGuncelleme();

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Profil Fotoğrafı Güncelleme";
            dosya.ShowDialog();
            bilgiGuncelleme.resimYolu = dosya.FileName;
            pictureBox1.ImageLocation = bilgiGuncelleme.resimYolu;
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bilgiGuncelleme.telefon = txtTelNo.Text;
            bilgiGuncelleme.email = txtEmail.Text;
            var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_id == kullaniciID).FirstOrDefault();
            if(bilgiGuncelleme.resimYolu != null)
            {
                sonuc.resim = bilgiGuncelleme.resimYolu;
            }
            if(bilgiGuncelleme.telefon != null)
            {
                sonuc.telefon = bilgiGuncelleme.telefon;
            }
            if (bilgiGuncelleme.email != null)
            {
                sonuc.email = bilgiGuncelleme.email;
            }
            db.SaveChanges();
        }

        SifreGuncelleme sifreGuncelleme = new SifreGuncelleme();

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            sifreGuncelleme.eskiSifre = txtEskiSifre.Text;
            sifreGuncelleme.yeniSifre = txtYeniSifre.Text;
            sifreGuncelleme.yeniSifreTekrar = txtYeniSifreTekrar.Text;
            MD5CryptoServiceProvider m = new MD5CryptoServiceProvider();
            byte[] byteuser = System.Text.Encoding.UTF8.GetBytes(sifreGuncelleme.eskiSifre);
            byte[] hasheduser = m.ComputeHash(byteuser);
            string usernamemd5 = Convert.ToBase64String(hasheduser);
            sifreGuncelleme.eskiSifre = usernamemd5;
            if (db.tbl_Kullanici.Where(r => r.kullanici_id == kullaniciID && r.kullanici_sifre == sifreGuncelleme.eskiSifre).Count() > 0)
            {
                if (sifreGuncelleme.yeniSifre != sifreGuncelleme.yeniSifreTekrar)
                {
                    MessageBox.Show("Yeni Şifreler Uyuşmuyor");
                }
                else
                {
                    var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_id == kullaniciID).FirstOrDefault();
                    byteuser = System.Text.Encoding.UTF8.GetBytes(sifreGuncelleme.yeniSifre);
                    hasheduser = m.ComputeHash(byteuser);
                    usernamemd5 = Convert.ToBase64String(hasheduser);
                    sifreGuncelleme.yeniSifre = usernamemd5;
                    sonuc.kullanici_sifre = sifreGuncelleme.yeniSifre;
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Eski Şifre Hatalı");
            }
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            temaIslemleri();
            var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_id == kullaniciID).FirstOrDefault();
            pictureBox1.ImageLocation = sonuc.resim;
        }

        private void temaIslemleri()
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }
    }
}
