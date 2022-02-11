using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace StokTakipProgramiFinal
{
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }

        public int kullaniciID;

        public string tema;

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            KullaniciEkle frmKullaniciEkle = new KullaniciEkle();
            frmKullaniciEkle.Dock = DockStyle.Fill;
            frmKullaniciEkle.TopLevel = false;
            frmKullaniciEkle.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmKullaniciEkle);
            frmKullaniciEkle.tema = tema;
            frmKullaniciEkle.kullaniciID = kullaniciID;
            frmKullaniciEkle.Show();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            KullaniciIslemleri frmKullaniciIslemleri = new KullaniciIslemleri();
            frmKullaniciIslemleri.Dock = DockStyle.Fill;
            frmKullaniciIslemleri.TopLevel = false;
            frmKullaniciIslemleri.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmKullaniciIslemleri);
            frmKullaniciIslemleri.tema = tema;
            frmKullaniciIslemleri.kullaniciID = kullaniciID;
            frmKullaniciIslemleri.Show();
        }
        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            FirmaBilgileri frmFirmaBilgileri = new FirmaBilgileri();
            frmFirmaBilgileri.Dock = DockStyle.Fill;
            frmFirmaBilgileri.TopLevel = false;
            frmFirmaBilgileri.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmFirmaBilgileri);
            frmFirmaBilgileri.tema = tema;
            frmFirmaBilgileri.kullaniciID = kullaniciID;
            frmFirmaBilgileri.Show();
        }

        private void btnFirmaBilgileri_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            FirmaEkle frmFirmaEkle = new FirmaEkle();
            frmFirmaEkle.Dock = DockStyle.Fill;
            frmFirmaEkle.TopLevel = false;
            frmFirmaEkle.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmFirmaEkle);
            frmFirmaEkle.tema = tema;
            frmFirmaEkle.kullaniciID = kullaniciID;
            frmFirmaEkle.Show();
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            DepoEkle frmDepoEkle = new DepoEkle();
            frmDepoEkle.Dock = DockStyle.Fill;
            frmDepoEkle.TopLevel = false;
            frmDepoEkle.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmDepoEkle);
            frmDepoEkle.tema = tema;
            frmDepoEkle.kullaniciID = kullaniciID;
            frmDepoEkle.Show();
        }

        private void btnDepoBilgileri_Click(object sender, EventArgs e)
        {
            pnlAna.Controls.Clear();
            DepoBilgileri frmDepoBilgileri = new DepoBilgileri();
            frmDepoBilgileri.Dock = DockStyle.Fill;
            frmDepoBilgileri.TopLevel = false;
            frmDepoBilgileri.FormBorderStyle = FormBorderStyle.None;
            pnlAna.Controls.Add(frmDepoBilgileri);
            frmDepoBilgileri.tema = tema;
            frmDepoBilgileri.kullaniciID = kullaniciID;
            frmDepoBilgileri.Show();
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

        private void kullanıcıEkleYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciEkle frmKullaniciEkle = new KullaniciEkle();
            frmKullaniciEkle.tema = tema;
            frmKullaniciEkle.kullaniciID = kullaniciID;
            frmKullaniciEkle.Show();
        }

        private void kullanıcıİşlemleriYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri frmKullaniciIslemleri = new KullaniciIslemleri();
            frmKullaniciIslemleri.tema = tema;
            frmKullaniciIslemleri.kullaniciID = kullaniciID;
            frmKullaniciIslemleri.Show();
        }

        private void firmaEkleYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaEkle frmFirmaEkle = new FirmaEkle();
            frmFirmaEkle.tema = tema;
            frmFirmaEkle.kullaniciID = kullaniciID;
            frmFirmaEkle.Show();
        }

        private void firmaİşlemleriYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaBilgileri frmFirmaBilgileri = new FirmaBilgileri();
            frmFirmaBilgileri.tema = tema;
            frmFirmaBilgileri.kullaniciID = kullaniciID;
            frmFirmaBilgileri.Show();
        }

        private void depoEkleYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepoEkle frmDepoEkle = new DepoEkle();
            frmDepoEkle.tema = tema;
            frmDepoEkle.kullaniciID = kullaniciID;
            frmDepoEkle.Show();
        }

        private void depoİşlemleriYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepoBilgileri frmDepoBilgileri = new DepoBilgileri();
            frmDepoBilgileri.tema = tema;
            frmDepoBilgileri.kullaniciID = kullaniciID;
            frmDepoBilgileri.Show();
        }

        private void ayarlarYeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayarlar frmAyarlar = new Ayarlar();
            frmAyarlar.tema = tema;
            frmAyarlar.kullaniciID = kullaniciID;
            frmAyarlar.Show();
        }

        private void AdminEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {
            temaIslemi();
            DovizGoster();
            tmrZaman.Start();
            tmrPara.Start();
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
        private void temaIslemi()
        {
            try
            {
                string[] value2 = tema.Split(';');
                pnlAna.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
            }
            catch
            {

            }
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            try
            {
                lblZaman.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
            }
            catch
            {

            }
        }

        private void tmrPara_Tick(object sender, EventArgs e)
        {
            DovizGoster();
        }
    }
}
