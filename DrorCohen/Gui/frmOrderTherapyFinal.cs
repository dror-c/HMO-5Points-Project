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
        private string idDoctor, d;
        private int idTherapy;
        private Form parent;
        private string patientId;
        public frmOrderTherapyFinal(string patientId, Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.patientId = patientId;
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
            this.doctorOrNurseTableAdapter.Fill (this.theDoctorMeeting.DoctorOrNurse);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.meetingDoctorTableAdapter.FillBy(this.meetingByDoctorId.MeetingDoctor, comboBox1.SelectedValue.ToString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            specificMeetingDoctorTableAdapter.Fill(meeting.SpecificMeetingDoctor);
         //   this.doctorOrNurseTableAdapter.Fill(this.theDoctorMeeting.DoctorOrNurse);
          string x = idTherapy.ToString();
          
            int serial = this.meeting.SpecificMeetingDoctor.Count + 1;


            //לבדוק אם התאריך זה באמת היום שניבחר לטיפול
        
            
            string dd=  dateTimePicker1.Value.DayOfWeek.ToString();// שיהיה מספרלחלץ יום
            switch (dd)
            {
                case "Thursday":
                    dd = "5";
                    break;
          


                case "שני":
                    dd = "2";
                break;
            }

            if (dd == d)
            {
                meeting.SpecificMeetingDoctor.AddSpecificMeetingDoctorRow(serial, x, dateTimePicker1.Value, patientId);


                //check there is no duplicate meeting
                specificMeetingDoctorTableAdapter.Update(meeting.SpecificMeetingDoctor);
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.meetingDoctorTableAdapter.FillBy(this.meetingByDoctorId.MeetingDoctor, comboBox1.SelectedValue.ToString());
        }

        private void meetingDoctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = meetingDoctorDataGridView.CurrentCell.RowIndex;
            idTherapy = Convert.ToInt32(meetingDoctorDataGridView.Rows[rowIndex].Cells[0].Value);
            button1.Visible = true;
            d = (meetingDoctorDataGridView.Rows[rowIndex].Cells[3].Value).ToString();//לשנותן באמת יום
            idDoctor = (meetingDoctorDataGridView.Rows[rowIndex].Cells[2].Value).ToString();
        }
    }
}
