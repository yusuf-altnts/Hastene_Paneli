using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_hastane
{
    public partial class form_Girişler : Form
    {
        public form_Girişler()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            //hastagiriş formumu göster girişler formumu gizle demektir.

            form_hastagiriş  hastagr = new form_hastagiriş();
            hastagr.Show();
            this.Hide();
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            // doktorgiriş formumu göster girişler formumu gizle

            form_doktorgiriş doktorgr = new form_doktorgiriş();
            doktorgr.Show();
            this.Hide();
        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            // sekretergiriş formumu göster girişler formumu gizle 

            form_sekretergiriş sekretergr = new form_sekretergiriş();
            sekretergr.Show();
            this.Hide();
        }
    }
}
