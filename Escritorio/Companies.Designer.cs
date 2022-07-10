namespace Escritorio
{
    partial class Companies
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
            this.tcCompanies = new System.Windows.Forms.ToolStripContainer();
            this.tlCompanies = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferencePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsCompanies = new System.Windows.Forms.ToolStrip();
            this.tbsNew = new System.Windows.Forms.ToolStripButton();
            this.tbsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tcCompanies.ContentPanel.SuspendLayout();
            this.tcCompanies.TopToolStripPanel.SuspendLayout();
            this.tcCompanies.SuspendLayout();
            this.tlCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.tsCompanies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCompanies
            // 
            // 
            // tcCompanies.ContentPanel
            // 
            this.tcCompanies.ContentPanel.Controls.Add(this.tlCompanies);
            this.tcCompanies.ContentPanel.Size = new System.Drawing.Size(952, 425);
            this.tcCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCompanies.Location = new System.Drawing.Point(0, 0);
            this.tcCompanies.Name = "tcCompanies";
            this.tcCompanies.Size = new System.Drawing.Size(952, 450);
            this.tcCompanies.TabIndex = 0;
            this.tcCompanies.Text = "toolStripContainer1";
            // 
            // tcCompanies.TopToolStripPanel
            // 
            this.tcCompanies.TopToolStripPanel.Controls.Add(this.tsCompanies);
            // 
            // tlCompanies
            // 
            this.tlCompanies.ColumnCount = 2;
            this.tlCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCompanies.Controls.Add(this.dgvCompanies, 0, 0);
            this.tlCompanies.Controls.Add(this.btnActualizar, 0, 1);
            this.tlCompanies.Controls.Add(this.btnSalir, 1, 1);
            this.tlCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCompanies.Location = new System.Drawing.Point(0, 0);
            this.tlCompanies.Name = "tlCompanies";
            this.tlCompanies.RowCount = 2;
            this.tlCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCompanies.Size = new System.Drawing.Size(952, 425);
            this.tlCompanies.TabIndex = 0;
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Cuit,
            this.Category,
            this.ReferenceName,
            this.ReferencePhone,
            this.Email,
            this.ReferenceEmail,
            this.Status,
            this.SignupDate});
            this.tlCompanies.SetColumnSpan(this.dgvCompanies, 2);
            this.dgvCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompanies.Location = new System.Drawing.Point(3, 3);
            this.dgvCompanies.MultiSelect = false;
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.ReadOnly = true;
            this.dgvCompanies.RowTemplate.Height = 25;
            this.dgvCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanies.Size = new System.Drawing.Size(946, 390);
            this.dgvCompanies.TabIndex = 0;
            this.dgvCompanies.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompanies_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            this.Cuit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReferenceName
            // 
            this.ReferenceName.DataPropertyName = "ReferenceName";
            this.ReferenceName.HeaderText = "Reference Name";
            this.ReferenceName.Name = "ReferenceName";
            this.ReferenceName.ReadOnly = true;
            this.ReferenceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReferencePhone
            // 
            this.ReferencePhone.DataPropertyName = "ReferencePhone";
            this.ReferencePhone.HeaderText = "Reference Phone";
            this.ReferencePhone.Name = "ReferencePhone";
            this.ReferencePhone.ReadOnly = true;
            this.ReferencePhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Mail";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReferenceEmail
            // 
            this.ReferenceEmail.DataPropertyName = "ReferenceEmail";
            this.ReferenceEmail.HeaderText = "Reference Email";
            this.ReferenceEmail.Name = "ReferenceEmail";
            this.ReferenceEmail.ReadOnly = true;
            this.ReferenceEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SignupDate
            // 
            this.SignupDate.DataPropertyName = "Date";
            this.SignupDate.HeaderText = "Signup Date";
            this.SignupDate.Name = "SignupDate";
            this.SignupDate.ReadOnly = true;
            this.SignupDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // tsCompanies
            // 
            this.tsCompanies.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCompanies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsNew,
            this.tbsEdit,
            this.tsbDelete});
            this.tsCompanies.Location = new System.Drawing.Point(3, 0);
            this.tsCompanies.Name = "tsCompanies";
            this.tsCompanies.Size = new System.Drawing.Size(112, 25);
            this.tsCompanies.TabIndex = 0;
            // 
            // tbsNew
            // 
            this.tbsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsNew.Name = "tbsNew";
            this.tbsNew.Size = new System.Drawing.Size(23, 22);
            this.tbsNew.Text = "Agregar";
            this.tbsNew.Click += new System.EventHandler(this.tbsNew_Click);
            // 
            // tbsEdit
            // 
            this.tbsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsEdit.Name = "tbsEdit";
            this.tbsEdit.Size = new System.Drawing.Size(23, 22);
            this.tbsEdit.Text = "Editar";
            this.tbsEdit.Click += new System.EventHandler(this.tbsEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Eliminar";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.tcCompanies);
            this.Name.Name = "Companies";
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.Companies_Load);
            this.tcCompanies.ContentPanel.ResumeLayout(false);
            this.tcCompanies.TopToolStripPanel.ResumeLayout(false);
            this.tcCompanies.TopToolStripPanel.PerformLayout();
            this.tcCompanies.ResumeLayout(false);
            this.tcCompanies.PerformLayout();
            this.tlCompanies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.tsCompanies.ResumeLayout(false);
            this.tsCompanies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCompanies;
        private System.Windows.Forms.TableLayoutPanel tlCompanies;
        private System.Windows.Forms.DataGridView dgvCompanies;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCompanies;
        private System.Windows.Forms.ToolStripButton tbsNew;
        private System.Windows.Forms.ToolStripButton tbsEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferencePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignupDate;
    }
}