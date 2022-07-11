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
    public partial class CityDesktop : ApplicationForm
    {
        public CityDesktop()
        {
            InitializeComponent();
        }

        private Bolsa.Entities.City _CurrentCity;
        private Bolsa.Business.City cl = new Bolsa.Business.City();
        private Bolsa.Business.Province pl = new Bolsa.Business.Province();

        public Bolsa.Entities.City CurrentCity
        {
            get { return this._CurrentCity; }
            set { this._CurrentCity = value; }
        }

        public CityDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            txtZipCode.Select();
            btnAceptar.Text = "Guardar";

        }

        public CityDesktop(String zipCode, ModoForm modo) : this()
        {
            CurrentCity = cl.GetOne(zipCode);
            MapearDeDatos();
            this.Modo = modo;
            switch (Modo)
            {
                case ModoForm.Baja:
                    btnAceptar.Select();
                    btnAceptar.Text = "Eliminar";
                    txtZipCode.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtProvinceId.ReadOnly = true;
                    break;
                case ModoForm.Modificacion:
                    txtZipCode.Select();
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Select();
                    txtZipCode.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtProvinceId.ReadOnly = true;
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtZipCode.Text = this.CurrentCity.ZipCode;
            this.txtName.Text = this.CurrentCity.Name;
            this.txtProvinceId.Text = this.CurrentCity.ProvinceId.ToString();
        }

        public override void MapearADatos()
        {
            this.CurrentCity.ZipCode = this.txtZipCode.Text;
            this.CurrentCity.Name = this.txtName.Text;
            this.CurrentCity.ProvinceId = Int32.Parse(this.txtProvinceId.Text);
            switch (Modo)
            {
                case ModoForm.Baja:
                    CurrentCity.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Alta:
                    CurrentCity.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    CurrentCity.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    CurrentCity.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            CurrentCity = new Bolsa.Entities.City();
            MapearADatos();
            cl.Save(CurrentCity);
        }
        public override bool Validar()
        {
            if ((this.txtZipCode.Text == "") || (this.txtName.Text == "") || (this.txtProvinceId.Text == ""))
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

        private void CityDesktop_Load(object sender, EventArgs e)
        {
            List<Bolsa.Entities.Province> provinces = new List<Bolsa.Entities.Province>();
            provinces = pl.GetAll();
            foreach (Bolsa.Entities.Province prov in provinces)
            {
                cbIdProvincias.Items.Add(prov.Id );
            }
            
        }
    }
}
