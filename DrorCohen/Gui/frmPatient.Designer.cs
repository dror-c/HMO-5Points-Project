﻿namespace DrorCohen.Gui
{
    partial class frmPatient
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
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.maleOrFemale = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.inputPhoneNumber = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputId = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.search = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lastNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderTherapy = new System.Windows.Forms.Button();
            this.futurePatient = new DrorCohen.FuturePatient();
            this.specificMeetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specificMeetingDoctorTableAdapter = new DrorCohen.FuturePatientTableAdapters.SpecificMeetingDoctorTableAdapter();
            this.tableAdapterManager = new DrorCohen.FuturePatientTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idPatientToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idPatientToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dateOfTherapyToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateOfTherapyToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.specificMeetingDoctorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDateBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futurePatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.inputGender.Location = new System.Drawing.Point(263, 372);
            this.inputGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(264, 24);
            this.inputGender.TabIndex = 18;
            this.inputGender.Validating += new System.ComponentModel.CancelEventHandler(this.inputGender_Validating);
            // 
            // maleOrFemale
            // 
            this.maleOrFemale.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleOrFemale.ForeColor = System.Drawing.Color.Blue;
            this.maleOrFemale.Location = new System.Drawing.Point(16, 368);
            this.maleOrFemale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maleOrFemale.Name = "maleOrFemale";
            this.maleOrFemale.Size = new System.Drawing.Size(159, 37);
            this.maleOrFemale.TabIndex = 16;
            this.maleOrFemale.Text = "Gender: ";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.ForeColor = System.Drawing.Color.Blue;
            this.phoneNumber.Location = new System.Drawing.Point(16, 245);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(216, 37);
            this.phoneNumber.TabIndex = 15;
            this.phoneNumber.Text = "Phone Number: ";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.ForeColor = System.Drawing.Color.Blue;
            this.dateOfBirth.Location = new System.Drawing.Point(12, 287);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(220, 37);
            this.dateOfBirth.TabIndex = 14;
            this.dateOfBirth.Text = "Date Of Birth: ";
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.ForeColor = System.Drawing.Color.Blue;
            this.adress.Location = new System.Drawing.Point(16, 193);
            this.adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(159, 32);
            this.adress.TabIndex = 13;
            this.adress.Text = "Address: ";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Blue;
            this.lastName.Location = new System.Drawing.Point(16, 139);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(159, 36);
            this.lastName.TabIndex = 12;
            this.lastName.Text = "Last Name: ";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Blue;
            this.firstName.Location = new System.Drawing.Point(16, 86);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(159, 39);
            this.firstName.TabIndex = 11;
            this.firstName.Text = "First Name: ";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.White;
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Blue;
            this.id.Location = new System.Drawing.Point(16, 42);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(159, 30);
            this.id.TabIndex = 10;
            this.id.Text = "id: ";
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Location = new System.Drawing.Point(263, 245);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(264, 22);
            this.inputPhoneNumber.TabIndex = 21;
            this.inputPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.inputPhoneNumber_Validating);
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(263, 193);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(264, 22);
            this.inputAddress.TabIndex = 22;
            this.inputAddress.Validating += new System.ComponentModel.CancelEventHandler(this.inputAddress_Validating);
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(263, 139);
            this.inputLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(264, 22);
            this.inputLastName.TabIndex = 23;
            this.inputLastName.Validating += new System.ComponentModel.CancelEventHandler(this.inputLastName_Validating);
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(263, 86);
            this.inputFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(264, 22);
            this.inputFirstName.TabIndex = 24;
            this.inputFirstName.TextChanged += new System.EventHandler(this.inputFirstName_TextChanged);
            this.inputFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.inputFirstName_Validating);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(263, 42);
            this.inputId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(264, 22);
            this.inputId.TabIndex = 25;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            this.inputId.Validating += new System.ComponentModel.CancelEventHandler(this.inputId_Validating);
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(708, 134);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 38);
            this.update.TabIndex = 26;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(708, 90);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 37);
            this.Add.TabIndex = 28;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(708, 192);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 32);
            this.cancel.TabIndex = 29;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // next
            // 
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(404, 452);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(124, 28);
            this.next.TabIndex = 30;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Location = new System.Drawing.Point(156, 452);
            this.prev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(124, 28);
            this.prev.TabIndex = 31;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(708, 251);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(284, 39);
            this.save.TabIndex = 32;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // search
            // 
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(1104, 289);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(160, 34);
            this.search.TabIndex = 33;
            this.search.Text = "submit";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1104, 149);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 116);
            this.listBox1.TabIndex = 34;
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.HideSelection = false;
            this.lastNameSearch.Location = new System.Drawing.Point(1103, 82);
            this.lastNameSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameSearch.Multiline = true;
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(160, 43);
            this.lastNameSearch.TabIndex = 35;
            this.lastNameSearch.Text = "enter last name\r\n to search the patient";
            this.lastNameSearch.Click += new System.EventHandler(this.lastNameSearch_Click);
            this.lastNameSearch.TextChanged += new System.EventHandler(this.lastNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1099, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 49);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderTherapy
            // 
            this.orderTherapy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderTherapy.Location = new System.Drawing.Point(708, 46);
            this.orderTherapy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderTherapy.Name = "orderTherapy";
            this.orderTherapy.Size = new System.Drawing.Size(164, 37);
            this.orderTherapy.TabIndex = 37;
            this.orderTherapy.Text = "order therapy";
            this.orderTherapy.UseVisualStyleBackColor = true;
            this.orderTherapy.Click += new System.EventHandler(this.orderTherapy_Click);
            this.orderTherapy.Validated += new System.EventHandler(this.orderTherapy_Validated);
            // 
            // futurePatient
            // 
            this.futurePatient.DataSetName = "FuturePatient";
            this.futurePatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specificMeetingDoctorBindingSource
            // 
            this.specificMeetingDoctorBindingSource.DataMember = "SpecificMeetingDoctor";
            this.specificMeetingDoctorBindingSource.DataSource = this.futurePatient;
            // 
            // specificMeetingDoctorTableAdapter
            // 
            this.specificMeetingDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SpecificMeetingDoctorTableAdapter = this.specificMeetingDoctorTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrorCohen.FuturePatientTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idPatientToolStripLabel,
            this.idPatientToolStripTextBox,
            this.dateOfTherapyToolStripLabel,
            this.dateOfTherapyToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1373, 27);
            this.fillToolStrip.TabIndex = 39;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idPatientToolStripLabel
            // 
            this.idPatientToolStripLabel.Name = "idPatientToolStripLabel";
            this.idPatientToolStripLabel.Size = new System.Drawing.Size(70, 24);
            this.idPatientToolStripLabel.Text = "IdPatient:";
            this.idPatientToolStripLabel.Visible = false;
            // 
            // idPatientToolStripTextBox
            // 
            this.idPatientToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idPatientToolStripTextBox.Name = "idPatientToolStripTextBox";
            this.idPatientToolStripTextBox.Size = new System.Drawing.Size(112, 27);
            this.idPatientToolStripTextBox.Visible = false;
            // 
            // dateOfTherapyToolStripLabel
            // 
            this.dateOfTherapyToolStripLabel.Name = "dateOfTherapyToolStripLabel";
            this.dateOfTherapyToolStripLabel.Size = new System.Drawing.Size(113, 24);
            this.dateOfTherapyToolStripLabel.Text = "DateOfTherapy:";
            // 
            // dateOfTherapyToolStripTextBox
            // 
            this.dateOfTherapyToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateOfTherapyToolStripTextBox.Name = "dateOfTherapyToolStripTextBox";
            this.dateOfTherapyToolStripTextBox.Size = new System.Drawing.Size(112, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // specificMeetingDoctorDataGridView
            // 
            this.specificMeetingDoctorDataGridView.AutoGenerateColumns = false;
            this.specificMeetingDoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specificMeetingDoctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.specificMeetingDoctorDataGridView.DataSource = this.specificMeetingDoctorBindingSource;
            this.specificMeetingDoctorDataGridView.Location = new System.Drawing.Point(601, 348);
            this.specificMeetingDoctorDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.specificMeetingDoctorDataGridView.Name = "specificMeetingDoctorDataGridView";
            this.specificMeetingDoctorDataGridView.RowHeadersWidth = 51;
            this.specificMeetingDoctorDataGridView.RowTemplate.Height = 26;
            this.specificMeetingDoctorDataGridView.Size = new System.Drawing.Size(732, 185);
            this.specificMeetingDoctorDataGridView.TabIndex = 39;
            this.specificMeetingDoctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.specificMeetingDoctorDataGridView_CellContentClick);
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
            // inputDateBirth
            // 
            this.inputDateBirth.Location = new System.Drawing.Point(263, 292);
            this.inputDateBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputDateBirth.Name = "inputDateBirth";
            this.inputDateBirth.Size = new System.Drawing.Size(264, 22);
            this.inputDateBirth.TabIndex = 40;
            this.inputDateBirth.Validating += new System.ComponentModel.CancelEventHandler(this.inputDateBirth_Validating);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 706);
            this.Controls.Add(this.inputDateBirth);
            this.Controls.Add(this.specificMeetingDoctorDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.orderTherapy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.search);
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
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.maleOrFemale);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPatient";
            this.Text = "frmPatient";
            this.Activated += new System.EventHandler(this.frmPatient_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPatient_FormClosing);
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futurePatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputGender;
        private System.Windows.Forms.Label maleOrFemale;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox inputPhoneNumber;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox lastNameSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderTherapy;
        private System.Windows.Forms.BindingSource specificMeetingDoctorBindingSource;
        private FuturePatient futurePatient;
        private FuturePatientTableAdapters.SpecificMeetingDoctorTableAdapter specificMeetingDoctorTableAdapter;
        private FuturePatientTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idPatientToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idPatientToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dateOfTherapyToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dateOfTherapyToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView specificMeetingDoctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker inputDateBirth;
    }
}