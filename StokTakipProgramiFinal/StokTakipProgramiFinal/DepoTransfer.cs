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
    public partial class DepoTransfer : Form
    {
        public DepoTransfer()
        {
            InitializeComponent();
        }
        class DepoTransferIslemi
        {
            public int stokID;
            public int miktar;
            public DateTime tarih;
            public int bulunduguDepo;
            public int gidecegiDepo;
        }

        public string tema;

        private void degerAtama()
        {
            depoTransferIslemi.miktar = Convert.ToInt32(txtMiktar.Text);
            depoTransferIslemi.tarih = dtpTarih.Value;
            depoTransferIslemi.bulunduguDepo = (int)cbbBulunduguDepo.SelectedValue;
            depoTransferIslemi.gidecegiDepo = (int)cbbGidecegiDepo.SelectedValue;
        }

        DepoTransferIslemi depoTransferIslemi = new DepoTransferIslemi();


        private void btnBarkod_Click(object sender, EventArgs e)
        {
            //BarkodOkuyucu frmBarkodOkuyucu = new BarkodOkuyucu();
            //frmBarkodOkuyucu.Show();
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            comboBulunduguDepo();
            sorgu();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            degerAtama();
            tbl_Transfer tbl_Transfer = new tbl_Transfer();
            tbl_Transfer.stok_id = depoTransferIslemi.stokID;
            tbl_Transfer.miktar = depoTransferIslemi.miktar;
            tbl_Transfer.gidicegi_tarih = depoTransferIslemi.tarih;
            tbl_Transfer.bulundugu_depo_id = depoTransferIslemi.bulunduguDepo;
            tbl_Transfer.gidecegi_depo_id = depoTransferIslemi.gidecegiDepo;
            db.tbl_Transfer.Add(tbl_Transfer);
            db.SaveChanges();
            var sonuc = db.tbl_Stok.Where(x => x.stok_id == depoTransferIslemi.stokID).FirstOrDefault();
            sonuc.depo_id = depoTransferIslemi.gidecegiDepo;
            db.SaveChanges();
            listele();
        }


        tbl_Depo tbl_depo = new tbl_Depo();

        private void comboBulunduguDepo()
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

        private void comboGidecegiDepo()
        {
            var query = (from d1 in db.tbl_Depo
                         select new
                         {
                             Value = d1.depo_id,
                             Names = d1.depo_ad
                         }).ToList();
            cbbGidecegiDepo.DataSource = query;
            cbbGidecegiDepo.DisplayMember = "Names";
            cbbGidecegiDepo.ValueMember = "Value";
            cbbGidecegiDepo.SelectedItem = 1;
        }

        private void DepoTransfer_Load(object sender, EventArgs e)
        {
            comboGidecegiDepo();
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
            listele();
        }
        private void listele()
        {
            var query = from d1 in db.tbl_Transfer
                        join d2 in db.tbl_Depo
                        on d1.bulundugu_depo_id equals d2.depo_id
                        join d3 in db.tbl_Stok
                        on d1.stok_id equals d3.stok_id
                        join d4 in db.tbl_Depo
                        on d1.gidecegi_depo_id equals d4.depo_id
                        select new
                        {
                            URUN_ADI = d3.urun_ad,
                            MIKTAR = d1.miktar,
                            GIDECEGI_TARIH = d1.gidicegi_tarih,
                            BULUNDUGU_DEPO = d2.depo_ad,
                            GIDECEGI_DEPO = d4.depo_ad
                        };
            dgwDepoTransfer.DataSource = query.ToList();
        }

        private void sorgu()
        {
            var sorgu = db.tbl_Stok.SingleOrDefault(r => r.urun_kod == txtBarkod.Text);

            if (sorgu != null)
            {
                txtUrunAdi.Text = sorgu.urun_ad;
                txtMiktar.Text = sorgu.urun_miktar.ToString();
                depoTransferIslemi.miktar = Convert.ToInt32(sorgu.urun_miktar);
                depoTransferIslemi.stokID = sorgu.stok_id;
            }
            else
            {
                txtUrunAdi.Text = "";
                txtMiktar.Text = "0";
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Excel.Application();
                app.Visible = true;
                Workbook urunler = app.Workbooks.Add(System.Reflection.Missing.Value);
                Worksheet sayfa = (Worksheet)urunler.Sheets[1];

                for (int i = 0; i < dgwDepoTransfer.Columns.Count; i++)
                {
                    if (dgwDepoTransfer.Columns[i].Visible == true)
                    {
                        Range alan = (Range)sayfa.Cells[1, 1];
                        alan.Cells[1, i + 1] = dgwDepoTransfer.Columns[i].HeaderText;
                    }
                }
                for (int i = 0; i < dgwDepoTransfer.Columns.Count; i++)
                {
                    if (dgwDepoTransfer.Columns[i].Visible == true)
                    {
                        for (int j = 0; j < dgwDepoTransfer.Rows.Count; j++)
                        {
                            Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                            alan2.Cells[2, 1] = dgwDepoTransfer[i, j].Value;
                        }
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
