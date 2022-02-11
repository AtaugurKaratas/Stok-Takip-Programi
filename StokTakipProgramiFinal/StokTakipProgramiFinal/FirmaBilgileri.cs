using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class FirmaBilgileri : Form
    {
        public FirmaBilgileri()
        {
            InitializeComponent();
        }
        class Firmalar
        {
            public int firmaID;
            public string ad;
            public string adres;
            public string hesapNo;
            public string telefon;
            public string vergiDairesi;
            public string aciklama;
            public string resim;
        }

        public int kullaniciID;

        public string tema;

        Firmalar firmalar = new Firmalar();

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Firma Resmi Güncelleme";
            dosya.ShowDialog();
            firmalar.resim = dosya.FileName;
            picFirmaResim.ImageLocation = firmalar.resim;
        }

        private void degerAtama()
        {
            firmalar.ad = txtFirmaAdi.Text;
            firmalar.adres = txtAdres.Text;
            firmalar.hesapNo = txtHesapNo.Text;
            firmalar.telefon = txtTelefon.Text;
            firmalar.vergiDairesi = txtVergiDairesi.Text;
            firmalar.aciklama = txtAciklama.Text;
            firmalar.resim = picFirmaResim.ImageLocation;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            degerAtama();
            var sonuc = db.tbl_Firma.Where(x => x.firma_id == firmalar.firmaID).FirstOrDefault();
            sonuc.firma_ad = firmalar.ad;
            sonuc.firma_adres = firmalar.adres;
            sonuc.hesap_no = firmalar.hesapNo;
            sonuc.firma_telefon = firmalar.telefon;
            sonuc.vergi_dairesi = firmalar.vergiDairesi;
            sonuc.firma_aciklama = firmalar.aciklama;
            sonuc.firma_resmi = firmalar.resim;
            db.SaveChanges();
            dgwDoldur();
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void FirmaBilgileri_Load(object sender, EventArgs e)
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
            dgwDoldur();
        }
        private void dgwDoldur()
        {
            dgwFirmaBilgileri.DataSource = db.tbl_Firma.ToList();
            dgwFirmaBilgileri.Columns["firma_id"].Visible = false;
            dgwFirmaBilgileri.Columns["firma_resmi"].Visible = false;
        }
        private void dgwGuncelle()
        {
            try
            {
                firmalar.firmaID = (int)dgwFirmaBilgileri.CurrentRow.Cells["firma_id"].Value;
                txtFirmaAdi.Text = dgwFirmaBilgileri.CurrentRow.Cells["firma_ad"].Value.ToString();
                txtAdres.Text = dgwFirmaBilgileri.CurrentRow.Cells["firma_adres"].Value.ToString();
                txtHesapNo.Text = dgwFirmaBilgileri.CurrentRow.Cells["hesap_no"].Value.ToString();
                txtTelefon.Text = dgwFirmaBilgileri.CurrentRow.Cells["firma_telefon"].Value.ToString();
                txtVergiDairesi.Text = dgwFirmaBilgileri.CurrentRow.Cells["vergi_dairesi"].Value.ToString();
                txtAciklama.Text = dgwFirmaBilgileri.CurrentRow.Cells["firma_aciklama"].Value.ToString();
                if (dgwFirmaBilgileri.CurrentRow.Cells["firma_resmi"].Value != null)
                {
                    picFirmaResim.ImageLocation = dgwFirmaBilgileri.CurrentRow.Cells["firma_resmi"].Value.ToString();
                }
                else
                {
                    picFirmaResim.ImageLocation = "";
                }
            }
            catch(Exception exc)
            {

            }
        }
        private void dgwFirmaBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = db.tbl_Firma.Where(x => x.firma_id == firmalar.firmaID).FirstOrDefault();
            db.tbl_Firma.Remove(sonuc);
            db.SaveChanges();
            dgwDoldur();
        }
    }
}
