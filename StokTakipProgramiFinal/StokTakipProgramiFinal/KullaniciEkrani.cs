using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace StokTakipProgramiFinal
{
    public partial class KullaniciEkrani : Form
    {
        public KullaniciEkrani()
        {
            InitializeComponent();
        }
        public int kullaniciID;

        public string tema;

        private void btnStokAlis_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            StokAlis frmStokAlis = new StokAlis();
            frmStokAlis.Dock = DockStyle.Fill;
            frmStokAlis.TopLevel = false;
            frmStokAlis.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmStokAlis);
            frmStokAlis.tema = tema;
            frmStokAlis.Show();
        }

        private void btnStokBilgileri_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            StokBilgileri frmStokBilgileri = new StokBilgileri();
            frmStokBilgileri.Dock = DockStyle.Fill;
            frmStokBilgileri.TopLevel = false;
            frmStokBilgileri.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmStokBilgileri);
            frmStokBilgileri.tema = tema;
            frmStokBilgileri.Show();
        }

        private void btnStokSatis_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            StokSatis frmStokSatis = new StokSatis();
            frmStokSatis.Dock = DockStyle.Fill;
            frmStokSatis.TopLevel = false;
            frmStokSatis.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmStokSatis);
            frmStokSatis.tema = tema;
            frmStokSatis.Show();
        }

        private void btnStokTransfer_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            DepoTransfer frmDepoTransfer = new DepoTransfer();
            frmDepoTransfer.Dock = DockStyle.Fill;
            frmDepoTransfer.TopLevel = false;
            frmDepoTransfer.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmDepoTransfer);
            frmDepoTransfer.tema = tema;
            frmDepoTransfer.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            Ayarlar frmAyarlar = new Ayarlar();
            frmAyarlar.Dock = DockStyle.Fill;
            frmAyarlar.TopLevel = false;
            frmAyarlar.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmAyarlar);
            frmAyarlar.tema = tema;
            frmAyarlar.kullaniciID = kullaniciID;
            frmAyarlar.Show();
        }

        private void stokAlışYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokAlis frmStokAlis = new StokAlis();
            frmStokAlis.tema = tema;
            frmStokAlis.Show();
            temaIslemi();
        }

        private void stokBilgileriYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokBilgileri frmStokBilgileri = new StokBilgileri();
            frmStokBilgileri.tema = tema;
            frmStokBilgileri.Show();
        }

        private void stokSatışYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokSatis frmStokSatis = new StokSatis();
            frmStokSatis.tema = tema;
            frmStokSatis.Show();
        }

        private void transferBilgisiYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepoTransfer frmDepoTransfer = new DepoTransfer();
            frmDepoTransfer.tema = tema;
            frmDepoTransfer.Show();
        }

        private void ayarlarYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar frmAyarlar = new Ayarlar();
            frmAyarlar.tema = tema;
            frmAyarlar.kullaniciID = kullaniciID;
            frmAyarlar.Show();
        }

        private void KullaniciEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciEkrani_Load(object sender, EventArgs e)
        {
            DovizGoster();
            tmrZaman.Start();
            temaIslemi();
            tmrPara.Start();
        }

        private void temaIslemi()
        {
            string[] value2 = tema.Split(';');
            pnlAna.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }
        int i = 0;
        public void DovizGoster()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                if (i == 0)
                {
                    lblPara.Text = "Dolar: " + dolar.ToString();
                    i++;
                }
                else if (i == 1)
                {
                    lblPara.Text = "Euro: " + euro.ToString();
                    i++;
                }
                else if (i == 2)
                {
                    lblPara.Text = "Sterlin: " + sterlin.ToString();
                    i = 0;
                }
            }
            catch (XmlException xml)
            {
                tmrZaman.Stop();
                MessageBox.Show(xml.ToString());
            }

        }
        private void tmrPara_Tick(object sender, EventArgs e)
        {
            DovizGoster();
        }
    }
}
