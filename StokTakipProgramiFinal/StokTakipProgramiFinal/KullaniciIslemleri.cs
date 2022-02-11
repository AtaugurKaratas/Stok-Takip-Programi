using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        class KullaniciIslemi
        {
            public string tcNo;
            public string kullaniciAdi;
            public string kullaniciSoyadi;
        }

        public int kullaniciID;

        public string tema;

        KullaniciIslemi kullaniciIslemi = new KullaniciIslemi();

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void degerAtama()
        {
            kullaniciIslemi.tcNo = txtTcNo.Text;
            kullaniciIslemi.kullaniciAdi = txtKullaniciAdi.Text;
            kullaniciIslemi.kullaniciSoyadi = txtKullaniciSoyadi.Text;
        }
        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            var query = (from d1 in db.tbl_Kullanici
                         where d1.tc_no == txtTcNo.Text
                         select new
                         {
                             TC_NO = d1.tc_no,
                             AD = d1.ad,
                             SOYAD = d1.soyad,
                             TELEFON = d1.telefon,
                             EMAIL = d1.email,
                             DOGUM_TARIH = d1.dogum_tarih,
                             CINSIYET = d1.cinsiyet,
                             RESIM = d1.resim
                         }).ToList();
            dgwKullanicilar.DataSource = query;
            dgwKullanicilar.Columns["RESIM"].Visible = false;
        }
        private void dgwKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgwKullanicilar.CurrentRow.Cells[7].Value != null)
            {
                picProfilResmi.ImageLocation = dgwKullanicilar.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {
                picProfilResmi.ImageLocation = null;
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            var query = (from d1 in db.tbl_Kullanici
                         where d1.ad == txtKullaniciAdi.Text
                         select new
                         {
                             TC_NO = d1.tc_no,
                             AD = d1.ad,
                             SOYAD = d1.soyad,
                             TELEFON = d1.telefon,
                             EMAIL = d1.email,
                             DOGUM_TARIH = d1.dogum_tarih,
                             CINSIYET = d1.cinsiyet,
                             RESIM = d1.resim
                         }).ToList();
            dgwKullanicilar.DataSource = query;
            dgwKullanicilar.Columns["RESIM"].Visible = false;
        }

        private void txtKullaniciSoyadi_TextChanged(object sender, EventArgs e)
        {
            var query = (from d1 in db.tbl_Kullanici
                         where d1.soyad == txtKullaniciSoyadi.Text
                         select new
                         {
                             TC_NO = d1.tc_no,
                             AD = d1.ad,
                             SOYAD = d1.soyad,
                             TELEFON = d1.telefon,
                             EMAIL = d1.email,
                             DOGUM_TARIH = d1.dogum_tarih,
                             CINSIYET = d1.cinsiyet,
                             RESIM = d1.resim
                         }).ToList();
            dgwKullanicilar.DataSource = query;
            dgwKullanicilar.Columns["RESIM"].Visible = false;
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            var kullanicilar = db.tbl_Kullanici.ToList();
            dgwKullanicilar.DataSource = kullanicilar;
            dgwKullanicilar.Columns.Remove("kullanici_id");
            dgwKullanicilar.Columns.Remove("kullanici_ad");
            dgwKullanicilar.Columns.Remove("kullanici_sifre");
            dgwKullanicilar.Columns[7].Visible = false;
            dgwKullanicilar.Columns.Remove("hesap_durum");
            dgwKullanicilar.Columns.Remove("tema");
        }
    }
}
