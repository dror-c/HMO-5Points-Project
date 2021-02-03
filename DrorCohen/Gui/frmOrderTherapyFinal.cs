using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrorCohen.Gui
{
    public partial class frmOrderTherapyFinal : Form
    {
        public frmOrderTherapyFinal()
        {
            InitializeComponent();
        }

        private void doctorOrNurseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorOrNurseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theDoctorMeeting);

        }

        private void frmOrderTherapyFinal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meeting.SpecificMeetingDoctor' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'meetingByDoctorId.MeetingDoctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'theDoctorMeeting.DoctorOrNurse' table. You can move, or remove it, as needed.
            this.doctorOrNurseTableAdapter.Fill
                (this.theDoctorMeeting.DoctorOrNurse);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.meetingDoctorTableAdapter.FillBy
                (this.meetingByDoctorId.MeetingDoctor
                ,comboBox1.SelectedValue.ToString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.specificMeetingDoctorTableAdapter.Fill
                (this.meeting.SpecificMeetingDoctor);
            string x = idTherapy.ToString();
            this.specificMeetingDoctorTableAdapter.Fill
                (this.meeting.SpecificMeetingDoctor);
            int serial = this.meeting.SpecificMeetingDoctor.Count + 1;
            meeting.SpecificMeetingDoctor.
                AddSpecificMeetingDoctorRow
                (serial, x, dateTimePicker1.Value, patientId);


            //check there is no duplicate meeting
            specificMeetingDoctorTableAdapter1.Update
                (meeting.SpecificMeetingDoctor);
        }
    }
}
