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
                comboBoxType.DataSource = db.TypeEaux.ToList();
                comboBoxType.DisplayMember = "NomTypeEau";
                comboBoxType.ValueMember = "id";
                FillDataGridView(db.Eaux);
            }
        }
        private void FillDataGridView(IQueryable<Eau> elecs)
        {
            dataGridViewEau.Rows.Clear();
            foreach (var elec in elecs)
            {
                dataGridViewEau.Rows.Add(
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

        // Ajouter Nouvel Eau
        private void add_Click(object sender, EventArgs e)
        {
                using (var db = new FacturationEntities())
                {
                    db.Eaux.Add(new Eau
                    {
                        NPolice = textBoxPolice.Text,
                        Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue),
                        TypeEau = db.TypeEaux.Single(te => te.id == (int)comboBoxType.SelectedValue),
                        NCompteur = textBoxNCompt.Text,
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
                var eau = db.Eaux.SingleOrDefault(ea => ea.NPolice == textBoxPolice.Text);
                
                eau.Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue);
                eau.TypeEau = db.TypeEaux.Single(te => te.id == (int)comboBoxType.SelectedValue);
                eau.NCompteur = textBoxNCompt.Text;
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
                var eau = db.Eaux.SingleOrDefault(ea => ea.NPolice == textBoxPolice.Text);
                if (eau == null) return;
                db.Eaux.Remove(eau);
                db.SaveChanges();
            }
        }

        private void enregister_Click(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                FillDataGridView(db.Eaux);
            }
        }

        private void dataGridViewEau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPolice.Text = dataGridViewEau.CurrentRow.Cells["npolice"].Value.ToString();
            textBoxRef.Text = dataGridViewEau.CurrentRow.Cells["Reference"].Value.ToString();
            textBoxAnnee.Text = dataGridViewEau.CurrentRow.Cells["Annee"].Value.ToString();
            textBoxAdresse.Text = dataGridViewEau.CurrentRow.Cells["adrsse"].Value.ToString();
            textBoxNCompt.Text = dataGridViewEau.CurrentRow.Cells["nCompteur"].Value.ToString();
            comboBoxEtat.Text = dataGridViewEau.CurrentRow.Cells["etat"].Value.ToString();
            dateTimePickerEau.Value = (DateTime)dataGridViewEau.CurrentRow.Cells["date"].Value;
            textBoxTel.Text = dataGridViewEau.CurrentRow.Cells["Tele"].Value.ToString();
            comboBoxType.Text = dataGridViewEau.CurrentRow.Cells["Type"].Value.ToString();
        }
    }
}