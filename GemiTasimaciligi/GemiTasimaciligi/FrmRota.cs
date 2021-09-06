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
    public partial class FrmRota : Form
    {
        Gemi[] gelenGemiler;
        public FrmRota(Gemi[] g)
        {
            InitializeComponent();
            gelenGemiler = g;
        }

        private void FrmRota_Load(object sender, EventArgs e)
        {
            cmbBaslangic.Items.Add("İstanbul");
            cmbBaslangic.Items.Add("İzmir");
            cmbUgrayacak.Items.Add("Yunanistan");
            cmbUgrayacak.Items.Add("Tunus");
            cmbVaris.Items.Add("İtalya");
            cmbVaris.Items.Add("Fransa");
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //string[] secilenRota = new string[3];
           
            if (cmbBaslangic.Text == string.Empty || cmbUgrayacak.Text == string.Empty || cmbVaris.Text == string.Empty)
            {
                MessageBox.Show("Lütfen rotayı tam olarak belirleyin..");
            }
            else
            {
                Rota rota = new Rota();
                rota.rotaBaslangıc = cmbBaslangic.SelectedItem.ToString();
                rota.rotaUgranacak = cmbUgrayacak.SelectedItem.ToString();
                rota.rotaVarıs = cmbVaris.SelectedItem.ToString();
                lstRota.Items.Add(rota);
                btnGec.Enabled = true;
                Temizle();
            }
        }
        private void Temizle()
        {
            cmbBaslangic.Text = null;
            cmbUgrayacak.Text = null;
            cmbVaris.Text = null;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstRota.SelectedItem == null) return;
            lstRota.Items.RemoveAt(lstRota.SelectedIndex);
            Temizle();
        }

        Rota guncellenenRota = new Rota();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstRota.SelectedItem == null) return;
            else
            { string[] guncelle = new string[3];
                guncellenenRota = (Rota)lstRota.SelectedItem;
                guncellenenRota.rotaBaslangıc = cmbBaslangic.SelectedItem.ToString();
                guncellenenRota.rotaUgranacak = cmbUgrayacak.SelectedItem.ToString();
                guncellenenRota.rotaVarıs = cmbVaris.SelectedItem.ToString();
                lstRota.Items.Add(guncellenenRota);
                lstRota.Items.RemoveAt(lstRota.SelectedIndex);
                Temizle();
            }

        }
        Rota secilmisRota = null;
        private void lstRota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRota.SelectedItem == null) return;
            else
            {
                secilmisRota = (Rota)lstRota.SelectedItem;
                cmbBaslangic.Text = secilmisRota.rotaBaslangıc;
                cmbUgrayacak.Text = secilmisRota.rotaUgranacak;
                cmbVaris.Text = secilmisRota.rotaVarıs;
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Rota[] rotalar = new Rota[0];
            foreach (Rota item in lstRota.Items)
            {
                Array.Resize(ref rotalar, rotalar.Length + 1);
                rotalar[rotalar.Length - 1] = item;
            }

            FrmGemiRotasi gr = new FrmGemiRotasi(rotalar,gelenGemiler);
            gr.Show();
        }
    }
}
