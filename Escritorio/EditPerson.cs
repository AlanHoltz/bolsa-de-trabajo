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
    public partial class frmEditPerson : Form
    {
        public int id;
        public frmEditPerson(int _id)
        {
            id = _id;
            InitializeComponent();

            Bolsa.Business.Person personBusiness = new Bolsa.Business.Person();
            Bolsa.Entities.Person person = personBusiness.GetOne(id);
        
            txtName.Text = person.Name;
            txtSurname.Text = person.Surname;
            txtPassword.Text = person.Password;
            dtpBirthdate.Value = person.BirthDate;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Bolsa.Business.Person businessPerson = new Bolsa.Business.Person();

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                Bolsa.Entities.Person person = new Bolsa.Entities.Person();
                person.Name = txtName.Text;
                person.Surname = txtSurname.Text;
                person.Password = txtPassword.Text;
                person.BirthDate = dtpBirthdate.Value;
                person.Id = id;

                businessPerson.Save(person);

                this.Close();
            }
        }

        private void frmEditPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
