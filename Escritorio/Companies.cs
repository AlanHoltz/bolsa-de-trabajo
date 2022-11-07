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
    public partial class frmCompanies : Form
    {
        public Bolsa.Business.Company companyBusiness;

        public frmCompanies()
        {
            InitializeComponent();
            companyBusiness = new Bolsa.Business.Company();
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            dgvCompanies.DataSource = companyBusiness.GetAll();

            dgvCompanies.Columns["Photo"].Visible = false;
            dgvCompanies.Columns["CityZipCode"].Visible = false;
            dgvCompanies.Columns["User"].Visible = false;
            dgvCompanies.Columns["Password"].Visible = false;
            dgvCompanies.Columns["SignupDate"].Visible = false;
            dgvCompanies.Columns["Persons"].Visible = false;
            dgvCompanies.Columns["Companies"].Visible = false;
            dgvCompanies.Columns["City"].Visible = false;
            dgvCompanies.Columns["ReferenceName"].Visible = false;
            dgvCompanies.Columns["ReferenceEmail"].Visible = false;
            dgvCompanies.Columns["ReferencePhone"].Visible = false;
            dgvCompanies.Columns["ReferenceArea"].Visible = false;
            dgvCompanies.Columns["ReferenceWorkingOnCompany"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddCompany frmAddCompany = new frmAddCompany();
            frmAddCompany.ShowDialog();

            dgvCompanies.DataSource = companyBusiness.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCompanies.Rows[dgvCompanies.CurrentRow.Index].Cells[0].Value.ToString());
            frmEditCompany frmEditCompany = new frmEditCompany(id);
            frmEditCompany.ShowDialog();

            dgvCompanies.DataSource = companyBusiness.GetAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCompanies.Rows[dgvCompanies.CurrentRow.Index].Cells[0].Value.ToString());
            companyBusiness.Delete(id);

            dgvCompanies.DataSource = companyBusiness.GetAll();
        }
    }
}
