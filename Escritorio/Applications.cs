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
    public partial class frmApplications : Form
    {
        public Bolsa.Business.JobProfilePerson jobProfilePersonBusiness;

        public frmApplications()
        {
            InitializeComponent();
            jobProfilePersonBusiness = new Bolsa.Business.JobProfilePerson();
        }

        private void FetchApplications()
        {

            dgvApplications.Rows.Clear();

            List<Bolsa.Entities.JobProfilePerson> applications = jobProfilePersonBusiness.GetApplications(Session.Id ?? -1);


            foreach (Bolsa.Entities.JobProfilePerson application in applications)
            {
                dgvApplications.Rows.Add(application.JobProfiles.Id, application.JobProfiles.Company.Name, application.JobProfiles.Position, application.JobProfiles.StartingDate, application.JobProfiles.EndingDate);
            }
        }

        private void Applications_Load(object sender, EventArgs e)
        {

            dgvApplications.Columns.Add("Id", "Id");
            dgvApplications.Columns["Id"].Visible = false;
            dgvApplications.Columns.Add("Company", "Company");
            dgvApplications.Columns.Add("Position", "Position");
            dgvApplications.Columns.Add("StartingDate", "Starting");
            dgvApplications.Columns.Add("EndingDate", "Ending");

            FetchApplications();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            if (dgvApplications.Rows.Count == 0) return;

            int id = int.Parse(dgvApplications.Rows[dgvApplications.CurrentRow.Index].Cells[0].Value.ToString());

            frmJob job = new frmJob(id);
            job.ShowDialog();

            FetchApplications();

        }
    }
}
