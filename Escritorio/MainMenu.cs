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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
        }

        private void MainMenu_Shown(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void tsmListaUsuarios_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
        }

        private void tsmAgregarUsuarios_Click(object sender, EventArgs e)
        {
            UserDesktop formUser = new UserDesktop(ApplicationForm.ModoForm.Alta);
            formUser.ShowDialog();
        }

        private void tsmListaEmpresas_Click(object sender, EventArgs e)
        {
            Companies em = new Companies();
            em.Show();
        }

        private void tsmAgregarEmpresas_Click(object sender, EventArgs e)
        {
            CompanyDesktop formUser = new CompanyDesktop(ApplicationForm.ModoForm.Alta);
            formUser.ShowDialog();
        }

        private void tsmListaCiudades_Click(object sender, EventArgs e)
        {
            Cities c = new Cities();
            c.Show();
        }

        private void tsmAgregarCiudades_Click(object sender, EventArgs e)
        {
            CityDesktop formCity = new CityDesktop(ApplicationForm.ModoForm.Alta);
            formCity.ShowDialog();
        }

        private void tsmListaProvincias_Click(object sender, EventArgs e)
        {
            Provinces p = new Provinces();
            p.Show();
        }

        private void tsmAgregarProvincias_Click(object sender, EventArgs e)
        {
            ProvinceDesktop formProvince = new ProvinceDesktop(ApplicationForm.ModoForm.Alta);
            formProvince.ShowDialog();

        }

    }
}
