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
    public partial class frmScheduleDoctor : Form
    {
        public frmScheduleDoctor()
        {
            InitializeComponent();
        }

        private void meetingDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.meetingDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMODataSet1);

        }

        private void frmScheduleDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMODataSet1.MeetingDoctor' table. You can move, or remove it, as needed.
            this.meetingDoctorTableAdapter.Fill(this.hMODataSet1.MeetingDoctor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
