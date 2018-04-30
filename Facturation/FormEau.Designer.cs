namespace Facturation
{
    partial class FormEau
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
            this.Search = new System.Windows.Forms.Button();
            this.textBoxRechNpo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.del = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEau = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxNCompt = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxAnnee = new System.Windows.Forms.TextBox();
            this.textBoxRef = new System.Windows.Forms.TextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRechRef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRechNcomp = new System.Windows.Forms.TextBox();
            this.textBoxRechAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewEau = new System.Windows.Forms.DataGridView();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEau)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(870, 46);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(101, 23);
            this.Search.TabIndex = 21;
            this.Search.Text = "Rechercher";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBoxRechNpo
            // 
            this.textBoxRechNpo.Location = new System.Drawing.Point(73, 19);
            this.textBoxRechNpo.Name = "textBoxRechNpo";
            this.textBoxRechNpo.Size = new System.Drawing.Size(143, 20);
            this.textBoxRechNpo.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.del);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Location = new System.Drawing.Point(9, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 69);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(212, 19);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 37);
            this.del.TabIndex = 4;
            this.del.Text = "Supprimer";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(113, 19);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 37);
            this.edit.TabIndex = 5;
            this.edit.Text = "Modifier";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(14, 19);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 37);
            this.add.TabIndex = 6;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBoxEtat);
            this.groupBox1.Controls.Add(this.dateTimePickerEau);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.textBoxTel);
            this.groupBox1.Controls.Add(this.textBoxNCompt);
            this.groupBox1.Controls.Add(this.textBoxAdresse);
            this.groupBox1.Controls.Add(this.textBoxAnnee);
            this.groupBox1.Controls.Add(this.textBoxRef);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 341);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eau";
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Location = new System.Drawing.Point(142, 205);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(162, 21);
            this.comboBoxEtat.TabIndex = 48;
            // 
            // dateTimePickerEau
            // 
            this.dateTimePickerEau.Location = new System.Drawing.Point(142, 237);
            this.dateTimePickerEau.Name = "dateTimePickerEau";
            this.dateTimePickerEau.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerEau.TabIndex = 47;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(142, 296);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(162, 21);
            this.comboBoxType.TabIndex = 46;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(142, 266);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(162, 20);
            this.textBoxTel.TabIndex = 39;
            // 
            // textBoxNCompt
            // 
            this.textBoxNCompt.Location = new System.Drawing.Point(142, 174);
            this.textBoxNCompt.Name = "textBoxNCompt";
            this.textBoxNCompt.Size = new System.Drawing.Size(162, 20);
            this.textBoxNCompt.TabIndex = 42;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(142, 142);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(162, 20);
            this.textBoxAdresse.TabIndex = 43;
            // 
            // textBoxAnnee
            // 
            this.textBoxAnnee.Location = new System.Drawing.Point(142, 110);
            this.textBoxAnnee.Name = "textBoxAnnee";
            this.textBoxAnnee.Size = new System.Drawing.Size(162, 20);
            this.textBoxAnnee.TabIndex = 44;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(142, 80);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(162, 20);
            this.textBoxRef.TabIndex = 44;
            // 
            // textBoxPolice
            // 
            this.textBoxPolice.Location = new System.Drawing.Point(142, 49);
            this.textBoxPolice.Name = "textBoxPolice";
            this.textBoxPolice.Size = new System.Drawing.Size(162, 20);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxRechNpo);
            this.groupBox3.Controls.Add(this.textBoxRechRef);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxRechNcomp);
            this.groupBox3.Controls.Add(this.textBoxRechAdress);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(362, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 100);
            this.groupBox3.TabIndex = 22;
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
            this.textBoxRechNcomp.Location = new System.Drawing.Point(300, 19);
            this.textBoxRechNcomp.Name = "textBoxRechNcomp";
            this.textBoxRechNcomp.Size = new System.Drawing.Size(163, 20);
            this.textBoxRechNcomp.TabIndex = 42;
            // 
            // textBoxRechAdress
            // 
            this.textBoxRechAdress.Location = new System.Drawing.Point(300, 54);
            this.textBoxRechAdress.Name = "textBoxRechAdress";
            this.textBoxRechAdress.Size = new System.Drawing.Size(163, 20);
            this.textBoxRechAdress.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "n° Compteur :";
            // 
            // dataGridViewEau
            // 
            this.dataGridViewEau.AllowUserToAddRows = false;
            this.dataGridViewEau.AllowUserToDeleteRows = false;
            this.dataGridViewEau.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.npolice,
            this.Reference,
            this.nCompteur,
            this.Type,
            this.etat,
            this.Annee,
            this.date,
            this.Tele,
            this.adrsse});
            this.dataGridViewEau.Location = new System.Drawing.Point(362, 144);
            this.dataGridViewEau.Name = "dataGridViewEau";
            this.dataGridViewEau.ReadOnly = true;
            this.dataGridViewEau.Size = new System.Drawing.Size(606, 341);
            this.dataGridViewEau.TabIndex = 29;
            this.dataGridViewEau.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEau_CellDoubleClick);
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
            this.button1.Location = new System.Drawing.Point(870, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Afficher Tous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEau);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEau";
            this.Text = "L\'Eau";
            this.Load += new System.EventHandler(this.FormEau_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBoxRechNpo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxNCompt;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPolice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxAnnee;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEau;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRechRef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRechNcomp;
        private System.Windows.Forms.TextBox textBoxRechAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewEau;
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