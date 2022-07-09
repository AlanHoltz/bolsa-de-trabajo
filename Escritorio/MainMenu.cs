﻿using System;
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
            Usuarios u = new Usuarios();
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
            Usuarios u = new Usuarios();
            u.Show();
        }
    }
}
