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
    public partial class YeniSifre : Form
    {
        public YeniSifre()
        {
            InitializeComponent();
        }

        public int kullaniciID=1;
        public string kullaniciSifre;

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYeniSifre.Text == txtSifreTekrar.Text)
                {
                    kullaniciSifre = txtYeniSifre.Text;
                    MD5CryptoServiceProvider m = new MD5CryptoServiceProvider();
                    byte[] byteuser = System.Text.Encoding.UTF8.GetBytes(kullaniciSifre);
                    byte[] hasheduser = m.ComputeHash(byteuser);
                    string usernamemd5 = Convert.ToBase64String(hasheduser);
                    kullaniciSifre = usernamemd5;
                    var sonuc = db.tbl_Kullanici.Where(x => x.kullanici_id == kullaniciID).FirstOrDefault();
                    sonuc.kullanici_sifre = kullaniciSifre;
                    db.SaveChanges();
                    this.Close();
                    String adres = "log.txt";
                    FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(log);
                    streamWriter.WriteLine(sonuc.ad + " " + sonuc.soyad + "kullanıcısı şifre değişikliği yaptı. " + DateTime.Now.ToLocalTime());
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Hatalı İşlem Yapıldı. " + exc.ToString());
            }
        }
    }
}
