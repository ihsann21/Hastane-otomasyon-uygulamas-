namespace proje_hastane
{
    partial class frmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaKayıt));
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTcKayıt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifreKayıt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCinsiyetKayıt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(250, 149);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(203, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTcKayıt
            // 
            this.mskTcKayıt.Location = new System.Drawing.Point(250, 205);
            this.mskTcKayıt.Mask = "00000000000";
            this.mskTcKayıt.Name = "mskTcKayıt";
            this.mskTcKayıt.Size = new System.Drawing.Size(203, 36);
            this.mskTcKayıt.TabIndex = 3;
            this.mskTcKayıt.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(250, 87);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(203, 36);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "TEL Numarası:";
            // 
            // txtSifreKayıt
            // 
            this.txtSifreKayıt.Location = new System.Drawing.Point(250, 323);
            this.txtSifreKayıt.Name = "txtSifreKayıt";
            this.txtSifreKayıt.Size = new System.Drawing.Size(203, 36);
            this.txtSifreKayıt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "ŞİFRE:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(250, 266);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(203, 36);
            this.mskTel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "CİNSİYET:";
            // 
            // cmbCinsiyetKayıt
            // 
            this.cmbCinsiyetKayıt.FormattingEnabled = true;
            this.cmbCinsiyetKayıt.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyetKayıt.Location = new System.Drawing.Point(250, 378);
            this.cmbCinsiyetKayıt.Name = "cmbCinsiyetKayıt";
            this.cmbCinsiyetKayıt.Size = new System.Drawing.Size(203, 36);
            this.cmbCinsiyetKayıt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(138, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 61);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hasta Kayıt Paneli";
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.Cyan;
            this.btnKayıt.Location = new System.Drawing.Point(274, 431);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(145, 35);
            this.btnKayıt.TabIndex = 21;
            this.btnKayıt.Text = "Kayıt Yap";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // frmHastaKayıt
            // 
            this.AcceptButton = this.btnKayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(648, 500);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.label7);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmHastaKayıt";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTcKayıt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifreKayıt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCinsiyetKayıt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKayıt;
    }
}