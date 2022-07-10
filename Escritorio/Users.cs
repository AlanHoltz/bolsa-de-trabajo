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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.MultiSelect = false;
        }

        public void Listar()
        {
            this.dgvUsuarios.DataSource = Bolsa.Business.Person.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
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
            UserDesktop formUser = new UserDesktop(ApplicationForm.ModoForm.Alta);
            formUser.ShowDialog();
            this.Listar();
        }

        private void tbsEdit_Click(object sender, EventArgs e)
        {
            int ID = ((Bolsa.Entities.Person)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Id;
            UserDesktop formUser = new UserDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formUser.ShowDialog();
            this.Listar();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int ID = ((Bolsa.Entities.Person)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Id;
            UserDesktop formUser = new UserDesktop(ID, ApplicationForm.ModoForm.Baja);
            formUser.ShowDialog();
            this.Listar();
        }

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = ((Bolsa.Entities.Person)this.dgvUsuarios.SelectedRows[0].DataBoundItem).Id;
            UserDesktop formUser = new UserDesktop(ID, ApplicationForm.ModoForm.Consulta);
            formUser.ShowDialog();
            this.Listar();
        }
    }
}
