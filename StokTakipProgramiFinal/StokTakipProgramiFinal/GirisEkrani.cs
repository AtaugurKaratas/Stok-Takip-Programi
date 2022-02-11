using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        class Giris
        {
            public String kullaniciAdi;
            public String password;
            public Boolean girisIslemi;
        }
        private void lnkLblSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum frmSifreUnuttum = new SifremiUnuttum();
            frmSifreUnuttum.Show();
        }

        Giris grs = new Giris();

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            grs.girisIslemi = true;
            btnYonetici.BackColor = SystemColors.MenuHighlight;
            btnPersonel.BackColor = Color.Lavender;
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            grs.girisIslemi = false;
            btnPersonel.BackColor = SystemColors.MenuHighlight;
            btnYonetici.BackColor = Color.Lavender;
        }
        int girisHakki = 3;

        private void captcha()
        {
            Random rnd = new Random();
            int num = rnd.Next(6, 8);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rnd.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl == num)
                        break;
                }
            } while (true);
            lblCaptcha.Text = captcha;
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        string adres = "log.txt";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (lblCaptcha.Text == txtDogrulama.Text)
            {
                grs.kullaniciAdi = txtKullaniciAdi.Text;
                grs.password = txtSifre.Text;
                MD5CryptoServiceProvider m = new MD5CryptoServiceProvider();
                byte[] byteuser = System.Text.Encoding.UTF8.GetBytes(grs.password);
                byte[] hasheduser = m.ComputeHash(byteuser);
                string usernamemd5 = Convert.ToBase64String(hasheduser);
                grs.password = usernamemd5;
                if (grs.girisIslemi == true)
                {
                    if(db.tbl_Kullanici.Where(r=>r.kullanici_ad==grs.kullaniciAdi
                    && r.hesap_durum=="admin" && r.kullanici_sifre==grs.password).Count()>0)
                    {
                        FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                        StreamWriter streamWriter = new StreamWriter(log);
                        streamWriter.WriteLine("Admin kullanıcısı giriş yaptı. " + DateTime.Now.ToLocalTime());
                        streamWriter.Flush();
                        streamWriter.Close();
                        this.Hide();
                        AdminEkrani frmAdminEkrani = new AdminEkrani();
                        var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_ad == txtKullaniciAdi.Text).FirstOrDefault();
                        frmAdminEkrani.kullaniciID = sonuc.kullanici_id;
                        frmAdminEkrani.tema = sonuc.tema;
                        frmAdminEkrani.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
                        captcha();
                    }
                }
                else
                {
                    if (db.tbl_Kullanici.Where(r => r.kullanici_ad == grs.kullaniciAdi
                     && r.hesap_durum == "kullanici" && r.kullanici_sifre == grs.password).Count() > 0)
                    {
                        this.Hide();
                        KullaniciEkrani frmKullaniciEkrani = new KullaniciEkrani();
                        var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_ad == txtKullaniciAdi.Text).FirstOrDefault();
                        frmKullaniciEkrani.kullaniciID = sonuc.kullanici_id;
                        FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                        StreamWriter streamWriter = new StreamWriter(log);
                        streamWriter.WriteLine(sonuc.ad + " " + sonuc.soyad + " giriş yaptı. " + DateTime.Now.ToLocalTime());
                        streamWriter.Flush();
                        streamWriter.Close();
                        frmKullaniciEkrani.tema = sonuc.tema;
                        frmKullaniciEkrani.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
                        captcha();
                    }
                }
                girisHakki--;
                if (girisHakki == 0)
                {
                    MessageBox.Show("Giriş Hakkınız Doldu. Daha Fazla Giriş Yapamazsınız.");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Doğrulama Kodunuz Yanlış");
                captcha();
            }
        }

        private void btnSifreAcKapa_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
            {
                txtSifre.UseSystemPasswordChar = false;
                btnSifreAcKapa.Image = Image.FromFile("sifreAcik.png");
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                btnSifreAcKapa.Image = Image.FromFile("sifreKapali.png");
            }
        }

        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            captcha();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            captcha();
        }
    }
}
