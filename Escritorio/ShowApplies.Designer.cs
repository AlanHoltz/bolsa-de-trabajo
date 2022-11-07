namespace Escritorio
{
    partial class frmShowApplies
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
            this.dgvApplies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplies
            // 
            this.dgvApplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplies.Location = new System.Drawing.Point(12, 12);
            this.dgvApplies.MultiSelect = false;
            this.dgvApplies.Name = "dgvApplies";
            this.dgvApplies.ReadOnly = true;
            this.dgvApplies.RowTemplate.Height = 25;
            this.dgvApplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplies.Size = new System.Drawing.Size(598, 212);
            this.dgvApplies.TabIndex = 0;
            // 
            // frmShowApplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 418);
            this.Controls.Add(this.dgvApplies);
            this.Name = "frmShowApplies";
            this.Text = "ShowApplies";
            this.Load += new System.EventHandler(this.frmShowApplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplies;
    }
}