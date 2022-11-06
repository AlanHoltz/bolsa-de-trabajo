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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Session.Reset();
            new frmLogin().Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPersons().Show();
        }

        private void PersonDashboard_Shown(object sender, EventArgs e)
        {
            administradorToolStripMenuItem.Visible = Session.IsAdmin == true;
            lblBienvenida.Text = $"Bienvenido/a {Session.Name} {Session.Surname}";
        }
    }
}
