namespace Facturation
{
    partial class FormElec
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerElec = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxTeli = new System.Windows.Forms.TextBox();
            this.textBoxNcompteur = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxPolice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dellete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRechNpo = new System.Windows.Forms.TextBox();
            this.textBoxRechRef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRechNcomp = new System.Windows.Forms.TextBox();
            this.textBoxRechAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridViewElec = new System.Windows.Forms.DataGridView();
            this.npolice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCompteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrsse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElec)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dateTimePickerElec);
            this.groupBox1.Controls.Add(this.comboBoxEtat);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.textBoxTeli);
            this.groupBox1.Controls.Add(this.textBoxNcompteur);
            this.groupBox1.Controls.Add(this.textBoxAdresse);
            this.groupBox1.Controls.Add(this.textBoxAnnee);
            this.groupBox1.Controls.Add(this.textBoxReference);
            this.groupBox1.Controls.Add(this.textBoxPolice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 341);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eléctricité";
            // 
            // dateTimePickerElec
            // 
            this.dateTimePickerElec.Location = new System.Drawing.Point(143, 236);
            this.dateTimePickerElec.Name = "dateTimePickerElec";
            this.dateTimePickerElec.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerElec.TabIndex = 47;
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Location = new System.Drawing.Point(143, 204);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(161, 21);
            this.comboBoxEtat.TabIndex = 46;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(143, 296);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxType.TabIndex = 46;
            // 
            // textBoxTeli
            // 
            this.textBoxTeli.Location = new System.Drawing.Point(143, 266);
            this.textBoxTeli.Name = "textBoxTeli";
            this.textBoxTeli.Size = new System.Drawing.Size(161, 20);
            this.textBoxTeli.TabIndex = 39;
            // 
            // textBoxNcompteur
            // 
            this.textBoxNcompteur.Location = new System.Drawing.Point(143, 174);
            this.textBoxNcompteur.Name = "textBoxNcompteur";
            this.textBoxNcompteur.Size = new System.Drawing.Size(161, 20);
            this.textBoxNcompteur.TabIndex = 42;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(143, 142);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(161, 20);
            this.textBoxAdresse.TabIndex = 43;
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(143, 110);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(161, 20);
            this.textBoxAnnee.TabIndex = 44;
            // 
            // textBoxReference
            // 
            this.textBoxReference.Location = new System.Drawing.Point(143, 80);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(161, 20);
            this.textBoxReference.TabIndex = 44;
            // 
            // textBoxPolice
            // 
            this.textBoxPolice.Location = new System.Drawing.Point(143, 49);
            this.textBoxPolice.Name = "textBoxPolice";
            this.textBoxPolice.Size = new System.Drawing.Size(161, 20);
            this.textBoxPolice.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tél :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Date :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Etat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Année :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "n° Compteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Reference :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 141);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(51, 13);
            this.label29.TabIndex = 37;
            this.label29.Text = "Adresse :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(19, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 38;
            this.label30.Text = "n° Police :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dellete);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Location = new System.Drawing.Point(12, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 69);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // dellete
            // 
            this.dellete.Location = new System.Drawing.Point(224, 17);
            this.dellete.Name = "dellete";
            this.dellete.Size = new System.Drawing.Size(75, 37);
            this.dellete.TabIndex = 4;
            this.dellete.Text = "Supprimer";
            this.dellete.UseVisualStyleBackColor = true;
            this.dellete.Click += new System.EventHandler(this.dellete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(125, 17);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 37);
            this.edit.TabIndex = 5;
            this.edit.Text = "Modifier";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(26, 17);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 37);
            this.add.TabIndex = 6;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxRechNpo);
            this.groupBox3.Controls.Add(this.textBoxRechRef);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxRechNcomp);
            this.groupBox3.Controls.Add(this.textBoxRechAdress);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(368, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 100);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "n° Police :";
            // 
            // textBoxRechNpo
            // 
            this.textBoxRechNpo.Location = new System.Drawing.Point(73, 19);
            this.textBoxRechNpo.Name = "textBoxRechNpo";
            this.textBoxRechNpo.Size = new System.Drawing.Size(143, 20);
            this.textBoxRechNpo.TabIndex = 20;
            // 
            // textBoxRechRef
            // 
            this.textBoxRechRef.Location = new System.Drawing.Point(71, 55);
            this.textBoxRechRef.Name = "textBoxRechRef";
            this.textBoxRechRef.Size = new System.Drawing.Size(145, 20);
            this.textBoxRechRef.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Reference :";
            // 
            // textBoxRechNcomp
            // 
            this.textBoxRechNcomp.Location = new System.Drawing.Point(303, 19);
            this.textBoxRechNcomp.Name = "textBoxRechNcomp";
            this.textBoxRechNcomp.Size = new System.Drawing.Size(163, 20);
            this.textBoxRechNcomp.TabIndex = 42;
            // 
            // textBoxRechAdress
            // 
            this.textBoxRechAdress.Location = new System.Drawing.Point(303, 52);
            this.textBoxRechAdress.Name = "textBoxRechAdress";
            this.textBoxRechAdress.Size = new System.Drawing.Size(163, 20);
            this.textBoxRechAdress.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "n° Compteur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adresse :";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(876, 39);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(101, 23);
            this.Search.TabIndex = 29;
            this.Search.Text = "Rechercher";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridViewElec
            // 
            this.dataGridViewElec.AllowUserToAddRows = false;
            this.dataGridViewElec.AllowUserToDeleteRows = false;
            this.dataGridViewElec.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewElec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.npolice,
            this.Reference,
            this.nCompteur,
            this.Type,
            this.etat,
            this.Annee,
            this.date,
            this.Tele,
            this.adrsse});
            this.dataGridViewElec.Location = new System.Drawing.Point(368, 138);
            this.dataGridViewElec.Name = "dataGridViewElec";
            this.dataGridViewElec.ReadOnly = true;
            this.dataGridViewElec.Size = new System.Drawing.Size(606, 341);
            this.dataGridViewElec.TabIndex = 28;
            this.dataGridViewElec.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewElec_CellMouseDoubleClick);
            // 
            // npolice
            // 
            this.npolice.HeaderText = "n° Police";
            this.npolice.Name = "npolice";
            this.npolice.ReadOnly = true;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // nCompteur
            // 
            this.nCompteur.HeaderText = "n°Compteur";
            this.nCompteur.Name = "nCompteur";
            this.nCompteur.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // etat
            // 
            this.etat.HeaderText = "Etat";
            this.etat.Name = "etat";
            this.etat.ReadOnly = true;
            // 
            // Annee
            // 
            this.Annee.HeaderText = "Année";
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Tele
            // 
            this.Tele.HeaderText = "Télèphone";
            this.Tele.Name = "Tele";
            this.Tele.ReadOnly = true;
            // 
            // adrsse
            // 
            this.adrsse.HeaderText = "Adresse";
            this.adrsse.Name = "adrsse";
            this.adrsse.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Afficher Tous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormElec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(989, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridViewElec);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormElec";
            this.Text = "FormElec";
            this.Load += new System.EventHandler(this.FormElec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxTeli;
        private System.Windows.Forms.TextBox textBoxNcompteur;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.TextBox textBoxPolice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePickerElec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dellete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRechNpo;
        private System.Windows.Forms.TextBox textBoxRechRef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRechNcomp;
        private System.Windows.Forms.TextBox textBoxRechAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridViewElec;
        private System.Windows.Forms.DataGridViewTextBoxColumn npolice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCompteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrsse;
        private System.Windows.Forms.Button button1;
    }
}