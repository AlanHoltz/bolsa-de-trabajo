
namespace Escritorio
{
    partial class Provinces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provinces));
            this.tcProvinces = new System.Windows.Forms.ToolStripContainer();
            this.tlProvinces = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProvinces = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsProvinces = new System.Windows.Forms.ToolStrip();
            this.tbsNew = new System.Windows.Forms.ToolStripButton();
            this.tbsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tcProvinces.ContentPanel.SuspendLayout();
            this.tcProvinces.TopToolStripPanel.SuspendLayout();
            this.tcProvinces.SuspendLayout();
            this.tlProvinces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvinces)).BeginInit();
            this.tsProvinces.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProvinces
            // 
            // 
            // tcProvinces.ContentPanel
            // 
            this.tcProvinces.ContentPanel.Controls.Add(this.tlProvinces);
            this.tcProvinces.ContentPanel.Size = new System.Drawing.Size(952, 425);
            this.tcProvinces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProvinces.Location = new System.Drawing.Point(0, 0);
            this.tcProvinces.Name = "tcProvinces";
            this.tcProvinces.Size = new System.Drawing.Size(952, 450);
            this.tcProvinces.TabIndex = 0;
            this.tcProvinces.Text = "toolStripContainer1";
            // 
            // tcProvinces.TopToolStripPanel
            // 
            this.tcProvinces.TopToolStripPanel.Controls.Add(this.tsProvinces);
            // 
            // tlProvinces
            // 
            this.tlProvinces.ColumnCount = 2;
            this.tlProvinces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlProvinces.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlProvinces.Controls.Add(this.dgvProvinces, 0, 0);
            this.tlProvinces.Controls.Add(this.btnActualizar, 0, 1);
            this.tlProvinces.Controls.Add(this.btnSalir, 1, 1);
            this.tlProvinces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlProvinces.Location = new System.Drawing.Point(0, 0);
            this.tlProvinces.Name = "tlProvinces";
            this.tlProvinces.RowCount = 2;
            this.tlProvinces.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlProvinces.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlProvinces.Size = new System.Drawing.Size(952, 425);
            this.tlProvinces.TabIndex = 0;
            // 
            // dgvProvinces
            // 
            this.dgvProvinces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvinces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name
            });
            this.tlProvinces.SetColumnSpan(this.dgvProvinces, 2);
            this.dgvProvinces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProvinces.Location = new System.Drawing.Point(3, 3);
            this.dgvProvinces.MultiSelect = false;
            this.dgvProvinces.Name = "dgvProvinces";
            this.dgvProvinces.ReadOnly = true;
            this.dgvProvinces.RowTemplate.Height = 25;
            this.dgvProvinces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvinces.Size = new System.Drawing.Size(946, 390);
            this.dgvProvinces.TabIndex = 0;
            this.dgvProvinces.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvinces_CellContentDoubleClick);
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
            // tsProvinces
            // 
            this.tsProvinces.Dock = System.Windows.Forms.DockStyle.None;
            this.tsProvinces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsNew,
            this.tbsEdit,
            this.tsbDelete});
            this.tsProvinces.Location = new System.Drawing.Point(3, 0);
            this.tsProvinces.Name = "tsProvinces";
            this.tsProvinces.Size = new System.Drawing.Size(81, 25);
            this.tsProvinces.TabIndex = 0;
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
            // Provinces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.tcProvinces);
            this.Name.Name = "Provinces";
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.Provinces_Load);
            this.tcProvinces.ContentPanel.ResumeLayout(false);
            this.tcProvinces.TopToolStripPanel.ResumeLayout(false);
            this.tcProvinces.TopToolStripPanel.PerformLayout();
            this.tcProvinces.ResumeLayout(false);
            this.tcProvinces.PerformLayout();
            this.tlProvinces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvinces)).EndInit();
            this.tsProvinces.ResumeLayout(false);
            this.tsProvinces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcProvinces;
        private System.Windows.Forms.TableLayoutPanel tlProvinces;
        private System.Windows.Forms.DataGridView dgvProvinces;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsProvinces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.ToolStripButton tbsNew;
        private System.Windows.Forms.ToolStripButton tbsEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}