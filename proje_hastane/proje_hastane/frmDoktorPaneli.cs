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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            // Branşları cmboxa aktarma
            SqlCommand komut = new SqlCommand("select bransad from tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1=new SqlCommand("insert into tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut1.Parameters.AddWithValue("@p4", mskDoktorTc.Text);
            komut1.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskDoktorTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil=new SqlCommand("delete from tbl_Doktorlar where doktorTc=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", mskDoktorTc.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update tbl_Doktorlar set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p5,doktorTc=@p4 where doktorTc=@p4", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", mskDoktorTc.Text);
            komutguncelle.Parameters.AddWithValue("@p5", txtSifre.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bigi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
