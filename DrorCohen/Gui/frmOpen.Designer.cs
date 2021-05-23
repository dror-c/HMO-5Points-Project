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
            this.department = new FontAwesome.Sharp.IconButton();
            this.doctor = new FontAwesome.Sharp.IconButton();
            this.Patient = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.panelMenue.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.Color.MediumBlue;
            this.panelMenue.Controls.Add(this.exitButton);
            this.panelMenue.Controls.Add(this.iconButton1);
            this.panelMenue.Controls.Add(this.department);
            this.panelMenue.Controls.Add(this.doctor);
            this.panelMenue.Controls.Add(this.Patient);
            this.panelMenue.Controls.Add(this.panelLogo);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(369, 646);
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
            this.iconButton1.Location = new System.Drawing.Point(0, 576);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.iconButton1.Size = new System.Drawing.Size(369, 70);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "help";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.department.Location = new System.Drawing.Point(0, 382);
            this.department.Name = "department";
            this.department.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.department.Size = new System.Drawing.Size(369, 88);
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
            this.doctor.Location = new System.Drawing.Point(0, 289);
            this.doctor.Name = "doctor";
            this.doctor.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.doctor.Size = new System.Drawing.Size(369, 93);
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
            this.Patient.Location = new System.Drawing.Point(0, 216);
            this.Patient.Name = "Patient";
            this.Patient.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.Patient.Size = new System.Drawing.Size(369, 73);
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
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(369, 216);
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
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.iconButton2.Size = new System.Drawing.Size(369, 182);
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
            this.panel1.Location = new System.Drawing.Point(369, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 10);
            this.panel1.TabIndex = 1;
            // 
            // pContainer
            // 
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(369, 10);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(977, 636);
            this.pContainer.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 488);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.exitButton.Size = new System.Drawing.Size(369, 88);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // frmOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1346, 646);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOpen_Load);
            this.panelMenue.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenue;
        private FontAwesome.Sharp.IconButton department;
        private FontAwesome.Sharp.IconButton doctor;
        private FontAwesome.Sharp.IconButton Patient;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel pContainer;
        private FontAwesome.Sharp.IconButton exitButton;
    }
}