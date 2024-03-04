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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TC;
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TC;


            // DOKTOR AD SOYAD ÇEKME 


            SqlCommand komut= new SqlCommand("select DoktorAd,DoktorSoyad from tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text= dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            // Randevuları data gride aktarma


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDuzenle fr=new frmDoktorBilgiDuzenle();
            fr.TCNO = lblTc.Text;
            fr.Show();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            frmDuyurular fr=new frmDuyurular();
            fr.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
