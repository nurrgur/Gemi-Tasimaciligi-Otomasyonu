
namespace GemiTasimaciligi
{
    partial class FrmGemiRotasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstGemiRotasi = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbRota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGemiAdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpGitmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstGemiRotasi
            // 
            this.lstGemiRotasi.FormattingEnabled = true;
            this.lstGemiRotasi.ItemHeight = 20;
            this.lstGemiRotasi.Location = new System.Drawing.Point(190, 255);
            this.lstGemiRotasi.Name = "lstGemiRotasi";
            this.lstGemiRotasi.Size = new System.Drawing.Size(677, 184);
            this.lstGemiRotasi.TabIndex = 0;
            this.lstGemiRotasi.SelectedIndexChanged += new System.EventHandler(this.lstGemiRotasi_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(384, 445);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 43);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGec
            // 
            this.btnGec.Enabled = false;
            this.btnGec.Location = new System.Drawing.Point(933, 451);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(75, 44);
            this.btnGec.TabIndex = 2;
            this.btnGec.Text = ">>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(550, 445);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 43);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbRota
            // 
            this.cmbRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRota.FormattingEnabled = true;
            this.cmbRota.Location = new System.Drawing.Point(190, 81);
            this.cmbRota.Name = "cmbRota";
            this.cmbRota.Size = new System.Drawing.Size(266, 28);
            this.cmbRota.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(513, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gemi Adi:";
            // 
            // cmbGemiAdi
            // 
            this.cmbGemiAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGemiAdi.FormattingEnabled = true;
            this.cmbGemiAdi.Location = new System.Drawing.Point(607, 75);
            this.cmbGemiAdi.Name = "cmbGemiAdi";
            this.cmbGemiAdi.Size = new System.Drawing.Size(258, 28);
            this.cmbGemiAdi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gidilecek Tarih:";
            // 
            // dtpGitmeTarihi
            // 
            this.dtpGitmeTarihi.Location = new System.Drawing.Point(190, 134);
            this.dtpGitmeTarihi.Name = "dtpGitmeTarihi";
            this.dtpGitmeTarihi.Size = new System.Drawing.Size(266, 26);
            this.dtpGitmeTarihi.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(753, 186);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 43);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(300, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "GEMİNİN ROTASI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(492, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dönüş Tarih:";
            // 
            // dtpDonusTarihi
            // 
            this.dtpDonusTarihi.Location = new System.Drawing.Point(609, 131);
            this.dtpDonusTarihi.Name = "dtpDonusTarihi";
            this.dtpDonusTarihi.Size = new System.Drawing.Size(258, 26);
            this.dtpDonusTarihi.TabIndex = 17;
            // 
            // FrmGemiRotasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1030, 507);
            this.Controls.Add(this.dtpDonusTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpGitmeTarihi);
            this.Controls.Add(this.cmbGemiAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRota);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lstGemiRotasi);
            this.Name = "FrmGemiRotasi";
            this.Text = "FrmGemiRotasi";
            this.Load += new System.EventHandler(this.FrmGemiRotasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGemiRotasi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbRota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGemiAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpGitmeTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDonusTarihi;
    }
}