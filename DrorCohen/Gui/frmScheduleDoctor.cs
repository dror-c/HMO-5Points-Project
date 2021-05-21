using DrorCohen.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrorCohen.DB;
using DrorCohen.Models;

namespace DrorCohen.Gui
{
    public partial class frmScheduleDoctor : Form
    {
        private string doctorId;
        private AddState state;
        private ScheduleDoctorMeetingDB meetings;
        public frmScheduleDoctor(string doctorId)
        {
            this.doctorId = doctorId;
            InitializeComponent();
            meetings = new ScheduleDoctorMeetingDB();
            Populate(meetings.GetCurrentRow());
            state = AddState.NAVIGATE;
            SetButtonStates(true);
        }
        private void Populate(ScheduleDoctorMeeting meeting)
        {
            textBox1.Text = meeting.TherapyCode;
            comboBox2.Text = meeting.WhoCanGiveTheTherapy;
            textBox2.Text = meeting.IdDoctor;
            comboBox1.SelectedIndex = meeting.Day-1;
            textBox3.Text = meeting.Hour;
        }
        private void SetButtonStates(bool b)
        {
            next.Enabled = b;
            prev.Enabled = b;
            Add.Enabled = b;
            update.Enabled = b;
            cancel.Enabled = !b;
            save.Enabled = !b;
            textBox1.Enabled = !b;
            textBox2.Enabled = !b;
            textBox3.Enabled = !b;
            comboBox1.Enabled = !b;
            comboBox2.Enabled = !b;
        }
        private void meetingDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            /*this.meetingDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMODataSet1);*/
        }

        private void frmScheduleDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scedule.MeetingDoctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hMODataSet1.MeetingDoctor' table. You can move, or remove it, as needed.
            //this.meetingDoctorTableAdapter.Fill(this.hMODataSet1.MeetingDoctor);
            string firstTherapyCode = textBox1.Text;
            while (!doctorId.Equals(textBox2.Text))
            {
                meetings.MoveNext();
                Populate(meetings.GetCurrentRow());
                if(firstTherapyCode.Equals(textBox1.Text))
                {
                    Clear();
                    textBox1.Text = meetings.GetKey();
                    state = AddState.ADDNEW;
                    SetButtonStates(false);
                    cancel.Enabled = false;
                    label6.Visible = true;
                    return;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            ScheduleDoctorMeeting s = new ScheduleDoctorMeeting();
            s.Day = comboBox1.SelectedIndex + 1;
            if (state == AddState.ADDNEW)
                meetings.AddRow(s);
            else
                meetings.UpdateRow(s);
            SetButtonStates(true);
            state = AddState.NAVIGATE;
            meetings.Save();
            label6.Visible = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            meetings.MoveNext();
            Populate(meetings.GetCurrentRow());
        }

        private void prev_Click(object sender, EventArgs e)
        {
            meetings.MovePrev();
            Populate(meetings.GetCurrentRow());
        }

        private void update_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            state = AddState.UPDATE;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = meetings.GetKey();
            state = AddState.ADDNEW;
            SetButtonStates(false);
        }
        private void Clear()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Text = "";
                if (c is ComboBox)
                    (c as ComboBox).Text = "";
                if (c is DateTimePicker)
                    (c as DateTimePicker).Value = DateTime.Today;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Populate(meetings.GetCurrentRow());
            SetButtonStates(true);
        }
    }
}
