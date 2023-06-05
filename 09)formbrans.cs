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
    public partial class formbrans : Form
    {
        public formbrans()
        {
            InitializeComponent();
        }
        sqlbaglantı bgl = new sqlbaglantı();
        private void formbrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select bransid as 'Branş İD' , bransad as 'Branş' from tbl_brans " , bgl.bağlantı());
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            bgl.bağlantı().Close();

            textıd.Enabled= false;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (textbransad.Text != "")
            {
                SqlCommand komut = new SqlCommand("insert into tbl_brans (bransad) values (@p1) " , bgl.bağlantı());
                komut.Parameters.AddWithValue("@p1", textbransad.Text);

                 komut.ExecuteNonQuery();
                MessageBox.Show("Branş Eklenmişitr", "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                bgl.bağlantı().Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Branş Giriniz" , "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Hand );

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            // brans Silme
            SqlCommand komut = new SqlCommand("delete from tbl_brans where bransid= @p1 or bransad=@p2" , bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", textıd.Text);
            komut.Parameters.AddWithValue("@p2",textbransad.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Branş Silinmiştir" , "Bilgi", MessageBoxButtons.OK , MessageBoxIcon.Information);
            bgl.bağlantı() .Close();    


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if (textıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("update tbl_brans set bransad=@p1 where bransid= @p2", bgl.bağlantı());
                komut.Parameters.AddWithValue("@p1", textbransad.Text);
                komut.Parameters.AddWithValue("@p2", textıd.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Branş Güncelleme İşlemi Yapılmıştır");
            }
            else {
                MessageBox.Show("Lütfen Güncelleme yapamadan önce branş seçin ");
            }
        }
    }
}
