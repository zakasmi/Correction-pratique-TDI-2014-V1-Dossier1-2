using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestMovement
{
    public partial class Q7etatgraphique : Form
    {
        public Q7etatgraphique()
        {
            InitializeComponent();
        }

        private void Q7etatgraphique_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
