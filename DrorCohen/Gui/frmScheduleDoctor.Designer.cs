
namespace DrorCohen.Gui
{
    partial class frmScheduleDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleDoctor));
            System.Windows.Forms.Label therapyCodeLabel;
            System.Windows.Forms.Label whoCanGiveTheTherapyLabel;
            System.Windows.Forms.Label idDoctorLabel;
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label hourLabel;
            this.hMODataSet1 = new DrorCohen.HMODataSet1();
            this.meetingDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingDoctorTableAdapter = new DrorCohen.HMODataSet1TableAdapters.MeetingDoctorTableAdapter();
            this.tableAdapterManager = new DrorCohen.HMODataSet1TableAdapters.TableAdapterManager();
            this.meetingDoctorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.meetingDoctorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.therapyCodeTextBox = new System.Windows.Forms.TextBox();
            this.whoCanGiveTheTherapyTextBox = new System.Windows.Forms.TextBox();
            this.idDoctorTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            therapyCodeLabel = new System.Windows.Forms.Label();
            whoCanGiveTheTherapyLabel = new System.Windows.Forms.Label();
            idDoctorLabel = new System.Windows.Forms.Label();
            dayLabel = new System.Windows.Forms.Label();
            hourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingNavigator)).BeginInit();
            this.meetingDoctorBindingNavigator.SuspendLayout();
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
            this.tableAdapterManager.SpecificMeetingDoctorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DrorCohen.HMODataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // meetingDoctorBindingNavigator
            // 
            this.meetingDoctorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.meetingDoctorBindingNavigator.BindingSource = this.meetingDoctorBindingSource;
            this.meetingDoctorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.meetingDoctorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.meetingDoctorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.meetingDoctorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.meetingDoctorBindingNavigatorSaveItem});
            this.meetingDoctorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.meetingDoctorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.meetingDoctorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.meetingDoctorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.meetingDoctorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.meetingDoctorBindingNavigator.Name = "meetingDoctorBindingNavigator";
            this.meetingDoctorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.meetingDoctorBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.meetingDoctorBindingNavigator.TabIndex = 0;
            this.meetingDoctorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // meetingDoctorBindingNavigatorSaveItem
            // 
            this.meetingDoctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.meetingDoctorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("meetingDoctorBindingNavigatorSaveItem.Image")));
            this.meetingDoctorBindingNavigatorSaveItem.Name = "meetingDoctorBindingNavigatorSaveItem";
            this.meetingDoctorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.meetingDoctorBindingNavigatorSaveItem.Text = "Save Data";
            this.meetingDoctorBindingNavigatorSaveItem.Click += new System.EventHandler(this.meetingDoctorBindingNavigatorSaveItem_Click);
            // 
            // therapyCodeLabel
            // 
            therapyCodeLabel.AutoSize = true;
            therapyCodeLabel.Location = new System.Drawing.Point(451, 107);
            therapyCodeLabel.Name = "therapyCodeLabel";
            therapyCodeLabel.Size = new System.Drawing.Size(102, 17);
            therapyCodeLabel.TabIndex = 1;
            therapyCodeLabel.Text = "Therapy Code:";
            // 
            // therapyCodeTextBox
            // 
            this.therapyCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meetingDoctorBindingSource, "TherapyCode", true));
            this.therapyCodeTextBox.Location = new System.Drawing.Point(646, 104);
            this.therapyCodeTextBox.Name = "therapyCodeTextBox";
            this.therapyCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.therapyCodeTextBox.TabIndex = 2;
            // 
            // whoCanGiveTheTherapyLabel
            // 
            whoCanGiveTheTherapyLabel.AutoSize = true;
            whoCanGiveTheTherapyLabel.Location = new System.Drawing.Point(451, 135);
            whoCanGiveTheTherapyLabel.Name = "whoCanGiveTheTherapyLabel";
            whoCanGiveTheTherapyLabel.Size = new System.Drawing.Size(189, 17);
            whoCanGiveTheTherapyLabel.TabIndex = 3;
            whoCanGiveTheTherapyLabel.Text = "Who Can Give The Therapy:";
            // 
            // whoCanGiveTheTherapyTextBox
            // 
            this.whoCanGiveTheTherapyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meetingDoctorBindingSource, "WhoCanGiveTheTherapy", true));
            this.whoCanGiveTheTherapyTextBox.Location = new System.Drawing.Point(646, 132);
            this.whoCanGiveTheTherapyTextBox.Name = "whoCanGiveTheTherapyTextBox";
            this.whoCanGiveTheTherapyTextBox.Size = new System.Drawing.Size(100, 22);
            this.whoCanGiveTheTherapyTextBox.TabIndex = 4;
            // 
            // idDoctorLabel
            // 
            idDoctorLabel.AutoSize = true;
            idDoctorLabel.Location = new System.Drawing.Point(451, 163);
            idDoctorLabel.Name = "idDoctorLabel";
            idDoctorLabel.Size = new System.Drawing.Size(69, 17);
            idDoctorLabel.TabIndex = 5;
            idDoctorLabel.Text = "Id Doctor:";
            // 
            // idDoctorTextBox
            // 
            this.idDoctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meetingDoctorBindingSource, "IdDoctor", true));
            this.idDoctorTextBox.Location = new System.Drawing.Point(646, 160);
            this.idDoctorTextBox.Name = "idDoctorTextBox";
            this.idDoctorTextBox.Size = new System.Drawing.Size(100, 22);
            this.idDoctorTextBox.TabIndex = 6;
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(451, 191);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(35, 17);
            dayLabel.TabIndex = 7;
            dayLabel.Text = "day:";
            // 
            // dayTextBox
            // 
            this.dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meetingDoctorBindingSource, "day", true));
            this.dayTextBox.Location = new System.Drawing.Point(646, 188);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 22);
            this.dayTextBox.TabIndex = 8;
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Location = new System.Drawing.Point(451, 219);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new System.Drawing.Size(41, 17);
            hourLabel.TabIndex = 9;
            hourLabel.Text = "hour:";
            // 
            // hourTextBox
            // 
            this.hourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.meetingDoctorBindingSource, "hour", true));
            this.hourTextBox.Location = new System.Drawing.Point(646, 216);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(100, 22);
            this.hourTextBox.TabIndex = 10;
            // 
            // frmScheduleDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(therapyCodeLabel);
            this.Controls.Add(this.therapyCodeTextBox);
            this.Controls.Add(whoCanGiveTheTherapyLabel);
            this.Controls.Add(this.whoCanGiveTheTherapyTextBox);
            this.Controls.Add(idDoctorLabel);
            this.Controls.Add(this.idDoctorTextBox);
            this.Controls.Add(dayLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(hourLabel);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.meetingDoctorBindingNavigator);
            this.Name = "frmScheduleDoctor";
            this.Text = "frmScheduleDoctor";
            this.Load += new System.EventHandler(this.frmScheduleDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDoctorBindingNavigator)).EndInit();
            this.meetingDoctorBindingNavigator.ResumeLayout(false);
            this.meetingDoctorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMODataSet1 hMODataSet1;
        private System.Windows.Forms.BindingSource meetingDoctorBindingSource;
        private HMODataSet1TableAdapters.MeetingDoctorTableAdapter meetingDoctorTableAdapter;
        private HMODataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator meetingDoctorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton meetingDoctorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox therapyCodeTextBox;
        private System.Windows.Forms.TextBox whoCanGiveTheTherapyTextBox;
        private System.Windows.Forms.TextBox idDoctorTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
    }
}