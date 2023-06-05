using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_hastane
{
    public partial class formduyurular : Form
    {
        public formduyurular()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void formduyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select duyuru  as Duyurular from tbl_duyuru  ", bgl.bağlantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.bağlantı().Close();

        }
    }
}
