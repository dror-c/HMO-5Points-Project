namespace DrorCohen.Gui
{
    partial class frmOrderTherapyFinal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doctorOrNurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theDoctorMeeting = new DrorCohen.TheDoctorMeeting();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorOrNurseTableAdapter = new DrorCohen.TheDoctorMeetingTableAdapters.DoctorOrNurseTableAdapter();
            this.tableAdapterManager = new DrorCohen.TheDoctorMeetingTableAdapters.TableAdapterManager();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.meetingByDoctorId = new DrorCohen.MeetingByDoctorId();
            this.meetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingDoctorTableAdapter = new DrorCohen.MeetingByDoctorIdTableAdapters.MeetingDoctorTableAdapter();
            this.tableAdapterManager1 = new DrorCohen.MeetingByDoctorIdTableAdapters.TableAdapterManager();
            this.meetingDoctorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkDuplicateMeetings1 = new DrorCohen.CheckDuplicateMeetings();
            this.ds = new DrorCohen.ds();
            this.specificMeetingDoctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specificMeetingDoctorTableAdapter1 = new DrorCohen.dsTableAdapters.SpecificMeetingDoctorTableAdapter();
            this.tableAdapterManager3 = new DrorCohen.dsTableAdapters.TableAdapterManager();
            this.dupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dupTableAdapter = new DrorCohen.CheckDuplicateMeetingsTableAdapters.dupTableAdapter();
            this.tableAdapterManager4 = new DrorCohen.CheckDuplicateMeetingsTableAdapters.TableAdapterManager();
            this.meeting = new DrorCohen.meeting();
            this.specificMeetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specificMeetingDoctorTableAdapter = new DrorCohen.meetingTableAdapters.SpecificMeetingDoctorTableAdapter();
            this.tableAdapterManager2 = new DrorCohen.meetingTableAdapters.TableAdapterManager();
            this.f = new DrorCohen.f();
            this.specificMeetingDoctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.specificMeetingDoctorTableAdapter2 = new DrorCohen.fTableAdapters.SpecificMeetingDoctorTableAdapter();
            this.tableAdapterManager5 = new DrorCohen.fTableAdapters.TableAdapterManager();
            this.specificMeetingDoctorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDoctorMeeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingByDoctorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDuplicateMeetings1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.doctorOrNurseBindingSource;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doctorOrNurseBindingSource
            // 
            this.doctorOrNurseBindingSource.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource.DataSource = this.theDoctorMeeting;
            // 
            // theDoctorMeeting
            // 
            this.theDoctorMeeting.DataSetName = "TheDoctorMeeting";
            this.theDoctorMeeting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(72, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose doctor";
            // 
            // doctorOrNurseTableAdapter
            // 
            this.doctorOrNurseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorOrNurseTableAdapter = this.doctorOrNurseTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrorCohen.TheDoctorMeetingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // meetingByDoctorId
            // 
            this.meetingByDoctorId.DataSetName = "MeetingByDoctorId";
            this.meetingByDoctorId.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingDoctorBindingSource
            // 
            this.meetingDoctorBindingSource.DataMember = "MeetingDoctor";
            this.meetingDoctorBindingSource.DataSource = this.meetingByDoctorId;
            // 
            // meetingDoctorTableAdapter
            // 
            this.meetingDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MeetingDoctorTableAdapter = this.meetingDoctorTableAdapter;
            this.tableAdapterManager1.UpdateOrder = DrorCohen.MeetingByDoctorIdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.meetingDoctorDataGridView.Location = new System.Drawing.Point(291, 101);
            this.meetingDoctorDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.meetingDoctorDataGridView.Name = "meetingDoctorDataGridView";
            this.meetingDoctorDataGridView.RowHeadersWidth = 51;
            this.meetingDoctorDataGridView.Size = new System.Drawing.Size(721, 271);
            this.meetingDoctorDataGridView.TabIndex = 2;
            this.meetingDoctorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDoctorDataGridView_CellContentClick);
            this.meetingDoctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingDoctorDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TherapyCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "TherapyCode";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WhoCanGiveTheTherapy";
            this.dataGridViewTextBoxColumn2.HeaderText = "WhoCanGiveTheTherapy";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdDoctor";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdDoctor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "day";
            this.dataGridViewTextBoxColumn4.HeaderText = "day";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hour";
            this.dataGridViewTextBoxColumn5.HeaderText = "hour";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 203);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(72, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "choose date";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 293);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Visible = false;
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "choose hour";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(71, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkDuplicateMeetings1
            // 
            this.checkDuplicateMeetings1.DataSetName = "CheckDuplicateMeetings";
            this.checkDuplicateMeetings1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specificMeetingDoctorBindingSource1
            // 
            this.specificMeetingDoctorBindingSource1.DataMember = "SpecificMeetingDoctor";
            this.specificMeetingDoctorBindingSource1.DataSource = this.ds;
            // 
            // specificMeetingDoctorTableAdapter1
            // 
            this.specificMeetingDoctorTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = DrorCohen.dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dupBindingSource
            // 
            this.dupBindingSource.DataMember = "dup";
            this.dupBindingSource.DataSource = this.checkDuplicateMeetings1;
            // 
            // dupTableAdapter
            // 
            this.dupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.dupTableAdapter = this.dupTableAdapter;
            this.tableAdapterManager4.UpdateOrder = DrorCohen.CheckDuplicateMeetingsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // meeting
            // 
            this.meeting.DataSetName = "meeting";
            this.meeting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specificMeetingDoctorBindingSource
            // 
            this.specificMeetingDoctorBindingSource.DataMember = "SpecificMeetingDoctor";
            this.specificMeetingDoctorBindingSource.DataSource = this.meeting;
            // 
            // specificMeetingDoctorTableAdapter
            // 
            this.specificMeetingDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.SpecificMeetingDoctorTableAdapter = this.specificMeetingDoctorTableAdapter;
            this.tableAdapterManager2.UpdateOrder = DrorCohen.meetingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // f
            // 
            this.f.DataSetName = "f";
            this.f.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specificMeetingDoctorBindingSource2
            // 
            this.specificMeetingDoctorBindingSource2.DataMember = "SpecificMeetingDoctor";
            this.specificMeetingDoctorBindingSource2.DataSource = this.f;
            // 
            // specificMeetingDoctorTableAdapter2
            // 
            this.specificMeetingDoctorTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.Connection = null;
            this.tableAdapterManager5.UpdateOrder = DrorCohen.fTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specificMeetingDoctorDataGridView
            // 
            this.specificMeetingDoctorDataGridView.AutoGenerateColumns = false;
            this.specificMeetingDoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specificMeetingDoctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            this.specificMeetingDoctorDataGridView.DataSource = this.specificMeetingDoctorBindingSource2;
            this.specificMeetingDoctorDataGridView.Location = new System.Drawing.Point(349, 508);
            this.specificMeetingDoctorDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.specificMeetingDoctorDataGridView.Name = "specificMeetingDoctorDataGridView";
            this.specificMeetingDoctorDataGridView.RowHeadersWidth = 51;
            this.specificMeetingDoctorDataGridView.Size = new System.Drawing.Size(400, 271);
            this.specificMeetingDoctorDataGridView.TabIndex = 9;
            this.specificMeetingDoctorDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn6.HeaderText = "Expr1";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // frmOrderTherapyFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 804);
            this.Controls.Add(this.specificMeetingDoctorDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.meetingDoctorDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrderTherapyFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOrderTherapyFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDoctorMeeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingByDoctorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDuplicateMeetings1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private TheDoctorMeeting theDoctorMeeting;
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource;
        private TheDoctorMeetingTableAdapters.DoctorOrNurseTableAdapter doctorOrNurseTableAdapter;
        private TheDoctorMeetingTableAdapters.TableAdapterManager tableAdapterManager;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MeetingByDoctorId meetingByDoctorId;
        private System.Windows.Forms.BindingSource meetingDoctorBindingSource;
        private MeetingByDoctorIdTableAdapters.MeetingDoctorTableAdapter meetingDoctorTableAdapter;
        private MeetingByDoctorIdTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView meetingDoctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private meeting meeting;
        private System.Windows.Forms.BindingSource specificMeetingDoctorBindingSource;
        private meetingTableAdapters.SpecificMeetingDoctorTableAdapter specificMeetingDoctorTableAdapter;
        private meetingTableAdapters.TableAdapterManager tableAdapterManager2;
        private CheckDuplicateMeetings checkDuplicateMeetings1;
        private ds ds;
        private System.Windows.Forms.BindingSource specificMeetingDoctorBindingSource1;
        private dsTableAdapters.SpecificMeetingDoctorTableAdapter specificMeetingDoctorTableAdapter1;
        private dsTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.BindingSource dupBindingSource;
        private CheckDuplicateMeetingsTableAdapters.dupTableAdapter dupTableAdapter;
        private CheckDuplicateMeetingsTableAdapters.TableAdapterManager tableAdapterManager4;
        private f f;
        private System.Windows.Forms.BindingSource specificMeetingDoctorBindingSource2;
        private fTableAdapters.SpecificMeetingDoctorTableAdapter specificMeetingDoctorTableAdapter2;
        private fTableAdapters.TableAdapterManager tableAdapterManager5;
        private System.Windows.Forms.DataGridView specificMeetingDoctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}