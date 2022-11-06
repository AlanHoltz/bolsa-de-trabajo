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
    public partial class frmJobs : Form
    {
        public Bolsa.Business.JobProfile jobProfileBusiness;

        public frmJobs()
        {
            InitializeComponent();
            jobProfileBusiness = new Bolsa.Business.JobProfile();
        }

        private void Persons_Load(object sender, EventArgs e)
        {

            dgvJobs.Columns.Add("Id", "Id");
            dgvJobs.Columns["Id"].Visible = false;
            dgvJobs.Columns.Add("Company", "Company");
            dgvJobs.Columns.Add("Position", "Position");
            dgvJobs.Columns.Add("StartingDate", "Starting");
            dgvJobs.Columns.Add("EndingDate", "Ending");

            List<Bolsa.Entities.JobProfile> jobProfiles = jobProfileBusiness.GetAll(Session.Id ?? 0);

            foreach(Bolsa.Entities.JobProfile jobProfile in jobProfiles)
            {
                dgvJobs.Rows.Add(jobProfile.Id,jobProfile.Company.Name, jobProfile.Position, jobProfile.StartingDate, jobProfile.EndingDate);
            }

        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            if (dgvJobs.Rows.Count == 0) return;

            int id = int.Parse(dgvJobs.Rows[dgvJobs.CurrentRow.Index].Cells[0].Value.ToString());

            new formJob(id).ShowDialog();
            

        }
    }
}
