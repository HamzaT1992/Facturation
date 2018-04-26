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
            using (var db = new FacturationEntities())
            {
                comboBoxNpolice.DataSource = db.Eaux.Select(ea => ea.NPolice).ToList();
                //comboBoxNpolice.DisplayMember = "NPolice";
                //comboBoxNpolice.ValueMember = "NPolice";
            }
            for (int i = 1; i <= 4; i++)
                comboBoxTrimestre.Items.Add(i);
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
                    dataGridView1.Rows.Add(comboBoxNpolice.Text, textBoxAdress.Text, textBoxNewIndex.Text, textBoxPrevIndex.Text, textBoxConsommation.Text, textBoxNetPayer.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewIndex.Text != "")
            {
                const double tvae = 0.07, firstconst = 7.58, secondconst = 30, redevencefix = 19.98;
                var consom = Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text);
                //var np = consom * firstconst + consom * firstconst * tvae + secondconst + secondconst * tvae + consom * 4 + consom * 4 * tvae + redevencefix + redevencefix * tvae;
                var np = consom == 0 ? 53.48 : consom * ((firstconst + 4) * (1 + tvae)) + (secondconst + redevencefix) * (1 + tvae);
                textBoxNetPayer.Text = np.ToString();
            }
        }

        private void comboBoxNpolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var npolice = comboBoxNpolice.SelectedValue.ToString();

                var eau = db.Eaux.Single(ea => ea.NPolice == npolice);
                textBoxAdress.Text = eau.Adresse;
                textBoxNCompt.Text = eau.NCompteur.ToString();
                var rels = db.RelveeEaux.Where(r => r.Eau.NPolice == npolice);
                foreach (var rel in rels)
                {
                    dataGridView1.Rows.Add(eau.NPolice, eau.Adresse, rel.NIndex, rel.PIndex, rel.NIndex - rel.PIndex, rel.NPayer, rel.Rapport);
                }
                
            }
        }
    }
}
