namespace DrorCohen.Gui
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.isAdmin1 = new DrorCohen.isAdmin();
            this.doctorOrNurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorOrNurseTableAdapter = new DrorCohen.isAdminTableAdapters.DoctorOrNurseTableAdapter();
            this.tableAdapterManager = new DrorCohen.isAdminTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "please enter your login details:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(207, 191);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(170, 37);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(231, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isAdmin1
            // 
            this.isAdmin1.DataSetName = "isAdmin";
            this.isAdmin1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorOrNurseBindingSource
            // 
            this.doctorOrNurseBindingSource.DataMember = "DoctorOrNurse";
            this.doctorOrNurseBindingSource.DataSource = this.isAdmin1;
            // 
            // doctorOrNurseTableAdapter
            // 
            this.doctorOrNurseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorOrNurseTableAdapter = this.doctorOrNurseTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrorCohen.isAdminTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(657, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isAdmin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorOrNurseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private isAdmin isAdmin1;
        private System.Windows.Forms.BindingSource doctorOrNurseBindingSource;
        private isAdminTableAdapters.DoctorOrNurseTableAdapter doctorOrNurseTableAdapter;
        private isAdminTableAdapters.TableAdapterManager tableAdapterManager;
    }
}