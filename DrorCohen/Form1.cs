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

namespace DrorCohen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            frmPatient frmPatient = new frmPatient();
            frmPatient.MdiParent = this.MdiParent;
            this.Hide();
            frmPatient.ShowDialog();
        }
    }
}
