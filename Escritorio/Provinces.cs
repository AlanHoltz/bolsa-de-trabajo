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
    public partial class Provinces : Form
    {
        public Provinces()
        {
            InitializeComponent();
            dgvProvinces.AutoGenerateColumns = false;
            dgvProvinces.MultiSelect = false;
        }

        public void Listar()
        {
            this.dgvProvinces.DataSource = Bolsa.Business.Province.GetAll();
        }

        private void Provinces_Load(object sender, EventArgs e)
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
            ProvinceDesktop formProvince = new ProvinceDesktop(ApplicationForm.ModoForm.Alta);
            formProvince.ShowDialog();
            this.Listar();
        }

        private void tbsEdit_Click(object sender, EventArgs e)
        {
            int ID = ((Bolsa.Entities.Province)this.dgvProvinces.SelectedRows[0].DataBoundItem).Id;
            ProvinceDesktop formProvince = new ProvinceDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formProvince.ShowDialog();
            this.Listar();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int ID = ((Bolsa.Entities.Province)this.dgvProvinces.SelectedRows[0].DataBoundItem).Id;
            ProvinceDesktop formProvince = new ProvinceDesktop(ID, ApplicationForm.ModoForm.Baja);
            formProvince.ShowDialog();
            this.Listar();
        }

        private void dgvProvinces_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = ((Bolsa.Entities.Province)this.dgvProvinces.SelectedRows[0].DataBoundItem).Id;
            ProvinceDesktop formProvince = new ProvinceDesktop(ID, ApplicationForm.ModoForm.Consulta);
            formProvince.ShowDialog();
            this.Listar();
        }
    }
}
