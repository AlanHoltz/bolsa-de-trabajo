namespace Escritorio
{
    partial class frmDashboard
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
            this.menuDashboard = new System.Windows.Forms.MenuStrip();
            this.trabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspProposals = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tspEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDashboard
            // 
            this.menuDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajosToolStripMenuItem,
            this.aplicacionesToolStripMenuItem,
            this.tspProposals,
            this.administradorToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.menuDashboard.Location = new System.Drawing.Point(0, 0);
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(800, 24);
            this.menuDashboard.TabIndex = 0;
            this.menuDashboard.Text = "menuStrip1";
            // 
            // trabajosToolStripMenuItem
            // 
            this.trabajosToolStripMenuItem.Name = "trabajosToolStripMenuItem";
            this.trabajosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trabajosToolStripMenuItem.Text = "Trabajos";
            this.trabajosToolStripMenuItem.Click += new System.EventHandler(this.trabajosToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // tspProposals
            // 
            this.tspProposals.Name = "tspProposals";
            this.tspProposals.Size = new System.Drawing.Size(77, 20);
            this.tspProposals.Text = "Propuestas";
            this.tspProposals.Click += new System.EventHandler(this.tspProposals_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPersonas,
            this.tspEmpresas});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // tspPersonas
            // 
            this.tspPersonas.Name = "tspPersonas";
            this.tspPersonas.Size = new System.Drawing.Size(124, 22);
            this.tspPersonas.Text = "Personas";
            this.tspPersonas.Click += new System.EventHandler(this.tspPersonas_Click);
            // 
            // tspEmpresas
            // 
            this.tspEmpresas.Name = "tspEmpresas";
            this.tspEmpresas.Size = new System.Drawing.Size(124, 22);
            this.tspEmpresas.Text = "Empresas";
            this.tspEmpresas.Click += new System.EventHandler(this.tspEmpresas_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.Brown;
            this.lblBienvenida.Location = new System.Drawing.Point(12, 44);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(65, 25);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "label1";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuDashboard);
            this.MainMenuStrip = this.menuDashboard;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Shown += new System.EventHandler(this.PersonDashboard_Shown);
            this.menuDashboard.ResumeLayout(false);
            this.menuDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuDashboard;
        private System.Windows.Forms.ToolStripMenuItem trabajosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspPersonas;
        private System.Windows.Forms.ToolStripMenuItem tspEmpresas;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ToolStripMenuItem tspProposals;
    }
}