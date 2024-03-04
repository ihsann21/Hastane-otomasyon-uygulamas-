using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_hastane
{
    public partial class frmGirisler : Form
    {
        public frmGirisler()
        {
            InitializeComponent();
        }

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            frmHastaGiris fr = new frmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            frmDoktorGiris fr=new frmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            frmSekreterGiris fr=new frmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void frmGirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
