using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proje_hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan =new SqlConnection("Data Source=DESKTOP-APC8S4A;Initial Catalog=HastaneProje;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
