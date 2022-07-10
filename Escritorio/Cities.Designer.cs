
namespace Escritorio
{
    partial class Cities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cities));
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dvgCities = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsUsuarios = new System.Windows.Forms.ToolStrip();
            this.tbsNew = new System.Windows.Forms.ToolStripButton();
            this.tbsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.tlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCities)).BeginInit();
            this.tsUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tlUsuarios);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(952, 425);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(952, 450);
            this.tcUsuarios.TabIndex = 0;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.tsUsuarios);
            // 
            // tlUsuarios
            // 
            this.tlUsuarios.ColumnCount = 2;
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarios.Controls.Add(this.dvgCities, 0, 0);
            this.tlUsuarios.Controls.Add(this.btnActualizar, 0, 1);
            this.tlUsuarios.Controls.Add(this.btnSalir, 1, 1);
            this.tlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlUsuarios.Name = "tlUsuarios";
            this.tlUsuarios.RowCount = 2;
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarios.Size = new System.Drawing.Size(952, 425);
            this.tlUsuarios.TabIndex = 0;
            // 
            // dvgCities
            // 
            this.dvgCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZipCode,
            this.Descripcion,
            this.IdProvincia});
            this.tlUsuarios.SetColumnSpan(this.dvgCities, 2);
            this.dvgCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgCities.Location = new System.Drawing.Point(3, 3);
            this.dvgCities.MultiSelect = false;
            this.dvgCities.Name = "dvgCities";
            this.dvgCities.ReadOnly = true;
            this.dvgCities.RowTemplate.Height = 25;
            this.dvgCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCities.Size = new System.Drawing.Size(946, 390);
            this.dvgCities.TabIndex = 0;
            this.dvgCities.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCities_CellContentDoubleClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(793, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(874, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsNew,
            this.tbsEdit,
            this.tsbDelete});
            this.tsUsuarios.Location = new System.Drawing.Point(3, 0);
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(81, 25);
            this.tsUsuarios.TabIndex = 0;
            // 
            // tbsNew
            // 
            this.tbsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsNew.Image = ((System.Drawing.Image)(resources.GetObject("tbsNew.Image")));
            this.tbsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsNew.Name = "tbsNew";
            this.tbsNew.Size = new System.Drawing.Size(23, 22);
            this.tbsNew.Text = "Agregar";
            this.tbsNew.Click += new System.EventHandler(this.tbsNew_Click);
            // 
            // tbsEdit
            // 
            this.tbsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbsEdit.Image")));
            this.tbsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsEdit.Name = "tbsEdit";
            this.tbsEdit.Size = new System.Drawing.Size(23, 22);
            this.tbsEdit.Text = "Editar";
            this.tbsEdit.Click += new System.EventHandler(this.tbsEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Eliminar";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // ZipCode
            // 
            this.ZipCode.DataPropertyName = "ZipCode";
            this.ZipCode.HeaderText = "City Zip Code";
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
            this.ZipCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ZipCode.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Name";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 250;
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "ProvinceID";
            this.IdProvincia.HeaderText = "ID Provincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            this.IdProvincia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.tcUsuarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cities";
            this.Text = "Cities";
            this.Load += new System.EventHandler(this.Cities_Load);
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.tlUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCities)).EndInit();
            this.tsUsuarios.ResumeLayout(false);
            this.tsUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlUsuarios;
        private System.Windows.Forms.DataGridView dvgCities;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.ToolStripButton tbsNew;
        private System.Windows.Forms.ToolStripButton tbsEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
    }
}