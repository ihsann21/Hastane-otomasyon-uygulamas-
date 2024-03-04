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
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=  new sqlbaglantisi();
        public string TCNO;
        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTcKayıt.Text = TCNO;

            SqlCommand komut= new SqlCommand("select * from tbl_Doktorlar where doktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcKayıt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifreKayıt.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Doktorlar set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p4 where doktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtSifreKayıt.Text);
            komut.Parameters.AddWithValue("@p5", mskTcKayıt.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi");

        }
    }
}
