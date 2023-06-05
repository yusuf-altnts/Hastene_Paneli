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
    public partial class form_hastadetay : Form
    {
        public form_hastadetay()
        {
            InitializeComponent();
        }
        public string Tc;
        
        sqlbaglantı bgl = new sqlbaglantı();

        private void form_hastadetay_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#4F4557");
            dataGridView1.ForeColor = Color.Black;
            dataGridView2.ForeColor = Color.Black;

            //hasta ad soyad çekme 
            lbltc.Text = Tc;
            SqlCommand komut = new SqlCommand("Select hastaad, hastasoyad from tbl_hasta where hastatc= @p1" , bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.bağlantı().Close();


            //hasta randevu geçmişi

            DataTable dt = new DataTable(); // datatable oluşturduk " veri tablosu" sanal bir tablo oluşturuyoruz 
            SqlDataAdapter da = new SqlDataAdapter("select randevuid as 'Randevu İD' , randevutarih as 'Randevu Tarih' , randevusaat as 'Randevu Saat', randevubrans as 'Randevu Branş' , randevudoktor as 'Randevu Doktor' from tbl_randevular where hastatc=" + Tc, bgl.bağlantı());
            // sql adapter bizim data gride verileri aktarmamıza yaarayan command dır.
            da.Fill(dt); // burada tablomuzdan gelecek olan verileri sanal tablomuza attık
            dataGridView1.DataSource = dt;
            //burada da data giridn veri kaynağı dt oldugudur.
            bgl.bağlantı().Close() ;


            //branşları çekme

            SqlCommand komut2 = new SqlCommand("Select bransad from tbl_brans" , bgl.bağlantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                combobrans.Items.Add(dr2[0]);
            }
            bgl.bağlantı().Close();


        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4F4557");
            
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1, hastatc =@p1, hastaşikayet=@p2 where randevuid=@p3 ", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2",richsikayet.Text);
            komut.Parameters.AddWithValue("@p3" , textid.Text);
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevunuz Oluşturulmuştur" , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            bgl.bağlantı().Close();



            


        }

        private void combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {
              //doktor seçme branşa göre
            combodoktor.Items.Clear();  
            SqlCommand komut = new SqlCommand("Select doktorad, doktorsoyad from tbl_doktor where doktorbrans= @p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", combobrans.Text);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                combodoktor.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.bağlantı().Close();
        }

        private void combodoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select randevuid as 'Randevu İD' , randevutarih as 'Randevu Tarih' , randevusaat as 'Randevu Saat', randevubrans as 'Randevu Branş' , randevudoktor as 'Randevu Doktor' from tbl_randevular where randevubrans = '" + combobrans.Text+"'" +"and randevudoktor='" +combodoktor.Text+ "'" + "and randevudurum=0", bgl.bağlantı());
            adapter.Fill(dt);
            dataGridView2.DataSource= dt;       
            bgl.bağlantı().Close() ;    



            
        }

        private void linkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_hastabilgidüzenle k = new form_hastabilgidüzenle();
            k.tc =lbltc.Text;
            k.Show();
            this.Hide();    
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            textid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
