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
    public partial class DepoBilgileri : Form
    {
        public DepoBilgileri()
        {
            InitializeComponent();
        }

        class Depo
        {
            public int depoID;
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
            depo.depoAdresi = txtAdres.Text;
            depo.depoSorumlusu = txtDepoSorumlusu.Text;
            depo.depoTelefonu = txtTelefon.Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            degerAtama();
            var sonuc = db.tbl_Depo.Where(x => x.depo_id == depo.depoID).FirstOrDefault();
            sonuc.depo_ad = depo.depoAdi;
            sonuc.depo_yer = depo.depoYeri;
            sonuc.depo_adres = depo.depoAdresi;
            sonuc.depo_sorumlusu = depo.depoSorumlusu;
            sonuc.depo_telefon = depo.depoTelefonu;
            db.SaveChanges();
            dgwDoldur();
        }

        STOK_TAKIPEntities db = new STOK_TAKIPEntities();

        private void txtDepoAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepoBilgileri_Load(object sender, EventArgs e)
        {
            string[] value2 = tema.Split(';');
            this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(value2[0]), Convert.ToInt32(value2[1]), Convert.ToInt32(value2[2]));
            dgwDoldur();
        }

        private void dgwDoldur()
        {
            dgwDepoBilgileri.DataSource = db.tbl_Depo.ToList();
            dgwDepoBilgileri.Columns["depo_id"].Visible = false;
        }

        private void dgwGuncelle()
        {
            depo.depoID = (int)dgwDepoBilgileri.CurrentRow.Cells["depo_id"].Value;
            txtDepoAdi.Text = dgwDepoBilgileri.CurrentRow.Cells["depo_ad"].Value.ToString();
            txtDepoYeri.Text = dgwDepoBilgileri.CurrentRow.Cells["depo_yer"].Value.ToString();
            txtAdres.Text = dgwDepoBilgileri.CurrentRow.Cells["depo_adres"].Value.ToString();
            txtDepoSorumlusu.Text = dgwDepoBilgileri.CurrentRow.Cells["depo_sorumlusu"].Value.ToString();
            txtTelefon.Text = dgwDepoBilgileri.CurrentRow.Cells["depo_telefon"].Value.ToString();
        }

        private void dgwDepoBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgwGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = db.tbl_Depo.Where(x => x.depo_id == depo.depoID).FirstOrDefault();
            db.tbl_Depo.Remove(sonuc);
            db.SaveChanges();
            dgwDoldur();
        }
    }
}
