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
            //Frmmain f = new Frmmain();
            if (id.Text.Equals("111111111"))
            {
                frmOpen f = new frmOpen(this);
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
    }
}
