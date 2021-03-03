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
    public partial class frmDepartment : Form
    {
        private Form parent;
        private AddState state;
        private DepartmentDB departments;
        public frmDepartment(Form frmmain)
        {
            this.parent = frmmain;
            InitializeComponent();
            departments = new DepartmentDB();
            state = AddState.NAVIGATE;
            Populate(departments.GetCurrentRow());
            SetButtonStates(true);
        }
        private void Populate(Department d)
        {
            inputId.Text = d.DepartmentID;
            inputDepartmentName.Text = d.DepartmentName;
            inputAmountOfPatient.Text = d.AmountOfPatient.ToString();
        }
        private bool UpdateObject(Department d)
        {
            bool ok = true;
            try
            {
                d.DepartmentID = inputId.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                d.DepartmentName = inputDepartmentName.Text;
                errorProvider1.SetError(inputId, "");
            }
            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(inputId, ex.Message);
            }
            try
            {
                d.AmountOfPatient= Convert.ToInt32(inputAmountOfPatient.Text);
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
            inputDepartmentName.Enabled = !b;
            inputAmountOfPatient.Enabled = !b;
        }
        private void inputId_TextChanged(object sender, EventArgs e)
        {
            this.doctorOrNurseTableAdapter.FillBy(this.hMODataSet.DoctorOrNurse,inputId.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            if (UpdateObject(d))
            {
                if (state == AddState.ADDNEW)
                    departments.AddRow(d);
                else
                    departments.UpdateRow(d);
            }
            SetButtonStates(true);
            state = AddState.NAVIGATE;
            departments.Save();
        }

        private void next_Click(object sender, EventArgs e)
        {
            departments.MoveNext();
            Populate(departments.GetCurrentRow());
        }

        private void prev_Click(object sender, EventArgs e)
        {
            departments.MovePrev();
            Populate(departments.GetCurrentRow());
        }

        private void update_Click(object sender, EventArgs e)
        {
            SetButtonStates(false);
            state = AddState.UPDATE;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Clear();
            inputId.Text = departments.GetKey();
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
            Populate(departments.GetCurrentRow());
            SetButtonStates(true);
        }

        private void frmDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            parent.Show();
        }

        private void doctorOrNurseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorOrNurseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMODataSet);

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMODataSet.DoctorOrNurse' table. You can move, or remove it, as needed.
        }

        private void doctorOrNurseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = doctorOrNurseDataGridView.CurrentCell.RowIndex;
            string id = doctorOrNurseDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            frmDoctorOrNurse f = new frmDoctorOrNurse(id);
            f.Show();
        }
    }
}
