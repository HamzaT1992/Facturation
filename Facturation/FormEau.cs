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
    public partial class FormEau : Form
    {
        public FormEau()
        {
            InitializeComponent();
        }

        private void FormEau_Load(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                comboBoxEtat.DataSource = db.Etats.ToList();
                comboBoxEtat.DisplayMember = "NomEtat";
                comboBoxEtat.ValueMember = "id";
                comboBoxType.DataSource = db.TypeEaus.ToList();
                comboBoxType.DisplayMember = "NomTypeEau";
                comboBoxType.ValueMember = "id";
            }
        }

        // Ajouter Nouvel Eau
        private void add_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                db.Eaus.Add(new Eau
                {
                    NPolice = int.Parse(textBoxPolice.Text),
                    Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue),
                    TypeEau = db.TypeEaus.Single(te => te.id == (int)comboBoxType.SelectedValue),
                    NCompteur = int.Parse(textBoxNCompt.Text),
                    Tel = textBoxTel.Text,
                    Date = dateTimePickerEau.Value,
                    Reference = textBoxRef.Text,
                    Adresse = textBoxAdresse.Text,
                    Annee = short.Parse(textBoxAnnee.Text)
                });
                db.SaveChanges();
            }
        }

        // Modifier un Eau
        private void edit_Click(object sender, EventArgs e)
        {
            
            using (var db = new FacturationEntities())
            {
                var npolice = int.Parse(textBoxPolice.Text);
                var eau = db.Eaus.SingleOrDefault(ea => ea.NPolice == npolice);
                
                eau.Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue);
                eau.TypeEau = db.TypeEaus.Single(te => te.id == (int)comboBoxType.SelectedValue);
                eau.NCompteur = int.Parse(textBoxNCompt.Text);
                eau.Tel = textBoxTel.Text;
                eau.Date = dateTimePickerEau.Value;
                eau.Reference = textBoxRef.Text;
                eau.Adresse = textBoxAdresse.Text;
                eau.Annee = short.Parse(textBoxAnnee.Text);

                db.SaveChanges();
            }
        }

        private void del_Click(object sender, EventArgs e)
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

        private void enregister_Click(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}