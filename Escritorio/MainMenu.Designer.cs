
namespace Escritorio
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListaEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCiudades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListaCiudades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarCiudades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListaProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListaPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmPerfiles});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuarios,
            this.tsmEmpresas,
            this.tsmCiudades,
            this.tsmProvincias});
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListaUsuarios,
            this.tsmAgregarUsuarios});
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmUsuarios.Text = "Usuarios";
            // 
            // tsmListaUsuarios
            // 
            this.tsmListaUsuarios.Name = "tsmListaUsuarios";
            this.tsmListaUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmListaUsuarios.Text = "Lista";
            this.tsmListaUsuarios.Click += new System.EventHandler(this.tsmListaUsuarios_Click);
            // 
            // tsmAgregarUsuarios
            // 
            this.tsmAgregarUsuarios.Name = "tsmAgregarUsuarios";
            this.tsmAgregarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmAgregarUsuarios.Text = "Agregar";
            this.tsmAgregarUsuarios.Click += new System.EventHandler(this.tsmAgregarUsuarios_Click);
            // 
            // tsmEmpresas
            // 
            this.tsmEmpresas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListaEmpresas,
            this.tsmAgregarEmpresas});
            this.tsmEmpresas.Name = "tsmEmpresas";
            this.tsmEmpresas.Size = new System.Drawing.Size(180, 22);
            this.tsmEmpresas.Text = "Empresas";
            // 
            // tsmListaEmpresas
            // 
            this.tsmListaEmpresas.Name = "tsmListaEmpresas";
            this.tsmListaEmpresas.Size = new System.Drawing.Size(116, 22);
            this.tsmListaEmpresas.Text = "Lista";
            // 
            // tsmAgregarEmpresas
            // 
            this.tsmAgregarEmpresas.Name = "tsmAgregarEmpresas";
            this.tsmAgregarEmpresas.Size = new System.Drawing.Size(116, 22);
            this.tsmAgregarEmpresas.Text = "Agregar";
            // 
            // tsmCiudades
            // 
            this.tsmCiudades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListaCiudades,
            this.tsmAgregarCiudades});
            this.tsmCiudades.Name = "tsmCiudades";
            this.tsmCiudades.Size = new System.Drawing.Size(180, 22);
            this.tsmCiudades.Text = "Ciudades";
            // 
            // tsmListaCiudades
            // 
            this.tsmListaCiudades.Name = "tsmListaCiudades";
            this.tsmListaCiudades.Size = new System.Drawing.Size(116, 22);
            this.tsmListaCiudades.Text = "Lista";
            // 
            // tsmAgregarCiudades
            // 
            this.tsmAgregarCiudades.Name = "tsmAgregarCiudades";
            this.tsmAgregarCiudades.Size = new System.Drawing.Size(116, 22);
            this.tsmAgregarCiudades.Text = "Agregar";
            // 
            // tsmProvincias
            // 
            this.tsmProvincias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListaProvincias,
            this.tsmAgregarProvincias});
            this.tsmProvincias.Name = "tsmProvincias";
            this.tsmProvincias.Size = new System.Drawing.Size(180, 22);
            this.tsmProvincias.Text = "Provincias";
            // 
            // tsmListaProvincias
            // 
            this.tsmListaProvincias.Name = "tsmListaProvincias";
            this.tsmListaProvincias.Size = new System.Drawing.Size(116, 22);
            this.tsmListaProvincias.Text = "Lista";
            // 
            // tsmAgregarProvincias
            // 
            this.tsmAgregarProvincias.Name = "tsmAgregarProvincias";
            this.tsmAgregarProvincias.Size = new System.Drawing.Size(116, 22);
            this.tsmAgregarProvincias.Text = "Agregar";
            // 
            // tsmPerfiles
            // 
            this.tsmPerfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListaPerfiles,
            this.tsmAgregarPerfiles});
            this.tsmPerfiles.Name = "tsmPerfiles";
            this.tsmPerfiles.Size = new System.Drawing.Size(113, 20);
            this.tsmPerfiles.Text = "Perfiles de trabajo";
            // 
            // tsmListaPerfiles
            // 
            this.tsmListaPerfiles.Name = "tsmListaPerfiles";
            this.tsmListaPerfiles.Size = new System.Drawing.Size(116, 22);
            this.tsmListaPerfiles.Text = "Lista";
            // 
            // tsmAgregarPerfiles
            // 
            this.tsmAgregarPerfiles.Name = "tsmAgregarPerfiles";
            this.tsmAgregarPerfiles.Size = new System.Drawing.Size(116, 22);
            this.tsmAgregarPerfiles.Text = "Agregar";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmCiudades;
        private System.Windows.Forms.ToolStripMenuItem tsmProvincias;
        private System.Windows.Forms.ToolStripMenuItem tsmPerfiles;
        private System.Windows.Forms.ToolStripMenuItem tsmListaPerfiles;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarPerfiles;
        private System.Windows.Forms.ToolStripMenuItem tsmEmpresas;
        private System.Windows.Forms.ToolStripMenuItem tsmListaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmListaEmpresas;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarEmpresas;
        private System.Windows.Forms.ToolStripMenuItem tsmListaCiudades;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarCiudades;
        private System.Windows.Forms.ToolStripMenuItem tsmListaProvincias;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarProvincias;
    }
}