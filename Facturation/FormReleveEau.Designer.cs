namespace Facturation
{
    partial class FormReleveEau
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
            this.annuler = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Npolice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consommation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNetPayer = new System.Windows.Forms.TextBox();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.textBoxConsommation = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxNCompt = new System.Windows.Forms.TextBox();
            this.textBoxPrevIndex = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNpolice = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(236, 510);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 25);
            this.annuler.TabIndex = 56;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(147, 510);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 25);
            this.confirm.TabIndex = 56;
            this.confirm.Text = "Confirmer";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Npolice,
            this.adresse,
            this.annee,
            this.trim,
            this.IndexNew,
            this.IndexPrev,
            this.consommation,
            this.netpay,
            this.rapport});
            this.dataGridView1.Location = new System.Drawing.Point(354, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(946, 428);
            this.dataGridView1.TabIndex = 58;
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
            // annee
            // 
            this.annee.HeaderText = "Année";
            this.annee.Name = "annee";
            this.annee.ReadOnly = true;
            // 
            // trim
            // 
            this.trim.HeaderText = "Trimméstre";
            this.trim.Name = "trim";
            this.trim.ReadOnly = true;
            // 
            // IndexNew
            // 
            this.IndexNew.HeaderText = "Nouveau Index";
            this.IndexNew.Name = "IndexNew";
            this.IndexNew.ReadOnly = true;
            // 
            // IndexPrev
            // 
            this.IndexPrev.HeaderText = "Index Précédent";
            this.IndexPrev.Name = "IndexPrev";
            this.IndexPrev.ReadOnly = true;
            // 
            // consommation
            // 
            this.consommation.HeaderText = "Consommation";
            this.consommation.Name = "consommation";
            this.consommation.ReadOnly = true;
            // 
            // netpay
            // 
            this.netpay.DataPropertyName = "netPayer";
            this.netpay.HeaderText = "Net à Payer";
            this.netpay.Name = "netpay";
            this.netpay.ReadOnly = true;
            // 
            // rapport
            // 
            this.rapport.HeaderText = "Rapport";
            this.rapport.Name = "rapport";
            this.rapport.ReadOnly = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(581, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(141, 24);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "Relevé de l\'eau";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Autorisé :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Facturation.Properties.Resources.go;
            this.pictureBox1.Location = new System.Drawing.Point(267, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(135, 337);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Consommation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Net à Payer :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Motif :";
            this.label8.Visible = false;
            // 
            // textBoxNetPayer
            // 
            this.textBoxNetPayer.Location = new System.Drawing.Point(135, 291);
            this.textBoxNetPayer.Name = "textBoxNetPayer";
            this.textBoxNetPayer.Size = new System.Drawing.Size(164, 20);
            this.textBoxNetPayer.TabIndex = 51;
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.Location = new System.Drawing.Point(133, 372);
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(164, 20);
            this.textBoxMotif.TabIndex = 51;
            this.textBoxMotif.Visible = false;
            // 
            // textBoxConsommation
            // 
            this.textBoxConsommation.Location = new System.Drawing.Point(135, 263);
            this.textBoxConsommation.Name = "textBoxConsommation";
            this.textBoxConsommation.Size = new System.Drawing.Size(164, 20);
            this.textBoxConsommation.TabIndex = 49;
            this.textBoxConsommation.TextChanged += new System.EventHandler(this.textBoxConsommation_TextChanged);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(147, 242);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDate.TabIndex = 75;
            // 
            // textBoxNCompt
            // 
            this.textBoxNCompt.Location = new System.Drawing.Point(147, 157);
            this.textBoxNCompt.Name = "textBoxNCompt";
            this.textBoxNCompt.Size = new System.Drawing.Size(164, 20);
            this.textBoxNCompt.TabIndex = 69;
            // 
            // textBoxPrevIndex
            // 
            this.textBoxPrevIndex.Location = new System.Drawing.Point(147, 298);
            this.textBoxPrevIndex.Name = "textBoxPrevIndex";
            this.textBoxPrevIndex.Size = new System.Drawing.Size(164, 20);
            this.textBoxPrevIndex.TabIndex = 70;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(147, 129);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(164, 20);
            this.textBoxAdress.TabIndex = 71;
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(147, 185);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(164, 20);
            this.textBoxAnnee.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Index Précédent :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Nouvel Index :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Date :";
            // 
            // textBoxNewIndex
            // 
            this.textBoxNewIndex.Location = new System.Drawing.Point(147, 270);
            this.textBoxNewIndex.Name = "textBoxNewIndex";
            this.textBoxNewIndex.Size = new System.Drawing.Size(164, 20);
            this.textBoxNewIndex.TabIndex = 73;
            this.textBoxNewIndex.TextChanged += new System.EventHandler(this.textBoxNewIndex_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Trimèstre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Année :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "n° Compteur :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(26, 130);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 62;
            this.label29.Text = "Adresse :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBoxNpolice);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxNetPayer);
            this.groupBox1.Controls.Add(this.textBoxMotif);
            this.groupBox1.Controls.Add(this.textBoxConsommation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 419);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Données";
            // 
            // comboBoxNpolice
            // 
            this.comboBoxNpolice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNpolice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNpolice.FormattingEnabled = true;
            this.comboBoxNpolice.Location = new System.Drawing.Point(135, 26);
            this.comboBoxNpolice.Name = "comboBoxNpolice";
            this.comboBoxNpolice.Size = new System.Drawing.Size(164, 21);
            this.comboBoxNpolice.TabIndex = 52;
            this.comboBoxNpolice.SelectedIndexChanged += new System.EventHandler(this.comboBoxNpolice_SelectedIndexChanged);
            this.comboBoxNpolice.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNpolice_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "n° Police :";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxTrimestre.Location = new System.Drawing.Point(147, 213);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(164, 21);
            this.comboBoxTrimestre.TabIndex = 74;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(26, 103);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 68;
            this.label30.Text = "n° Police :";
            // 
            // FormReleveEau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 582);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxNCompt);
            this.Controls.Add(this.textBoxPrevIndex);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxAnnee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.comboBoxTrimestre);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReleveEau";
            this.Text = "ReleveEauOuElec";
            this.Load += new System.EventHandler(this.ReleveEauOuElec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Npolice;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn trim;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn consommation;
        private System.Windows.Forms.DataGridViewTextBoxColumn netpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNetPayer;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.TextBox textBoxConsommation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxNCompt;
        private System.Windows.Forms.TextBox textBoxPrevIndex;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNpolice;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label10;
    }
}