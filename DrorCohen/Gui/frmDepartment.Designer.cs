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
            this.hMODataSet = new DrorCohen.HMODataSet();
            this.doctorOrNurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorOrNurseTableAdapter = new DrorCohen.HMODataSetTableAdapters.DoctorOrNurseTableAdapter();
            this.tableAdapterManager = new DrorCohen.HMODataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorOrNurseDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(632, 201);
            this.save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(283, 28);
            this.save.TabIndex = 59;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(159, 193);
            this.prev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(125, 28);
            this.prev.TabIndex = 58;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(405, 193);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(125, 28);
            this.next.TabIndex = 57;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.Location = new System.Drawing.Point(815, 146);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 56;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(815, 81);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 55;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(815, 25);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 28);
            this.update.TabIndex = 53;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(264, 30);
            this.inputId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(265, 22);
            this.inputId.TabIndex = 52;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
            // 
            // inputDepartmentName
            // 
            this.inputDepartmentName.Location = new System.Drawing.Point(264, 74);
            this.inputDepartmentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputDepartmentName.Name = "inputDepartmentName";
            this.inputDepartmentName.Size = new System.Drawing.Size(265, 22);
            this.inputDepartmentName.TabIndex = 51;
            // 
            // inputAmountOfPatient
            // 
            this.inputAmountOfPatient.Location = new System.Drawing.Point(264, 127);
            this.inputAmountOfPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputAmountOfPatient.Name = "inputAmountOfPatient";
            this.inputAmountOfPatient.Size = new System.Drawing.Size(265, 22);
            this.inputAmountOfPatient.TabIndex = 50;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(17, 127);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(223, 36);
            this.lastName.TabIndex = 39;
            this.lastName.Text = "Amount Of Patient: ";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(17, 74);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(223, 39);
            this.firstName.TabIndex = 38;
            this.firstName.Text = "Department Name: ";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(17, 30);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(179, 30);
            this.id.TabIndex = 37;
            this.id.Text = "Department ID: ";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // hMODataSet
            // 
            this.hMODataSet.DataSetName = "HMODataSet";
            this.hMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorOrNurseBindingSource
            // 
            this.doctorOrNurseBindingSource.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource.DataSource = this.hMODataSet;
            // 
            // doctorOrNurseTableAdapter
            // 
            this.doctorOrNurseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConnectionTableBetweenPatientAndDoctorAndSpecificTherapyTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.DoctorOrNurseTableAdapter = this.doctorOrNurseTableAdapter;
            this.tableAdapterManager.GenericTherapyTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.SpecificTherapyForPatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DrorCohen.HMODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn10.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IsDoctorOrNurse";
            this.dataGridViewTextBoxColumn9.HeaderText = "IsDoctorOrNurse";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaleFemale";
            this.dataGridViewTextBoxColumn8.HeaderText = "MaleFemale";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateOfDeath";
            this.dataGridViewTextBoxColumn6.HeaderText = "DateOfDeath";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // doctorOrNurseDataGridView
            // 
            this.doctorOrNurseDataGridView.AutoGenerateColumns = false;
            this.doctorOrNurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorOrNurseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.doctorOrNurseDataGridView.DataSource = this.doctorOrNurseBindingSource;
            this.doctorOrNurseDataGridView.Location = new System.Drawing.Point(27, 261);
            this.doctorOrNurseDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorOrNurseDataGridView.Name = "doctorOrNurseDataGridView";
            this.doctorOrNurseDataGridView.RowHeadersWidth = 51;
            this.doctorOrNurseDataGridView.Size = new System.Drawing.Size(1392, 271);
            this.doctorOrNurseDataGridView.TabIndex = 60;
            this.doctorOrNurseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorOrNurseDataGridView_CellContentClick);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1525, 628);
            this.Controls.Add(this.doctorOrNurseDataGridView);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDepartment_FormClosing);
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource;
        private HMODataSet hMODataSet;
        private HMODataSetTableAdapters.DoctorOrNurseTableAdapter doctorOrNurseTableAdapter;
        private HMODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView doctorOrNurseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}