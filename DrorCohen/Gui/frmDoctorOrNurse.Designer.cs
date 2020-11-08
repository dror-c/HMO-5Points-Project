namespace DrorCohen.Gui
{
    partial class frmDoctorOrNurse
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.save = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputPhoneNumber = new System.Windows.Forms.TextBox();
            this.inputDateBirth = new System.Windows.Forms.DateTimePicker();
            this.inputDateDeath = new System.Windows.Forms.DateTimePicker();
            this.dateOfDeath = new System.Windows.Forms.Label();
            this.maleOrFemale = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.inputDoctorOrNurse = new System.Windows.Forms.ComboBox();
            this.DoctorOrNurse = new System.Windows.Forms.Label();
            this.inputDepartmentID = new System.Windows.Forms.TextBox();
            this.DepartmentID = new System.Windows.Forms.Label();
            this.inputGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(525, 317);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(212, 23);
            this.save.TabIndex = 55;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(170, 412);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(94, 23);
            this.prev.TabIndex = 54;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(355, 412);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 23);
            this.next.TabIndex = 53;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.Location = new System.Drawing.Point(662, 197);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 52;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(662, 144);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 51;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(662, 94);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 50;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(662, 45);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 49;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(249, 49);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(200, 20);
            this.inputId.TabIndex = 48;
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(249, 85);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(200, 20);
            this.inputFirstName.TabIndex = 47;
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(249, 128);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(200, 20);
            this.inputLastName.TabIndex = 46;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(249, 172);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(200, 20);
            this.inputAddress.TabIndex = 45;
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Location = new System.Drawing.Point(249, 214);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.inputPhoneNumber.TabIndex = 44;
            // 
            // inputDateBirth
            // 
            this.inputDateBirth.Location = new System.Drawing.Point(249, 248);
            this.inputDateBirth.Name = "inputDateBirth";
            this.inputDateBirth.Size = new System.Drawing.Size(200, 20);
            this.inputDateBirth.TabIndex = 43;
            // 
            // inputDateDeath
            // 
            this.inputDateDeath.Location = new System.Drawing.Point(249, 284);
            this.inputDateDeath.Name = "inputDateDeath";
            this.inputDateDeath.Size = new System.Drawing.Size(200, 20);
            this.inputDateDeath.TabIndex = 42;
            // 
            // dateOfDeath
            // 
            this.dateOfDeath.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfDeath.Location = new System.Drawing.Point(64, 284);
            this.dateOfDeath.Name = "dateOfDeath";
            this.dateOfDeath.Size = new System.Drawing.Size(131, 30);
            this.dateOfDeath.TabIndex = 40;
            this.dateOfDeath.Text = "Date Of Death: ";
            // 
            // maleOrFemale
            // 
            this.maleOrFemale.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleOrFemale.Location = new System.Drawing.Point(64, 314);
            this.maleOrFemale.Name = "maleOrFemale";
            this.maleOrFemale.Size = new System.Drawing.Size(119, 30);
            this.maleOrFemale.TabIndex = 39;
            this.maleOrFemale.Text = "Gender: ";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.Location = new System.Drawing.Point(64, 214);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(131, 30);
            this.phoneNumber.TabIndex = 38;
            this.phoneNumber.Text = "Phone Number: ";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(64, 248);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(119, 30);
            this.dateOfBirth.TabIndex = 37;
            this.dateOfBirth.Text = "Date Of Birth: ";
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.Location = new System.Drawing.Point(64, 172);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(119, 26);
            this.adress.TabIndex = 36;
            this.adress.Text = "Address: ";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(64, 128);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(119, 29);
            this.lastName.TabIndex = 35;
            this.lastName.Text = "Last Name: ";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(64, 85);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(119, 32);
            this.firstName.TabIndex = 34;
            this.firstName.Text = "First Name: ";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(64, 49);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(119, 24);
            this.id.TabIndex = 33;
            this.id.Text = "id: ";
            // 
            // inputDoctorOrNurse
            // 
            this.inputDoctorOrNurse.FormattingEnabled = true;
            this.inputDoctorOrNurse.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.inputDoctorOrNurse.Location = new System.Drawing.Point(249, 354);
            this.inputDoctorOrNurse.Name = "inputDoctorOrNurse";
            this.inputDoctorOrNurse.Size = new System.Drawing.Size(200, 21);
            this.inputDoctorOrNurse.TabIndex = 57;
            // 
            // DoctorOrNurse
            // 
            this.DoctorOrNurse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorOrNurse.Location = new System.Drawing.Point(64, 351);
            this.DoctorOrNurse.Name = "DoctorOrNurse";
            this.DoctorOrNurse.Size = new System.Drawing.Size(119, 30);
            this.DoctorOrNurse.TabIndex = 56;
            this.DoctorOrNurse.Text = "Doctor/Nurse:";
            // 
            // inputDepartmentID
            // 
            this.inputDepartmentID.Location = new System.Drawing.Point(249, 386);
            this.inputDepartmentID.Name = "inputDepartmentID";
            this.inputDepartmentID.Size = new System.Drawing.Size(200, 20);
            this.inputDepartmentID.TabIndex = 59;
            // 
            // DepartmentID
            // 
            this.DepartmentID.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentID.Location = new System.Drawing.Point(64, 386);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(131, 26);
            this.DepartmentID.TabIndex = 58;
            this.DepartmentID.Text = "Department ID:";
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.inputGender.Location = new System.Drawing.Point(249, 314);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(200, 21);
            this.inputGender.TabIndex = 60;
            // 
            // frmDoctorOrNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(837, 487);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputDepartmentID);
            this.Controls.Add(this.DepartmentID);
            this.Controls.Add(this.inputDoctorOrNurse);
            this.Controls.Add(this.DoctorOrNurse);
            this.Controls.Add(this.save);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputPhoneNumber);
            this.Controls.Add(this.inputDateBirth);
            this.Controls.Add(this.inputDateDeath);
            this.Controls.Add(this.dateOfDeath);
            this.Controls.Add(this.maleOrFemale);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.id);
            this.Name = "frmDoctorOrNurse";
            this.Text = "frmDoctorOrNurse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoctorOrNurse_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.TextBox inputPhoneNumber;
        private System.Windows.Forms.DateTimePicker inputDateBirth;
        private System.Windows.Forms.DateTimePicker inputDateDeath;
        private System.Windows.Forms.Label dateOfDeath;
        private System.Windows.Forms.Label maleOrFemale;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox inputDepartmentID;
        private System.Windows.Forms.Label DepartmentID;
        private System.Windows.Forms.ComboBox inputDoctorOrNurse;
        private System.Windows.Forms.Label DoctorOrNurse;
        private System.Windows.Forms.ComboBox inputGender;
    }
}