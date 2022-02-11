using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class StokAlis : Form
    {
        public StokAlis()
        {
            InitializeComponent();
        }
        class StokAlma
        {
            public string urunKodu;
            public string urunAdi;
            public int miktar;
            public int kategoriID;
            public int firmaID;
            public int birimID;
            public int birimMiktari;
            public int birimFiyati;
            public int depoID;
            public string resimYolu;
            public DateTime alisTarihi;
        }

        public string tema;

        StokAlma stokAlma = new StokAlma();
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Stok Resmi Ekleme";
            dosya.ShowDialog();
            stokAlma.resimYolu = dosya.FileName;
            picStokResim.ImageLocation = stokAlma.resimYolu;
        }

        private void degerAtama()
        {
            stokAlma.urunKodu = txtUrunKodu.Text;
            stokAlma.urunAdi = txtUrunAdi.Text;
            stokAlma.miktar = Convert.ToInt32(txtMiktar.Text);
            stokAlma.kategoriID = (int)cbbKategori.SelectedValue;
            stokAlma.firmaID = (int)cbbFirma.SelectedValue;
            stokAlma.birimID = (int)cbbBirim.SelectedValue;
            stokAlma.birimMiktari = Convert.ToInt32(txtBirimMiktari.Text);
            stokAlma.birimFiyati = Convert.ToInt32(txtBirimFiyati.Text);
            stokAlma.depoID = (int)cbbDepoBilgisi.SelectedValue;
            stokAlma.alisTarihi = DateTime.Now;
        }

        tbl_Stok tbl_Stok = new tbl_Stok();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            degerAtama();
            tbl_Stok.urun_kod = stokAlma.urunKodu;
            tbl_Stok.urun_ad = stokAlma.urunAdi;
            tbl_Stok.urun_miktar = stokAlma.miktar;
            tbl_Stok.kategori_id = stokAlma.kategoriID;
            tbl_Stok.firma_id = stokAlma.firmaID;
            tbl_Stok.birim_id = stokAlma.birimID;
            tbl_Stok.birim_miktar = stokAlma.birimMiktari;
            tbl_Stok.birim_fiyat = stokAlma.birimFiyati;
            tbl_Stok.depo_id = stokAlma.depoID;
            tbl_Stok.resim = stokAlma.resimYolu;
            tbl_Stok.alis_tarih = stokAlma.alisTarihi;
            db.tbl_Stok.Add(tbl_Stok);
            db.SaveChanges();
        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            //BarkodOkuyucu frmBarkodOkuyucu = new BarkodOkuyucu();
            //frmBarkodOkuyucu.Show();
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        tbl_Birim tbl_Birim = new tbl_Birim();

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

        tbl_Firma tbl_Firma = new tbl_Firma();

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

        tbl_Depo tbl_Depo = new tbl_Depo();

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

        tbl_Kategori tbl_Kategori = new tbl_Kategori();

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

        private void StokAlis_Load(object sender, EventArgs e)
        {
            comboBirim();
            comboFirma();
            comboDepo();
            comboKategori();
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }

        private void btnBarkod_Click_1(object sender, EventArgs e)
        {
            BarkodOkuyucu barkodOkuyucu = new BarkodOkuyucu();
            barkodOkuyucu.Show();
        }
    }
}
