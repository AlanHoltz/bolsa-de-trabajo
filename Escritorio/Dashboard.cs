using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

        }


        private void PersonDashboard_Shown(object sender, EventArgs e)
        {
            administradorToolStripMenuItem.Visible = Session.IsAdmin == true;

            if(Session.Type == "Person")
            {
                tspProposals.Visible = false;
            }
            else
            {
                trabajosToolStripMenuItem.Visible = false;
                aplicacionesToolStripMenuItem.Visible = false;
            }
            
            string? name = Session.Type == "Person" ? $"{Session.Name} {Session.Surname}" : Session.Name;
            lblBienvenida.Text = $"Dashboard de {name}";
        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmJobs().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session.Reset();
            new frmLogin().Show();
        }

        private void tspPersonas_Click(object sender, EventArgs e)
        {
            new frmPersons().ShowDialog();
        }


        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmApplications().ShowDialog();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.Type == "Person")
            {
                new frmEditPerson(Session.Id ?? -1).ShowDialog();
            }
            else
            {
                new frmEditCompany(Session.Id ?? -1).ShowDialog();
            }

        }


        private void tspEmpresas_Click(object sender, EventArgs e)
        {
            new frmCompanies().ShowDialog();
        }


        private void tspProposals_Click(object sender, EventArgs e)
        {

            new frmListProposals(Session.Id ?? -1).ShowDialog();
        }
    }
}
