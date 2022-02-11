using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class YuklemeEkrani : Form
    {
        public YuklemeEkrani()
        {
            InitializeComponent();
        }

        private void yuklemeEkrani_Load(object sender, EventArgs e)
        {
            yuklemeBari.Style = ProgressBarStyle.Marquee;
            yuklemeBari.MarqueeAnimationSpeed = 10;
            tmrYukleme.Interval = 3000;
            tmrYukleme.Start();
            adminKayit();
        }
        int i = 0;
        private void tmrYukleme_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                tmrYukleme.Stop();
                this.Hide();
                GirisEkrani frmGiris = new GirisEkrani();
                frmGiris.Show();
            }
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        tbl_Kullanici tbl_Kullanici = new tbl_Kullanici();

        private void adminKayit()
        {
            var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_ad == "admin").FirstOrDefault();
            if (sonuc == null)
            {
                tbl_Kullanici.tc_no = "1000000000";
                tbl_Kullanici.ad = "Admin";
                tbl_Kullanici.soyad = "Yönetici";
                tbl_Kullanici.kullanici_ad = "admin";
                MD5CryptoServiceProvider m = new MD5CryptoServiceProvider();
                byte[] byteuser = System.Text.Encoding.UTF8.GetBytes("123");
                byte[] hasheduser = m.ComputeHash(byteuser);
                string usernamemd5 = Convert.ToBase64String(hasheduser);
                tbl_Kullanici.kullanici_sifre = usernamemd5;
                tbl_Kullanici.telefon = "05555555555";
                tbl_Kullanici.email = "KaratasStokTakip@gmail.com";
                tbl_Kullanici.dogum_tarih = DateTime.Now;
                tbl_Kullanici.cinsiyet = "Erkek";
                tbl_Kullanici.hesap_durum = "admin";
                tbl_Kullanici.tema = "255;230;82";
                db.tbl_Kullanici.Add(tbl_Kullanici);
                db.SaveChanges();
                string adres = "log.txt";
                FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(log);
                streamWriter.WriteLine("Admin Kullanıcısı Eklendi. " + DateTime.Now.ToLocalTime());
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}
