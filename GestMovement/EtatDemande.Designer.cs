namespace GestMovement
{
    partial class EtatDemande
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BTN_Afficher = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_IdDemande = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 65);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(819, 464);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BTN_Afficher
            // 
            this.BTN_Afficher.Location = new System.Drawing.Point(508, 11);
            this.BTN_Afficher.Name = "BTN_Afficher";
            this.BTN_Afficher.Size = new System.Drawing.Size(75, 23);
            this.BTN_Afficher.TabIndex = 7;
            this.BTN_Afficher.Text = "Afficher";
            this.BTN_Afficher.UseVisualStyleBackColor = true;
            this.BTN_Afficher.Click += new System.EventHandler(this.BTN_Afficher_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Id Demande";
            // 
            // CB_IdDemande
            // 
            this.CB_IdDemande.FormattingEnabled = true;
            this.CB_IdDemande.Location = new System.Drawing.Point(284, 11);
            this.CB_IdDemande.Name = "CB_IdDemande";
            this.CB_IdDemande.Size = new System.Drawing.Size(179, 21);
            this.CB_IdDemande.TabIndex = 5;
            // 
            // EtatDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 529);
            this.Controls.Add(this.BTN_Afficher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CB_IdDemande);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "EtatDemande";
            this.Text = "EtatDemande";
            this.Load += new System.EventHandler(this.EtatDemande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button BTN_Afficher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_IdDemande;
    }
}