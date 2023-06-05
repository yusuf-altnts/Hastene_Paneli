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
    public partial class form_sekretergiriş : Form
    {
        public form_sekretergiriş()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void btngiriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1",masktc.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                formsekreterdetay k = new formsekreterdetay();
                k.tc =masktc.Text;
                k.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre " ,"Hata");

            }
            bgl.bağlantı().Close();
        }
    }
}
