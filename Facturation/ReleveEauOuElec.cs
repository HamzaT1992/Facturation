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
    public partial class ReleveEauOuElec : Form
    {
        public Label LabelTitle {
            get { return labelTitle; }
            set { labelTitle = value; }
        }
        public ReleveEauOuElec()
        {
            InitializeComponent();
        }
        private void ReleveEauOuElec_Load(object sender, EventArgs e)
        {

        }
    }
}
