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
using System.Data.Common;

namespace Proje_hastane
{
    public partial class formdoktorpaneli : Form
    {
        public formdoktorpaneli()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı(); 
        
        private void formdoktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_doktor" , bgl.bağlantı());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            bgl.bağlantı().Close();

            SqlCommand komut = new SqlCommand("select  bransad from tbl_brans", bgl.bağlantı());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combobrans.Items.Add(dr[0].ToString());
            }

            bgl.bağlantı().Close();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (masktc.Text != "" && textsifre.Text != "" && textad.Text != "" && textsoyad.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into tbl_doktor (doktorad, doktorsoyad , doktorbrans , doktortc , doktorsifre) values (@d1, @d2, @d3,@d4 , @d5)", bgl.bağlantı());
                komut.Parameters.AddWithValue("@d1", textad.Text);
                komut.Parameters.AddWithValue("@d2", textsoyad.Text);
                komut.Parameters.AddWithValue("@d3", combobrans.Text);
                komut.Parameters.AddWithValue("@d4", masktc.Text);
                komut.Parameters.AddWithValue("@d5", textsifre.Text);

                komut.ExecuteNonQuery();

                MessageBox.Show("Doktor Kaydı Yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.bağlantı().Close();
            }
            else
            {
                MessageBox.Show("Lütfen Doktor Ad,Soyad,Tc ve Şifre Ekleyin","Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            textad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); 
            combobrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            masktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            label6.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

           
            if (masktc.Text == "" || label6.Text == "" )
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Doktorun Tc Numarasını Girinizi" , "Hata" ,MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }
            else
            {
                SqlCommand komut = new SqlCommand("delete from tbl_doktor where doktortc = @p1 or doktorid =@p2", bgl.bağlantı());
                komut.Parameters.AddWithValue("@p1", masktc.Text);
                komut.Parameters.AddWithValue("@p2", label6.Text);
                komut.ExecuteNonQuery();
                bgl.bağlantı().Close();
                MessageBox.Show("Doktor Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            

            bgl.bağlantı().Close();
            if (label6.Text =="")
            {
                MessageBox.Show("Lütfen Önce Tablodan Doktor Seçimini Yapınız" , "Hata" , MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            else
            {

                SqlCommand komut = new SqlCommand("update tbl_doktor set  doktorad= @p1 , doktorsoyad= @p2 , doktorbrans = @p3 , doktortc = @p4 , doktorsifre=@p5 where doktorid=@p6 ", bgl.bağlantı());
                komut.Parameters.AddWithValue("@p1", textad.Text);
                komut.Parameters.AddWithValue("@p2", textsoyad.Text);
                komut.Parameters.AddWithValue("@p3", combobrans.Text);
                komut.Parameters.AddWithValue("@p4", masktc.Text);
                komut.Parameters.AddWithValue("@p5", textsifre.Text);
                komut.Parameters.AddWithValue("@p6", label6.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Doktor Güncelleme İşlemi Yapılmış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
