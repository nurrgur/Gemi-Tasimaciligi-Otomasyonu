using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemiTasimaciligi
{
    public partial class FrmGemiRotasi : Form
    {
        Rota[] gelenRotalar;
        Gemi[] gelenGemiler;
        public FrmGemiRotasi(Rota[] r,Gemi[] g)
        {
            InitializeComponent();
            gelenGemiler = g;
            gelenRotalar = r;
        }

        private void FrmGemiRotasi_Load(object sender, EventArgs e)
        {
            foreach (Gemi item in gelenGemiler)
            {
                cmbGemiAdi.Items.Add(item);
            }
            foreach (Rota item in gelenRotalar)
            {
                cmbRota.Items.Add(item);
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbRota.SelectedItem == null || cmbGemiAdi.SelectedItem == null || dtpGitmeTarihi.Value == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun...");
            }
            else
            {
                GemiRotasi gr = new GemiRotasi();
                gr.gidecekGemi = (Gemi)cmbGemiAdi.SelectedItem;
                gr.gidilecekRota = (Rota)cmbRota.SelectedItem;
                gr.GidisTarihi = dtpGitmeTarihi.Value;
                gr.DonusTarihi = dtpDonusTarihi.Value;
                lstGemiRotasi.Items.Add(gr);
                btnGec.Enabled = true;
                Temizle();
            }
        }
        private void Temizle()
        {
            cmbGemiAdi.SelectedItem = null;
            cmbRota.SelectedItem = null;
            dtpGitmeTarihi.Value = DateTime.Now;
            dtpDonusTarihi.Value = DateTime.Today;
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            GemiRotasi[] gemirotalari = new GemiRotasi[0];
            foreach (GemiRotasi item in lstGemiRotasi.Items)
            {
                Array.Resize(ref gemirotalari ,gemirotalari.Length + 1);
                gemirotalari[gemirotalari.Length - 1] = item;
            }

            FrmMusteri fmusteri = new FrmMusteri(gelenGemiler,gelenRotalar,gemirotalari);
            fmusteri.Show();

        }


        private void lstGemiRotasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGemiRotasi.SelectedItem == null) return;
            GemiRotasi secilenSatir = (GemiRotasi)lstGemiRotasi.SelectedItem;
            cmbGemiAdi.SelectedItem = secilenSatir.gidecekGemi;
            cmbRota.SelectedItem = secilenSatir.gidilecekRota;
            dtpGitmeTarihi.Value = secilenSatir.GidisTarihi;
            dtpDonusTarihi.Value = secilenSatir.DonusTarihi;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstGemiRotasi.SelectedItem == null) return;

            GemiRotasi grotası = new GemiRotasi();
            grotası =(GemiRotasi) lstGemiRotasi.SelectedItem;
            grotası.gidecekGemi= (Gemi)cmbGemiAdi.SelectedItem;
            grotası.gidilecekRota = (Rota)cmbRota.SelectedItem;
            grotası.GidisTarihi = dtpGitmeTarihi.Value;
            grotası.DonusTarihi = dtpDonusTarihi.Value;
            lstGemiRotasi.Items.Add(grotası);
            lstGemiRotasi.Items.RemoveAt(lstGemiRotasi.SelectedIndex);
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGemiRotasi.SelectedItem == null) return;
            lstGemiRotasi.Items.RemoveAt(lstGemiRotasi.SelectedIndex);
            Temizle();
        }
    }
}
