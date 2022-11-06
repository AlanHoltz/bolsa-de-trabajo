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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Bolsa.Business.User userBusiness = new Bolsa.Business.User();

            string mail = txtMail.Text;
            string password = txtPassword.Text;

            Bolsa.Entities.User foundUser = userBusiness.Login(mail, password);

            if (foundUser != null)
            {
                frmDashboard dashboard = new frmDashboard();
                

                Session.Id = foundUser.Id;
                Session.Type = foundUser.Type;
                Session.Mail = foundUser.Mail;
                
                if(Session.Type == "Person")
                {
                    Bolsa.Business.Person personBusiness = new Bolsa.Business.Person();
                    Bolsa.Entities.Person person = personBusiness.GetOne(Session.Id ?? -1);

                    Session.Name = $"{person.Name} {person.Surname}";
                    Session.IsAdmin = person.IsAdmin;

                }
                else
                {
                    Bolsa.Business.Company companyBusiness = new Bolsa.Business.Company();
                    Bolsa.Entities.Company company = companyBusiness.GetOne(Session.Id ?? -1);

                    Session.Name = company.Name;
                    Session.CUIT = company.Cuit;
                    Session.Status = company.Status;

                }

                this.Hide();
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos", "Error");
            }


        }
    }
}
