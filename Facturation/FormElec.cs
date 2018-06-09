using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class FormElec : Form
    {
        public FormElec()
        {
            InitializeComponent();
        }
        private void FillDataGridView(IQueryable<Eau> elecs)
        {
            dataGridViewElec.Rows.Clear();
            foreach (var elec in elecs)
            {
                dataGridViewElec.Rows.Add(
                    elec.NPolice,
                    elec.Reference,
                    elec.NCompteur,
                    elec.TypeEau.NomTypeEau,
                    elec.Etat.NomEtat,
                    elec.Annee,
                    elec.Date,
                    elec.Tel,
                    elec.Adresse
                );
            }
            
        }

        private void FormElec_Load(object sender, EventArgs e)
        {//Remplissage des Comboboxs
            using (var db = new FacturationEntities())
            {
                comboBoxEtat.DataSource = db.Etats.ToList();
                comboBoxEtat.DisplayMember = "NomEtat";
                comboBoxEtat.ValueMember = "id";
                comboBoxType.DataSource = db.TypeElectricites.ToList();
                comboBoxType.DisplayMember = "NomTypeElec";
                comboBoxType.ValueMember = "id";

                //Remplissage de dataGridView
                FillDataGridView(db.Eaux);

                textBoxRechNpo.AutoCompleteCustomSource.AddRange(db.Electricites.Select(el => el.NPolice).ToArray());
                textBoxRechAdress.AutoCompleteCustomSource.AddRange(db.Electricites.Select(el => el.Adresse).ToArray());
            }

        }
        //Ajouter
        private void add_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                db.Eaux.Add(new Eau
                {
                    NPolice = textBoxPolice.Text,
                    Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue),
                    TypeEau = db.TypeEaux.Single(te => te.id == (int)comboBoxType.SelectedValue),
                    NCompteur = textBoxNcompteur.Text,
                    Tel = textBoxTeli.Text,
                    Date = dateTimePickerElec.Value,
                    Reference = textBoxReference.Text,
                    Adresse = textBoxAdresse.Text,
                    Annee = short.Parse(textBoxAnnee.Text)
                });
                db.SaveChanges();
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {

            using (var db = new FacturationEntities())
            {
                var eau = db.Eaux.SingleOrDefault(ea => ea.NPolice == textBoxPolice.Text);

                eau.Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue);
                eau.TypeEau = db.TypeEaux.Single(te => te.id == (int)comboBoxType.SelectedValue);
                eau.NCompteur = textBoxNcompteur.Text;
                eau.Tel = textBoxTeli.Text;
                eau.Date = dateTimePickerElec.Value;
                eau.Reference = textBoxReference.Text;
                eau.Adresse = textBoxAdresse.Text;
                eau.Annee = short.Parse(textBoxAnnee.Text);

                db.SaveChanges();
            }
        }

        private void dellete_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var eau = db.Eaux.SingleOrDefault(ea => ea.NPolice == textBoxPolice.Text);
                if (eau == null) return;
                db.Eaux.Remove(eau);
                db.SaveChanges();
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                IQueryable<Eau> elecs = db.Eaux;
                var countOfAll = elecs.Count();
                if (textBoxRechNpo.Text != "")
                    elecs = elecs.Where(el => el.NPolice == textBoxRechNpo.Text);
                else if (textBoxRechNcomp.Text != "")
                    elecs = elecs.Where(el => el.NCompteur == textBoxRechNcomp.Text);
                else if (textBoxRechRef.Text != "")
                    elecs = elecs.Where(el => el.Reference == textBoxRechRef.Text);
                else if (textBoxRechAdress.Text != "")
                    elecs = elecs.Where(el => el.Adresse.Contains(textBoxRechAdress.Text) || el.Adresse.StartsWith(textBoxRechAdress.Text));
                
                if (elecs.Count() > 0 && elecs.Count() < countOfAll)
                    FillDataGridView(elecs);
                else
                    MessageBox.Show("Aucun resultat trouvé!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                FillDataGridView(db.Eaux); 
            }
        }

        private void dataGridViewElec_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxPolice.Text = dataGridViewElec.CurrentRow.Cells["npolice"].Value.ToString();
            textBoxReference.Text = dataGridViewElec.CurrentRow.Cells["Reference"].Value.ToString();
            textBoxAnnee.Text = dataGridViewElec.CurrentRow.Cells["Annee"].Value.ToString();
            textBoxAdresse.Text = dataGridViewElec.CurrentRow.Cells["adrsse"].Value.ToString();
            textBoxNcompteur.Text = dataGridViewElec.CurrentRow.Cells["nCompteur"].Value.ToString();
            comboBoxEtat.Text = dataGridViewElec.CurrentRow.Cells["etat"].Value.ToString();
            dateTimePickerElec.Value = (DateTime)dataGridViewElec.CurrentRow.Cells["date"].Value;
            textBoxTeli.Text = dataGridViewElec.CurrentRow.Cells["Tele"].Value.ToString();
            comboBoxType.Text = dataGridViewElec.CurrentRow.Cells["Type"].Value.ToString();
        }

        private void textBoxRechNpo_TextChanged(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                IQueryable<Eau> elecs = db.Eaux;
                elecs = elecs.Where(el => el.NPolice == textBoxRechNpo.Text);
                FillDataGridView(elecs.Count() > 0 ? elecs : db.Eaux);
            }
        }
    }
}
