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
    public partial class frmAddJobProfile: Form
    {
        public int id;
        public frmAddJobProfile()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPosition.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtReceptor.Text) || String.IsNullOrEmpty(txtDescription.Text)) {

                MessageBox.Show("Rellene los campos vacíos","Error");
                return;
            }


            if (int.TryParse(txtCapacity.Text, out int n) == false)
            {

                MessageBox.Show("Capacidad debe ser numérico");
                return;

            }

            if(!(int.Parse(txtCapacity.Text) > 0))
            {
                MessageBox.Show("Capacidad debe ser mayor a 0");
                return;
            }

            if (!(comboType.SelectedItem == "Relación de Dependencia" || comboType.SelectedItem == "Pasantía"))
            {
                MessageBox.Show("Elija un tipo de relación correcta");
                return;
            }

            if(dtEnding.Value <= dtStarting.Value)
            {
                MessageBox.Show("La fecha de fin debe ser mayor que la de inicio");
                return;
            }

            Bolsa.Business.JobProfile jobProfileBusiness = new Bolsa.Business.JobProfile();

            Bolsa.Entities.JobProfile jobProfile = new Bolsa.Entities.JobProfile();

            jobProfile.Position = txtPosition.Text;
            jobProfile.Address = txtAddress.Text;
            jobProfile.EmailReceptor = txtReceptor.Text;
            jobProfile.Type = comboType.SelectedItem.ToString() == "Pasantía" ? "Internship" : "Relationship";
            jobProfile.StartingDate = dtStarting.Value;
            jobProfile.EndingDate = dtEnding.Value;
            jobProfile.Description = txtDescription.Text;
            jobProfile.Capacity = int.Parse(txtCapacity.Text);
            jobProfile.CompanyId = Session.Id ?? -1;

            jobProfileBusiness.Add(jobProfile);

            this.Close();
                
            
        }
    }
}
