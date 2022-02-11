using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class FirmaEkle : Form
    {
        public FirmaEkle()
        {
            InitializeComponent();
        }
        class FirmaEkleme
        {
            public string firmaAdi;
            public string adres;
            public string telefon;
            public string vergiDairesi;
            public string hesapNo;
            public string aciklama;
            public string firmaResmi;
        }

        public int kullaniciID;

        public string tema;

        FirmaEkleme firmaEkleme = new FirmaEkleme();

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Profil Fotoğrafı Seçiniz";
            dosya.ShowDialog();
            string resim;
            resim = dosya.FileName;
            picFirmaResim.ImageLocation = resim;
        }

        private void firmaKayit()
        {
            firmaEkleme.firmaAdi = txtFirmaAdi.Text;
            firmaEkleme.adres = txtAdres.Text;
            firmaEkleme.telefon = txtTelefon.Text;
            firmaEkleme.vergiDairesi = txtVergiDairesi.Text;
            firmaEkleme.hesapNo = txtHesapNo.Text;
            firmaEkleme.aciklama = txtAciklama.Text;
            firmaEkleme.firmaResmi = picFirmaResim.ImageLocation;
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try {
            firmaKayit();
            tbl_Firma tbl_Firma = new tbl_Firma();
            tbl_Firma.firma_ad = firmaEkleme.firmaAdi;
            tbl_Firma.firma_adres = firmaEkleme.adres;
            tbl_Firma.firma_telefon = firmaEkleme.telefon;
            tbl_Firma.vergi_dairesi = firmaEkleme.vergiDairesi;
            tbl_Firma.hesap_no = firmaEkleme.hesapNo;
            tbl_Firma.firma_aciklama = firmaEkleme.aciklama;
            tbl_Firma.firma_resmi = firmaEkleme.firmaResmi;
            db.tbl_Firma.Add(tbl_Firma);
            db.SaveChanges();
            string adres = "log.txt";
            FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(log);
            streamWriter.WriteLine(firmaEkleme.firmaAdi + " Firması Eklendi. " + DateTime.Now.ToLocalTime());
            streamWriter.Flush();
            streamWriter.Close();
            }
            catch(Exception exc)
            {
                string adres = "log.txt";
                FileStream log = new FileStream(adres, FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(log);
                streamWriter.WriteLine("Hatalı Firma Kayıt İşlemi " + exc + " " + DateTime.Now.ToLocalTime());
                streamWriter.Flush();
                streamWriter.Close();
                MessageBox.Show("Bilgileri Kontrol Ediniz.");
            }
        }

        private void FirmaEkle_Load(object sender, EventArgs e)
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }
    }
}
