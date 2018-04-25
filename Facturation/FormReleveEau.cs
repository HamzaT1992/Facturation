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
    public partial class FormReleveEau : Form
    {
        public Label LabelTitle {
            get { return labelTitle; }
            set { labelTitle = value; }
        }
        private bool imageCheck = true;
        public FormReleveEau()
        {
            InitializeComponent();
        }
        private void ReleveEauOuElec_Load(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrevIndex_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewIndex.Text != "") 
            {
                textBoxConsommation.Text = (Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text)).ToString();

            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment confirmer!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Add(textBoxPolice.Text, textBoxAdress.Text, textBoxNewIndex.Text, textBoxPrevIndex.Text, textBoxConsommation.Text, textBoxNetPayer.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTC.Text != "")
            {
                const double tvae = 0.07, firstconst = 7.58, secondconst = 30, redevencefix = 19.98;
                var consom = Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text);
                var np = consom * firstconst + consom * firstconst * tvae + secondconst + secondconst * tvae + consom * 4 + consom * 4 * tvae + redevencefix + redevencefix * tvae;
                textBoxNetPayer.Text = np.ToString();

            }
        }

        private void textBoxPolice_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
