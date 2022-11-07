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
    public partial class frmAddCompany : Form
    {
        public int id;
        public frmAddCompany()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Bolsa.Business.Company businessCompany = new Bolsa.Business.Company();

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtCuit.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                Bolsa.Entities.Company company = new Bolsa.Entities.Company();
                company.Name = txtName.Text;
                company.Mail = txtMail.Text;
                company.CityZipCode = comboCities.SelectedValue.ToString();
                company.Cuit = txtCuit.Text;
                company.Password = txtPassword.Text;
                company.Address = txtAddress.Text;
                company.Id = id;

                businessCompany.Save(company);

                this.Close();
            }

        }

        private void frmEditPerson_Load(object sender, EventArgs e)
        {
            Bolsa.Business.City businessCity = new Bolsa.Business.City();
            
            comboCities.DataSource = businessCity.GetAll();
            comboCities.DisplayMember = "Name";
            comboCities.ValueMember = "ZipCode";
        }
    }
}
