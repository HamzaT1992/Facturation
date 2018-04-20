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
                var eau = db.Eaus.SingleOrDefault(ea => ea.NPolice == npolice);

                eau.Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue);
                eau.TypeEau = db.TypeEaus.Single(te => te.id == (int)comboBoxType.SelectedValue);
                eau.NCompteur = int.Parse(textBoxNcompteur.Text);
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
                var npolice = int.Parse(textBoxPolice.Text);
                var eau = db.Eaus.SingleOrDefault(ea => ea.NPolice == npolice);
                if (eau == null) return;
                db.Eaus.Remove(eau);
                db.SaveChanges();
            }
        }
    }
}
