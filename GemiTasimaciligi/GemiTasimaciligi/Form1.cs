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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGemiAdi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Bilgilerinizi eksiksiz girin..");
            }
            else if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Tomaj değeri 0 dan büyük olmalı..");
            }
            else
            {
                Gemi g = new Gemi();
                g.gemiAdi = txtGemiAdi.Text;
                g.gemiTonaj = numericUpDown1.Value;
                lstGemi.Items.Add(g);
                btnGec.Enabled =true;
                Temizle();
            }

        }

        private void Temizle()
        {
            txtGemiAdi.Text = null;
            numericUpDown1.Value = 1;
        }
        Gemi secilmisGemi = null;
        private void lstGemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGemi.SelectedItem == null) return; //Boş satıra tıkladığında hata vermicek
            secilmisGemi = (Gemi)lstGemi.SelectedItem;
            txtGemiAdi.Text = secilmisGemi.gemiAdi;
            numericUpDown1.Value = secilmisGemi.gemiTonaj;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGemi.SelectedItem == null) return;
            lstGemi.Items.RemoveAt(lstGemi.SelectedIndex);
            Temizle();
        }
        Gemi guncellenenGemi = null;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstGemi.SelectedItem == null) return;
            guncellenenGemi = (Gemi)lstGemi.SelectedItem;
            if (txtGemiAdi.Text == string.Empty) 
            {
                MessageBox.Show("Lütfen bir gemi adı giriniz..");
            }
            else if(numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Lütfen Tonaj değerini giriniz..");
            }
            else
            {
                guncellenenGemi.gemiAdi = txtGemiAdi.Text;
                guncellenenGemi.gemiTonaj = numericUpDown1.Value;
                lstGemi.Items.Add(guncellenenGemi).ToString();
                lstGemi.Items.RemoveAt(lstGemi.SelectedIndex);
                Temizle();
            }

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Gemi[] gemi = new Gemi[0];
            foreach (Gemi item in lstGemi.Items)
            {
                Array.Resize(ref gemi, gemi.Length + 1);
                gemi[gemi.Length - 1] = item;
            }

            FrmRota fr = new FrmRota(gemi);
            fr.Show();
        }

    }
}
