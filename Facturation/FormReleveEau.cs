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
        public FormReleveEau()
        {
            InitializeComponent();
        }
        private void ReleveEauOuElec_Load(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                comboBoxNpolice.DataSource = db.Eaux.Select(ea => ea.NPolice).ToList();
                comboBoxNpolice.AutoCompleteCustomSource.AddRange(db.Eaux.Select(ea => ea.NPolice).ToArray());
                InitFields();
            }
        }

        private void InitFields()
        {
            using (var db = new FacturationEntities())
            {
                // l'année
                textBoxAnnee.Text = DateTime.Today.Year.ToString();
                // L'index précèdent
                var rel = db.RelveeEaux.Where(r => r.Eau_NPolice == comboBoxNpolice.Text).OrderByDescending(r => r.Id).FirstOrDefault();
                textBoxPrevIndex.Text = rel != null ? rel.NIndex.ToString() : "0";
                // Trimmestre
                comboBoxTrimestre.Items.Clear();
                for (int i = 0; i < 4; i++)
                    comboBoxTrimestre.Items.Add(i + 1);
                comboBoxTrimestre.Text = "1";
                if (rel == null)
                    return;
                comboBoxTrimestre.Text = rel.Trimestre != 4 ? (++rel.Trimestre).ToString() : "1";
            }
        }

        private void textBoxNewIndex_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewIndex.Text == "" || textBoxPrevIndex.Text == "")
                return;
            textBoxConsommation.Text = (Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text)).ToString();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            //if (textBoxAnnee.Text != "" && comboBoxTrimestre.Text != "" && textBoxNewIndex.Text != "" && textBoxPrevIndex.Text != "" && comboBoxNpolice.Text != "" && textBoxAdress.Text != "" && textBoxNCompt.Text != "" )
            //{ 
            //    if (MessageBox.Show("Voulez vous vraiment confirmer!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
            //        if (textBoxMotif.Text == "")
            //            dataGridView1.Rows.Add(comboBoxNpolice.Text, textBoxAdress.Text, textBoxAnnee.Text, comboBoxTrimestre.Text, textBoxNewIndex.Text, textBoxPrevIndex.Text, textBoxConsommation.Text, textBoxNetPayer.Text);
            //        else
            //            dataGridView1.Rows.Add(comboBoxNpolice.Text, textBoxAdress.Text, textBoxAnnee.Text, comboBoxTrimestre.Text, textBoxNewIndex.Text, textBoxPrevIndex.Text, textBoxConsommation.Text, textBoxNetPayer.Text, textBoxMotif.Text);
            //    }
            //}

            //else
            //    MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var All_Ok = true;

            foreach (Control control in Controls.OfType<TextBox>())
            {
                if (control.Text == "")
                {
                    All_Ok = false;
                    break;
                }
            }

            if (comboBoxTrimestre.Text == "" || (textBoxMotif.Visible && textBoxMotif.Text == ""))
                All_Ok = false;

            if (!All_Ok)
                ErrorMbox("Veuiller remplir tous les champs!");

            else if (MessageBox.Show("Voulez vous vraiment confirmer!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (var db = new FacturationEntities())
                {
                    db.RelveeEaux.Add(new RelveeEau
                    {
                        Eau_NPolice = comboBoxNpolice.Text,
                        Annee = short.Parse(textBoxAnnee.Text),
                        Trimestre = int.Parse(comboBoxTrimestre.Text),
                        NIndex = int.Parse(textBoxNewIndex.Text),
                        PIndex = int.Parse(textBoxPrevIndex.Text),
                        NPayer = float.Parse(textBoxNetPayer.Text),
                        Rapport = textBoxMotif.Visible ? textBoxMotif.Text : null
                    });
                    db.SaveChanges();
                }
                comboBoxNpolice_SelectedIndexChanged(sender, e);
            }
        }

        private static void ErrorMbox(string msg)
        {
            MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewIndex.Text == "" || textBoxPrevIndex.Text == "" || textBoxConsommation.Text == "")
                return;

            var consom = Convert.ToInt32(textBoxConsommation.Text);
            const double tvae = 0.07, firstconst = 7.58, secondconst = 30, redevencefix = 19.98;
            //var np = consom * firstconst + consom * firstconst * tvae + secondconst + secondconst * tvae + consom * 4 + consom * 4 * tvae + redevencefix + redevencefix * tvae;

            var np = consom == 0 ? 53.48 : consom * ((firstconst + 4) * (1 + tvae)) + (secondconst + redevencefix) * (1 + tvae);
            textBoxNetPayer.Text = np.ToString();
        }

        private void comboBoxNpolice_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var npolice = comboBoxNpolice.SelectedValue.ToString();

                var eau = db.Eaux.Single(ea => ea.NPolice == npolice);
                textBoxAdress.Text = eau.Adresse;
                textBoxNCompt.Text = eau.NCompteur.ToString();
                InitFields();
                dataGridView1.Rows.Clear();
                foreach (var rel in eau.RelveeEaux)
                {
                    dataGridView1.Rows.Add(eau.NPolice, eau.Adresse, eau.Annee, rel.Trimestre, rel.NIndex, rel.PIndex, rel.NIndex - rel.PIndex, rel.NPayer, rel.Rapport);
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
