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
            using (var db = new FacturationEntities())
            {
                comboBoxNpolice.DataSource = db.Electricites.Select(ea => ea.NPolice).ToList();
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
            textBoxConsommation.Text = (Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text)).ToString();
        }

        private void textBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            const double tvaelec = 0.07, firstconst = 1.18930, redevencefix = 401.13;
            var consom = Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text);
            var np = consom * firstconst + consom * firstconst * tvaelec + redevencefix + redevencefix * tvaelec;
            textBoxNetPayer.Text = np.ToString();
        }

        private void comboBoxNpolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                int npolice = (int)comboBoxNpolice.SelectedValue;

                var elec = db.Electricites.Single(el => el.NPolice == npolice);
                textBoxAdress.Text = elec.Adresse;
                textBoxNCompt.Text = elec.NCompteur.ToString();
                foreach (var rel in elec.RelveeElecs)
                {
                    dataGridView2.Rows.Add(elec.NPolice , elec.Adresse, rel.NIndex, rel.PIndex, rel.NIndex - rel.PIndex, rel.NPayer, rel.Rapport);
                }
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment confirmer!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dataGridView2.Rows.Add(comboBoxNpolice.Text, textBoxAdress.Text, textBoxNewIndex.Text, textBoxPrevIndex.Text, textBoxConsommation.Text, textBoxNetPayer.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
