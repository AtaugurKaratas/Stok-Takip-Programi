using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace StokTakipProgramiFinal
{
    public partial class StokBilgileri : Form
    {
        public StokBilgileri()
        {
            InitializeComponent();
        }
        class StokBilgisi
        {
            public int stokID;
            public string urunKodu;
            public string urunAdi;
            public int miktar;
            public int kategoriID;
            public int firmaID;
            public int birimID;
            public int birimMiktari;
            public decimal birimFiyati;
            public int depoID;
            public string resimYolu;
        }

        public string tema;

        StokBilgisi stokBilgisi = new StokBilgisi();
        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Stok Resmi Güncelleme";
            dosya.ShowDialog();
            stokBilgisi.resimYolu = dosya.FileName;
            picStokResim.ImageLocation = stokBilgisi.resimYolu;
        }

        private void degerAtama()
        {
            stokBilgisi.urunKodu = txtBarkod.Text;
            stokBilgisi.urunAdi = txtUrunAdi.Text;
            stokBilgisi.miktar = Convert.ToInt32(txtMiktar.Text);
            stokBilgisi.kategoriID = (int)cbbKategori.SelectedValue;
            stokBilgisi.firmaID = (int)cbbFirma.SelectedValue;
            stokBilgisi.birimID = (int)cbbBirim.SelectedValue;
            stokBilgisi.birimMiktari = Convert.ToInt32(txtBirimMiktari.Text);
            stokBilgisi.birimFiyati = decimal.Parse(txtBirimFiyati.Text, NumberStyles.Currency);
            stokBilgisi.depoID = (int)cbbDepoBilgisi.SelectedValue;
            stokBilgisi.resimYolu = picStokResim.ImageLocation;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            degerAtama();
            var sonuc = db.tbl_Stok.Where(x => x.stok_id == stokBilgisi.stokID).FirstOrDefault();
            sonuc.urun_kod = stokBilgisi.urunKodu;
            sonuc.urun_ad = stokBilgisi.urunAdi;
            sonuc.urun_miktar = stokBilgisi.miktar;
            sonuc.kategori_id = stokBilgisi.kategoriID;
            sonuc.firma_id = stokBilgisi.firmaID;
            sonuc.birim_id = stokBilgisi.birimID;
            sonuc.birim_miktar = stokBilgisi.birimMiktari;
            sonuc.birim_fiyat = stokBilgisi.birimFiyati;
            sonuc.depo_id = stokBilgisi.depoID;
            sonuc.resim = stokBilgisi.resimYolu;
            db.SaveChanges();
            dgwDoldur();
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        tbl_Stok tbl_Stok = new tbl_Stok();

        private void dgwDoldur()
        {
            var query = from d1 in db.tbl_Stok
                        join d2 in db.tbl_Depo
                        on d1.depo_id equals d2.depo_id
                        join d3 in db.tbl_Firma
                        on d1.firma_id equals d3.firma_id
                        join d4 in db.tbl_Birim
                        on d1.birim_id equals d4.birim_id
                        join d5 in db.tbl_Depo
                        on d1.depo_id equals d5.depo_id
                        join d6 in db.tbl_Kategori
                        on d1.kategori_id equals d6.kategori_id
                        where d1.urun_kod == txtBarkod.Text
                        select new
                        {
                            STOK_ID = d1.stok_id,
                            URUN_KODU = d1.urun_kod,
                            URUN_ADI = d1.urun_ad,
                            MIKTAR = d1.urun_miktar,
                            KATEGORI_ID = d1.kategori_id,
                            KATEGORI_ADI = d6.kategori_ad,
                            FIRMA_ID = d1.firma_id,
                            FIRMA_ADI = d3.firma_ad,
                            BIRIM_ID = d1.birim_id,
                            BIRIM_TURU = d4.birim_ad,
                            BIRIM_MIKTAR = d1.birim_miktar,
                            BIRIM_FIYAT = d1.birim_fiyat,
                            DEPO_ID = d1.depo_id,
                            DEPO_ADI = d5.depo_ad,
                            RESIM = d1.resim,
                            ALIS_TARIHI = d1.alis_tarih
                        };
            dgwStokBilgileri.DataSource = query.ToList();
            dgwStokBilgileri.Columns["STOK_ID"].Visible = false;
            dgwStokBilgileri.Columns["KATEGORI_ID"].Visible = false;
            dgwStokBilgileri.Columns["FIRMA_ID"].Visible = false;
            dgwStokBilgileri.Columns["BIRIM_ID"].Visible = false;
            dgwStokBilgileri.Columns["DEPO_ID"].Visible = false;
            dgwStokBilgileri.Columns["RESIM"].Visible = false;
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            dgwDoldur();
        }

        private void dgwStokBilgileriGuncelle()
        {
            stokBilgisi.stokID = (int)dgwStokBilgileri.CurrentRow.Cells["STOK_ID"].Value;

            stokBilgisi.kategoriID = (int)dgwStokBilgileri.CurrentRow.Cells["KATEGORI_ID"].Value;
            cbbKategori.SelectedValue = stokBilgisi.kategoriID;

            stokBilgisi.birimID = (int)dgwStokBilgileri.CurrentRow.Cells["BIRIM_ID"].Value;
            cbbBirim.SelectedValue = stokBilgisi.birimID;

            stokBilgisi.firmaID = (int)dgwStokBilgileri.CurrentRow.Cells["FIRMA_ID"].Value;
            cbbFirma.SelectedValue = stokBilgisi.firmaID;

            stokBilgisi.depoID = (int)dgwStokBilgileri.CurrentRow.Cells["DEPO_ID"].Value;
            cbbDepoBilgisi.SelectedValue = stokBilgisi.depoID;

            txtUrunAdi.Text = dgwStokBilgileri.CurrentRow.Cells["URUN_ADI"].Value.ToString();
            txtMiktar.Text = dgwStokBilgileri.CurrentRow.Cells["MIKTAR"].Value.ToString();
            txtBirimMiktari.Text = dgwStokBilgileri.CurrentRow.Cells["BIRIM_MIKTAR"].Value.ToString();
            txtBirimFiyati.Text = dgwStokBilgileri.CurrentRow.Cells["BIRIM_FIYAT"].Value.ToString();

            picStokResim.ImageLocation = dgwStokBilgileri.CurrentRow.Cells["RESIM"].Value.ToString();
        }

        private void dgwStokBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwStokBilgileriGuncelle();
        }

        private void comboKategori()
        {
            var query = (from item in db.tbl_Kategori
                         select new
                         {
                             Value = item.kategori_id,
                             Names = item.kategori_ad
                         }).ToList();
            cbbKategori.DataSource = query;
            cbbKategori.DisplayMember = "Names";
            cbbKategori.ValueMember = "Value";
            cbbKategori.SelectedItem = 1;
        }

        private void comboBirim()
        {
            var query = (from item in db.tbl_Birim
                         select new
                         {
                             Value = item.birim_id,
                             Names = item.birim_ad
                         }).ToList();
            cbbBirim.DataSource = query;
            cbbBirim.DisplayMember = "Names";
            cbbBirim.ValueMember = "Value";
            cbbBirim.SelectedItem = 1;
        }

        private void comboFirma()
        {
            var query = (from item in db.tbl_Firma
                         select new
                         {
                             Value = item.firma_id,
                             Names = item.firma_ad
                         }).ToList();
            cbbFirma.DataSource = query;
            cbbFirma.DisplayMember = "Names";
            cbbFirma.ValueMember = "Value";
            cbbFirma.SelectedItem = 1;
        }

        private void comboDepo()
        {
            var query = (from item in db.tbl_Depo
                         select new
                         {
                             Value = item.depo_id,
                             Names = item.depo_ad
                         }).ToList();
            cbbDepoBilgisi.DataSource = query;
            cbbDepoBilgisi.DisplayMember = "Names";
            cbbDepoBilgisi.ValueMember = "Value";
            cbbDepoBilgisi.SelectedItem = 1;
        }

        private void StokBilgileri_Load(object sender, EventArgs e)
        {
            comboBirim();
            comboKategori();
            comboFirma();
            comboDepo();
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = db.tbl_Stok.Where(x => x.stok_id == stokBilgisi.stokID).FirstOrDefault();
            db.tbl_Stok.Remove(sonuc);
            db.SaveChanges();
        }
        private void btnUrunleriListeleme_Click(object sender, EventArgs e)
        {
            var query = from d1 in db.tbl_Stok
                        join d2 in db.tbl_Depo
                        on d1.depo_id equals d2.depo_id
                        join d3 in db.tbl_Firma
                        on d1.firma_id equals d3.firma_id
                        join d4 in db.tbl_Birim
                        on d1.birim_id equals d4.birim_id
                        join d5 in db.tbl_Depo
                        on d1.depo_id equals d5.depo_id
                        join d6 in db.tbl_Kategori
                        on d1.kategori_id equals d6.kategori_id
                        select new
                        {
                            STOK_ID = d1.stok_id,
                            URUN_KODU = d1.urun_kod,
                            URUN_ADI = d1.urun_ad,
                            MIKTAR = d1.urun_miktar,
                            KATEGORI_ID = d1.kategori_id,
                            KATEGORI_ADI = d6.kategori_ad,
                            FIRMA_ID = d1.firma_id,
                            FIRMA_ADI = d3.firma_ad,
                            BIRIM_ID = d1.birim_id,
                            BIRIM_TURU = d4.birim_ad,
                            BIRIM_MIKTAR = d1.birim_miktar,
                            BIRIM_FIYAT = d1.birim_fiyat,
                            DEPO_ID = d1.depo_id,
                            DEPO_ADI = d5.depo_ad,
                            RESIM = d1.resim,
                            ALIS_TARIHI = d1.alis_tarih
                        };
            dgwStokBilgileri.DataSource = query.ToList();
            dgwStokBilgileri.Columns["STOK_ID"].Visible = false;
            dgwStokBilgileri.Columns["KATEGORI_ID"].Visible = false;
            dgwStokBilgileri.Columns["FIRMA_ID"].Visible = false;
            dgwStokBilgileri.Columns["BIRIM_ID"].Visible = false;
            dgwStokBilgileri.Columns["DEPO_ID"].Visible = false;
            dgwStokBilgileri.Columns["RESIM"].Visible = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dgwStokBilgileri.Columns.Remove("STOK_ID");
            dgwStokBilgileri.Columns.Remove("KATEGORI_ID");
            dgwStokBilgileri.Columns.Remove("FIRMA_ID");
            dgwStokBilgileri.Columns.Remove("BIRIM_ID");
            dgwStokBilgileri.Columns.Remove("DEPO_ID");
            dgwStokBilgileri.Columns.Remove("RESIM");
            try
            {
                Excel.Application app = new Excel.Application();
                app.Visible = true;
                Workbook urunler = app.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet sayfa = (Worksheet)urunler.Sheets[1];

                for (int i = 0; i < dgwStokBilgileri.Columns.Count; i++)
                {
                        Range alan = (Range)sayfa.Cells[1, 1];
                        alan.Cells[1, i + 1] = dgwStokBilgileri.Columns[i].HeaderText;
                }
                for (int i = 0; i < dgwStokBilgileri.Columns.Count; i++)
                {
                        for (int j = 0; j < dgwStokBilgileri.Rows.Count; j++)
                        {
                            Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                            alan2.Cells[2, 1] = dgwStokBilgileri[i, j].Value;
                        }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem");
            }
        }
   }
}
