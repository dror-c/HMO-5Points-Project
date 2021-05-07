using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrorCohen.Utility;

namespace DrorCohen.Gui
{
    public partial class MyMessage : Form
    {
        private string textMessage;
        private StatusMessage statusMessage;
        public MyMessage(string txt,int status)
        {
            this.textMessage = txt;
            this.statusMessage = (StatusMessage)status;
            InitializeComponent();
        }
        public void applyCustomChange()
        {
            label1.Text = textMessage;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox1.IconColor = Color.FromArgb(255, 255, 255);
            button1.Text = "Got it";
            button1.FlatStyle = FlatStyle.Flat;
            if (this.statusMessage == StatusMessage.APPROVED)
            {
                panel1.BackColor = Color.FromArgb(139, 210, 63);
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                button1.BackColor = Color.FromArgb(139, 210, 63);
            }
            if (this.statusMessage == StatusMessage.ERROR)
            {
                panel1.BackColor = Color.Crimson;
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                button1.BackColor = Color.Crimson;
            }
            if (this.statusMessage == StatusMessage.INFO)
            {
                panel1.BackColor = Color.FromArgb(53, 169, 228);
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                button1.BackColor = Color.FromArgb(53, 169, 228);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
