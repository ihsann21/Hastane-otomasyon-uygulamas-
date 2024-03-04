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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        public string sikayet;
        sqlbaglantisi bgl=  new sqlbaglantisi();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            //AD SOYAD ÇEKME
            SqlCommand komut2 = new SqlCommand("select HastaAd,HastaSoyad from tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // RANDEVU GEÇMİŞİ
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from tbl_Randevular where HastaTc="+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // BRANŞLARI ÇEKME
            SqlCommand komut3 = new SqlCommand("select bransAd from tbl_branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBrans.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select doktorAd,doktorSoyad from tbl_Doktorlar where doktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr4 = komut.ExecuteReader();
            while (dr4.Read())
            {
                cmbDoktor.Items.Add(dr4[0] + " " + dr4[1]);
            }
            bgl.baglanti() .Close();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Randevular set randevuDurum=1,HastaTc=@p1,hastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            komut.Parameters.AddWithValue("@p2", rchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtİd.Text);
            komut .ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Randevular where RandevuBrans='" + cmbBrans.Text+"'" + " and RandevuDoktor='" + cmbDoktor.Text + "' and randevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgileriDuzenle fr=new frmBilgileriDuzenle();
            fr.tcno = lblTc.Text;
            fr.Show();
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
