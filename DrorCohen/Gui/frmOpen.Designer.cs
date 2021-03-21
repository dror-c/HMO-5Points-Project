namespace DrorCohen.Gui
{
    partial class frmOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpen));
            this.panelMenue = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.therapys = new FontAwesome.Sharp.IconButton();
            this.department = new FontAwesome.Sharp.IconButton();
            this.doctor = new FontAwesome.Sharp.IconButton();
            this.Patient = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vaccine1 = new DrorCohen.Gui.vaccine();
            this.panelMenue.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.Color.MediumBlue;
            this.panelMenue.Controls.Add(this.iconButton1);
            this.panelMenue.Controls.Add(this.therapys);
            this.panelMenue.Controls.Add(this.department);
            this.panelMenue.Controls.Add(this.doctor);
            this.panelMenue.Controls.Add(this.Patient);
            this.panelMenue.Controls.Add(this.panelLogo);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(430, 747);
            this.panelMenue.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 661);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 0, 24, 0);
            this.iconButton1.Size = new System.Drawing.Size(430, 86);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "help";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // therapys
            // 
            this.therapys.Dock = System.Windows.Forms.DockStyle.Top;
            this.therapys.FlatAppearance.BorderSize = 0;
            this.therapys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.therapys.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.therapys.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.therapys.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.therapys.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.therapys.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.therapys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.therapys.Location = new System.Drawing.Point(0, 524);
            this.therapys.Margin = new System.Windows.Forms.Padding(4);
            this.therapys.Name = "therapys";
            this.therapys.Padding = new System.Windows.Forms.Padding(11, 0, 24, 0);
            this.therapys.Size = new System.Drawing.Size(430, 86);
            this.therapys.TabIndex = 4;
            this.therapys.Text = "all therapys";
            this.therapys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.therapys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.therapys.UseVisualStyleBackColor = true;
            this.therapys.Click += new System.EventHandler(this.therapys_Click);
            // 
            // department
            // 
            this.department.Dock = System.Windows.Forms.DockStyle.Top;
            this.department.FlatAppearance.BorderSize = 0;
            this.department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.department.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.department.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.department.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.department.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.department.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.department.Location = new System.Drawing.Point(0, 438);
            this.department.Margin = new System.Windows.Forms.Padding(4);
            this.department.Name = "department";
            this.department.Padding = new System.Windows.Forms.Padding(11, 0, 24, 0);
            this.department.Size = new System.Drawing.Size(430, 86);
            this.department.TabIndex = 3;
            this.department.Text = "departments";
            this.department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.department.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.department.UseVisualStyleBackColor = true;
            this.department.Click += new System.EventHandler(this.department_Click);
            // 
            // doctor
            // 
            this.doctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctor.FlatAppearance.BorderSize = 0;
            this.doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.doctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doctor.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.doctor.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.doctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctor.Location = new System.Drawing.Point(0, 352);
            this.doctor.Margin = new System.Windows.Forms.Padding(4);
            this.doctor.Name = "doctor";
            this.doctor.Padding = new System.Windows.Forms.Padding(11, 0, 24, 0);
            this.doctor.Size = new System.Drawing.Size(430, 86);
            this.doctor.TabIndex = 2;
            this.doctor.Text = "workers\' details";
            this.doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctor.UseVisualStyleBackColor = true;
            this.doctor.Click += new System.EventHandler(this.doctor_Click);
            // 
            // Patient
            // 
            this.Patient.Dock = System.Windows.Forms.DockStyle.Top;
            this.Patient.FlatAppearance.BorderSize = 0;
            this.Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patient.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Patient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Patient.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.Patient.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.Patient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Patient.Location = new System.Drawing.Point(0, 266);
            this.Patient.Margin = new System.Windows.Forms.Padding(4);
            this.Patient.Name = "Patient";
            this.Patient.Padding = new System.Windows.Forms.Padding(11, 0, 24, 0);
            this.Patient.Size = new System.Drawing.Size(430, 86);
            this.Patient.TabIndex = 1;
            this.Patient.Text = "patients\' details";
            this.Patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Patient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Patient.UseVisualStyleBackColor = true;
            this.Patient.Click += new System.EventHandler(this.Patient_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconButton2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(430, 266);
            this.panelLogo.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShieldVirus;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 72;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(11, 0, 24, 0);
            this.iconButton2.Size = new System.Drawing.Size(430, 224);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Your Best\r\n Health Care";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 12);
            this.panel1.TabIndex = 1;
            // 
            // vaccine1
            // 
            this.vaccine1.BackColor = System.Drawing.Color.White;
            this.vaccine1.Location = new System.Drawing.Point(475, 68);
            this.vaccine1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vaccine1.Name = "vaccine1";
            this.vaccine1.Size = new System.Drawing.Size(883, 440);
            this.vaccine1.TabIndex = 2;
            this.vaccine1.Load += new System.EventHandler(this.vaccine1_Load);
            // 
            // frmOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 747);
            this.Controls.Add(this.vaccine1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOpen";
            this.Load += new System.EventHandler(this.frmOpen_Load);
            this.panelMenue.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenue;
        private FontAwesome.Sharp.IconButton therapys;
        private FontAwesome.Sharp.IconButton department;
        private FontAwesome.Sharp.IconButton doctor;
        private FontAwesome.Sharp.IconButton Patient;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private vaccine vaccine1;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}