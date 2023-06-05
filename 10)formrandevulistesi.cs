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

namespace Proje_hastane
{
    public partial class formrandevulistesi : Form
    {
        public formrandevulistesi()
        {
            InitializeComponent();
        }

        sqlbaglantı bgl = new sqlbaglantı();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formrandevulistesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select randevuid as 'Randevu İD' , randevutarih as 'Randevu Tarih', randevusaat as 'Randevu Saat' , randevubrans as 'Randevu Branş' , randevudoktor as 'Randevu Doktor', randevudurum as 'Randevu Durum' , hastatc as 'Hasta TC', hastaşikayet as 'Hasta Şikayet'  from  tbl_randevular ", bgl.bağlantı());
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
