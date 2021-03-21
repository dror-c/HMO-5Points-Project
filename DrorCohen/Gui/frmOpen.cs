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
    public partial class frmOpen : Form
    {
        public frmOpen()
        {
            InitializeComponent();
            vaccine f = new vaccine () { Dock = DockStyle.Fill };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(f);
            this.pContainer.BringToFront();
            f.Show();
        }

        private void imageLogo_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            frmPatient f = new frmPatient(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(f);
            this.pContainer.BringToFront();
            f.Show();
            /*frmPatient f = new frmPatient(this);
            f.Show();
            this.Hide();*/
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            frmDoctorOrNurse f = new frmDoctorOrNurse(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(f);
            this.pContainer.BringToFront();
            f.Show();
            /*frmDoctorOrNurse f = new frmDoctorOrNurse(this);
            f.Show();
            this.Hide();*/
        }

        private void department_Click(object sender, EventArgs e)
        {
            frmDepartment f = new frmDepartment(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(f);
            this.pContainer.BringToFront();
            f.Show();
            /*frmDepartment f = new frmDepartment(this);
            f.Show();
            this.Hide();*/
        }

        private void therapys_Click(object sender, EventArgs e)
        {
            
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmOpen_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please call to our call center: 1111");
        }

        private void vaccine1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
