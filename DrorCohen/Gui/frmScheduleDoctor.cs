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
using DrorCohen.DATA;

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
                    textBox2.Text = doctorId;
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
        private bool UpdateObject(ScheduleDoctorMeeting s)
        {
            bool ok = true;
            try
            {
                s.TherapyCode= textBox1.Text;
                errorProvider1.SetError(textBox1, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(textBox1, ex.Message);
            }
            try
            {
                s.IdDoctor= textBox2.Text;
                errorProvider1.SetError(textBox2, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(textBox2, ex.Message);
            }
            try
            {
                s.WhoCanGiveTheTherapy= comboBox2.Text;
                errorProvider1.SetError(comboBox2, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(comboBox2, ex.Message);
            }
            try
            {
                s.Day = comboBox1.SelectedIndex+1;
                errorProvider1.SetError(comboBox1, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(comboBox1, ex.Message);
            }
            try
            {
                s.Hour = textBox3.Text;
                errorProvider1.SetError(textBox3, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(textBox3, ex.Message);
            }
            return ok;
        }
        private void save_Click(object sender, EventArgs e)
        {
            ScheduleDoctorMeeting s = new ScheduleDoctorMeeting();
            //s.Day = comboBox1.SelectedIndex + 1;
            if (UpdateObject(s))
            {
                if (state == AddState.ADDNEW)
                {
                    string SQLadd = "INSERT INTO MeetingDoctor ( TherapyCode, WhoCanGiveTheTherapy, IdDoctor, [day], [hour] ) VALUES('" + s.TherapyCode+ "','" + s.WhoCanGiveTheTherapy+ "','" + s.IdDoctor+ "',[" + s.Day+ "],['" + s.Hour+ "'])";
                    //string path = System.IO.Directory.GetCurrentDirectory();
                    //int x = path.IndexOf("\\bin");
                    //path = path.Substring(0, x) + "\\Data\\try.accdb";

                    //string myConnectionStr = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
                    //con = new OleDbConnection(myConnectionStr);
                    //con.Open();
                    //OleDbCommand SQLCommand = new OleDbCommand();
                    //SQLCommand.CommandText = SQLadd;
                    //SQLCommand.Connection = con;
                    int response1 = -1;
                    //  response1 = SQLCommand.ExecuteNonQuery();
                    response1 = DAL.GetInstance().ExecuteNonQuery(SQLadd);
                   

                }
                //meetings.AddRow(s);

                else
                    meetings.UpdateRow(s);
            }
            SetButtonStates(true);
            state = AddState.NAVIGATE;
 //..           meetings.Save();
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
            textBox2.Text = this.doctorId;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidationUtilites.isNumber(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "not valid code");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!(comboBox2.Text.Equals("Doctor") || comboBox2.Equals("Nurse")))
            {
                e.Cancel = true;
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "not valid role");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox2, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidationUtilites.CheckIdNumber(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "not valid id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidationUtilites.isDay(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "this day format is wrong");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBox1, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidationUtilites.isHour(textBox3.Text))
            {
                e.Cancel = false;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "not valid hour!" +
                    " please adhere to the format");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, null);
            }
        }
    }
}
