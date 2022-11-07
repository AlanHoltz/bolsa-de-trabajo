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
    public partial class frmListProposal : Form
    {
        public int idProposal;

        public frmListProposal(int _idProposal)
        {
            idProposal = _idProposal;
            InitializeComponent();
        }

        private void frmListProposal_Load(object sender, EventArgs e)
        {
            Bolsa.Business.Company businessCompany = new Bolsa.Business.Company();

            Bolsa.Entities.JobProfile jobProfile = businessCompany.GetProposal(idProposal);

            string currentDirectory = Environment.CurrentDirectory;
            string solutionDirectory = Directory.GetParent(currentDirectory).Parent.Parent.Parent.FullName;
            // string imageUrl = jobProfile.Company.Photo != null ? $"companies\\{jobProfile.Company.Photo}" : "logo.png";
            // picCompany.ImageLocation = $"{solutionDirectory}\\WebMVC\\wwwroot\\images\\{imageUrl}";

            lblPosition.Text = jobProfile.Position;
            // lblCompany.Text = jobProfile.Company.Name;
            lblStartingDateValue.Text = jobProfile.StartingDate.ToString("dd/MM/yyyy");
            lblEndingDateValue.Text = jobProfile.EndingDate.ToString("dd/MM/yyyy");
            lblAddressValue.Text = jobProfile.Address;
            lblCapacityValue.Text = jobProfile.Capacity.ToString();
            lblDescriptionValue.Text = jobProfile.Description;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Bolsa.Business.JobProfile businessJobProfile = new Bolsa.Business.JobProfile();

            businessJobProfile.Delete(idProposal);

            this.Close();
        }

        private void btnVerPostulantes_Click(object sender, EventArgs e)
        {
            new frmShowApplies(idProposal).ShowDialog();
        }
    }
}
