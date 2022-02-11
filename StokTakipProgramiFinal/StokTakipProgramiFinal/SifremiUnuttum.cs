using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Linq;
using System.Net;

namespace StokTakipProgramiFinal
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        class Kullanici
        {
            public int kullaniciID;
        }

        Kullanici kullanici = new Kullanici();
        int sayi;

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void btnOnayKodu_Click(object sender, EventArgs e)
        {

            if (db.tbl_Kullanici.Where(r => r.kullanici_ad == txtKullaniciAdi.Text && r.email == txtEmail.Text).Count() > 0)
            {
                try
                {
                    Random random = new Random();
                    sayi = random.Next(1, 10000);
                    MailMessage mesajım = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential("KaratasStokTakip@hotmail.com", "123456Ataugur#");
                    istemci.Port = 587;
                    istemci.Host = "smtp.live.com";
                    istemci.EnableSsl = true;
                    mesajım.To.Add(txtEmail.Text);
                    mesajım.From = new MailAddress("KaratasStokTakip@hotmail.com");
                    mesajım.Subject = "Onay Kodu ";
                    mesajım.Body = "Onay Kodunuz " + sayi;
                    istemci.Send(mesajım);
                    var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_ad == txtKullaniciAdi.Text).FirstOrDefault();
                    kullanici.kullaniciID = sonuc.kullanici_id;
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Hatalı işlem gerçekleştirildi. "+exc.ToString());
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız ve Email Adresiniz Eşleşmedi.");
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (sayi == Convert.ToInt32(txtOnayKodu.Text))
            {
                YeniSifre yeniSifre = new YeniSifre();
                this.Visible = false;
                yeniSifre.kullaniciID = kullanici.kullaniciID;
                yeniSifre.Show();
            }
            else
            {
                MessageBox.Show("Onay Kodu Geçersiz");
            }
        }
    }
}
