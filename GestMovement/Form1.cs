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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BTN_MAJProf_Click(object sender, EventArgs e)
        {
            MAJProf M = new MAJProf();
            M.ShowDialog();
        }

        private void BTN_ConsultProf_Click(object sender, EventArgs e)
        {
            ConsultProf C = new ConsultProf();
            C.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Afficher10Lycee A = new Afficher10Lycee();
            A.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtatDemande E = new EtatDemande();
            E.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Q7etatgraphique q = new Q7etatgraphique();
            q.ShowDialog();
        }
    }
}
