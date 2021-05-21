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
    public partial class frmGenericTherapy : Form
    {
        private Form parent;
        private AddState state;
        //private GenericTherapyDB therapys;
        public frmGenericTherapy(Form f)
        {
            this.parent = f;
            InitializeComponent();
            //therapys = new GenericTherapyDB();
            state = AddState.NAVIGATE;
            //Populate(therapys.GetCurrentRow());
            SetButtonStates(true);
        }
        public frmGenericTherapy()
        {
            InitializeComponent();
        }
        //private bool UpdateObject(GenericTherapy p)
        //{
        //    bool ok = true;
        //    try
        //    {
        //        p.TherapyCode = inputCode.Text;
        //        errorProvider1.SetError(inputCode, "");
        //    }
        //    catch (Exception ex)
        //    {
        //        ok = false;
        //        errorProvider1.SetError(inputCode, ex.Message);
        //    }
        //    try
        //    {
        //        p.DurationOfTherapy = inputDuration.Text;
        //        errorProvider1.SetError(inputCode, "");
        //    }
        //    catch (Exception ex)
        //    {
        //        ok = false;
        //        errorProvider1.SetError(inputCode, ex.Message);
        //    }
        //    try
        //    {
        //        p.NameOftherapy = inputName.Text;
        //        errorProvider1.SetError(inputCode, "");
        //    }
        //    catch (Exception ex)
        //    {
        //        ok = false;
        //        errorProvider1.SetError(inputCode, ex.Message);
        //    }
        //    try
        //    {
        //        p.TypeOfTherapy = inputTypeOfTherapy.Text;
        //        errorProvider1.SetError(inputCode, "");
        //    }
        //    catch (Exception ex)
        //    {
        //        ok = false;
        //        errorProvider1.SetError(inputCode, ex.Message);
        //    }
        //    try
        //    {
        //        p.WhoCanGiveTheTherapy = inputWhoGiveTherapy.Text;
        //        errorProvider1.SetError(inputCode, "");
        //    }
        //    catch (Exception ex)
        //    {
        //        ok = false;
        //        errorProvider1.SetError(inputCode, ex.Message);
        //    }
        //    return ok;
        //}
        private void SetButtonStates(bool b)
        {
            next.Enabled = b;
            prev.Enabled = b;
            Add.Enabled = b;
            update.Enabled = b;
            cancel.Enabled = !b;
            save.Enabled = !b;
            inputCode.Enabled = !b;
            inputDuration.Enabled = !b;
            inputName.Enabled = !b;
            inputTypeOfTherapy.Enabled = !b;
            inputWhoGiveTherapy.Enabled = !b;
        }
        //private void Populate(GenericTherapy gt)
        //{
        //    inputCode.Text = gt.TherapyCode;
        //    inputDuration.Text = gt.DurationOfTherapy;
        //    inputName.Text = gt.NameOftherapy;
        //    inputTypeOfTherapy.Text = gt.TypeOfTherapy;
        //    inputWhoGiveTherapy.Text = gt.WhoCanGiveTheTherapy;
        //}
        private void cancel_Click(object sender, EventArgs e)
        {
            //Populate(therapys.GetCurrentRow());
            SetButtonStates(true);
        }

        private void save_Click(object sender, EventArgs e)
        {
            //GenericTherapy gt = new GenericTherapy();
            //if (UpdateObject(gt))
            //{
            //    if (state == AddState.ADDNEW)
            //        therapys.AddRow(gt);
            //    else
            //        therapys.UpdateRow(gt);
            //}
            //SetButtonStates(true);
            //state = AddState.NAVIGATE;
            //therapys.Save();
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

        private void Add_Click(object sender, EventArgs e)
        {
            Clear();
            //inputCode.Text = therapys.GetKey();
            state = AddState.ADDNEW;
            SetButtonStates(false);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            //therapys.MovePrev();
            //Populate(therapys.GetCurrentRow());
        }

        private void next_Click(object sender, EventArgs e)
        {
            //therapys.MoveNext();
            //Populate(therapys.GetCurrentRow());
        }

        private void frmGenericTherapy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Dispose();
            parent.Show();
        }
    }
}
