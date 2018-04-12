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
    public partial class MDIParent : Form
    {
        //private int childFormNumber = 0;
        Form ActiveForm;
        public MDIParent()
        {
            InitializeComponent();
            
        }
        private void identificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                if (ActiveForm.GetType() == typeof(FormEau))
                    return;    
                ActiveForm.Close();
                createFormEau();
            }
            else
                createFormEau();
        }
        private void createFormEau()
        {
            ActiveForm = new FormEau
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            ActiveForm.FormClosed += new FormClosedEventHandler(ActiveFormNull);
            ActiveForm.Show();
        }
        private void ActiveFormNull(object sender, EventArgs e)
        {
            ActiveForm = null;
        }
    }
}
