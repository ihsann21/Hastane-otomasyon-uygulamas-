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
    public partial class frmBilgileriDuzenle : Form
    {
        public frmBilgileriDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frmBilgileriDuzenle_Load(object sender, EventArgs e)
        {
            mskTcKayıt.Text = tcno;
            
           SqlCommand komut=new SqlCommand("select * from tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcKayıt.Text);
           SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTel.Text = dr[4].ToString();
                txtSifreKayıt.Text = dr[5].ToString();
                cmbCinsiyetKayıt.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Hastalar set HastaAd=@p1,hastaSoyad=@p2,hastaTelefon=@p3,hastaSifre=@p4,hastaCinsiyet=@p5 where hastaTc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTel.Text);
            komut.Parameters.AddWithValue("@p4", txtSifreKayıt.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyetKayıt.Text);
            komut.Parameters.AddWithValue("@p6", mskTcKayıt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close() ;
            MessageBox.Show("Bilgileriniz güncellenmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Question);


        }
    }
}
