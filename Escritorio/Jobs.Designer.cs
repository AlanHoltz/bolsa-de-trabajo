namespace Escritorio
{
    partial class frmJobs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.btnLook = new System.Windows.Forms.Button();
            this.lblJobs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(12, 37);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowTemplate.Height = 25;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(539, 220);
            this.dgvJobs.TabIndex = 0;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(476, 285);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 1;
            this.btnLook.Text = "Mirar";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJobs.Location = new System.Drawing.Point(12, 4);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(89, 30);
            this.lblJobs.TabIndex = 2;
            this.lblJobs.Text = "Trabajos";
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 320);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.dgvJobs);
            this.Name = "frmJobs";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.Persons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Label lblJobs;
    }
}
