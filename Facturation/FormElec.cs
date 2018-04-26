using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void FillDataGridView(IQueryable<Electricite> elecs)
        {
            dataGridViewElec.Rows.Clear();
            foreach (var elec in elecs)
            {
                dataGridViewElec.Rows.Add(
                    elec.NPolice,
                    elec.Reference,
                    elec.NCompteur,
                    elec.TypeElectricite.NomTypeElec,
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
                FillDataGridView(db.Electricites);
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
                var elecs = db.Electricites;
                if (textBoxRechNpo.Text != "")
                {

                }
            }
        }
        private void dataGridViewElec_SelectionChanged(object sender, EventArgs e)
        {
            //var tr = true;
            //foreach (DataGridViewCell cell in dataGridViewElec.CurrentRow.Cells)
            //    if (cell.Value == null) return;

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
    }
}
