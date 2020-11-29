using DrorCohen.Gui;
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
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            frmPatient frmPatient = new frmPatient(this);
            //frmPatient.MdiParent = this.MdiParent;
            this.Hide();
            frmPatient.ShowDialog();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }

        private void DoctorOrNurse_Click(object sender, EventArgs e)
        {
            frmDoctorOrNurse frmDoctorOrNurse = new frmDoctorOrNurse(this);
            //frmPatient.MdiParent = this.MdiParent;
            this.Hide();
            frmDoctorOrNurse.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDepartment frmDepartment = new frmDepartment(this);
            //frmPatient.MdiParent = this.MdiParent;
            this.Hide();
            frmDepartment.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGenericTherapy frmGenericTherapy = new frmGenericTherapy(this);
            //frmPatient.MdiParent = this.MdiParent;
            this.Hide();
            frmGenericTherapy.ShowDialog();
        }
    }
}
