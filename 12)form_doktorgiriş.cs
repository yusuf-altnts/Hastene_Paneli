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
    public partial class form_doktorgiriş : Form
    {
        public form_doktorgiriş()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select doktortc, doktorsifre,doktorad, doktorsoyad from tbl_doktor where doktortc= @p1 and doktorsifre= @p2", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", masktc.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                form_doktordetay k = new form_doktordetay();
                k.tc = masktc.Text;
                k.adsoyad = dr[2].ToString() +" " +  dr[3];
                k.Show();
                this.Hide();
                
                
            }
            else
            {
                MessageBox.Show("Tc Kimlik No veya Şifre Hatalıdır Lütfen Tekrar Deneyiniz", "Hata" , MessageBoxButtons.OK , MessageBoxIcon.Hand);

            }
            bgl.bağlantı().Close();
        }

        private void form_doktorgiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
