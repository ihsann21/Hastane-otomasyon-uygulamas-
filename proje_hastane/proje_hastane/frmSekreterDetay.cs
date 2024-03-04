using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje_hastane
{
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tcno;


            // Ad-soyad çekme
            SqlCommand komut = new SqlCommand("select sekreterAdSoyad from tbl_Sekreter where sekreterTc=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();


            //Branşları data gride aktarma

           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *  from tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            // Doktorları data gride aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktorAd+ ' ' +doktorSoyad) as 'Doktorlar', DoktorBrans from tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Branşları combo boxa aktarma

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti() .Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komutkaydet = new SqlCommand("insert into tbl_Randevular (randevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");


        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komutdoktor = new SqlCommand("select Doktorad,DoktorSoyad from tbl_Doktorlar where doktorBrans=@p1", bgl.baglanti());
            komutdoktor.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr3=komutdoktor.ExecuteReader();  
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli drp=new frmDoktorPaneli();
            drp.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            frmBransPaneli fr=new frmBransPaneli();
            fr.Show();

        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuListesi dyr=new frmRandevuListesi();
            dyr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frd =new frmDuyurular();
            frd.Show();
        }
    }
}
