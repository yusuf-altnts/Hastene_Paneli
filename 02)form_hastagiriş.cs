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
    public partial class form_hastagiriş : Form
    {
        public form_hastagiriş()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_hastakayıt hastak = new form_hastakayıt();

            hastak.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_Girişler k = new form_Girişler();
            k.Show();
            this.Hide();
        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hastatc = @p1 and hastasifre = @p2 " , bgl.bağlantı() );
            komut.Parameters.AddWithValue("@p1", masktc.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                form_hastadetay k = new form_hastadetay();
                k.Tc = masktc.Text;
                
                k.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır", "Hata" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bgl.bağlantı().Close();

        }
    }
}
