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
            // Remplissage des numeros de Police
            using (var db = new FacturationEntities())
            {
                comboBoxNpolice.DataSource = db.Electricites.Select(ea => ea.NPolice).ToList();
                comboBoxNpolice.AutoCompleteCustomSource.AddRange(db.Electricites.Select(ea => ea.NPolice).ToArray());
                InitFields();
            }
        }
        // Une Methode pour remlir les champs selon le Numero de Police
        private void InitFields()
        {
            using (var db = new FacturationEntities())
            {
                // l'année
                textBoxAnnee.Text = DateTime.Today.Year.ToString();
                // L'index précèdent
                var rel = db.RelveeElecs.Where(r => r.Elec_NPolice == comboBoxNpolice.Text).OrderByDescending(r => r.Id).FirstOrDefault();
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
        // Calcule de la Consommation
        private void TextBoxNewIndex_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewIndex.Text == "" || textBoxPrevIndex.Text == "")
                return;
            textBoxConsommation.Text = (Convert.ToInt32(textBoxNewIndex.Text) - Convert.ToInt32(textBoxPrevIndex.Text)).ToString();
        }

        // Calcule du Net à Payer
        private void TextBoxConsommation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewIndex.Text == "" || textBoxPrevIndex.Text == "" || textBoxConsommation.Text == "")
                return;

            const double tvaelec = 0.07, firstconst = 1.18930, redevencefix = 401.13;
            var consom = Convert.ToInt32(textBoxConsommation.Text);
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
                InitFields();
                dataGridView2.Rows.Clear();
                foreach (var rel in elec.RelveeElecs)
                {
                    dataGridView2.Rows.Add(elec.NPolice, elec.Adresse,rel.Annee, rel.Trimestre, rel.NIndex, rel.PIndex, rel.NIndex - rel.PIndex, rel.NPayer, rel.Rapport);
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
                using (var db = new FacturationEntities())
                {
                    db.RelveeElecs.Add(new RelveeElec
                    {
                        Electricite = db.Electricites.Single(el => el.NPolice == comboBoxNpolice.Text),
                        Annee = short.Parse(textBoxAnnee.Text),
                        Trimestre = int.Parse(comboBoxTrimestre.Text),
                        NIndex = int.Parse(textBoxNewIndex.Text),
                        PIndex = int.Parse(textBoxPrevIndex.Text),
                        NPayer = float.Parse(textBoxNetPayer.Text),
                        Rapport = textBoxMotif.Visible ? textBoxMotif.Text : null
                    });
                    db.SaveChanges();
                }
                ComboBoxNpolice_SelectedIndexChanged(sender, e);
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
