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
    public partial class EtatDemande : Form
    {
        public EtatDemande()
        {
            InitializeComponent();
        }

        private void EtatDemande_Load(object sender, EventArgs e)
        {
            if (Provider.ds.Tables.Contains("Demande")) { Provider.ds.Tables["Demande"].Rows.Clear(); }
            using (SqlDataAdapter da = new SqlDataAdapter("select * from Demande", Provider.cnx))
            {
                da.Fill(Provider.ds, "Demande");
            }
            CB_IdDemande.DataSource = Provider.ds.Tables["Demande"];
            CB_IdDemande.DisplayMember = Provider.ds.Tables["Demande"].Columns[0].ColumnName;
            CB_IdDemande.ValueMember = Provider.ds.Tables["Demande"].Columns[0].ColumnName;
        }

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetParameterValue("@IdDemande",CB_IdDemande.SelectedValue.ToString());
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
