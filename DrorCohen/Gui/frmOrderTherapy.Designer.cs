namespace DrorCohen.Gui
{
    partial class frmOrderTherapy
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
            this.hMODataSet1 = new DrorCohen.HMODataSet1();
            this.meetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingDoctorTableAdapter = new DrorCohen.HMODataSet1TableAdapters.MeetingDoctorTableAdapter();
            this.tableAdapterManager = new DrorCohen.HMODataSet1TableAdapters.TableAdapterManager();
            this.specificMeetingDoctorTableAdapter = new DrorCohen.HMODataSet1TableAdapters.SpecificMeetingDoctorTableAdapter();
            this.meetingDoctorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.specificMeetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hMODataSet1
            // 
            this.hMODataSet1.DataSetName = "HMODataSet1";
            this.hMODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingDoctorBindingSource
            // 
            this.meetingDoctorBindingSource.DataMember = "MeetingDoctor";
            this.meetingDoctorBindingSource.DataSource = this.hMODataSet1;
            // 
            // meetingDoctorTableAdapter
            // 
            this.meetingDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConnectionDoctorDepartmentTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.DoctorOrNurseTableAdapter = null;
            this.tableAdapterManager.MeetingDoctorTableAdapter = this.meetingDoctorTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.SpecificMeetingDoctorTableAdapter = this.specificMeetingDoctorTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrorCohen.HMODataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specificMeetingDoctorTableAdapter
            // 
            this.specificMeetingDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // meetingDoctorDataGridView
            // 
            this.meetingDoctorDataGridView.AutoGenerateColumns = false;
            this.meetingDoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meetingDoctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.meetingDoctorDataGridView.DataSource = this.meetingDoctorBindingSource;
            this.meetingDoctorDataGridView.Location = new System.Drawing.Point(336, 141);
            this.meetingDoctorDataGridView.Name = "meetingDoctorDataGridView";
            this.meetingDoctorDataGridView.Size = new System.Drawing.Size(544, 111);
            this.meetingDoctorDataGridView.TabIndex = 2;
            this.meetingDoctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDoctorDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TherapyCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "TherapyCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WhoCanGiveTheTherapy";
            this.dataGridViewTextBoxColumn2.HeaderText = "WhoCanGiveTheTherapy";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdDoctor";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdDoctor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "day";
            this.dataGridViewTextBoxColumn4.HeaderText = "day";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hour";
            this.dataGridViewTextBoxColumn5.HeaderText = "hour";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // specificMeetingDoctorBindingSource
            // 
            this.specificMeetingDoctorBindingSource.DataMember = "SpecificMeetingDoctor";
            this.specificMeetingDoctorBindingSource.DataSource = this.hMODataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "select date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "select therapy";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // frmOrderTherapy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.meetingDoctorDataGridView);
            this.Name = "frmOrderTherapy";
            this.Text = "frmOrderTherapy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderTherapy_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderTherapy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HMODataSet1 hMODataSet1;
        private System.Windows.Forms.BindingSource meetingDoctorBindingSource;
        private HMODataSet1TableAdapters.MeetingDoctorTableAdapter meetingDoctorTableAdapter;
        private HMODataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private HMODataSet1TableAdapters.SpecificMeetingDoctorTableAdapter specificMeetingDoctorTableAdapter;
        private System.Windows.Forms.DataGridView meetingDoctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource specificMeetingDoctorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}