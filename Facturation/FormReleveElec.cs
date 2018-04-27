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

        public FormReleveElec()
        {
            InitializeComponent();
        }
        private void ReleveElec_Load(object sender, EventArgs e)
        {
            // Remplissage des N° de Police
            using (var db = new FacturationEntities())
            {
                comboBoxNpolice.DataSource = db.Electricites.Select(ea => ea.NPolice).ToList();
            }
        }

        // Calcule de la Consommation
        private void TextBoxPrevIndex_TextChanged(object sender, EventArgs e)
        {
            textBoxConsommation.Text = (Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text)).ToString();
        }

        // Calcule du Net à Payer
        private void TextBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            const double tvaelec = 0.07, firstconst = 1.18930, redevencefix = 401.13;
            var consom = Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text);
            var np = consom * firstconst + consom * firstconst * tvaelec + redevencefix + redevencefix * tvaelec;
            textBoxNetPayer.Text = np.ToString();
        }


        private void ComboBoxNpolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var npolice = comboBoxNpolice.SelectedValue.ToString();

                var elec = db.Electricites.Single(el => el.NPolice == npolice);
                textBoxAdress.Text = elec.Adresse;
                textBoxNCompt.Text = elec.NCompteur.ToString();
                foreach (var rel in elec.RelveeElecs)
                {
                    dataGridView2.Rows.Add(elec.NPolice, elec.Adresse, rel.NIndex, rel.PIndex, rel.NIndex - rel.PIndex, rel.NPayer, rel.Rapport);
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            var All_Ok = true;

            foreach (Control control in Controls.OfType<TextBox>())
            {
                if (control.Text == "")
                {
                    All_Ok = false;
                    break;
                }
            }

            if (comboBoxTrimestre.Text == "--Entrer Trimmestre--" || (textBoxMotif.Visible && textBoxMotif.Text == ""))
                All_Ok = false;

            if (!All_Ok)
                ErrorMbox("Veuiller remplir tous les champs!");

            else if(MessageBox.Show("Voulez vous vraiment confirmer!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                dataGridView2.Rows.Add(
                    comboBoxNpolice.Text,
                    textBoxAdress.Text,
                    textBoxAnnee.Text,
                    comboBoxTrimestre.Text,
                    textBoxNewIndex.Text,
                    textBoxPrevIndex.Text,
                    textBoxConsommation.Text,
                    textBoxNetPayer.Text,
                    textBoxMotif.Visible ? textBoxMotif.Text : null
                );
            }
        }

        private static void ErrorMbox(string msg)
        {
            MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Resources.go;
                label8.Enabled = label8.Visible = textBoxMotif.Enabled = textBoxMotif.Visible = false;
            }
            else
            {
                pictureBox1.Image = Resources.stop;
                label8.Enabled = label8.Visible = textBoxMotif.Enabled = textBoxMotif.Visible = true;
            }
        }
    }
}
