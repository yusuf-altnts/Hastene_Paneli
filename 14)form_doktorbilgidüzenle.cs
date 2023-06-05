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
    public partial class form_doktorbilgidüzenle : Form
    {
        public form_doktorbilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        public string tcno;
        private void form_doktorbilgidüzenle_Load(object sender, EventArgs e)
        {
            masktc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktortc = @p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader de = komut.ExecuteReader();

            while (de.Read())
            {
                textad.Text = de[1].ToString();
                textsoyad.Text= de[2].ToString();
                combobranş.Text= de[3].ToString();  
                textsifre.Text= de[5].ToString();
            }
            bgl.bağlantı().Close();

        }
        public int sayac =0;
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktor set doktorad=@p1, doktorsoyad=@p2, doktorbrans=@p3, doktorsifre=@p4 where doktortc=@p5",bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", textad.Text) ;
            komut.Parameters.AddWithValue("@p2",textsoyad.Text);
            komut.Parameters.AddWithValue("@p3",combobranş.Text);
            komut.Parameters.AddWithValue("@p4" ,textsifre.Text);
            komut.Parameters.AddWithValue("@p5", tcno);
            komut.ExecuteNonQuery();
            MessageBox.Show("Doktor Güncelleme İşlemi Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==30)
            {
                timer1.Stop();
                sayac= 0;
                form_Girişler k = new form_Girişler();
                k.Show();   
                this.Hide();
            }
        }
    }
}
