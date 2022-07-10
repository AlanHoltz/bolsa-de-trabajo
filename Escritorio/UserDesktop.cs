using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolsa.Entities;
using Bolsa.Business;
using System.Text.RegularExpressions;

namespace Escritorio
{
    public partial class UserDesktop : ApplicationForm
    {
        public UserDesktop()
        {
            InitializeComponent();
        }

        private Bolsa.Entities.Person _CurrentUser;
        private Bolsa.Business.Person ul = new Bolsa.Business.Person();

        public Bolsa.Entities.Person CurrentUser
        {
            get { return this._CurrentUser; }
            set { this._CurrentUser = value; }
        }

        public UserDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            txtName.Select();
            btnAceptar.Text = "Guardar";
            CalendarBirthDate.Enabled = true;

        }

        public UserDesktop(int ID, ModoForm modo) : this()
        {
            CurrentUser = ul.GetOne(ID);
            MapearDeDatos();
            this.Modo = modo;
            switch (Modo)
            {
                case ModoForm.Baja:
                    btnAceptar.Select();
                    btnAceptar.Text = "Eliminar";
                    txtName.ReadOnly = true;
                    txtSurname.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtConfirmPassword.ReadOnly = true;
                    CalendarBirthDate.Enabled = false;
                    chkAdmin.Enabled = false;
                    break;
                case ModoForm.Modificacion:
                    txtName.Select();
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Select();
                    txtName.ReadOnly = true;
                    txtSurname.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtConfirmPassword.ReadOnly = true;
                    CalendarBirthDate.Enabled = false;
                    chkAdmin.Enabled = false;
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CurrentUser.Id.ToString();
            this.chkAdmin.Checked = this.CurrentUser.IsAdmin;
            this.txtName.Text = this.CurrentUser.Name;
            this.txtSurname.Text = this.CurrentUser.Surname;
            this.txtEmail.Text = this.CurrentUser.Mail;
            this.txtPassword.Text = this.CurrentUser.Password;
            this.txtConfirmPassword.Text = this.CurrentUser.Password;
            this.txtBirthDate.Text = this.CurrentUser.BirthDate.ToString("dd/MM/yyyy");
            this.txtSignupDate.Text = this.CurrentUser.Date.ToString();
            this.CalendarBirthDate.SetDate(this.CurrentUser.BirthDate);
            this.txtSignupDate.Text = DateTime.Now.ToString();
        }

        public override void MapearADatos()
        {
            if (Modo != ModoForm.Alta)
            {
                this.CurrentUser.Id = Int32.Parse(this.txtID.Text);
            }
            if (this.chkAdmin.Checked)
            {
                this.CurrentUser.IsAdmin = true;
            }
            else
            {
                this.CurrentUser.IsAdmin = false;
            }
            this.CurrentUser.Name = this.txtName.Text;
            this.CurrentUser.Surname = this.txtSurname.Text;
            this.CurrentUser.Mail = this.txtEmail.Text;
            this.CurrentUser.Password = this.txtPassword.Text;
            this.CurrentUser.BirthDate = Convert.ToDateTime(this.txtBirthDate.Text);
            this.CurrentUser.Date = DateTime.Now;
            switch (Modo)
            {
                case ModoForm.Baja:
                    CurrentUser.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Alta:
                    CurrentUser.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    CurrentUser.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    CurrentUser.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            CurrentUser = new Bolsa.Entities.Person();
            MapearADatos();
            ul.Save(CurrentUser);
        }
        public override bool Validar()
        {
            if ((this.txtName.Text == "") || (this.txtSurname.Text == "") || (this.txtEmail.Text == "") || (this.txtPassword.Text == "") || (this.txtConfirmPassword.Text == "") || (this.txtBirthDate.Text == "") || (this.txtPassword.TextLength < 8) || !(Regex.IsMatch(txtEmail.Text, @"^[^@]+@[^@]+\.[a-zA-Z]{2,}$")) || (txtPassword.Text != txtConfirmPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons
botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() || (Modo == ModoForm.Baja)) // Se agrego esta condicion ya que el campo pre cargado no la cumple y no permitia la eliminacion del mismo.
            {
                GuardarCambios();
                this.Close();
            }
            else
            {
                Notificar("Error en la carga de datos", "Por favor revise la informacion cargada/Modificada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }

        }

        private void CalendarBirthDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.txtBirthDate.Text = this.CalendarBirthDate.SelectionStart.ToString("dd/MM/yyyy");
        }
    }
}
