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
    public partial class frmPersons : Form
    {
        public Bolsa.Business.Person personBusiness;

        public frmPersons()
        {
            InitializeComponent();
            personBusiness = new Bolsa.Business.Person();
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            dgvPersons.DataSource = personBusiness.GetAll();

            dgvPersons.Columns["Cv"].Visible = false;
            dgvPersons.Columns["IsAdmin"].Visible = false;
            dgvPersons.Columns["User"].Visible = false;
            dgvPersons.Columns["JobProfilePerson"].Visible = false;
            dgvPersons.Columns["Password"].Visible = false;
            dgvPersons.Columns["Status"].Visible = false;
            dgvPersons.Columns["SignupDate"].Visible = false;
            dgvPersons.Columns["Persons"].Visible = false;
            dgvPersons.Columns["Companies"].Visible = false;
            dgvPersons.Columns["Type"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson();
            frmAddPerson.ShowDialog();

            dgvPersons.DataSource = personBusiness.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPersons.Rows[dgvPersons.CurrentRow.Index].Cells[0].Value.ToString());
            frmEditPerson frmEditPerson = new frmEditPerson(id);
            frmEditPerson.ShowDialog();

            dgvPersons.DataSource = personBusiness.GetAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPersons.Rows[dgvPersons.CurrentRow.Index].Cells[0].Value.ToString());
            personBusiness.Delete(id);

            dgvPersons.DataSource = personBusiness.GetAll();
        }
    }
}
