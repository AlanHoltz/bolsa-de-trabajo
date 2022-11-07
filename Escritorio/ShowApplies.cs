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
    public partial class frmShowApplies : Form
    {
        public int idProposal;

        public frmShowApplies(int _idProposal)
        {
            idProposal = _idProposal;
            InitializeComponent();
        }

        private void frmShowApplies_Load(object sender, EventArgs e)
        {
            Bolsa.Business.Company businessCompany = new Bolsa.Business.Company();

            dgvApplies.DataSource = businessCompany.GetApplies(idProposal);

            dgvApplies.Columns["Id"].Visible = false;
            dgvApplies.Columns["Cv"].Visible = false;
            dgvApplies.Columns["IsAdmin"].Visible = false;
            dgvApplies.Columns["User"].Visible = false;
            dgvApplies.Columns["JobProfilePerson"].Visible = false;
            dgvApplies.Columns["Password"].Visible = false;
            dgvApplies.Columns["Type"].Visible = false;
            dgvApplies.Columns["Status"].Visible = false;
            dgvApplies.Columns["SignupDate"].Visible = false;
            dgvApplies.Columns["Persons"].Visible = false;
            dgvApplies.Columns["Companies"].Visible = false;
        }
    }
}
