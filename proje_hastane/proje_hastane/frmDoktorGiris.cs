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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from tbl_Doktorlar where DoktorTc=@p1 and doktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                frmDoktorDetay drdt = new frmDoktorDetay();
                drdt.TC = mskTc.Text;
                drdt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya şifre girdiniz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
