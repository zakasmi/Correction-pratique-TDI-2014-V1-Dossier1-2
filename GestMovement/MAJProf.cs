using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestMovement
{
    public partial class MAJProf : Form
    {
        public MAJProf()
        {
            InitializeComponent();
        }
        int Pos = 0;
        private void MAJProf_Load(object sender, EventArgs e)
        {
            try
            {
                //Lycee
                if (Provider.ds.Tables.Contains("Lycee")) { Provider.ds.Tables["Lycee"].Rows.Clear(); }
                using (SqlDataAdapter da = new SqlDataAdapter("select * from Lycee", Provider.cnx))
                {
                    da.Fill(Provider.ds,"Lycee");
                }
                    CB_IdLycee.DataSource = Provider.ds.Tables["Lycee"];
                CB_IdLycee.DisplayMember = Provider.ds.Tables["Lycee"].Columns[1].ColumnName;
                CB_IdLycee.ValueMember = Provider.ds.Tables["Lycee"].Columns[0].ColumnName;
                // Professeur
                if (Provider.ds.Tables.Contains("Professeur")) { Provider.ds.Tables["Professeur"].Rows.Clear(); }
                using (SqlDataAdapter da = new SqlDataAdapter("select * from Professeur", Provider.cnx))
                {
                    da.Fill(Provider.ds, "Professeur");

                    Provider.ds.Tables["Professeur"].PrimaryKey = new DataColumn[] { Provider.ds.Tables["Professeur"].Columns[0] };
                }

                BTN_Debut_Click(sender,e);
            }
            catch (Exception)
            {

            }
        }

        public  void Navig(int x)
        {
            if (Provider.ds.Tables["Professeur"].Rows[x].RowState != DataRowState.Deleted)
            {
                DataRow dr = Provider.ds.Tables["Professeur"].Rows[x];
                TB_IdProfesseur.Text = dr[0].ToString();
                TB_Nom.Text = dr[1].ToString();
                TB_Prenom.Text = dr[2].ToString();
                DTP_DateN.Value = DateTime.Parse(dr[3].ToString());
                TB_Email.Text = dr[4].ToString();
                TB_Pass.Text = dr[5].ToString();
                DTP_DateAffLycee.Value = DateTime.Parse(dr[6].ToString());
                CB_EtatCivil.SelectedItem = dr[7].ToString();
                TB_NEnfant.Text = dr[8].ToString();
                CB_IdLycee.SelectedValue = dr[9].ToString();

            }

        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Professeur"].Rows.Count;
            if (count > 0)
            {
                Pos = 0;
                Navig(0);

            }
            else { MessageBox.Show("Table Vide"); }
        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Professeur"].Rows.Count;
            if (count > 0)
            {
                Pos = count - 1;
                Navig(Pos);

            }
        }

        private void BTN_Suiv_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Professeur"].Rows.Count;
            if (count > 0 && Pos < count-1)
            {
                Pos++;
                Navig(Pos);

            }
        }

        private void BTN_Prec_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Professeur"].Rows.Count;
            if (count > 0 && Pos > 0)
            {
                Pos--;
                Navig(Pos);

            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TB_IdProfesseur.Text))
                {
                    DataRow dr = Provider.ds.Tables["Professeur"].NewRow();
                    dr[0] = TB_IdProfesseur.Text;
                    dr[1] = TB_Nom.Text;
                    dr[2] = TB_Prenom.Text;
                    dr[3] = DTP_DateN.Value;
                    dr[4] = TB_Email.Text;
                    dr[5] = TB_Pass.Text;
                    dr[6] = DTP_DateAffLycee.Value;
                    dr[7] = CB_EtatCivil.SelectedItem;
                    dr[8] = TB_NEnfant.Text;
                    dr[9] = CB_IdLycee.SelectedValue;
                    
                    Provider.ds.Tables["Professeur"].Rows.Add(dr);
                    if (Provider.UpdateProf())
                    {
                        MessageBox.Show("Professseur ajouté avec seucce");
                    }
                    else
                    {
                        MessageBox.Show("Professseur n'est pas Ajouté");
                    }
                }
                else
                {
                    MessageBox.Show("Saisie Id Professseur");

                }
        }
            catch (Exception e2)
            {
               
        MessageBox.Show(e2.Message);
    }


}

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(TB_IdProfesseur.Text))
                {
                    DataRow dr = Provider.ds.Tables["Professeur"].Rows.Find(TB_IdProfesseur.Text);
                    dr[0] = TB_IdProfesseur.Text;
                    dr[1] = TB_Nom.Text;
                    dr[2] = TB_Prenom.Text;
                    dr[3] = DTP_DateN.Value;
                    dr[4] = TB_Email.Text;
                    dr[5] = TB_Pass.Text;
                    dr[6] = DTP_DateAffLycee.Value;
                    dr[7] = CB_EtatCivil.SelectedItem;
                    dr[8] = TB_NEnfant.Text;
                    dr[9] = CB_IdLycee.SelectedValue;

                    if (Provider.UpdateProf())
                    {
                        MessageBox.Show("Professseur Modifier avec seucce");
                    }
                    else
                    {
                        MessageBox.Show("Professseur n'est pas Modifier");

                    }
                }
                else
                {
                    MessageBox.Show("Saisie Id Professseur");

                }
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message);
            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(TB_IdProfesseur.Text))
                {
                   Provider.ds.Tables["Professeur"].Rows.Find(TB_IdProfesseur.Text).Delete();

                    if (Provider.UpdateProf())
                    {
                        MessageBox.Show("Professseur Supprimé avec seucce");
                    }
                    else
                    {
                        MessageBox.Show("Professseur n'est pas  Supprimeé");

                    }
                }
                else
                {
                    MessageBox.Show("Saisie Id Professseur");

                }
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message);
            }
        }

        private void CB_EtatCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_EtatCivil.SelectedIndex == 0)
            {
                TB_NEnfant.Enabled = false;
            }else TB_NEnfant.Enabled = true;
        }
    }
}
