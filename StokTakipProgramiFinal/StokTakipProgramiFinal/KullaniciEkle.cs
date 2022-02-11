using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;

namespace StokTakipProgramiFinal
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        class KullaniciKayit
        {
            public string tcNo;
            public string ad;
            public string soyad;
            public string kullaniciAdi;
            public string sifre;
            public string telefon;
            public string email;
            public DateTime dogumTarihi;
            public string cinsiyet;
            public string avatarResim;
            public string hesapDurumu = "kullanici";
            public string tema = "190;174;226";
        }

        public string tema;

        public int kullaniciID;

        bool rdbCinsiyet;

        KullaniciKayit kullaniciKayit = new KullaniciKayit();

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            rdbCinsiyet = true;
            kullaniciKayit.cinsiyet = "Erkek";
            if (rdbErkek.Checked == true && picAvatar.ImageLocation == null)
            {
                picAvatar.Image = Image.FromFile("erkekAvatar.png");
            }
        }

        private void rdbKadin_CheckedChanged(object sender, EventArgs e)
        {
            rdbCinsiyet = false;
            kullaniciKayit.cinsiyet = "Kadın";
            if (rdbKadin.Checked == true && picAvatar.ImageLocation == null)
            {
                picAvatar.Image = Image.FromFile("kadinAvatar.png");
            }
        }

        string kullaniciSifre;

        private void sifre()
        {
            kullaniciSifre = string.Concat(kullaniciKayit.ad.Substring(0, 1).ToUpper() , "." , CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kullaniciKayit.soyad) , kullaniciKayit.dogumTarihi.Date.Year);
            MD5CryptoServiceProvider m = new MD5CryptoServiceProvider();
            byte[] byteuser = System.Text.Encoding.UTF8.GetBytes(kullaniciSifre);
            byte[] hasheduser = m.ComputeHash(byteuser);
            string usernamemd5 = Convert.ToBase64String(hasheduser);
            kullaniciKayit.sifre = usernamemd5;
        }

        private void degerAtama()
        {
            kullaniciKayit.tcNo = txtTcNo.Text;
            kullaniciKayit.ad = txtAd.Text;
            kullaniciKayit.soyad = txtSoyad.Text;
            kullaniciKayit.kullaniciAdi = txtKullaniciAdi.Text;
            kullaniciKayit.telefon = txtTelefon.Text;
            kullaniciKayit.email = txtEmail.Text;
            kullaniciKayit.dogumTarihi = dtpDogumTarihi.Value;
            kullaniciKayit.avatarResim = picAvatar.ImageLocation;
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                degerAtama();
                sifre();
                tbl_Kullanici tbl_Kullanici = new tbl_Kullanici();
                tbl_Kullanici.tc_no = kullaniciKayit.tcNo;
                tbl_Kullanici.ad = kullaniciKayit.ad;
                tbl_Kullanici.soyad = kullaniciKayit.soyad;
                tbl_Kullanici.kullanici_ad = kullaniciKayit.kullaniciAdi;
                tbl_Kullanici.kullanici_sifre = kullaniciKayit.sifre;
                tbl_Kullanici.telefon = kullaniciKayit.telefon;
                tbl_Kullanici.email = kullaniciKayit.email;
                tbl_Kullanici.dogum_tarih = kullaniciKayit.dogumTarihi;
                tbl_Kullanici.cinsiyet = kullaniciKayit.cinsiyet;
                tbl_Kullanici.resim = kullaniciKayit.avatarResim;
                tbl_Kullanici.hesap_durum = kullaniciKayit.hesapDurumu;
                tbl_Kullanici.tema = kullaniciKayit.tema;
                db.tbl_Kullanici.Add(tbl_Kullanici);
                db.SaveChanges();
                string adres = "log.txt";
                FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(log);
                streamWriter.WriteLine(kullaniciKayit.ad + " " + kullaniciKayit.soyad + " Kullanıcısı Eklendi. " + DateTime.Now.ToLocalTime());
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch(Exception exc)
            {
                string adres = "log.txt";
                FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(log);
                streamWriter.WriteLine("Hatalı Kullanıcı Kayıt İşlemi " + exc + " " + DateTime.Now.ToLocalTime());
                streamWriter.Flush();
                streamWriter.Close();
                //MessageBox.Show("Bilgileri Kontrol Ediniz.");
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Profil Fotoğrafı Seçiniz";
            dosya.ShowDialog();
            string resim;
            resim = dosya.FileName;
            picAvatar.ImageLocation = resim;
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }
    }
}
