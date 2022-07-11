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
    public partial class Cities : Form
    {
        public Cities()
        {
            InitializeComponent();
            dvgCities.AutoGenerateColumns = false;
            dvgCities.MultiSelect = false;
        }

        public void Listar()
        {
            this.dvgCities.DataSource = Bolsa.Business.City.GetAll();
        }

        private void Cities_Load(object sender, EventArgs e)
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
            CityDesktop formCity = new CityDesktop(ApplicationForm.ModoForm.Alta);
            formCity.ShowDialog();
            this.Listar();
        }

        private void tbsEdit_Click(object sender, EventArgs e)
        {
            String zipCode = ((Bolsa.Entities.City)this.dvgCities.SelectedRows[0].DataBoundItem).ZipCode;
            CityDesktop formCity = new CityDesktop(zipCode, ApplicationForm.ModoForm.Modificacion);
            formCity.ShowDialog();
            this.Listar();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            String zipCode = ((Bolsa.Entities.City)this.dvgCities.SelectedRows[0].DataBoundItem).ZipCode;
            CityDesktop formCity = new CityDesktop(zipCode, ApplicationForm.ModoForm.Baja);
            formCity.ShowDialog();
            this.Listar();
        }


        private void dgvCities_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String zipCode = ((Bolsa.Entities.City)this.dvgCities.SelectedRows[0].DataBoundItem).ZipCode;
            CityDesktop formCity = new CityDesktop(zipCode, ApplicationForm.ModoForm.Consulta);
            formCity.ShowDialog();
            this.Listar();
        }
    }
}
