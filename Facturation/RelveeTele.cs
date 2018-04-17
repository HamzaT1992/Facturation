using Facturation.Properties;
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
    public partial class RelveeTele : Form
    {
        public Label LabelTitle
        {
            get { return labelTitle; }
            set { labelTitle = value; }
        }
        public bool imageCheck { get; set; }
        public RelveeTele()
        {
            InitializeComponent();
        }

        private void RelveeTele_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (imageCheck)
            {
                pictureBox1.Image = Resources.go;
                label8.Enabled = label8.Visible = textBox6.Enabled = textBox6.Visible = imageCheck = false;
            }
            else
            {
                pictureBox1.Image = Resources.stop;
                label8.Enabled = label8.Visible = textBox6.Enabled = textBox6.Visible = imageCheck = true;
            }
        }

     
    }
}
