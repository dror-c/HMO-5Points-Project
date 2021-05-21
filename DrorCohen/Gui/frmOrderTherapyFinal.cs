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
        private frmPatient parent;
        private string patientId;
        public frmOrderTherapyFinal(string patientId, frmPatient parent)
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
            this.doctorOrNurseTableAdapter.Fill(this.theDoctorMeeting.DoctorOrNurse);
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
            // this.doctorOrNurseTableAdapter.Fill(this.theDoctorMeeting.DoctorOrNurse);
            string x = idTherapy.ToString();

            int serial = this.meeting.SpecificMeetingDoctor.Count + 1;

            string dd = dateTimePicker1.Value.DayOfWeek.ToString();
            switch (dd)
            {
                case "Sunday":
                    dd = "1";
                    break;
                case "Monday":
                    dd = "2";
                    break;
                case "Tuesday":
                    dd = "3";
                    break;
                case "Wednesday":
                    dd = "4";
                    break;
                case "Thursday":
                    dd = "5";
                    break;
                case "Friday":
                    dd = "6";
                    break;
                default:
                    dd = "7";
                    break;
            }
            if (dd == d)
            {
                DateTime d = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());

                
                this.specificMeetingDoctorTableAdapter2.Fill(this.f.SpecificMeetingDoctor, idTherapy.ToString(), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(d, typeof(System.DateTime))))));
                if (Convert.ToInt32(f.SpecificMeetingDoctor.Rows[0][0].ToString()) == 0) {
                    meeting.SpecificMeetingDoctor.AddSpecificMeetingDoctorRow(serial,idTherapy.ToString(),d,patientId);
                    specificMeetingDoctorTableAdapter.Update(meeting.SpecificMeetingDoctor);
                    MyMessage m = new MyMessage("your request to get therapy has been accepted and aprroved :)\n see you at "+d.ToShortDateString(),1);
                    m.applyCustomChange();
                    this.Close();
                    parent.MyRefresh();
                    m.ShowDialog();
                }
                else
                {
                    MyMessage message = new MyMessage("your rerquest doesn't aprooved from some reasons \n please try another date or another doctor", 2);
                    message.applyCustomChange();
                    message.ShowDialog();
                }
                //f.SpecificMeetingDoctor.Rows[0][0] = 5;
                //f.SpecificMeetingDoctor.AcceptChanges();
            }
            else
            {
                MyMessage message = new MyMessage("your rerquest doesn't aprooved from some reasons \n please try another date or another doctor", 2);
                message.applyCustomChange();
                message.ShowDialog();
            }

            //)

            //meeting.SpecificMeetingDoctor.AddSpecificMeetingDoctorRow
            //  (serial, x, d, patientId);
            
            specificMeetingDoctorTableAdapter.Fill
                (meeting.SpecificMeetingDoctor);
            //meeting.SpecificMeetingDoctor.AddSpecificMeetingDoctorRow
            //    (serial, x, d, patientId);
            this.specificMeetingDoctorTableAdapter.
            Update(meeting.SpecificMeetingDoctor);
        }


        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.meetingDoctorTableAdapter.FillBy(this.meetingByDoctorId.MeetingDoctor, comboBox1.SelectedValue.ToString());
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.specificMeetingDoctorTableAdapter2.Fill(this.f.SpecificMeetingDoctor, therapyCodeToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateOfTherapyToolStripTextBox.Text, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

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