namespace proje_hastane
{
    partial class frmBilgileriDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgileriDuzenle));
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyetKayıt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtSifreKayıt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTcKayıt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(203, 407);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(145, 35);
            this.btnBilgiGuncelle.TabIndex = 34;
            this.btnBilgiGuncelle.Text = "Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // cmbCinsiyetKayıt
            // 
            this.cmbCinsiyetKayıt.FormattingEnabled = true;
            this.cmbCinsiyetKayıt.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyetKayıt.Location = new System.Drawing.Point(179, 354);
            this.cmbCinsiyetKayıt.Name = "cmbCinsiyetKayıt";
            this.cmbCinsiyetKayıt.Size = new System.Drawing.Size(203, 36);
            this.cmbCinsiyetKayıt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "CİNSİYET:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(179, 242);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(203, 36);
            this.mskTel.TabIndex = 4;
            // 
            // txtSifreKayıt
            // 
            this.txtSifreKayıt.Location = new System.Drawing.Point(179, 299);
            this.txtSifreKayıt.Name = "txtSifreKayıt";
            this.txtSifreKayıt.Size = new System.Drawing.Size(203, 36);
            this.txtSifreKayıt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "TEL Numarası:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(179, 63);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(203, 36);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "SOYAD:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(179, 125);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(203, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTcKayıt
            // 
            this.mskTcKayıt.Location = new System.Drawing.Point(179, 181);
            this.mskTcKayıt.Mask = "00000000000";
            this.mskTcKayıt.Name = "mskTcKayıt";
            this.mskTcKayıt.Size = new System.Drawing.Size(203, 36);
            this.mskTcKayıt.TabIndex = 3;
            this.mskTcKayıt.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "TC Kimlik No:";
            // 
            // frmBilgileriDuzenle
            // 
            this.AcceptButton = this.btnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(457, 472);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.cmbCinsiyetKayıt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtSifreKayıt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.mskTcKayıt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmBilgileriDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frmBilgileriDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyetKayıt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtSifreKayıt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTcKayıt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}