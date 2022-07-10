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
    public partial class ProvinceDesktop : ApplicationForm
    {
        public ProvinceDesktop()
        {
            InitializeComponent();
        }

        private Bolsa.Entities.Province _CurrentProvince;
        private Bolsa.Business.Province pl = new Bolsa.Business.Province();

        public Bolsa.Entities.Province CurrentProvince
        {
            get { return this._CurrentProvince; }
            set { this._CurrentProvince = value; }
        }

        public ProvinceDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            txtName.Select();
            btnAceptar.Text = "Guardar";

        }

        public ProvinceDesktop(int ID, ModoForm modo) : this()
        {
            CurrentProvince = pl.GetOne(ID);
            MapearDeDatos();
            this.Modo = modo;
            switch (Modo)
            {
                case ModoForm.Baja:
                    btnAceptar.Select();
                    btnAceptar.Text = "Eliminar";
                    txtName.ReadOnly = true;
                    break;
                case ModoForm.Modificacion:
                    txtName.Select();
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Select();
                    txtName.ReadOnly = true;
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CurrentProvince.Id.ToString();
            this.txtName.Text = this.CurrentProvince.Name;
        }

        public override void MapearADatos()
        {
            if (Modo != ModoForm.Alta)
            {
                this.CurrentProvince.Id = Int32.Parse(this.txtID.Text);
            }
            this.CurrentProvince.Name = this.txtName.Text;
            switch (Modo)
            {
                case ModoForm.Baja:
                    CurrentProvince.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Alta:
                    CurrentProvince.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    CurrentProvince.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    CurrentProvince.State = BusinessEntity.States.Unmodified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            CurrentProvince = new Bolsa.Entities.Province();
            MapearADatos();
            pl.Save(CurrentProvince);
        }
        public override bool Validar()
        {
            if ((this.txtName.Text == ""))
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

    }
}
