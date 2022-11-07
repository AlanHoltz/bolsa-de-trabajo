namespace Escritorio
{
    partial class frmListProposals
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
            this.dgvProposals = new System.Windows.Forms.DataGridView();
            this.btnMirar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProposals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProposals
            // 
            this.dgvProposals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProposals.Location = new System.Drawing.Point(12, 58);
            this.dgvProposals.MultiSelect = false;
            this.dgvProposals.Name = "dgvProposals";
            this.dgvProposals.ReadOnly = true;
            this.dgvProposals.RowTemplate.Height = 25;
            this.dgvProposals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProposals.Size = new System.Drawing.Size(562, 198);
            this.dgvProposals.TabIndex = 0;
            // 
            // btnMirar
            // 
            this.btnMirar.Location = new System.Drawing.Point(499, 272);
            this.btnMirar.Name = "btnMirar";
            this.btnMirar.Size = new System.Drawing.Size(75, 23);
            this.btnMirar.TabIndex = 1;
            this.btnMirar.Text = "Mirar";
            this.btnMirar.UseVisualStyleBackColor = true;
            this.btnMirar.Click += new System.EventHandler(this.btnMirar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(404, 272);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmListProposals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 307);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMirar);
            this.Controls.Add(this.dgvProposals);
            this.Name = "frmListProposals";
            this.Text = "ListProposals";
            this.Load += new System.EventHandler(this.ListProposals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProposals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProposals;
        private System.Windows.Forms.Button btnMirar;
        private System.Windows.Forms.Button btnAgregar;
    }
}