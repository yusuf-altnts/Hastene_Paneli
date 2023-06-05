using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_hastane
{
    internal class sqlbaglantı
    {
        public SqlConnection bağlantı()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MONSTER\\YUSUF;Initial Catalog=hastane_proje;Integrated Security=True");
            baglan.Open();


            return baglan;
        }
    }
}
