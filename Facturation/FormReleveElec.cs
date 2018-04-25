using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturation.Properties;

namespace Facturation
{
    public partial class FormReleveElec : Form
    {
       
        
        private bool imageCheck = true;
        public FormReleveElec()
        {
            InitializeComponent();
        }
        private void ReleveElec_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (imageCheck)
            {
                pictureBox1.Image = Resources.go;
                label8.Enabled = label8.Visible = textBoxMotif.Enabled = textBoxMotif.Visible = imageCheck = false;
            }
            else
            {
                pictureBox1.Image = Resources.stop;
                label8.Enabled = label8.Visible = textBoxMotif.Enabled = textBoxMotif.Visible = imageCheck = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBoxPrevIndex_TextChanged(object sender, EventArgs e)
        {
            textBoxConsommation.Text = (Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text)).ToString();
        }

        private void textBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            const double tvaelec = 0.07, firstconst = 1.18930, redevencefix = 401.13;
            var consom = Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text);
            var np = consom * firstconst + consom * firstconst * tvaelec + redevencefix + redevencefix * tvaelec;
            textBoxNetPayer.Text = np.ToString();
        }
    }
}
