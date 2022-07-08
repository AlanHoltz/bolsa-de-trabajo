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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (!chkEmpresa.Checked)
                {
                    Bolsa.Entities.User user = new Bolsa.Entities.Person(txtEmail.Text, txtPassword.Text);
                    if (Bolsa.Business.Auth.Login(user))
                    {
                        MessageBox.Show("Ha ingresado correctamente al sistema", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    } else
                    {
                        MessageBox.Show("Email o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else
                {
                    Bolsa.Entities.User user = new Bolsa.Entities.Company(txtEmail.Text, txtPassword.Text);
                    if (Bolsa.Business.Auth.Login(user))
                    {
                        MessageBox.Show("Ha ingresado correctamente al sistema", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Email o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
