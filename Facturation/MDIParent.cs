﻿using System;
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
            lancerForm(new Acceuil());
        }
        private void identificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lancerForm(new FormEau());
        }
        private void lancerForm(Form form)
        {
            if (ActiveForm != null)
            {
                if (ActiveForm.GetType() == form.GetType())
                    return;
                ActiveForm = null;
                createNewForm(form);
            }
            else
                createNewForm(form);
        } 
        private void createNewForm(Form form)
        {
            ActiveForm = form;
            ActiveForm.MdiParent = this;
            ActiveForm.WindowState = FormWindowState.Maximized;
            ActiveForm.ControlBox = false;
            Width = form.Width;
            Height = form.Height;
            ActiveForm.Show();
        }

        private void identificationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lancerForm(new FormTelecommunication());
        }

        private void identificationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lancerForm(new FormElec());
        }
        private void relevéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // lancerReleve("Relevé de l'Eau", new ReleveEau());
            lancerForm(new FormReleveEau());
        }
        private void releveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  lancerReleve("Relevé de l'Electricité", new ReleveEau());
            lancerForm(new FormReleveElec());
        }
        private void relevéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lancerForm(new FormRelveeTele());
        }
        private void paiementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lancerForm(new FormPaiement());
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lancerForm(new Acceuil());
        }
    }
}
