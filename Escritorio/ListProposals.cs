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
    public partial class frmListProposals : Form
    {
        public int companyId;
        public frmListProposals(int _companyId)
        {
            companyId = _companyId;
            InitializeComponent();
        }
        
        private void ListProposals_Load(object sender, EventArgs e)
        {
            Bolsa.Business.Company businessCompany = new Bolsa.Business.Company();

            companyId = 2;
            dgvProposals.DataSource = businessCompany.GetProposals(companyId);

            dgvProposals.Columns["Status"].Visible = false;
            dgvProposals.Columns["CompanyId"].Visible = false;
            dgvProposals.Columns["Company"].Visible = false;
            dgvProposals.Columns["JobProfilePerson"].Visible = false;
            dgvProposals.Columns["Careers"].Visible = false;
            dgvProposals.Columns["Internship"].Visible = false;
            dgvProposals.Columns["Relationship"].Visible = false;
        }

        private void btnMirar_Click(object sender, EventArgs e)
        {
            int idProposal = int.Parse(dgvProposals.Rows[dgvProposals.CurrentRow.Index].Cells[0].Value.ToString());
            frmListProposal frmListProposal = new frmListProposal(idProposal);
            frmListProposal.ShowDialog();

            // dgvPersons.DataSource = personBusiness.GetAll();
        }
    }
}
