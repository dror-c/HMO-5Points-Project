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
    public partial class frmOrderTherapy : Form
    {
        private string patientId;
        private Form parent;
        public frmOrderTherapy(string patientId,Form parent)
        {
            InitializeComponent();
            button1.Visible = false;
            this.parent = parent;
            this.patientId = patientId;
        }

        private void frmOrderTherapy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            parent.Show();
        }

        //private void genericTherapyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //}

        private void frmOrderTherapy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meeting.SpecificMeetingDoctor' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'hMODataSet1.SpecificMeetingDoctor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hMODataSet1.MeetingDoctor' table. You can move, or remove it, as needed.
            this.meetingDoctorTableAdapter.Fill(this.hMODataSet1.MeetingDoctor);
            // TODO: This line of code loads data into the 'hMODataSet.GenericTherapy' table. You can move, or remove it, as needed.
        }

        private void meetingDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.meetingDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMODataSet1);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = idTherapy.ToString();
            this.specificMeetingDoctorTableAdapter1.Fill
                (this.meeting.SpecificMeetingDoctor);
            int serial=this.meeting.SpecificMeetingDoctor.Count + 1;
            meeting.SpecificMeetingDoctor.
                AddSpecificMeetingDoctorRow
                (serial,x, dateTimePicker1.Value,patientId);


            //check there is no duplicate meeting
            specificMeetingDoctorTableAdapter1.Update
                (meeting.SpecificMeetingDoctor);
        }
        private string idDoctor, d;
        private int idTherapy;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void meetingDoctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = meetingDoctorDataGridView.CurrentCell.RowIndex;
            idTherapy = Convert.ToInt32(meetingDoctorDataGridView.Rows[rowIndex].Cells[0].Value);
            button1.Visible = true;
            d = (meetingDoctorDataGridView.Rows[rowIndex].Cells[3].Value).ToString();
            idDoctor = (meetingDoctorDataGridView.Rows[rowIndex].Cells[2].Value).ToString();
        }
    }
}
