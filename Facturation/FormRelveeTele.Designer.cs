﻿namespace Facturation
{
    partial class FormRelveeTele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Npolice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirm = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMois = new System.Windows.Forms.ComboBox();
            this.textBoxMD = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.textBoxNetPayer = new System.Windows.Forms.TextBox();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPolice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Npolice,
            this.adresse,
            this.Column1,
            this.rapport});
            this.dataGridView1.Location = new System.Drawing.Point(377, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 428);
            this.dataGridView1.TabIndex = 86;
            // 
            // Npolice
            // 
            this.Npolice.HeaderText = "N° Police";
            this.Npolice.Name = "Npolice";
            this.Npolice.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "netPayer";
            this.Column1.HeaderText = "Net à Payer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // rapport
            // 
            this.rapport.HeaderText = "Rapport";
            this.rapport.Name = "rapport";
            this.rapport.ReadOnly = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(159, 504);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 25);
            this.confirm.TabIndex = 85;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(248, 504);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 25);
            this.annuler.TabIndex = 84;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(159, 251);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDate.TabIndex = 83;
            // 
            // comboBoxMois
            // 
            this.comboBoxMois.FormattingEnabled = true;
            this.comboBoxMois.Location = new System.Drawing.Point(159, 222);
            this.comboBoxMois.Name = "comboBoxMois";
            this.comboBoxMois.Size = new System.Drawing.Size(164, 21);
            this.comboBoxMois.TabIndex = 82;
            // 
            // textBoxMD
            // 
            this.textBoxMD.Location = new System.Drawing.Point(159, 166);
            this.textBoxMD.Name = "textBoxMD";
            this.textBoxMD.Size = new System.Drawing.Size(164, 20);
            this.textBoxMD.TabIndex = 73;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(159, 138);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(164, 20);
            this.textBoxAdress.TabIndex = 75;
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.Enabled = false;
            this.textBoxMotif.Location = new System.Drawing.Point(159, 452);
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(164, 20);
            this.textBoxMotif.TabIndex = 77;
            this.textBoxMotif.Visible = false;
            // 
            // textBoxNetPayer
            // 
            this.textBoxNetPayer.Location = new System.Drawing.Point(135, 196);
            this.textBoxNetPayer.Name = "textBoxNetPayer";
            this.textBoxNetPayer.Size = new System.Drawing.Size(164, 20);
            this.textBoxNetPayer.TabIndex = 78;
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(159, 194);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(164, 20);
            this.textBoxAnnee.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Motif :";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Net à Payer :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mois :";
            // 
            // textBoxPolice
            // 
            this.textBoxPolice.Location = new System.Drawing.Point(159, 110);
            this.textBoxPolice.Name = "textBoxPolice";
            this.textBoxPolice.Size = new System.Drawing.Size(164, 20);
            this.textBoxPolice.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Année :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "MD :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(38, 139);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 62;
            this.label29.Text = "Adresse :";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(287, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(268, 24);
            this.labelTitle.TabIndex = 72;
            this.labelTitle.Text = "Relevé de Telecommunication";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(38, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 71;
            this.label30.Text = "n° Police :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNetPayer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 329);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Données";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Facturation.Properties.Resources.go;
            this.pictureBox1.Location = new System.Drawing.Point(293, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormRelveeTele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.comboBoxMois);
            this.Controls.Add(this.textBoxMD);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxMotif);
            this.Controls.Add(this.textBoxAnnee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPolice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelveeTele";
            this.Text = "RelveeTele";
            this.Load += new System.EventHandler(this.RelveeTele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Npolice;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapport;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxMois;
        private System.Windows.Forms.TextBox textBoxMD;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.TextBox textBoxNetPayer;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPolice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}