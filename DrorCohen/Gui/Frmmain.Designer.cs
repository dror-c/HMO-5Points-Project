namespace DrorCohen.Gui
{
    partial class Frmmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patient = new System.Windows.Forms.Button();
            this.DoctorOrNurse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient
            // 
            this.patient.Location = new System.Drawing.Point(84, 128);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(75, 23);
            this.patient.TabIndex = 0;
            this.patient.Text = "patient";
            this.patient.UseVisualStyleBackColor = true;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // DoctorOrNurse
            // 
            this.DoctorOrNurse.Location = new System.Drawing.Point(84, 87);
            this.DoctorOrNurse.Name = "DoctorOrNurse";
            this.DoctorOrNurse.Size = new System.Drawing.Size(96, 23);
            this.DoctorOrNurse.TabIndex = 1;
            this.DoctorOrNurse.Text = "Doctor/Nurse";
            this.DoctorOrNurse.UseVisualStyleBackColor = true;
            this.DoctorOrNurse.Click += new System.EventHandler(this.DoctorOrNurse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorOrNurse);
            this.Controls.Add(this.patient);
            this.Name = "Frmmain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frmmain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Button DoctorOrNurse;
        private System.Windows.Forms.Button button1;
    }
}

