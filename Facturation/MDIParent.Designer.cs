namespace Facturation
{
    partial class MDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relevéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.releveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.télécommunicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relevéToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eauToolStripMenuItem,
            this.electricitéToolStripMenuItem,
            this.télécommunicationToolStripMenuItem,
            this.paiementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eauToolStripMenuItem
            // 
            this.eauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificationToolStripMenuItem,
            this.relevéToolStripMenuItem});
            this.eauToolStripMenuItem.Name = "eauToolStripMenuItem";
            this.eauToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.eauToolStripMenuItem.Text = "Eau";
            // 
            // identificationToolStripMenuItem
            // 
            this.identificationToolStripMenuItem.Name = "identificationToolStripMenuItem";
            this.identificationToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.identificationToolStripMenuItem.Text = "Identification";
            this.identificationToolStripMenuItem.Click += new System.EventHandler(this.identificationToolStripMenuItem_Click);
            // 
            // relevéToolStripMenuItem
            // 
            this.relevéToolStripMenuItem.Name = "relevéToolStripMenuItem";
            this.relevéToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.relevéToolStripMenuItem.Text = "Relevé";
            // 
            // electricitéToolStripMenuItem
            // 
            this.electricitéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificationToolStripMenuItem1,
            this.releveToolStripMenuItem});
            this.electricitéToolStripMenuItem.Name = "electricitéToolStripMenuItem";
            this.electricitéToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.electricitéToolStripMenuItem.Text = "Electricité";
            // 
            // identificationToolStripMenuItem1
            // 
            this.identificationToolStripMenuItem1.Name = "identificationToolStripMenuItem1";
            this.identificationToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.identificationToolStripMenuItem1.Text = "Identification";
            // 
            // releveToolStripMenuItem
            // 
            this.releveToolStripMenuItem.Name = "releveToolStripMenuItem";
            this.releveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.releveToolStripMenuItem.Text = "Releve";
            // 
            // télécommunicationToolStripMenuItem
            // 
            this.télécommunicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificationToolStripMenuItem2,
            this.relevéToolStripMenuItem1});
            this.télécommunicationToolStripMenuItem.Name = "télécommunicationToolStripMenuItem";
            this.télécommunicationToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.télécommunicationToolStripMenuItem.Text = "Télécommunication";
            // 
            // identificationToolStripMenuItem2
            // 
            this.identificationToolStripMenuItem2.Name = "identificationToolStripMenuItem2";
            this.identificationToolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.identificationToolStripMenuItem2.Text = "Identification";
            // 
            // relevéToolStripMenuItem1
            // 
            this.relevéToolStripMenuItem1.Name = "relevéToolStripMenuItem1";
            this.relevéToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.relevéToolStripMenuItem1.Text = "Relevé";
            // 
            // paiementToolStripMenuItem
            // 
            this.paiementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paiementToolStripMenuItem1});
            this.paiementToolStripMenuItem.Name = "paiementToolStripMenuItem";
            this.paiementToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.paiementToolStripMenuItem.Text = "Paiement";
            // 
            // paiementToolStripMenuItem1
            // 
            this.paiementToolStripMenuItem1.Name = "paiementToolStripMenuItem1";
            this.paiementToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.paiementToolStripMenuItem1.Text = "Paiement";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 535);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relevéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem télécommunicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relevéToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem1;
    }
}



