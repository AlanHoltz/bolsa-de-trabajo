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
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Bolsa.Business.Person businessPerson = new Bolsa.Business.Person();

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingrese todos los campos");
            } else
            {
                Bolsa.Entities.Person person = new Bolsa.Entities.Person();
                person.Name = txtName.Text;
                person.Surname = txtSurname.Text;
                person.Mail = txtEmail.Text;
                person.Password = txtPassword.Text;
                person.BirthDate = dtpBirthdate.Value;


                businessPerson.Save(person);
                
                this.Close();
            }

        }
    }
}
