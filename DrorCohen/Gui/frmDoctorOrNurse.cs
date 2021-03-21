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
            inputDateDeath.Value = p.DateOfDeath;
            inputDoctorOrNurse.Text = p.IsDoctorOrNurse;
            inputDepartmentID.Text = p.DepartmentID;
            comboId.Text = p.DepartmentID;
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
                p.DateOfDeath = inputDateDeath.Value;
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
            try
            {
                p.DepartmentID = inputDepartmentID.Text;
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
            inputDepartmentID.Enabled = !b;
            inputDoctorOrNurse.Enabled = !b;
        }
        private void frmPatient_Load(object sender, EventArgs e)
        {

        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure that you want to delete?"
                , "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(flag==true)
                inputDepartmentID.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboId.SelectedIndex;
        }


        private void inputId_TextChanged_1(object sender, EventArgs e)
        {
            this.specificMeetingDoctorTableAdapter.Fill(this.meetingForToday.SpecificMeetingDoctor, inputId.Text);
        }
    }
}
