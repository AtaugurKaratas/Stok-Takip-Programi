using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgramiFinal
{
    public partial class DepoEkle : Form
    {
        public DepoEkle()
        {
            InitializeComponent();
        }
        class Depo
        {
            public string depoAdi;
            public string depoYeri;
            public string depoAdresi;
            public string depoSorumlusu;
            public string depoTelefonu;
        }

        public int kullaniciID;

        public string tema;

        Depo depo = new Depo();

        private void degerAtama()
        {
            depo.depoAdi = txtDepoAdi.Text;
            depo.depoYeri = txtDepoYeri.Text;
            depo.depoAdresi = txtDepoAdresi.Text;
            depo.depoSorumlusu = txtDepoSorumlusu.Text;
            depo.depoTelefonu = txtTelefon.Text;
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            degerAtama();
            tbl_Depo tbl_Depo = new tbl_Depo();
            tbl_Depo.depo_ad = depo.depoAdi;
            tbl_Depo.depo_yer = depo.depoYeri;
            tbl_Depo.depo_adres = depo.depoAdresi;
            tbl_Depo.depo_sorumlusu = depo.depoSorumlusu;
            tbl_Depo.depo_telefon = depo.depoTelefonu;
            db.tbl_Depo.Add(tbl_Depo);
            db.SaveChanges();
        }

        private void DepoEkle_Load(object sender, EventArgs e)
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
        }
    }
}
