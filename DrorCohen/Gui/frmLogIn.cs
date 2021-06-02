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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)this.doctorOrNurseTableAdapter.isAdmin(id.Text, "admin");
            //Frmmain f = new Frmmain();
            if (x>0)
            {
                frmOpen f = new frmOpen(this);
                f.Width = 1500;
                f.Show();
                this.Hide();
            }
            else
            {
                MyMessage m = new MyMessage("your are not identify as manger\n please try again later", 2);
                m.applyCustomChange();
                m.ShowDialog();
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorOrNurseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorOrNurseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.isAdmin1);

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isAdmin1.DoctorOrNurse' table. You can move, or remove it, as needed.
            this.doctorOrNurseTableAdapter.Fill(this.isAdmin1.DoctorOrNurse);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
