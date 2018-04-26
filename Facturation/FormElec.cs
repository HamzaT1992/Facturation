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

        private void FormElec_Load(object sender, EventArgs e)
        {//Remplisage les Combobox
            using (var db = new FacturationEntities())
            {
                comboBoxEtat.DataSource = db.Etats.ToList();
                comboBoxEtat.DisplayMember = "NomEtat";
                comboBoxEtat.ValueMember = "id";
                comboBoxType.DataSource = db.TypeEaus.ToList();
                comboBoxType.DisplayMember = "NomTypeElec";
                comboBoxType.ValueMember = "id";
            }

        }
        //Ajouter
        private void add_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                db.Eaus.Add(new Eau
                {
                    NPolice = int.Parse(textBoxPolice.Text),
                    Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue),
                    TypeEau = db.TypeEaus.Single(te => te.id == (int)comboBoxType.SelectedValue),
                    NCompteur = int.Parse(textBoxNcompteur.Text),
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
                var npolice = int.Parse(textBoxPolice.Text);
                var elec = db.Electricites.SingleOrDefault(ea => ea.NPolice == npolice);
                elec.Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue);
                elec.TypeElec = db.TypeElectricites.Single(te => te.id == (int)comboBoxType.SelectedValue);
                elec.NCompteur = int.Parse(textBoxNcompteur.Text);
                elec.Tel = textBoxTeli.Text;
                elec.Date = dateTimePickerElec.Value;
                elec.Reference = textBoxReference.Text;
                elec.Adresse = textBoxAdresse.Text;
                elec.Annee = short.Parse(textBoxAnnee.Text);
                db.SaveChanges();
            }
        }

        private void dellete_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var npolice = int.Parse(textBoxPolice.Text);
                var eau = db.Eaus.SingleOrDefault(ea => ea.NPolice == npolice);
                if (eau == null) return;
                db.Eaus.Remove(eau);
                db.SaveChanges();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            using (var db = new FacturationEntities())
            {
                IQueryable<Electricite> elecs = db.Electricites;
                if (textBoxRechNpo.Text != "")
                {
                    var npolice = int.Parse( textBoxRechNpo.Text);
                    elecs = elecs.Where(ele => ele.NPolice == npolice);
                    if (elecs.Count() == 0)
                    {
                        MessageBox.Show("Elément introuvable");
                        return;
                    }
                    addrows(elecs);
                }
                else if (textBoxRechNcomp.Text != "")
                {
                    var ncompt = int.Parse(textBoxRechNcomp.Text);
                    if (elecs == null)
                    {
                        MessageBox.Show("Elément introuvable");
                        return;
                    }
                    elecs = elecs.Where(ele => ele.NCompteur == ncompt);
                    addrows(elecs);

                }
                else
                {
                    if (textBoxRechAdress.Text != "")
                    {
                        var adresse = textBoxRechAdress.Text;
                        elecs = elecs.Where(ele => ele.Adresse == adresse);
                        if (elecs.Count() == 0)
                        {
                            MessageBox.Show("Elément introuvable");
                            return;
                        }
                        addrows(elecs);
                    }
                    if (textBoxRechRef.Text != "")
                    {
                        var refr = textBoxRechRef.Text;
                        var elec = elecs.SingleOrDefault(ele => ele.Reference == refr);
                        if (elec == null)
                        {
                            MessageBox.Show("Elément introuvable");
                            return;
                        }
                        elecs = elecs.Where(ele => ele.Reference == refr);
                        addrows(elecs);
                    }
                }

            }
        }

        private void addrows(IQueryable<Electricite> elecs)
        {
            dataGridViewElec.Rows.Clear();
            foreach (var el in elecs)
            {
                dataGridViewElec.Rows.Add(el.NPolice, el.Reference, el.Annee, el.Adresse, el.NCompteur, el.Etat.NomEtat, el.Date, el.Tel, el.TypeElec.NomTypeElec);
            }
        }

        private void dataGridViewElec_SelectionChanged(object sender, EventArgs e)
        {
            textBoxPolice.Text = dataGridViewElec.CurrentRow.Cells[0].Value.ToString();
            textBoxReference.Text = dataGridViewElec.CurrentRow.Cells[1].Value.ToString();
            textBoxAnnee.Text = dataGridViewElec.CurrentRow.Cells[2].Value.ToString();
            textBoxAdresse.Text = dataGridViewElec.CurrentRow.Cells[3].Value.ToString();
            textBoxNcompteur.Text = dataGridViewElec.CurrentRow.Cells[4].Value.ToString();
            comboBoxEtat.Text = dataGridViewElec.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerElec.Text = dataGridViewElec.CurrentRow.Cells[6].Value.ToString();
            textBoxTeli.Text = dataGridViewElec.CurrentRow.Cells[7].Value.ToString();
            comboBoxType.Text = dataGridViewElec.CurrentRow.Cells[8].Value.ToString();



        }
    }
}
