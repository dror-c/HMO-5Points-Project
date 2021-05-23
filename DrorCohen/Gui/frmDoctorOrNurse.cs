using DrorCohen.DB;
using DrorCohen.Models;
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

namespace DrorCohen.Gui
{
    public partial class frmDoctorOrNurse : Form
    {
        private AddState state;
        private DoctorOrNurseDB doctorsOrNurses;
        private Form parent;
        private string idDoc;
        private static bool flag;

        public frmDoctorOrNurse(string id)
        {
            InitializeComponent();
            this.idDoc = id;
            doctorsOrNurses = new DoctorOrNurseDB();
            state = AddState.NAVIGATE;
            SetButtonStates(true);
            doctorsOrNurses.Find(id);
            Populate(doctorsOrNurses.GetCurrentRow());
            flag = true;
        }

        public frmDoctorOrNurse(Form f)
        {
            this.parent = f;
            InitializeComponent();
            doctorsOrNurses = new DoctorOrNurseDB();
            state = AddState.NAVIGATE;
            Populate(doctorsOrNurses.GetCurrentRow());
            SetButtonStates(true);
        }

        private void Populate(DoctorOrNurse p)
        {
            inputId.Text = p.Id;
            inputFirstName.Text = p.FirstName;
            inputLastName.Text = p.LastName;
            inputAddress.Text = p.Address;
            inputPhoneNumber.Text = p.PhoneNumber;
            inputGender.Text = p.MaleOrFemale;
            inputDateBirth.Value = p.DateOfBirth;
            inputDoctorOrNurse.Text = p.IsDoctorOrNurse;
        }
        private bool UpdateObject(DoctorOrNurse p)
        {
            bool ok = true;
            try
            {
                p.Id = inputId.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.FirstName = inputFirstName.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.LastName = inputLastName.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.Address = inputAddress.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.PhoneNumber = inputPhoneNumber.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.MaleOrFemale = inputGender.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.DateOfBirth = inputDateBirth.Value;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                p.IsDoctorOrNurse = inputDoctorOrNurse.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            return ok;
        }
        private void SetButtonStates(bool b)
        {
            next.Enabled = b;
            prev.Enabled = b;
            Add.Enabled = b;
            update.Enabled = b;
            cancel.Enabled = !b;
            save.Enabled = !b;
            inputId.Enabled = !b;
            inputFirstName.Enabled = !b;
            inputLastName.Enabled = !b;
            inputAddress.Enabled = !b;
            inputPhoneNumber.Enabled = !b;
            inputGender.Enabled = !b;
            inputDateBirth.Enabled = !b;
            inputDoctorOrNurse.Enabled = !b;
        }
        private void frmPatient_Load(object sender, EventArgs e)
        {

        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {

        }


        private void update_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            state = AddState.UPDATE;
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
        private void save_Click(object sender, EventArgs e)
        {
            DoctorOrNurse dn = new DoctorOrNurse();
            if (UpdateObject(dn))
            {
                if (state == AddState.ADDNEW)
                    doctorsOrNurses.AddRow(dn);
                else
                    doctorsOrNurses.UpdateRow(dn);
            }
            SetButtonStates(true);
            state = AddState.NAVIGATE;
            doctorsOrNurses.Save();
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Clear();
            state = AddState.ADDNEW;
            SetButtonStates(false);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Populate(doctorsOrNurses.GetCurrentRow());
            errorProvider1.SetError(inputId, null);
            errorProvider1.SetError(inputFirstName, null);
            errorProvider1.SetError(inputLastName, null);
            errorProvider1.SetError(inputAddress, null);
            errorProvider1.SetError(inputPhoneNumber, null);
            errorProvider1.SetError(inputDateBirth, null);
            errorProvider1.SetError(inputGender, null);
            errorProvider1.SetError(inputDoctorOrNurse, null);
            SetButtonStates(true);
        }
        private void prev_Click(object sender, EventArgs e)
        {
            doctorsOrNurses.MovePrev();
            Populate(doctorsOrNurses.GetCurrentRow());
        }

        private void next_Click(object sender, EventArgs e)
        {
            doctorsOrNurses.MoveNext();
            Populate(doctorsOrNurses.GetCurrentRow());
        }

        private void frmDoctorOrNurse_FormClosing(object sender, FormClosingEventArgs e)
        {
            flag = false;
            this.Hide();
            this.Dispose();
            parent.Show();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMODataSet);

        }

        private void frmDoctorOrNurse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMODataSet.DoctorOrNurse' table. You can move, or remove it, as needed.
            this.doctorOrNurseTableAdapter.Fill(this.hMODataSet.DoctorOrNurse);
            // TODO: This line of code loads data into the 'hMODataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hMODataSet.Department);

        }




        private void inputId_TextChanged_1(object sender, EventArgs e)
        {
            this.specificMeetingDoctorTableAdapter.Fill(this.meetingForToday.SpecificMeetingDoctor, inputId.Text);
        }

        private void inputId_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.CheckIdNumber(inputId.Text))
            {
                e.Cancel = true;
                inputId.Focus();
                errorProvider1.SetError(inputId, "this id number is not valid id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputId, null);
            }
        }

        private void inputFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.IsLegalName(inputFirstName.Text))
            {
                e.Cancel = true;
                inputFirstName.Focus();
                errorProvider1.SetError(inputFirstName, "you have entered non valid charchters");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputFirstName, null);
            }
        }

        private void inputLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.IsLegalName(inputLastName.Text))
            {
                e.Cancel = true;
                inputLastName.Focus();
                errorProvider1.SetError(inputLastName, "you have entered non valid charchters");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputLastName, null);
            }
        }

        private void inputAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.IsLegalAddress(inputAddress.Text))
            {
                e.Cancel = true;
                inputAddress.Focus();
                errorProvider1.SetError(inputAddress, "you have entered non valid charchters");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputAddress, null);
            }
        }

        private void inputPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.IsPhoneNumber(inputPhoneNumber.Text))
            {
                e.Cancel = true;
                inputPhoneNumber.Focus();
                errorProvider1.SetError(inputPhoneNumber, "you have entered non valid charchters");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputPhoneNumber, null);
            }
        }

        private void inputDateBirth_Validating(object sender, CancelEventArgs e)
        {
            if (inputDateBirth.Value > DateTime.Now)
            {
                e.Cancel = true;
                inputDateBirth.Focus();
                errorProvider1.SetError(inputDateBirth, "this date isnt happened yet");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputDateBirth, null);
            }
        }

        private void inputGender_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.IsLegalSex(inputGender.Text))
            {
                e.Cancel = true;
                inputGender.Focus();
                errorProvider1.SetError(inputGender, "this option does not exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputGender, null);
            }
        }

        private void inputDoctorOrNurse_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.IsLegalJob(inputDoctorOrNurse.Text))
            {
                e.Cancel = true;
                inputDoctorOrNurse.Focus();
                errorProvider1.SetError(inputDoctorOrNurse, "this option does not exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputDoctorOrNurse, null);
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            //bool flag = false;
            //foreach(string s in comboBox1.Items.IndexOf(comboBox1.Text))
            //    if (comboBox1.Text.Equals(s))
            //    {
            //        flag = true;
            //        break;
            //    }
            //int a = comboBox1.Items.IndexOf(0);
            //if (comboBox1.Items.IndexOf(comboBox1.Text)!=-1)
            //{
            //    e.Cancel = true;
            //    comboBox1.Focus();
            //    errorProvider1.SetError(comboBox1, "this department does not exist");
            //}
        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void specificMeetingDoctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmScheduleDoctor f = new frmScheduleDoctor(inputId.Text);
            f.Width = 1100;
            f.ShowDialog();
        }
    }
}
