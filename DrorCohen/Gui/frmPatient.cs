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
using DrorCohen.Utility;

namespace DrorCohen.Gui
{
    public partial class frmPatient : Form
    {
        private Form parent;
        private AddState state;
        private PatientDB patients;
        private DataView dv;
        //public frmPatient()
        //{
        //    InitializeComponent();
        //    patients = new PatientDB();
        //    state = AddState.NAVIGATE;
        //    Populate(patients.GetCurrentRow());
        //    SetButtonStates(true);
        //}

        public frmPatient(Form frmmain)
        {
            this.parent = frmmain;
            InitializeComponent();
            patients = new PatientDB();
            state = AddState.NAVIGATE;
            Populate(patients.GetCurrentRow());
            SetButtonStates(true);
            dv = patients.GetDataView();
            listBox1.DataSource = dv;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "LastName";
        }

        private void Populate(Patient p)
        {
            inputId.Text = p.Id;
            inputFirstName.Text = p.FirstName;
            inputLastName.Text = p.LastName;
            inputAddress.Text = p.Address;
            inputPhoneNumber.Text = p.PhoneNumber;
            inputGender.Text = p.MaleOrFemale;
            inputDateBirth.Value = p.DateOfBirth;
           inputDateDeath.Value = p.DateOfDeath;
        }
        private bool UpdateObject(Patient p)
        {
            bool ok = true;
            try
            {
                p.Id = inputId.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch(Exception ex)
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
                p.DateOfDeath = inputDateDeath.Value;
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
            inputDateDeath.Enabled = !b;
        }
        private void frmPatient_Load(object sender, EventArgs e)
        {

        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {
            idPatientToolStripTextBox.Text = inputId.Text;
            dateOfTherapyToolStripTextBox.Text = DateTime.Today.ToShortDateString();
            this.specificMeetingDoctorTableAdapter.Fill(this.futurePatient.SpecificMeetingDoctor, idPatientToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateOfTherapyToolStripTextBox.Text, typeof(System.DateTime))))));
        }

        private void save_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            if (UpdateObject(p))
            {
                if (state == AddState.ADDNEW)
                    patients.AddRow(p);
                else
                    patients.UpdateRow(p);
            }
            SetButtonStates(true);
            state = AddState.NAVIGATE;
            try
            {
                patients.Save();
            }
            catch 
            {

            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            patients.MoveNext();
            Populate(patients.GetCurrentRow());
        }

        private void prev_Click(object sender, EventArgs e)
        {
            patients.MovePrev();
            Populate(patients.GetCurrentRow());
        }

        private void update_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            state = AddState.UPDATE;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Clear();
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
            Populate(patients.GetCurrentRow());
            SetButtonStates(true);
        }

        private void frmPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            parent.Show();
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "LastName Like '" + lastNameSearch.Text.Trim() + "*'";
        }
        public void GetChoice(int choice)
        {
            if (patients.FindString(choice))
                Populate(patients.GetCurrentRow());
        }

        private void search_Click(object sender, EventArgs e)
        {
            GetChoice(Convert.ToInt32(listBox1.SelectedValue));
        }

        private void orderTherapy_Click(object sender, EventArgs e)
        {
            frmOrderTherapyFinal f = new frmOrderTherapyFinal(inputId.Text, this);
            this.Hide();
            f.ShowDialog();
        }

        private void specificMeetingDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specificMeetingDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.futurePatient);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.specificMeetingDoctorTableAdapter.Fill(this.futurePatient.SpecificMeetingDoctor, idPatientToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateOfTherapyToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void specificMeetingDoctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inputId_Validating(object sender, CancelEventArgs e)
        {
            if (!Utility.ValidationUtilites.LegalId(inputId.Text))
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
                inputId.Focus();
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
                inputId.Focus();
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
                inputId.Focus();
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
                inputId.Focus();
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
            if (Utility.ValidationUtilites.GetAge(inputDateBirth.Value)<0)
            {
                e.Cancel = true;
                inputId.Focus();
                errorProvider1.SetError(inputDateBirth, "your phone number is invalid");
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
                inputId.Focus();
                errorProvider1.SetError(inputGender, "this option does not exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputGender, null);
            }
        }

        private void inputDateBirth_Validating_1(object sender, CancelEventArgs e)
        {
            if (Utility.ValidationUtilites.GetAge(inputDateBirth.Value)<0)
            {
                e.Cancel = true;
                inputId.Focus();
                errorProvider1.SetError(inputGender, "this date isn't happened yet");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(inputGender, null);
            }
        }
    }
}
