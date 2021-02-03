﻿namespace DrorCohen.Gui
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
            this.label1 = new System.Windows.Forms.Label();
            this.theDoctorMeeting = new DrorCohen.TheDoctorMeeting();
            this.doctorOrNurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.meeting = new DrorCohen.meeting();
            this.specificMeetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specificMeetingDoctorTableAdapter = new DrorCohen.meetingTableAdapters.SpecificMeetingDoctorTableAdapter();
            this.tableAdapterManager2 = new DrorCohen.meetingTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.theDoctorMeeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingByDoctorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.doctorOrNurseBindingSource;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose doctor";
            // 
            // theDoctorMeeting
            // 
            this.theDoctorMeeting.DataSetName = "TheDoctorMeeting";
            this.theDoctorMeeting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorOrNurseBindingSource
            // 
            this.doctorOrNurseBindingSource.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource.DataSource = this.theDoctorMeeting;
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
            this.meetingDoctorDataGridView.Location = new System.Drawing.Point(218, 82);
            this.meetingDoctorDataGridView.Name = "meetingDoctorDataGridView";
            this.meetingDoctorDataGridView.Size = new System.Drawing.Size(541, 220);
            this.meetingDoctorDataGridView.TabIndex = 2;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "choose date";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(54, 238);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "choose hour";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frmOrderTherapyFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.meetingDoctorDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmOrderTherapyFinal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmOrderTherapyFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theDoctorMeeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingByDoctorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificMeetingDoctorBindingSource)).EndInit();
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
    }
}