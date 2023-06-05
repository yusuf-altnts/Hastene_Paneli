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
    public partial class form_hastabilgidüzenle : Form
    {
        public form_hastabilgidüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        public string tc;
        int sayac = 0;
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if (tc == masktc.Text)
            {
                SqlCommand komut = new SqlCommand("update tbl_hasta set hastaad= @p1 , hastasoyad=@p2 ,  hastatel = @p4 , hastasifre=@p5, hastacinsiyet=@p6  where hastatc=@p3  " , bgl.bağlantı());

                komut.Parameters.AddWithValue("@p1", textad.Text);
                komut.Parameters.AddWithValue("@p2", textsoyad.Text);
                komut.Parameters.AddWithValue("@p4", masktel.Text);
                komut.Parameters.AddWithValue("@p5", textsifre.Text);
                komut.Parameters.AddWithValue("@p6",combocinsiyet.Text);
                komut.Parameters.AddWithValue("@p3",masktc.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Güncellenmiştir ", "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer1.Start();
                
                
            }
            else
            {
                MessageBox.Show("Lütfen Kendi Tc niz İle giriş yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
                form_hastagiriş k = new form_hastagiriş();
                k.Show();
                this.Hide();
            
        }

        private void form_hastabilgidüzenle_Load(object sender, EventArgs e)
        {
            masktc.Text = tc;
            

            SqlCommand komut = new SqlCommand("Select * from tbl_hasta where hastatc=@k1", bgl.bağlantı());
            
            komut.Parameters.AddWithValue("@k1", masktc.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                textad.Text = dr1[1].ToString();
                textsoyad.Text = dr1[2].ToString();
                masktel.Text = dr1[4].ToString();
                textsifre.Text = dr1[5].ToString();
                combocinsiyet.Text = dr1[6].ToString();

            }
            bgl.bağlantı().Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==30)
            {
                timer1.Stop();
                form_hastagiriş k = new form_hastagiriş();
                k.Show();
                this.Hide();
            }
        }
    }
}
