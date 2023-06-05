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
    public partial class form_hastakayıt : Form
    {
        public form_hastakayıt()
        {
            InitializeComponent();
        }

        sqlbaglantı bgl = new sqlbaglantı();  // burada sqlbaglantı classımızdan bir nesne oluşturarak connection metodumuzu kullanacağız
        private void btnkaydet_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("insert into tbl_hasta (hastaad ,hastasoyad , hastatc, hastatel , hastasifre, hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5 ,@p6)", bgl.bağlantı());

            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut.Parameters.AddWithValue("@p3", masktc.Text);
            komut.Parameters.AddWithValue("@p4", masktel.Text);
            komut.Parameters.AddWithValue("@p5", textsifre.Text);
            komut.Parameters.AddWithValue("@p6", combocinsiyet.Text);
            komut.ExecuteNonQuery();

            bgl.bağlantı().Close();
            MessageBox.Show("Hasta Kayıt İşlemi Yapılmıştır  Şifreniz:" +textsifre.Text , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);


        }



        private void button1_Click(object sender, EventArgs e)
        {
            form_hastagiriş k = new form_hastagiriş();
            k.Show();
            this.Hide();
        }
    }
}
