namespace DrorCohen.Gui
{
    partial class frmGenericTherapy
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
            this.save = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputDuration = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.inputTypeOfTherapy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputWhoGiveTherapy = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(580, 183);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(212, 23);
            this.save.TabIndex = 71;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(123, 274);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(94, 23);
            this.prev.TabIndex = 70;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(308, 274);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 23);
            this.next.TabIndex = 69;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.Location = new System.Drawing.Point(717, 139);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 68;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(717, 86);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 67;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(717, 40);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 66;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(304, 44);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(200, 20);
            this.inputCode.TabIndex = 65;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(304, 80);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(200, 20);
            this.inputName.TabIndex = 64;
            // 
            // inputDuration
            // 
            this.inputDuration.Location = new System.Drawing.Point(304, 123);
            this.inputDuration.Name = "inputDuration";
            this.inputDuration.Size = new System.Drawing.Size(200, 20);
            this.inputDuration.TabIndex = 63;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(17, 123);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(167, 29);
            this.lastName.TabIndex = 62;
            this.lastName.Text = "Duration:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(17, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(167, 32);
            this.name.TabIndex = 61;
            this.name.Text = "Name: ";
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(17, 44);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(134, 24);
            this.Code.TabIndex = 60;
            this.Code.Text = "Therapy Code: ";
            // 
            // inputTypeOfTherapy
            // 
            this.inputTypeOfTherapy.Location = new System.Drawing.Point(304, 162);
            this.inputTypeOfTherapy.Name = "inputTypeOfTherapy";
            this.inputTypeOfTherapy.Size = new System.Drawing.Size(200, 20);
            this.inputTypeOfTherapy.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "Type Of Therapy:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "Who Allowed To Give The Therapy:";
            // 
            // inputWhoGiveTherapy
            // 
            this.inputWhoGiveTherapy.FormattingEnabled = true;
            this.inputWhoGiveTherapy.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.inputWhoGiveTherapy.Location = new System.Drawing.Point(308, 204);
            this.inputWhoGiveTherapy.Name = "inputWhoGiveTherapy";
            this.inputWhoGiveTherapy.Size = new System.Drawing.Size(196, 21);
            this.inputWhoGiveTherapy.TabIndex = 75;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGenericTherapy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputWhoGiveTherapy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTypeOfTherapy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputDuration);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Code);
            this.Name = "frmGenericTherapy";
            this.Text = "frmGenericTherapy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenericTherapy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputDuration;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox inputTypeOfTherapy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputWhoGiveTherapy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}