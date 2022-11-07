using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class frmJob : Form
    {

        public Bolsa.Entities.JobProfile jobProfile;
        public Bolsa.Entities.JobProfilePerson jobProfilePerson;

        public frmJob(int _id)
        {
            InitializeComponent();


            Bolsa.Business.JobProfile jobProfileBusiness = new Bolsa.Business.JobProfile();
            jobProfile = jobProfileBusiness.GetOne(Session.Id ?? -1, _id);

            Bolsa.Business.JobProfilePerson jobProfilePersonBusiness = new Bolsa.Business.JobProfilePerson();
            jobProfilePerson = jobProfilePersonBusiness.GetOne(jobProfile.Id, Session.Id ?? -1);

            lblStatus.Visible = false;

            if(jobProfilePerson == null) {

                btnApply.Visible = true;
                btnNoApply.Visible = false;
            }
            else
            {

                if(jobProfilePerson.Status != "Pending")
                {
                    btnApply.Visible = false;
                    btnNoApply.Visible = false;
                    lblStatus.Visible = true;


                    if (jobProfilePerson.Status == "Accepted")
                    {
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = "PROPUESTA ACEPTADA";
                    }

                    else
                    {
                        lblStatus.ForeColor = Color.Red;
                        lblStatus.Text = "PROPUESTA RECHAZADA";
                    }

                }
                else
                {
                    btnApply.Visible = false;
                    btnNoApply.Visible = true;
                }

            }


            string currentDirectory = Environment.CurrentDirectory;
            string solutionDirectory = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            string imageUrl = jobProfile.Company.Photo != null ? $"companies\\{jobProfile.Company.Photo}" : "logo.png";
            picCompany.ImageLocation = $"{solutionDirectory}\\WebMVC\\wwwroot\\images\\{imageUrl}";

            lblPosition.Text = jobProfile.Position;
            lblCompany.Text = jobProfile.Company.Name;
            lblStartingDateValue.Text = jobProfile.StartingDate.ToString("dd/MM/yyyy");
            lblEndingDateValue.Text = jobProfile.EndingDate.ToString("dd/MM/yyyy");
            lblAddressValue.Text = jobProfile.Address;
            lblCapacityValue.Text = jobProfile.Capacity.ToString();
            lblDescriptionValue.Text = jobProfile.Description;

        }

        private void btnNoApply_Click(object sender, EventArgs e)
        {
            Bolsa.Business.JobProfilePerson jobProfilePersonBusiness = new Bolsa.Business.JobProfilePerson();


            jobProfilePersonBusiness.Delete(jobProfilePerson.Id);

            this.Dispose();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Bolsa.Business.JobProfilePerson jobProfilePersonBusiness = new Bolsa.Business.JobProfilePerson();
            Bolsa.Entities.JobProfilePerson newJobProfilePerson = new Bolsa.Entities.JobProfilePerson();

            newJobProfilePerson.JobProfilesId = jobProfile.Id;
            newJobProfilePerson.PersonsId = Session.Id ?? -1;
            newJobProfilePerson.Observations = "";
            newJobProfilePerson.Status = "Pending";

            jobProfilePersonBusiness.Add(newJobProfilePerson);

            this.Dispose();
        }

    }
}
