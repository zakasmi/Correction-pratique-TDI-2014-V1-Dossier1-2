namespace GestMovement
{
    partial class MAJProf
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
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.CB_EtatCivil = new System.Windows.Forms.ComboBox();
            this.CB_IdLycee = new System.Windows.Forms.ComboBox();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_Prec = new System.Windows.Forms.Button();
            this.BTN_Suiv = new System.Windows.Forms.Button();
            this.BTN_Fin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_IdProfesseur = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.TB_NEnfant = new System.Windows.Forms.TextBox();
            this.DTP_DateN = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateAffLycee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(207, 306);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(85, 31);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(309, 306);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(85, 31);
            this.BTN_Modifier.TabIndex = 0;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(412, 306);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(85, 31);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // CB_EtatCivil
            // 
            this.CB_EtatCivil.FormattingEnabled = true;
            this.CB_EtatCivil.Items.AddRange(new object[] {
            "Celibataire",
            "Marie",
            "Divorce",
            "Veuf"});
            this.CB_EtatCivil.Location = new System.Drawing.Point(497, 130);
            this.CB_EtatCivil.Name = "CB_EtatCivil";
            this.CB_EtatCivil.Size = new System.Drawing.Size(142, 21);
            this.CB_EtatCivil.TabIndex = 1;
            this.CB_EtatCivil.SelectedIndexChanged += new System.EventHandler(this.CB_EtatCivil_SelectedIndexChanged);
            // 
            // CB_IdLycee
            // 
            this.CB_IdLycee.FormattingEnabled = true;
            this.CB_IdLycee.Location = new System.Drawing.Point(497, 220);
            this.CB_IdLycee.Name = "CB_IdLycee";
            this.CB_IdLycee.Size = new System.Drawing.Size(142, 21);
            this.CB_IdLycee.TabIndex = 1;
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(174, 374);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(64, 27);
            this.BTN_Debut.TabIndex = 0;
            this.BTN_Debut.Text = "<<";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_Prec
            // 
            this.BTN_Prec.Location = new System.Drawing.Point(276, 374);
            this.BTN_Prec.Name = "BTN_Prec";
            this.BTN_Prec.Size = new System.Drawing.Size(64, 27);
            this.BTN_Prec.TabIndex = 0;
            this.BTN_Prec.Text = "<";
            this.BTN_Prec.UseVisualStyleBackColor = true;
            this.BTN_Prec.Click += new System.EventHandler(this.BTN_Prec_Click);
            // 
            // BTN_Suiv
            // 
            this.BTN_Suiv.Location = new System.Drawing.Point(379, 374);
            this.BTN_Suiv.Name = "BTN_Suiv";
            this.BTN_Suiv.Size = new System.Drawing.Size(64, 27);
            this.BTN_Suiv.TabIndex = 0;
            this.BTN_Suiv.Text = ">";
            this.BTN_Suiv.UseVisualStyleBackColor = true;
            this.BTN_Suiv.Click += new System.EventHandler(this.BTN_Suiv_Click);
            // 
            // BTN_Fin
            // 
            this.BTN_Fin.Location = new System.Drawing.Point(476, 374);
            this.BTN_Fin.Name = "BTN_Fin";
            this.BTN_Fin.Size = new System.Drawing.Size(64, 27);
            this.BTN_Fin.TabIndex = 0;
            this.BTN_Fin.Text = ">>";
            this.BTN_Fin.UseVisualStyleBackColor = true;
            this.BTN_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IdProfesseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "DateN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "DateAffLycee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "EtatCivil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "NEnfant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "IdLycee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email";
            // 
            // TB_IdProfesseur
            // 
            this.TB_IdProfesseur.Location = new System.Drawing.Point(127, 43);
            this.TB_IdProfesseur.Name = "TB_IdProfesseur";
            this.TB_IdProfesseur.Size = new System.Drawing.Size(119, 20);
            this.TB_IdProfesseur.TabIndex = 3;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(127, 85);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(119, 20);
            this.TB_Nom.TabIndex = 3;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(127, 133);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(119, 20);
            this.TB_Prenom.TabIndex = 3;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(127, 216);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(119, 20);
            this.TB_Email.TabIndex = 3;
            // 
            // TB_Pass
            // 
            this.TB_Pass.Location = new System.Drawing.Point(497, 43);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(121, 20);
            this.TB_Pass.TabIndex = 3;
            // 
            // TB_NEnfant
            // 
            this.TB_NEnfant.Location = new System.Drawing.Point(497, 175);
            this.TB_NEnfant.Name = "TB_NEnfant";
            this.TB_NEnfant.Size = new System.Drawing.Size(121, 20);
            this.TB_NEnfant.TabIndex = 3;
            // 
            // DTP_DateN
            // 
            this.DTP_DateN.CustomFormat = "dd/MM/yyyy";
            this.DTP_DateN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DateN.Location = new System.Drawing.Point(127, 178);
            this.DTP_DateN.Name = "DTP_DateN";
            this.DTP_DateN.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateN.TabIndex = 4;
            // 
            // DTP_DateAffLycee
            // 
            this.DTP_DateAffLycee.CustomFormat = "dd/MM/yyyy";
            this.DTP_DateAffLycee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DateAffLycee.Location = new System.Drawing.Point(497, 81);
            this.DTP_DateAffLycee.Name = "DTP_DateAffLycee";
            this.DTP_DateAffLycee.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateAffLycee.TabIndex = 4;
            // 
            // MAJProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 468);
            this.Controls.Add(this.DTP_DateAffLycee);
            this.Controls.Add(this.DTP_DateN);
            this.Controls.Add(this.TB_NEnfant);
            this.Controls.Add(this.TB_Pass);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.TB_IdProfesseur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_IdLycee);
            this.Controls.Add(this.CB_EtatCivil);
            this.Controls.Add(this.BTN_Fin);
            this.Controls.Add(this.BTN_Suiv);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Prec);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Ajouter);
            this.Name = "MAJProf";
            this.Text = "MAJProf";
            this.Load += new System.EventHandler(this.MAJProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.ComboBox CB_EtatCivil;
        private System.Windows.Forms.ComboBox CB_IdLycee;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_Prec;
        private System.Windows.Forms.Button BTN_Suiv;
        private System.Windows.Forms.Button BTN_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_IdProfesseur;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.TextBox TB_NEnfant;
        private System.Windows.Forms.DateTimePicker DTP_DateN;
        private System.Windows.Forms.DateTimePicker DTP_DateAffLycee;
    }
}