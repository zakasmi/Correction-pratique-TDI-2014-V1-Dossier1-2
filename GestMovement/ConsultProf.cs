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
    public partial class ConsultProf : Form
    {
        public ConsultProf()
        {
            InitializeComponent();
        }

        private void ConsultProf_Load(object sender, EventArgs e)
        {
            //Lycee
            if (Provider.ds.Tables.Contains("Lycee")) { Provider.ds.Tables["Lycee"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter("select * from Lycee", Provider.cnx))
            {
                da.Fill(Provider.ds, "Lycee");
            }
            CB_IdLycee.DataSource = Provider.ds.Tables["Lycee"];
            CB_IdLycee.DisplayMember = Provider.ds.Tables["Lycee"].Columns[1].ColumnName;
            CB_IdLycee.ValueMember = Provider.ds.Tables["Lycee"].Columns[0].ColumnName;

        }

        private void CB_IdLycee_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            if (Provider.ds.Tables.Contains("ProfByVille")) { Provider.ds.Tables["ProfByVille"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter("  select P.IdProfesseur,P.Nom, P.Prenom from Professeur P where '"+CB_IdLycee.SelectedValue.ToString()+"' in (SELECT Lycee.IdLycee  FROM         dbo.Detail_Demande INNER JOIN  dbo.Demande ON dbo.Detail_Demande.IdDemande = dbo.Demande.IdDemande INNER JOIN dbo.Lycee ON dbo.Detail_Demande.IdLycee = dbo.Lycee.IdLycee where Demande.IdProfesseur = P.IdProfesseur)", Provider.cnx))
            {
                da.Fill(Provider.ds, "ProfByVille");
                dataGridView1.DataSource = Provider.ds.Tables["ProfByVille"];
            }
   
        }
    }
}
