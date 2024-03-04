using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace proje_hastane
{
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayıt fr=new frmHastaKayıt();
            fr.Show();
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komu1 = new SqlCommand("select * from tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komu1.Parameters.AddWithValue("@p1", mskTc.Text);
            komu1.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komu1.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr=new frmHastaDetay();
                fr.tc = mskTc.Text;
                
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı tc veya şifre ");
            }
            bgl.baglanti().Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGirisler frm=new frmGirisler();
            frm.Show();
            this.Close();
        }
    }
}
