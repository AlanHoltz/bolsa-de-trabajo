
namespace Escritorio
{
    partial class CompanyDesktop
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalendarBirthDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferenceName = new System.Windows.Forms.TextBox();
            this.txtSignupDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReferencePhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReferenceEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferenceArea = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.chkWorkCompany = new System.Windows.Forms.CheckBox();
            this.Ciudades = new System.Windows.Forms.ListBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(87, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(63, 23);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 23);
            this.txtName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Date:";
            // 
            // CalendarBirthDate
            // 
            this.CalendarBirthDate.Location = new System.Drawing.Point(33, 160);
            this.CalendarBirthDate.Name = "CalendarBirthDate";
            this.CalendarBirthDate.ShowToday = false;
            this.CalendarBirthDate.ShowTodayCircle = false;
            this.CalendarBirthDate.TabIndex = 100;
            this.CalendarBirthDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarBirthDate_DateSelected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(396, 123);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(192, 23);
            this.txtCategory.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(445, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(526, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(87, 131);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = true;
            this.txtBirthDate.Size = new System.Drawing.Size(192, 23);
            this.txtBirthDate.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reference Name:";
            // 
            // txtReferenceName
            // 
            this.txtReferenceName.Location = new System.Drawing.Point(396, 166);
            this.txtReferenceName.Name = "txtReferenceName";
            this.txtReferenceName.Size = new System.Drawing.Size(192, 23);
            this.txtReferenceName.TabIndex = 14;
            // 
            // txtSignupDate
            // 
            this.txtSignupDate.Location = new System.Drawing.Point(396, 330);
            this.txtSignupDate.Name = "txtSignupDate";
            this.txtSignupDate.ReadOnly = true;
            this.txtSignupDate.Size = new System.Drawing.Size(192, 23);
            this.txtSignupDate.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Signup Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cuit:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(87, 99);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(192, 23);
            this.txtCuit.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 101;
            this.label9.Text = "Reference Phone:";
            // 
            // txtReferencePhone
            // 
            this.txtReferencePhone.Location = new System.Drawing.Point(396, 203);
            this.txtReferencePhone.Name = "txtReferencePhone";
            this.txtReferencePhone.Size = new System.Drawing.Size(192, 23);
            this.txtReferencePhone.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "Reference Email:";
            // 
            // txtReferenceEmail
            // 
            this.txtReferenceEmail.Location = new System.Drawing.Point(396, 241);
            this.txtReferenceEmail.Name = "txtReferenceEmail";
            this.txtReferenceEmail.Size = new System.Drawing.Size(192, 23);
            this.txtReferenceEmail.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 105;
            this.label11.Text = "Reference Area:";
            // 
            // txtReferenceArea
            // 
            this.txtReferenceArea.Location = new System.Drawing.Point(396, 276);
            this.txtReferenceArea.Name = "txtReferenceArea";
            this.txtReferenceArea.Size = new System.Drawing.Size(192, 23);
            this.txtReferenceArea.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 107;
            this.label12.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(396, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 108;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 109;
            this.label13.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(396, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 23);
            this.txtAddress.TabIndex = 110;
            // 
            // chkWorkCompany
            // 
            this.chkWorkCompany.AutoSize = true;
            this.chkWorkCompany.Location = new System.Drawing.Point(464, 305);
            this.chkWorkCompany.Name = "chkWorkCompany";
            this.chkWorkCompany.Size = new System.Drawing.Size(124, 19);
            this.chkWorkCompany.TabIndex = 111;
            this.chkWorkCompany.Text = "Work on company";
            this.chkWorkCompany.UseVisualStyleBackColor = true;
            // 
            // Ciudades
            // 
            this.Ciudades.DataSource = this.cityBindingSource;
            this.Ciudades.FormattingEnabled = true;
            this.Ciudades.ItemHeight = 15;
            this.Ciudades.Location = new System.Drawing.Point(33, 339);
            this.Ciudades.Name = "Ciudades";
            this.Ciudades.Size = new System.Drawing.Size(248, 49);
            this.Ciudades.TabIndex = 112;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Bolsa.Entities.City);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 113;
            this.label14.Text = "Cities:";
            // 
            // CompanyDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(613, 394);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Ciudades);
            this.Controls.Add(this.chkWorkCompany);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtReferenceArea);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReferenceEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtReferencePhone);
            this.Controls.Add(this.txtSignupDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReferenceName);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.CalendarBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyDesktop";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.CompanyDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar CalendarBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.CheckBox chkWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReferenceName;
        private System.Windows.Forms.TextBox txtSignupDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReferencePhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReferenceEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReferenceArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox chkWorkCompany;
        private System.Windows.Forms.ListBox Ciudades;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Label label14;
    }
}