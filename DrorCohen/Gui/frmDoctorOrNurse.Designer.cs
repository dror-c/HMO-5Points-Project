﻿namespace DrorCohen.Gui
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMODataSet = new DrorCohen.HMODataSet();
            this.departmentTableAdapter = new DrorCohen.HMODataSetTableAdapters.DepartmentTableAdapter();
            this.tableAdapterManager = new DrorCohen.HMODataSetTableAdapters.TableAdapterManager();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.departmentDoctorNurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorOrNurseTableAdapter = new DrorCohen.HMODataSetTableAdapters.DoctorOrNurseTableAdapter();
            this.meetingForToday = new DrorCohen.MeetingForToday();
            this.specificMeetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specificMeetingDoctorTableAdapter = new DrorCohen.MeetingForTodayTableAdapters.SpecificMeetingDoctorTableAdapter();
            this.tableAdapterManager1 = new DrorCohen.MeetingForTodayTableAdapters.TableAdapterManager();
            this.specificMeetingDoctorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDoctorNurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingForToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(612, 276);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(247, 28);
            this.save.TabIndex = 55;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(198, 507);
            this.prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(110, 28);
            this.prev.TabIndex = 54;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(414, 507);
            this.next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(110, 28);
            this.next.TabIndex = 53;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.Location = new System.Drawing.Point(772, 178);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 28);
            this.cancel.TabIndex = 52;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(772, 113);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 28);
            this.Add.TabIndex = 51;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(772, 55);
            this.update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(87, 28);
            this.update.TabIndex = 49;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(290, 60);
            this.inputId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(233, 24);
            this.inputId.TabIndex = 48;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged_1);
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(290, 105);
            this.inputFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(233, 24);
            this.inputFirstName.TabIndex = 47;
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(290, 158);
            this.inputLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(233, 24);
            this.inputLastName.TabIndex = 46;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(290, 212);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(233, 24);
            this.inputAddress.TabIndex = 45;
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Location = new System.Drawing.Point(290, 263);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(233, 24);
            this.inputPhoneNumber.TabIndex = 44;
            // 
            // inputDateBirth
            // 
            this.inputDateBirth.Location = new System.Drawing.Point(290, 305);
            this.inputDateBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputDateBirth.Name = "inputDateBirth";
            this.inputDateBirth.Size = new System.Drawing.Size(233, 24);
            this.inputDateBirth.TabIndex = 43;
            // 
            // inputDateDeath
            // 
            this.inputDateDeath.Location = new System.Drawing.Point(290, 350);
            this.inputDateDeath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputDateDeath.Name = "inputDateDeath";
            this.inputDateDeath.Size = new System.Drawing.Size(233, 24);
            this.inputDateDeath.TabIndex = 42;
            // 
            // dateOfDeath
            // 
            this.dateOfDeath.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfDeath.Location = new System.Drawing.Point(75, 350);
            this.dateOfDeath.Name = "dateOfDeath";
            this.dateOfDeath.Size = new System.Drawing.Size(153, 37);
            this.dateOfDeath.TabIndex = 40;
            this.dateOfDeath.Text = "Date Of Death: ";
            // 
            // maleOrFemale
            // 
            this.maleOrFemale.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleOrFemale.Location = new System.Drawing.Point(75, 386);
            this.maleOrFemale.Name = "maleOrFemale";
            this.maleOrFemale.Size = new System.Drawing.Size(139, 37);
            this.maleOrFemale.TabIndex = 39;
            this.maleOrFemale.Text = "Gender: ";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.Location = new System.Drawing.Point(75, 263);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(153, 37);
            this.phoneNumber.TabIndex = 38;
            this.phoneNumber.Text = "Phone Number: ";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(75, 305);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(139, 37);
            this.dateOfBirth.TabIndex = 37;
            this.dateOfBirth.Text = "Date Of Birth: ";
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.Location = new System.Drawing.Point(75, 212);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(139, 32);
            this.adress.TabIndex = 36;
            this.adress.Text = "Address: ";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(75, 158);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(139, 36);
            this.lastName.TabIndex = 35;
            this.lastName.Text = "Last Name: ";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(75, 105);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(139, 39);
            this.firstName.TabIndex = 34;
            this.firstName.Text = "First Name: ";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(75, 60);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(139, 30);
            this.id.TabIndex = 33;
            this.id.Text = "id: ";
            // 
            // inputDoctorOrNurse
            // 
            this.inputDoctorOrNurse.FormattingEnabled = true;
            this.inputDoctorOrNurse.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.inputDoctorOrNurse.Location = new System.Drawing.Point(290, 436);
            this.inputDoctorOrNurse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputDoctorOrNurse.Name = "inputDoctorOrNurse";
            this.inputDoctorOrNurse.Size = new System.Drawing.Size(233, 24);
            this.inputDoctorOrNurse.TabIndex = 57;
            // 
            // DoctorOrNurse
            // 
            this.DoctorOrNurse.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorOrNurse.Location = new System.Drawing.Point(75, 432);
            this.DoctorOrNurse.Name = "DoctorOrNurse";
            this.DoctorOrNurse.Size = new System.Drawing.Size(139, 37);
            this.DoctorOrNurse.TabIndex = 56;
            this.DoctorOrNurse.Text = "Doctor/Nurse:";
            // 
            // inputDepartmentID
            // 
            this.inputDepartmentID.Enabled = false;
            this.inputDepartmentID.Location = new System.Drawing.Point(290, 475);
            this.inputDepartmentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputDepartmentID.Name = "inputDepartmentID";
            this.inputDepartmentID.Size = new System.Drawing.Size(233, 24);
            this.inputDepartmentID.TabIndex = 59;
            // 
            // DepartmentID
            // 
            this.DepartmentID.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentID.Location = new System.Drawing.Point(75, 475);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(153, 32);
            this.DepartmentID.TabIndex = 58;
            this.DepartmentID.Text = "Department ID:";
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.inputGender.Location = new System.Drawing.Point(290, 386);
            this.inputGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(233, 24);
            this.inputGender.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departmentBindingSource;
            this.comboBox1.DisplayMember = "DepartmentName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(594, 475);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.ValueMember = "DepartmentID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.hMODataSet;
            // 
            // hMODataSet
            // 
            this.hMODataSet.DataSetName = "HMODataSet";
            this.hMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConnectionTableBetweenPatientAndDoctorAndSpecificTherapyTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.DoctorOrNurseTableAdapter = null;
            this.tableAdapterManager.GenericTherapyTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.SpecificTherapyForPatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DrorCohen.HMODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboId
            // 
            this.comboId.DataSource = this.departmentBindingSource;
            this.comboId.DisplayMember = "DepartmentID";
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(772, 475);
            this.comboId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(140, 24);
            this.comboId.TabIndex = 62;
            this.comboId.ValueMember = "DepartmentID";
            this.comboId.SelectedIndexChanged += new System.EventHandler(this.comboId_SelectedIndexChanged);
            // 
            // departmentDoctorNurseBindingSource
            // 
            this.departmentDoctorNurseBindingSource.DataMember = "DepartmentDoctor/Nurse";
            this.departmentDoctorNurseBindingSource.DataSource = this.departmentBindingSource;
            // 
            // doctorOrNurseTableAdapter
            // 
            this.doctorOrNurseTableAdapter.ClearBeforeFill = true;
            // 
            // meetingForToday
            // 
            this.meetingForToday.DataSetName = "MeetingForToday";
            this.meetingForToday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specificMeetingDoctorBindingSource
            // 
            this.specificMeetingDoctorBindingSource.DataMember = "SpecificMeetingDoctor";
            this.specificMeetingDoctorBindingSource.DataSource = this.meetingForToday;
            // 
            // specificMeetingDoctorTableAdapter
            // 
            this.specificMeetingDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DrorCohen.MeetingForTodayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specificMeetingDoctorDataGridView
            // 
            this.specificMeetingDoctorDataGridView.AutoGenerateColumns = false;
            this.specificMeetingDoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specificMeetingDoctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.specificMeetingDoctorDataGridView.DataSource = this.specificMeetingDoctorBindingSource;
            this.specificMeetingDoctorDataGridView.Location = new System.Drawing.Point(981, 210);
            this.specificMeetingDoctorDataGridView.Name = "specificMeetingDoctorDataGridView";
            this.specificMeetingDoctorDataGridView.RowHeadersWidth = 51;
            this.specificMeetingDoctorDataGridView.RowTemplate.Height = 26;
            this.specificMeetingDoctorDataGridView.Size = new System.Drawing.Size(300, 220);
            this.specificMeetingDoctorDataGridView.TabIndex = 63;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Serial";
            this.dataGridViewTextBoxColumn1.HeaderText = "Serial";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TherapyCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "TherapyCode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOfTherapy";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateOfTherapy";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdPatient";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdPatient";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdDoctor";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdDoctor";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // frmDoctorOrNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1301, 777);
            this.Controls.Add(this.specificMeetingDoctorDataGridView);
            this.Controls.Add(this.comboId);
            this.Controls.Add(this.comboBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDoctorOrNurse";
            this.Text = "frmDoctorOrNurse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoctorOrNurse_FormClosing);
            this.Load += new System.EventHandler(this.frmDoctorOrNurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDoctorNurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingForToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HMODataSet hMODataSet;
        private HMODataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private HMODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.BindingSource departmentDoctorNurseBindingSource;
        private HMODataSetTableAdapters.DoctorOrNurseTableAdapter doctorOrNurseTableAdapter;
        private MeetingForToday meetingForToday;
        private System.Windows.Forms.BindingSource specificMeetingDoctorBindingSource;
        private MeetingForTodayTableAdapters.SpecificMeetingDoctorTableAdapter specificMeetingDoctorTableAdapter;
        private MeetingForTodayTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView specificMeetingDoctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}