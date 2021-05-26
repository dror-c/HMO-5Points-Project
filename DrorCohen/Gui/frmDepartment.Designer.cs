namespace DrorCohen.Gui
{
    partial class frmDepartment
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
            this.inputDepartmentName = new System.Windows.Forms.TextBox();
            this.inputAmountOfPatient = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleFemaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDoctorOrNurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorOrNurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorAndDepartmentConnection1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorAndDepartmentConnection1 = new DrorCohen.DoctorAndDepartmentConnection();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doctorOrNurseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.s = new DrorCohen.s();
            this.doctorOrNurseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorOrNurseConnectionDoctorDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorOrNurseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorOrNurseTableAdapter1 = new DrorCohen.sTableAdapters.DoctorOrNurseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorOrNurseTableAdapter = new DrorCohen.DoctorAndDepartmentConnectionTableAdapters.DoctorOrNurseTableAdapter();
            this.connectionDoctorDepartmentTableAdapter = new DrorCohen.DoctorAndDepartmentConnectionTableAdapters.ConnectionDoctorDepartmentTableAdapter();
            this.doctorAndDepartmentConnection3 = new DrorCohen.DoctorAndDepartmentConnection();
            this.createConnection = new DrorCohen.createConnection();
            this.connectionDoctorDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DrorCohen.createConnectionTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAndDepartmentConnection1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAndDepartmentConnection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseConnectionDoctorDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAndDepartmentConnection3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDoctorDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(505, 163);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(213, 28);
            this.save.TabIndex = 59;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // prev
            // 
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Location = new System.Drawing.Point(150, 157);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(93, 23);
            this.prev.TabIndex = 58;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(334, 157);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(93, 23);
            this.next.TabIndex = 57;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(642, 115);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 27);
            this.cancel.TabIndex = 56;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(642, 66);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 26);
            this.Add.TabIndex = 55;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(642, 20);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 28);
            this.update.TabIndex = 53;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(229, 24);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(199, 20);
            this.inputId.TabIndex = 52;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            // 
            // inputDepartmentName
            // 
            this.inputDepartmentName.Location = new System.Drawing.Point(229, 60);
            this.inputDepartmentName.Name = "inputDepartmentName";
            this.inputDepartmentName.Size = new System.Drawing.Size(199, 20);
            this.inputDepartmentName.TabIndex = 51;
            // 
            // inputAmountOfPatient
            // 
            this.inputAmountOfPatient.Location = new System.Drawing.Point(229, 103);
            this.inputAmountOfPatient.Name = "inputAmountOfPatient";
            this.inputAmountOfPatient.Size = new System.Drawing.Size(199, 20);
            this.inputAmountOfPatient.TabIndex = 50;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Blue;
            this.lastName.Location = new System.Drawing.Point(13, 103);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(210, 29);
            this.lastName.TabIndex = 39;
            this.lastName.Text = "Amount Of Patient: ";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Blue;
            this.firstName.Location = new System.Drawing.Point(13, 60);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(167, 32);
            this.firstName.TabIndex = 38;
            this.firstName.Text = "Department Name: ";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Blue;
            this.id.Location = new System.Drawing.Point(13, 24);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(135, 24);
            this.id.TabIndex = 37;
            this.id.Text = "Department ID: ";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(382, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 28);
            this.label1.TabIndex = 61;
            this.label1.Text = "The crew members in this department are:\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.maleFemaleDataGridViewTextBoxColumn,
            this.isDoctorOrNurseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorOrNurseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 122);
            this.dataGridView1.TabIndex = 62;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // maleFemaleDataGridViewTextBoxColumn
            // 
            this.maleFemaleDataGridViewTextBoxColumn.DataPropertyName = "MaleFemale";
            this.maleFemaleDataGridViewTextBoxColumn.HeaderText = "MaleFemale";
            this.maleFemaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maleFemaleDataGridViewTextBoxColumn.Name = "maleFemaleDataGridViewTextBoxColumn";
            this.maleFemaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // isDoctorOrNurseDataGridViewTextBoxColumn
            // 
            this.isDoctorOrNurseDataGridViewTextBoxColumn.DataPropertyName = "IsDoctorOrNurse";
            this.isDoctorOrNurseDataGridViewTextBoxColumn.HeaderText = "IsDoctorOrNurse";
            this.isDoctorOrNurseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isDoctorOrNurseDataGridViewTextBoxColumn.Name = "isDoctorOrNurseDataGridViewTextBoxColumn";
            this.isDoctorOrNurseDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorOrNurseBindingSource
            // 
            this.doctorOrNurseBindingSource.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource.DataSource = this.doctorAndDepartmentConnection1BindingSource;
            // 
            // doctorAndDepartmentConnection1BindingSource
            // 
            this.doctorAndDepartmentConnection1BindingSource.DataSource = this.doctorAndDepartmentConnection1;
            this.doctorAndDepartmentConnection1BindingSource.Position = 0;
            this.doctorAndDepartmentConnection1BindingSource.CurrentChanged += new System.EventHandler(this.doctorAndDepartmentConnection1BindingSource_CurrentChanged);
            // 
            // doctorAndDepartmentConnection1
            // 
            this.doctorAndDepartmentConnection1.DataSetName = "DoctorAndDepartmentConnection";
            this.doctorAndDepartmentConnection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.DataSource = this.doctorOrNurseBindingSource3;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(844, 135);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 63;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doctorOrNurseBindingSource3
            // 
            this.doctorOrNurseBindingSource3.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource3.DataSource = this.s;
            // 
            // s
            // 
            this.s.DataSetName = "s";
            this.s.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorOrNurseBindingSource2
            // 
            this.doctorOrNurseBindingSource2.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource2.DataSource = this.doctorAndDepartmentConnection1BindingSource;
            // 
            // doctorOrNurseBindingSource1
            // 
            this.doctorOrNurseBindingSource1.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource1.DataSource = this.doctorAndDepartmentConnection1BindingSource;
            // 
            // doctorOrNurseTableAdapter1
            // 
            this.doctorOrNurseTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(844, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 64;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(855, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 56);
            this.label2.TabIndex = 65;
            this.label2.Text = "add worker into \r\nthe department";
            // 
            // doctorOrNurseTableAdapter
            // 
            this.doctorOrNurseTableAdapter.ClearBeforeFill = true;
            // 
            // connectionDoctorDepartmentTableAdapter
            // 
            this.connectionDoctorDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // doctorAndDepartmentConnection3
            // 
            this.doctorAndDepartmentConnection3.DataSetName = "DoctorAndDepartmentConnection";
            this.doctorAndDepartmentConnection3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createConnection
            // 
            this.createConnection.DataSetName = "createConnection";
            this.createConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // connectionDoctorDepartmentBindingSource
            // 
            this.connectionDoctorDepartmentBindingSource.DataMember = "ConnectionDoctorDepartment";
            this.connectionDoctorDepartmentBindingSource.DataSource = this.createConnection;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DrorCohen.createConnectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputDepartmentName);
            this.Controls.Add(this.inputAmountOfPatient);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDepartment_FormClosing);
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAndDepartmentConnection1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAndDepartmentConnection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseConnectionDoctorDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorAndDepartmentConnection3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDoctorDepartmentBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox inputDepartmentName;
        private System.Windows.Forms.TextBox inputAmountOfPatient;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label id;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private DoctorAndDepartmentConnection doctorAndDepartmentConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorAndDepartmentConnection1BindingSource;
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource;
        private DoctorAndDepartmentConnectionTableAdapters.DoctorOrNurseTableAdapter doctorOrNurseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfDeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maleFemaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDoctorOrNurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource1;
        private System.Windows.Forms.BindingSource doctorOrNurseConnectionDoctorDepartmentBindingSource;
        private DoctorAndDepartmentConnectionTableAdapters.ConnectionDoctorDepartmentTableAdapter connectionDoctorDepartmentTableAdapter;
        private DoctorAndDepartmentConnection doctorAndDepartmentConnection3;
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource2;
        private s s;
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource3;
        private sTableAdapters.DoctorOrNurseTableAdapter doctorOrNurseTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private createConnection createConnection;
        private System.Windows.Forms.BindingSource connectionDoctorDepartmentBindingSource;
        private createConnectionTableAdapters.TableAdapterManager tableAdapterManager;
    }
}