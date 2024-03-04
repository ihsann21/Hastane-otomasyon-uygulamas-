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
    public partial class frmDuyurular : Form
    {
        public frmDuyurular()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("select * from tbl_Duyurular",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

          
        }
    }
}
