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
    public partial class FrmSiparis : Form
    {
        private Gemi[] gelenGemiler;
        private Rota[] gelenRotalar;
        private Musteri[] musteriler;
        private GemiRotasi[] gemirotalari;


        public FrmSiparis(Gemi[] gelenGemiler, Rota[] gelenRotalar, Musteri[] musteriler,GemiRotasi[] gemirotalari)
        {
            InitializeComponent();
            this.gelenGemiler = gelenGemiler;
            this.gelenRotalar = gelenRotalar;
            this.musteriler = musteriler;
            this.gemirotalari = gemirotalari;
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            foreach (Musteri item in musteriler)
            {
                cmbMusteri.Items.Add(item);
            }
            foreach (GemiRotasi item in gemirotalari)
            {
                lstSeferler.Items.Add(item);
            }

        }


        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (lstSeferler.SelectedItem == null) return;

            Siparis fsiparis = new Siparis();
            fsiparis.musteriAdi = (Musteri)cmbMusteri.SelectedItem;
            fsiparis.SiparisTonaj = numericUpDown1.Value;
            fsiparis.gemiRota = (GemiRotasi)lstSeferler.SelectedItem;


            if(numericUpDown1.Value<=fsiparis.gemiRota.gidecekGemi.gemiTonaj)
            {
                MessageBox.Show("Siparisiniz Alındı..");
            }
            else
            {
                MessageBox.Show("Ağırlık sınırını aştığı için işlem başarısız..");
            }

        }
    }
}
