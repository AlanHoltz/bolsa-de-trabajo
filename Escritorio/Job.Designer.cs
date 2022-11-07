﻿using System.Windows.Forms;

namespace Escritorio
{
    partial class frmJob
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
            this.picCompany = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblStartingDateValue = new System.Windows.Forms.Label();
            this.lblEndingDate = new System.Windows.Forms.Label();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.lblEndingDateValue = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.btnNoApply = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // picCompany
            // 
            this.picCompany.Location = new System.Drawing.Point(12, 12);
            this.picCompany.Name = "picCompany";
            this.picCompany.Size = new System.Drawing.Size(132, 103);
            this.picCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompany.TabIndex = 0;
            this.picCompany.TabStop = false;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.Location = new System.Drawing.Point(159, 33);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 25);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "label1";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(162, 80);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(38, 15);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "label1";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(676, 56);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblStartingDateValue
            // 
            this.lblStartingDateValue.AutoSize = true;
            this.lblStartingDateValue.Location = new System.Drawing.Point(106, 172);
            this.lblStartingDateValue.Name = "lblStartingDateValue";
            this.lblStartingDateValue.Size = new System.Drawing.Size(38, 15);
            this.lblStartingDateValue.TabIndex = 5;
            this.lblStartingDateValue.Text = "label2";
            // 
            // lblEndingDate
            // 
            this.lblEndingDate.AutoSize = true;
            this.lblEndingDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEndingDate.Location = new System.Drawing.Point(12, 209);
            this.lblEndingDate.Name = "lblEndingDate";
            this.lblEndingDate.Size = new System.Drawing.Size(76, 15);
            this.lblEndingDate.TabIndex = 6;
            this.lblEndingDate.Text = "Fecha de Fin:";
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStartingDate.Location = new System.Drawing.Point(12, 172);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(89, 15);
            this.lblStartingDate.TabIndex = 7;
            this.lblStartingDate.Text = "Fecha de Inicio:";
            // 
            // lblEndingDateValue
            // 
            this.lblEndingDateValue.AutoSize = true;
            this.lblEndingDateValue.Location = new System.Drawing.Point(106, 209);
            this.lblEndingDateValue.Name = "lblEndingDateValue";
            this.lblEndingDateValue.Size = new System.Drawing.Size(38, 15);
            this.lblEndingDateValue.TabIndex = 8;
            this.lblEndingDateValue.Text = "label1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddress.Location = new System.Drawing.Point(12, 244);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 15);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Dirección:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCapacity.Location = new System.Drawing.Point(12, 280);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(56, 15);
            this.lblCapacity.TabIndex = 10;
            this.lblCapacity.Text = "Vacantes:";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Location = new System.Drawing.Point(106, 244);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(38, 15);
            this.lblAddressValue.TabIndex = 11;
            this.lblAddressValue.Text = "label3";
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Location = new System.Drawing.Point(106, 280);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(38, 15);
            this.lblCapacityValue.TabIndex = 12;
            this.lblCapacityValue.Text = "label4";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(12, 354);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(38, 15);
            this.lblDescriptionValue.TabIndex = 13;
            this.lblDescriptionValue.Text = "label5";
            // 
            // btnNoApply
            // 
            this.btnNoApply.Location = new System.Drawing.Point(676, 56);
            this.btnNoApply.Name = "btnNoApply";
            this.btnNoApply.Size = new System.Drawing.Size(75, 23);
            this.btnNoApply.TabIndex = 14;
            this.btnNoApply.Text = "Cancelar";
            this.btnNoApply.UseVisualStyleBackColor = true;
            this.btnNoApply.Click += new System.EventHandler(this.btnNoApply_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(595, 58);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(156, 17);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "PROPUESTA PENDIENTE";
            // 
            // formJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNoApply);
            this.Controls.Add(this.lblDescriptionValue);
            this.Controls.Add(this.lblCapacityValue);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEndingDateValue);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.lblEndingDate);
            this.Controls.Add(this.lblStartingDateValue);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.picCompany);
            this.Name = "formJob";
            this.Text = "Job";
            ((System.ComponentModel.ISupportInitialize)(this.picCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCompany;
        private Label lblPosition;
        private Label lblCompany;
        private Button btnApply;
        private Label lblStartingDateValue;
        private Label lblEndingDate;
        private Label lblStartingDate;
        private Label lblEndingDateValue;
        private Label lblAddress;
        private Label lblCapacity;
        private Label lblAddressValue;
        private Label lblCapacityValue;
        private Label lblDescriptionValue;
        private Button btnNoApply;
        private Label lblStatus;
    }
}