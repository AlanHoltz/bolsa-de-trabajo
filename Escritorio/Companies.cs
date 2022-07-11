using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolsa.Business;
using Bolsa.Entities;

namespace Escritorio
{
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
            dgvCompanies.AutoGenerateColumns = false;
            dgvCompanies.MultiSelect = false;
        }

        public void Listar()
        {
            this.dgvCompanies.DataSource = Bolsa.Business.Company.GetAll();
        }

        private void Companies_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsNew_Click(object sender, EventArgs e)
        {
            CompanyDesktop formCompany = new CompanyDesktop(ApplicationForm.ModoForm.Alta);
            formCompany.ShowDialog();
            this.Listar();
        }

        private void tbsEdit_Click(object sender, EventArgs e)
        {
            int ID = ((Bolsa.Entities.Company)this.dgvCompanies.SelectedRows[0].DataBoundItem).Id;
            CompanyDesktop formCompany = new CompanyDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formCompany.ShowDialog();
            this.Listar();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int ID = ((Bolsa.Entities.Company)this.dgvCompanies.SelectedRows[0].DataBoundItem).Id;
            CompanyDesktop formCompany = new CompanyDesktop(ID, ApplicationForm.ModoForm.Baja);
            formCompany.ShowDialog();
            this.Listar();
        }

        private void dgvCompanies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = ((Bolsa.Entities.Company)this.dgvCompanies.SelectedRows[0].DataBoundItem).Id;
            CompanyDesktop formCompany = new CompanyDesktop(ID, ApplicationForm.ModoForm.Consulta);
            formCompany.ShowDialog();
            this.Listar();
        }
    }
}
