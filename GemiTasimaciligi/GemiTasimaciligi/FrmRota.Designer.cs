
namespace GemiTasimaciligi
{
    partial class FrmRota
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
            this.cmbBaslangic = new System.Windows.Forms.ComboBox();
            this.lstRota = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUgrayacak = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBaslangic
            // 
            this.cmbBaslangic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaslangic.FormattingEnabled = true;
            this.cmbBaslangic.Location = new System.Drawing.Point(18, 40);
            this.cmbBaslangic.Name = "cmbBaslangic";
            this.cmbBaslangic.Size = new System.Drawing.Size(169, 28);
            this.cmbBaslangic.TabIndex = 0;
            // 
            // lstRota
            // 
            this.lstRota.FormattingEnabled = true;
            this.lstRota.ItemHeight = 20;
            this.lstRota.Location = new System.Drawing.Point(78, 287);
            this.lstRota.Name = "lstRota";
            this.lstRota.Size = new System.Drawing.Size(447, 164);
            this.lstRota.TabIndex = 1;
            this.lstRota.SelectedIndexChanged += new System.EventHandler(this.lstRota_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(286, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "ROTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uğrayacak:";
            // 
            // cmbUgrayacak
            // 
            this.cmbUgrayacak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUgrayacak.FormattingEnabled = true;
            this.cmbUgrayacak.Location = new System.Drawing.Point(18, 94);
            this.cmbUgrayacak.Name = "cmbUgrayacak";
            this.cmbUgrayacak.Size = new System.Drawing.Size(169, 28);
            this.cmbUgrayacak.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Varış:";
            // 
            // cmbVaris
            // 
            this.cmbVaris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Location = new System.Drawing.Point(18, 144);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(169, 28);
            this.cmbVaris.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(417, 204);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 43);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGec
            // 
            this.btnGec.Enabled = false;
            this.btnGec.Location = new System.Drawing.Point(546, 477);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(108, 43);
            this.btnGec.TabIndex = 9;
            this.btnGec.Text = ">>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(181, 457);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 43);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(349, 457);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 43);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVaris);
            this.groupBox1.Controls.Add(this.cmbBaslangic);
            this.groupBox1.Controls.Add(this.cmbUgrayacak);
            this.groupBox1.Location = new System.Drawing.Point(139, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rota Oluştur";
            // 
            // FrmRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(666, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstRota);
            this.Name = "FrmRota";
            this.Text = "FrmRota";
            this.Load += new System.EventHandler(this.FrmRota_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBaslangic;
        private System.Windows.Forms.ListBox lstRota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUgrayacak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVaris;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}