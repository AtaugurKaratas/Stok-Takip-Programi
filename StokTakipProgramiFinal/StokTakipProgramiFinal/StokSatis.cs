using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace StokTakipProgramiFinal
{
    public partial class StokSatis : Form
    {
        public StokSatis()
        {
            InitializeComponent();
        }

        public class Satis
        {
            public int stokID;
            public int firmaID;
            public int depoID;
            public int miktar;
            public int netFiyat;
            public int kdv;
            public int otv;
            public int brutFiyat;
            public DateTime satisTarihi;
        }

        Satis satis = new Satis();

        public string tema;

        private void degerAtama()
        {
                satis.firmaID = (int)cmbFirma.SelectedValue;
                satis.depoID = (int)cbbBulunduguDepo.SelectedValue;
                satis.miktar = Convert.ToInt32(txtMiktar.Text);
                satis.netFiyat = Convert.ToInt32(txtNetFiyat.Text);
                satis.kdv = Convert.ToInt32(txtKdvOran.Text);
                satis.otv = Convert.ToInt32(txtOtvOran.Text);
                satis.brutFiyat = Convert.ToInt32(txtBrutFiyat.Text);
                satis.satisTarihi = DateTime.Now;
                urunMiktari -= Convert.ToInt32(txtMiktar.Text);
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
            degerAtama();
            tbl_Stok_Satis tbl_Stok_Satis = new tbl_Stok_Satis();
            tbl_Stok_Satis.stok_id = satis.stokID;
            tbl_Stok_Satis.firma_id = satis.firmaID;
            tbl_Stok_Satis.depo_id = satis.depoID;
            tbl_Stok_Satis.miktar = satis.miktar;
            tbl_Stok_Satis.net_fiyat = satis.netFiyat;
            tbl_Stok_Satis.kdv = satis.kdv;
            tbl_Stok_Satis.otv = satis.otv;
            tbl_Stok_Satis.brut_fiyat = satis.brutFiyat;
            tbl_Stok_Satis.satis_tarih = satis.satisTarihi;
            db.tbl_Stok_Satis.Add(tbl_Stok_Satis);
            db.SaveChanges();
            var sonuc = db.tbl_Stok.Where(x => x.stok_id == satis.stokID).FirstOrDefault();
            sonuc.urun_miktar = urunMiktari;
            db.SaveChanges();
            listele();
            satisBelgesi();
            }
            catch
            {
                MessageBox.Show("Değerleri Doldurunuz");
            }
        }

        private void satisBelgesi()
        {
            printPreviewDialog1.ShowDialog();
            DialogResult dlr = printDialogSatis.ShowDialog();
            if(dlr == DialogResult.OK)
            {
                printSatisBelge.Print();
            }
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            comboDepo();
            sorgulama();
        }

        tbl_Birim tbl_Birim = new tbl_Birim();

        private void comboFirma()
        {
            var query = (from d1 in db.tbl_Firma
                         select new
                         {
                             Value = d1.firma_id,
                             Names = d1.firma_ad
                         }).ToList();
            cmbFirma.DataSource = query;
            cmbFirma.DisplayMember = "Names";
            cmbFirma.ValueMember = "Value";
            cmbFirma.SelectedItem = 1;
        }


        tbl_Depo tbl_depo = new tbl_Depo();

        private void comboDepo()
        {
            cbbBulunduguDepo.DataSource = null;
            cbbBulunduguDepo.Items.Clear();
            var query = (from d1 in db.tbl_Depo
                         join d2 in db.tbl_Stok
                         on d1.depo_id equals d2.depo_id
                         where (d2.urun_kod == txtBarkod.Text)
                         select new
                         {
                             Value = d2.depo_id,
                             Names = d1.depo_ad
                         }).ToList();
            cbbBulunduguDepo.DataSource = query;
            cbbBulunduguDepo.DisplayMember = "Names";
            cbbBulunduguDepo.ValueMember = "Value";
            cbbBulunduguDepo.SelectedItem = 1;
        }

        int urunMiktari;

        private void sorgulama()
        {
            var sorgu = db.tbl_Stok.SingleOrDefault(r => r.urun_kod == txtBarkod.Text);

            if (sorgu != null)
            {
                txtMiktar.Text = sorgu.urun_miktar.ToString();
                satis.stokID = sorgu.stok_id;
                urunMiktari = Convert.ToInt32(txtMiktar.Text);
            }
            else
            {
                txtMiktar.Text = "0";
            }
        }

        private void StokSatis_Load(object sender, EventArgs e)
        {
            comboFirma();
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
            listele();
        }

        private void listele()
        {
            var query = from d1 in db.tbl_Stok_Satis
                        join d2 in db.tbl_Depo
                        on d1.depo_id equals d2.depo_id
                        join d3 in db.tbl_Firma
                        on d1.firma_id equals d3.firma_id
                        join d4 in db.tbl_Stok
                        on d1.stok_id equals d4.stok_id
                        join d5 in db.tbl_Depo
                        on d1.depo_id equals d5.depo_id
                        select new
                        {
                            STOK_ADI = d4.urun_ad,
                            FIRMA_ADI = d3.firma_ad,
                            DEPO_ADI = d2.depo_ad,
                            MİKTAR = d1.miktar,
                            NET_FIYAT = d1.net_fiyat,
                            KDV_ORANI = d1.kdv,
                            OTV_ORANI = d1.otv,
                            BRUT_FIYAT = d1.brut_fiyat,
                            SATIS_TARIHI = d1.satis_tarih
                        };
            dgwStokSatis.DataSource = query.ToList();
        }

        private void brutFiyat()
        {

            int netFiyati, kdvOrani, otvOrani;
            int brutFiyati;
            try
            {
                netFiyati = Convert.ToInt32(txtNetFiyat.Text);
                kdvOrani = Convert.ToInt32(txtKdvOran.Text);
                otvOrani = Convert.ToInt32(txtOtvOran.Text);
                brutFiyati = (netFiyati * (kdvOrani + 100)) / 100;
                brutFiyati = (brutFiyati * (otvOrani + 100)) / 100;
                txtBrutFiyat.Text = brutFiyati.ToString();
            }
            catch
            {
                MessageBox.Show("Hatalı Değer Girişi");
            }
        }

        private void txtNetFiyat_TextChanged(object sender, EventArgs e)
        {
            brutFiyat();
        }

        private void txtKdvOran_TextChanged(object sender, EventArgs e)
        {
            brutFiyat();
        }

        private void txtOtvOran_TextChanged(object sender, EventArgs e)
        {
            brutFiyat();
        }

        private void printSatisBelge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font myFont = new System.Drawing.Font("arial", 30);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen mypen = new Pen(Color.SkyBlue);

            var query = (from d1 in db.tbl_Stok_Satis
                         join d2 in db.tbl_Stok
                         on d1.stok_id equals d2.stok_id
                         join d3 in db.tbl_Firma
                         on d1.firma_id equals d3.firma_id
                         where (d1.stok_id == d2.stok_id)
                         select new
                         {
                             urunAdi = d2.urun_ad,
                             firma = d3.firma_ad,
                             miktar = d2.urun_miktar
                         }).ToList();

            e.Graphics.DrawLine(mypen, 100, 200, 700, 200);
            e.Graphics.DrawString("Karataş Stok Takip", myFont, sbrush, 200, 225);
            e.Graphics.DrawLine(mypen, 100, 300, 700, 300);
            foreach (var i in query)
            {
                e.Graphics.DrawString(DateTime.Now.ToString(), myFont, sbrush, 200, 100);
                e.Graphics.DrawString("Ürün Adı : " + i.urunAdi.ToString() + " * " + i.miktar.ToString(), myFont, sbrush, 100, 325);
                e.Graphics.DrawString("Satılacak Firma : " + i.firma.ToString(), myFont, sbrush, 100, 400);
                e.Graphics.DrawString("Net Fiyat : " + satis.netFiyat, myFont, sbrush, 100, 475);
                e.Graphics.DrawString("KDV Oranı : " + satis.kdv, myFont, sbrush, 100, 550);
                e.Graphics.DrawString("OTV Oranı : " + satis.otv, myFont, sbrush, 100, 625);
                e.Graphics.DrawString("Brüt Fiyat : " + satis.brutFiyat, myFont, sbrush, 100, 700);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                app.Visible = true;
                Workbook urunler = app.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet sayfa = (Worksheet)urunler.Sheets[1];

                for (int i = 0; i < dgwStokSatis.Columns.Count; i++)
                {
                    if (dgwStokSatis.Columns[i].Visible == true)
                    {
                        Range alan = (Range)sayfa.Cells[1, 1];
                        alan.Cells[1, i + 1] = dgwStokSatis.Columns[i].HeaderText;
                    }
                }
                for (int i = 0; i < dgwStokSatis.Columns.Count; i++)
                {
                    if (dgwStokSatis.Columns[i].Visible == true)
                    {
                        for (int j = 0; j < dgwStokSatis.Rows.Count; j++)
                        {
                            Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                            alan2.Cells[2, 1] = dgwStokSatis[i, j].Value;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı İşlem");
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
