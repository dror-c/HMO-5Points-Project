﻿using System;
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
        }

        private void imageLogo_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            frmPatient f = new frmPatient(this);
            f.Show();
            this.Hide();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            frmDoctorOrNurse f = new frmDoctorOrNurse(this);
            f.Show();
            this.Hide();
        }

        private void department_Click(object sender, EventArgs e)
        {
            frmDepartment f = new frmDepartment(this);
            f.Show();
            this.Hide();
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
    }
}