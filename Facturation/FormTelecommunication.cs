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

    public partial class FormTelecommunication : Form
    {
        public FormTelecommunication()
        {
            InitializeComponent();

        }

        private void FormTelecommunication_Load(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                comboBoxEtat.DataSource = db.Etats.ToList();
                comboBoxEtat.DisplayMember = "NomEtat";
                comboBoxEtat.ValueMember = "id";
                comboBoxType.DataSource = db.TypeTelecommunications.ToList();
                comboBoxType.DisplayMember = "NomTypeTelecommunication";
                comboBoxType.ValueMember = "id";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                db.TeleCommunications.Add(new TeleCommunication
                {
                    NPolice = int.Parse(textBoxPolice.Text),
                    Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue),
                    TypeTelecom = db.TypeTelecommunications.Single(te => te.id == (int)comboBoxType.SelectedValue),
                    Tel = textBoxTel.Text,
                    Date = dateTimePickerTelecom.Value,
                    MD = textBoxMD.Text,
                    Adresse = textBoxAdresse.Text,
                    Forfait = int.Parse(textBoxForfait.Text),
                    Montant = double.Parse(textBoxPrice.Text)
                });
                db.SaveChanges();
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var npolice = int.Parse(textBoxPolice.Text);
                var Telecommunication = db.TeleCommunications.SingleOrDefault(ea => ea.NPolice == npolice);

                Telecommunication.Etat = db.Etats.Single(et => et.id == (int)comboBoxEtat.SelectedValue);
                Telecommunication.TypeTelecom = db.TypeTelecommunications.Single(te => te.id == (int)comboBoxType.SelectedValue);
                Telecommunication.Tel = textBoxTel.Text;
                Telecommunication.Date = dateTimePickerTelecom.Value;
                Telecommunication.MD = textBoxMD.Text;
                Telecommunication.Adresse = textBoxAdresse.Text;
                Telecommunication.Montant = short.Parse(textBoxPrice.Text);
                Telecommunication.Forfait = int.Parse(textBoxForfait.Text);
                db.SaveChanges();
            }
        }
        private void del_Click(object sender, EventArgs e)
        {
            using (var db = new FacturationEntities())
            {
                var npolice = int.Parse(textBoxPolice.Text);
                var Telecommunication = db.TeleCommunications.SingleOrDefault(ea => ea.NPolice == npolice);
                if (Telecommunication == null) return;
                db.TeleCommunications.Remove(Telecommunication);
                db.SaveChanges();
            }
        }
    }
}
