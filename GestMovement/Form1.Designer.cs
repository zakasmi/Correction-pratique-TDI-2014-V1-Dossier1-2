namespace GestMovement
{
    partial class Menu
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
            this.BTN_MAJProf = new System.Windows.Forms.Button();
            this.BTN_ConsultProf = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_MAJProf
            // 
            this.BTN_MAJProf.Location = new System.Drawing.Point(137, 92);
            this.BTN_MAJProf.Name = "BTN_MAJProf";
            this.BTN_MAJProf.Size = new System.Drawing.Size(143, 51);
            this.BTN_MAJProf.TabIndex = 0;
            this.BTN_MAJProf.Text = "Q2 MAJ Professeur";
            this.BTN_MAJProf.UseVisualStyleBackColor = true;
            this.BTN_MAJProf.Click += new System.EventHandler(this.BTN_MAJProf_Click);
            // 
            // BTN_ConsultProf
            // 
            this.BTN_ConsultProf.Location = new System.Drawing.Point(323, 92);
            this.BTN_ConsultProf.Name = "BTN_ConsultProf";
            this.BTN_ConsultProf.Size = new System.Drawing.Size(145, 51);
            this.BTN_ConsultProf.TabIndex = 0;
            this.BTN_ConsultProf.Text = "Q3 Consultation Prof";
            this.BTN_ConsultProf.UseVisualStyleBackColor = true;
            this.BTN_ConsultProf.Click += new System.EventHandler(this.BTN_ConsultProf_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 51);
            this.button3.TabIndex = 0;
            this.button3.Text = "Q4 Afficher 10 Lycee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Q6 Etat Demande ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Q7  Etat Graphique";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_ConsultProf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_MAJProf);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_MAJProf;
        private System.Windows.Forms.Button BTN_ConsultProf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

