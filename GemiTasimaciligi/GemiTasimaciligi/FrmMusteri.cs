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
    public partial class FrmMusteri : Form
    {
        private Gemi[] gelenGemiler;
        private Rota[] gelenRotalar;
        private GemiRotasi[] gemirotalari;


        public FrmMusteri(Gemi[] gelenGemiler, Rota[] gelenRotalar, GemiRotasi[] gemirotalari)
        {
            InitializeComponent();
            this.gelenGemiler = gelenGemiler;
            this.gelenRotalar = gelenRotalar;
            this.gemirotalari = gemirotalari;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (txtMusteriAdi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Adınızı girin..");
            }
            else if (mskdTc.MaskFull==false) 
            {
                MessageBox.Show("Lütfen tc bilginizi eksiksiz girin..");
            }

            else
            {
                Musteri musteri = new Musteri();
                musteri.MusteriAdi = txtMusteriAdi.Text;
                musteri.Tc = mskdTc.Text;
                MessageBox.Show(mskdTc.Text);
                lstMusteri.Items.Add(musteri);
                btnGec.Enabled = true;
                Temizle();
            }


        }
        private void Temizle()
        {
            txtMusteriAdi.Text = null;
            mskdTc.Text = null;
        }
       

        private void lstMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMusteri.SelectedItem == null) return;
            Musteri fMusteri = new Musteri();
            fMusteri = (Musteri)lstMusteri.SelectedItem;
            txtMusteriAdi.Text=fMusteri.MusteriAdi;
            mskdTc.Text=fMusteri.Tc;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMusteri.SelectedItem == null) return;
            lstMusteri.Items.RemoveAt(lstMusteri.SelectedIndex);
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMusteri.SelectedItem == null) return;
            Musteri guncellenenMusteri = new Musteri();
            guncellenenMusteri.MusteriAdi = txtMusteriAdi.Text;
            guncellenenMusteri.Tc = mskdTc.Text;
            lstMusteri.Items.Add(guncellenenMusteri);
            lstMusteri.Items.RemoveAt(lstMusteri.SelectedIndex);
            Temizle();

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Musteri[] musteriler = new Musteri[0];
            foreach (Musteri item in lstMusteri.Items)
            {
                Array.Resize(ref musteriler, musteriler.Length + 1);
                musteriler[musteriler.Length - 1] = item;
            }
            FrmSiparis fSiparis = new FrmSiparis(gelenGemiler,gelenRotalar,musteriler, gemirotalari);
            fSiparis.Show();
        }
    }
}
