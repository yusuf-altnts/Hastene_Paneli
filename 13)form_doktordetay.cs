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
    public partial class form_doktordetay : Form
    {
        public form_doktordetay()
        {
            InitializeComponent();
        }
        public string tc;
        public string adsoyad;
        sqlbaglantı bgl = new sqlbaglantı();
        
        private void form_doktordetay_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Black;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#4F4557");

            
            lbltc.Text = tc;
            lbladsoyad.Text = adsoyad;

            //Doktor alınmış Randevu Listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select randevuid,hastatc,randevutarih , randevusaat  from tbl_randevular where randevudoktor='"+ adsoyad + "'" + "and randevudurum=1", bgl.bağlantı());   
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            bgl.bağlantı().Close();


           

        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            formduyurular k = new formduyurular();
            k.Show();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            form_doktorbilgidüzenle k = new form_doktorbilgidüzenle();
            k.tcno = lbltc.Text;
            k.Show();
            this.Hide();

        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //randevu Detay
            //ad soyad çekme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand komut = new SqlCommand("select hastaad, hastasoyad from tbl_hasta where hastatc= @p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[1].Value.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblhastaadsoyad.Text = dr[0].ToString() + " " + dr[1];

            }
            bgl.bağlantı().Close();
            // şikayet çekme

            SqlCommand komut2 = new SqlCommand("select hastaşikayet from tbl_randevular where hastatc=@p1 and randevuid=@p2", bgl.bağlantı());
            komut2.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[1].Value.ToString());
            komut2.Parameters.AddWithValue("@p2", dataGridView1.Rows[secilen].Cells[0].Value.ToString());

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                richsikayet.Text = dr2[0].ToString();

            }
            bgl.bağlantı().Close();
        }
    }
}
