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
    public partial class CompanyDesktop : ApplicationForm
    {
        public CompanyDesktop()
        {
            InitializeComponent();
        }

        private Bolsa.Entities.Company _CurrentCompany;
        private Bolsa.Business.Company ul = new Bolsa.Business.Company();

        public Bolsa.Entities.Company CurrentCompany
        {
            get { return this._CurrentCompany; }
            set { this._CurrentCompany = value; }
        }

        public CompanyDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            txtName.Select();
            btnAceptar.Text = "Guardar";
            CalendarBirthDate.Enabled = true;
        }

        public CompanyDesktop(int ID, ModoForm modo) : this()
        {
            CurrentCompany = ul.GetOne(ID);
            MapearDeDatos();
            this.Modo = modo;
            switch (Modo)
            {
                case ModoForm.Baja:
                    btnAceptar.Select();
                    btnAceptar.Text = "Eliminar";
                    txtName.ReadOnly = true;
                    txtCuit.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtCategory.ReadOnly = true;
                    txtReferenceName.ReadOnly = true;
                    txtReferenceEmail.ReadOnly = true;
                    txtReferencePhone.ReadOnly = true;
                    CalendarBirthDate.Enabled = false;
                    break;
                case ModoForm.Modificacion:
                    txtName.Select();
                    txtEmail.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Select();
                    txtName.ReadOnly = true;
                    txtCuit.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtCategory.ReadOnly = true;
                    txtReferenceName.ReadOnly = true;
                    txtReferenceEmail.ReadOnly = true;
                    txtReferencePhone.ReadOnly = true;
                    CalendarBirthDate.Enabled = false;
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CurrentCompany.Id.ToString();
            this.chkWorkCompany.Checked = this.CurrentCompany.ReferenceWorkOnCompany;
            this.txtName.Text = this.CurrentCompany.Name;
            this.txtCuit.Text = this.CurrentCompany.Cuit;
            this.txtEmail.Text = this.CurrentCompany.Mail;
            this.txtCategory.Text = this.CurrentCompany.Category;
            this.txtReferenceName.Text = this.CurrentCompany.ReferenceName;
            this.txtReferenceEmail.Text = this.CurrentCompany.ReferenceEmail;
            this.txtReferencePhone.Text = this.CurrentCompany.ReferencePhone;
            this.txtReferenceArea.Text = this.CurrentCompany.ReferenceArea;
            this.txtSignupDate.Text = this.CurrentCompany.Date.ToString();
            this.txtSignupDate.Text = DateTime.Now.ToString();
        }

        public override void MapearADatos()
        {
            if (Modo != ModoForm.Alta)
            {
                this.CurrentCompany.Id = Int32.Parse(this.txtID.Text);
            }
            if (this.chkWorkCompany.Checked)
            {
                this.CurrentCompany.ReferenceWorkOnCompany = true;
            }
            else
            {
                this.CurrentCompany.ReferenceWorkOnCompany = false;
            }
            this.CurrentCompany.Name = this.txtName.Text;
            this.CurrentCompany.Address = this.txtAddress.Text;
            this.CurrentCompany.Cuit = this.txtCuit.Text;
            this.CurrentCompany.Mail = this.txtEmail.Text;
            this.CurrentCompany.Password = this.txtPassword.Text;
            this.CurrentCompany.Category = this.txtCategory.Text;
            this.CurrentCompany.Date = DateTime.Now;
            this.CurrentCompany.ZipCode = Ciudades.SelectedValue.ToString();
            this.CurrentCompany.ReferenceName = this.txtReferenceName.Text;
            this.CurrentCompany.ReferenceEmail = this.txtReferenceEmail.Text;
            this.CurrentCompany.ReferencePhone = this.txtReferencePhone.Text;
            this.CurrentCompany.ReferenceArea = this.txtReferenceArea.Text;
            this.CurrentCompany.Photo = "";
            switch (Modo)
            {
                case ModoForm.Baja:
                    CurrentCompany.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Alta:
                    CurrentCompany.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    CurrentCompany.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    CurrentCompany.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            CurrentCompany = new Bolsa.Entities.Company();
            MapearADatos();
            ul.Save(CurrentCompany);
        }
        public override bool Validar()
        {
            if ((this.txtName.Text == "") || (this.txtCuit.Text == "") || (this.txtEmail.Text == "") || (this.txtCategory.Text == "") || (this.txtReferenceName.Text == "") || (this.txtBirthDate.Text == "") || (this.txtPassword.TextLength < 8) || !(Regex.IsMatch(txtEmail.Text, @"^[^@]+@[^@]+\.[a-zA-Z]{2,}$")) || !(Regex.IsMatch(txtReferenceEmail.Text, @"^[^@]+@[^@]+\.[a-zA-Z]{2,}$")))
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

        private void CompanyDesktop_Load(object sender, EventArgs e)
        {
            List<Bolsa.Entities.City> ciudades = Bolsa.Business.City.GetAll();

            Ciudades.DataSource = ciudades;
            Ciudades.DisplayMember = "Name";
            Ciudades.ValueMember = "ZipCode";
        }
    }
}
