using Facturation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class FormRelveeTele : Form
    {
        public Label LabelTitle
        {
            get { return labelTitle; }
            set { labelTitle = value; }
        }
        public bool imageCheck { get; set; }
        public FormRelveeTele()
        {
            InitializeComponent();
        }

        private void RelveeTele_Load(object sender, EventArgs e)
        {
            var frCult = new CultureInfo("fr");
            foreach (var m in frCult.DateTimeFormat.MonthNames.Take(12))
            {
                string month = m.ToString();
                comboBoxMois.Items.Add(month.First().ToString().ToUpper() + month.Substring(1));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (imageCheck)
            {
                pictureBox1.Image = Resources.go;
                label8.Enabled = label8.Visible = textBoxMotif.Enabled = textBoxMotif.Visible = imageCheck = false;
            }
            else
            {
                pictureBox1.Image = Resources.stop;
                label8.Enabled = label8.Visible = textBoxMotif.Enabled = textBoxMotif.Visible = imageCheck = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
