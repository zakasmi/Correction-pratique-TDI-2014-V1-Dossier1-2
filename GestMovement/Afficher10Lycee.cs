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
    public partial class Afficher10Lycee : Form
    {
        public Afficher10Lycee()
        {
            InitializeComponent();
        }

     

        private void Afficher10Lycee_Load(object sender, EventArgs e)
        {
            //Lycee
            if (Provider.ds.Tables.Contains("Academie")) { Provider.ds.Tables["Academie"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter("select * from Academie", Provider.cnx))
            {
                da.Fill(Provider.ds, "Academie");
            }
            CB_Academie.DataSource = Provider.ds.Tables["Academie"];
            CB_Academie.DisplayMember = Provider.ds.Tables["Academie"].Columns[1].ColumnName;
            CB_Academie.ValueMember = Provider.ds.Tables["Academie"].Columns[0].ColumnName;
        }
        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            if (Provider.ds.Tables.Contains("TopVille")) { Provider.ds.Tables["TopVille"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter(" SELECT Top 10   Lycee.*, count(Lycee.IdLycee) as [Nombre Mutation]FROM         dbo.Detail_Demande INNER JOIN   dbo.Lycee ON dbo.Detail_Demande.IdLycee = dbo.Lycee.IdLycee INNER JOIN dbo.Academie ON dbo.Lycee.IdAcademie = dbo.Academie.IdAcademie where dbo.Academie.IdAcademie = '"+ CB_Academie.SelectedValue.ToString()+ "' and  Detail_Demande.NumOrdre = 1 group by  dbo.Lycee.IdLycee, dbo.Lycee.NomLycee, dbo.Lycee.Ville, dbo.Lycee.IdAcademie order by count(Lycee.IdLycee)", Provider.cnx))
            {
                da.Fill(Provider.ds, "TopVille");
                dataGridView1.DataSource = Provider.ds.Tables["TopVille"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Provider.ds.Tables.Contains("TopVille")) {

                Provider.ds.Tables["TopVille"].WriteXml("Lycees.xml");
                MessageBox.Show(@"Fichier XML est Creer Avec Succes GestMovement\bin\debug");
            }
        }
    }
}
