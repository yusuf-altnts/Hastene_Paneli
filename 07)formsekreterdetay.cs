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
    public partial class formsekreterdetay : Form
    {
        public formsekreterdetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantı bgl = new sqlbaglantı();
        private void formsekreterdetay_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#4F4557");
            lbltc.Text = tc;

            //ad soyad

            SqlCommand komut = new SqlCommand("Select sekreteradsoyad from tbl_sekreter where sekretertc=" + tc, bgl.bağlantı());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.bağlantı().Close();

            //branşları datagride aktardma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select bransid as 'Branş İD', bransad as 'Branş' from tbl_brans" ,bgl.bağlantı());
            da.Fill(dt1);
            dataGridView1.DataSource= dt1;
            bgl.bağlantı().Close();


            //Doktorları listeye aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter dr2 = new SqlDataAdapter("select doktortc as 'Doktor Tc',(doktorad + ' ' + doktorsoyad) as 'Doktorlar',doktorbrans as 'Doktor Branş' from tbl_doktor", bgl.bağlantı());
            dr2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            bgl.bağlantı().Close();

            //branşları comboboxsa atama
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_brans" , bgl.bağlantı());
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                combobrans.Items.Add(dr3[0].ToString());
            }
            bgl.bağlantı().Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_randevular (randevutarih, randevusaat,randevubrans,randevudoktor) values (@r1, @r2, @r3,@r4)" , bgl.bağlantı());
            komut.Parameters.AddWithValue("@r1", masktarih.Text);
            komut.Parameters.AddWithValue("@r2", masksaat.Text);
            komut.Parameters.AddWithValue("@r3", combobrans.Text);
            komut.Parameters.AddWithValue("@r4", combodoktor.Text);
            komut.ExecuteNonQuery();

            bgl.bağlantı().Close() ;
            MessageBox.Show("Randevu Tarihiniz " + masktarih.Text + " Olarak Oluşturulmuştur.", "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combodoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select doktorad, doktorsoyad from tbl_doktor where doktorbrans= @p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", combobrans.Text);
            SqlDataReader dr4 = komut.ExecuteReader();
            while (dr4.Read())
            {
                combodoktor.Items.Add((dr4[0] +" "+ dr4[1] ).ToString());
            }
            bgl.bağlantı().Close();
        }

        private void btnoluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyuru (duyuru) values (@p1) " , bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1",richduyuru.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturuldu" , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.bağlantı().Close() ;
            

        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            formdoktorpaneli k = new formdoktorpaneli();
            k.Show();
            
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            formbrans k = new formbrans();
            k.Show();
            

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            formrandevulistesi k = new formrandevulistesi();
            k.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formduyurular k = new formduyurular();
            k.Show();
        }
    }
}
