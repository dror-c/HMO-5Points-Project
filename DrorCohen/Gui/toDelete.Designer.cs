
using System;

namespace DrorCohen.Gui
{
    partial class toDelete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderTherapy = new System.Windows.Forms.Button();
            this.lastNameSearch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.inputId = new System.Windows.Forms.TextBox();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputPhoneNumber = new System.Windows.Forms.TextBox();
            this.inputDateBirth = new System.Windows.Forms.DateTimePicker();
            this.inputDateDeath = new System.Windows.Forms.DateTimePicker();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.dateOfDeath = new System.Windows.Forms.Label();
            this.maleOrFemale = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderTherapy
            // 
            this.orderTherapy.Location = new System.Drawing.Point(700, 83);
            this.orderTherapy.Margin = new System.Windows.Forms.Padding(4);
            this.orderTherapy.Name = "orderTherapy";
            this.orderTherapy.Size = new System.Drawing.Size(128, 28);
            this.orderTherapy.TabIndex = 64;
            this.orderTherapy.Text = "order therapy";
            this.orderTherapy.UseVisualStyleBackColor = true;
            // 
            // lastNameSearch
            // 
            this.lastNameSearch.HideSelection = false;
            this.lastNameSearch.Location = new System.Drawing.Point(1014, 291);
            this.lastNameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameSearch.Name = "lastNameSearch";
            this.lastNameSearch.Size = new System.Drawing.Size(159, 22);
            this.lastNameSearch.TabIndex = 62;
            this.lastNameSearch.TextChanged += new System.EventHandler(this.lastNameSearch_TextChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1014, 334);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 116);
            this.listBox1.TabIndex = 61;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1014, 476);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(160, 28);
            this.search.TabIndex = 60;
            this.search.Text = "submit";
            this.search.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1009, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(688, 418);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(283, 28);
            this.save.TabIndex = 59;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(214, 498);
            this.prev.Margin = new System.Windows.Forms.Padding(4);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(125, 28);
            this.prev.TabIndex = 58;
            this.prev.Text = "<<";
            this.prev.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(461, 498);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(125, 28);
            this.next.TabIndex = 57;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancel.Location = new System.Drawing.Point(870, 208);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 56;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(870, 143);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 55;
            this.Add.Text = "create";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(870, 83);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 28);
            this.update.TabIndex = 54;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(320, 88);
            this.inputId.Margin = new System.Windows.Forms.Padding(4);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(265, 22);
            this.inputId.TabIndex = 53;
            this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged_1);
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(320, 132);
            this.inputFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(265, 22);
            this.inputFirstName.TabIndex = 52;
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(320, 185);
            this.inputLastName.Margin = new System.Windows.Forms.Padding(4);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(265, 22);
            this.inputLastName.TabIndex = 51;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(320, 239);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(4);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(265, 22);
            this.inputAddress.TabIndex = 50;
            this.inputAddress.TextChanged += new System.EventHandler(this.inputAddress_TextChanged);
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Location = new System.Drawing.Point(320, 291);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(265, 22);
            this.inputPhoneNumber.TabIndex = 49;
            // 
            // inputDateBirth
            // 
            this.inputDateBirth.Location = new System.Drawing.Point(320, 333);
            this.inputDateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.inputDateBirth.Name = "inputDateBirth";
            this.inputDateBirth.Size = new System.Drawing.Size(265, 22);
            this.inputDateBirth.TabIndex = 48;
            // 
            // inputDateDeath
            // 
            this.inputDateDeath.Location = new System.Drawing.Point(320, 377);
            this.inputDateDeath.Margin = new System.Windows.Forms.Padding(4);
            this.inputDateDeath.Name = "inputDateDeath";
            this.inputDateDeath.Size = new System.Drawing.Size(265, 22);
            this.inputDateDeath.TabIndex = 47;
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.inputGender.Location = new System.Drawing.Point(320, 418);
            this.inputGender.Margin = new System.Windows.Forms.Padding(4);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(265, 24);
            this.inputGender.TabIndex = 46;
            // 
            // dateOfDeath
            // 
            this.dateOfDeath.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfDeath.Location = new System.Drawing.Point(73, 377);
            this.dateOfDeath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfDeath.Name = "dateOfDeath";
            this.dateOfDeath.Size = new System.Drawing.Size(175, 37);
            this.dateOfDeath.TabIndex = 45;
            this.dateOfDeath.Text = "Date Of Death: ";
            // 
            // maleOrFemale
            // 
            this.maleOrFemale.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleOrFemale.Location = new System.Drawing.Point(73, 414);
            this.maleOrFemale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maleOrFemale.Name = "maleOrFemale";
            this.maleOrFemale.Size = new System.Drawing.Size(159, 37);
            this.maleOrFemale.TabIndex = 44;
            this.maleOrFemale.Text = "Gender: ";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.Location = new System.Drawing.Point(73, 291);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(175, 37);
            this.phoneNumber.TabIndex = 43;
            this.phoneNumber.Text = "Phone Number: ";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(73, 333);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(159, 37);
            this.dateOfBirth.TabIndex = 42;
            this.dateOfBirth.Text = "Date Of Birth: ";
            // 
            // adress
            // 
            this.adress.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress.Location = new System.Drawing.Point(73, 239);
            this.adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(159, 32);
            this.adress.TabIndex = 41;
            this.adress.Text = "Address: ";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(73, 185);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(159, 36);
            this.lastName.TabIndex = 40;
            this.lastName.Text = "Last Name: ";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(73, 132);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(159, 39);
            this.firstName.TabIndex = 39;
            this.firstName.Text = "First Name: ";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(73, 88);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(159, 30);
            this.id.TabIndex = 38;
            this.id.Text = "id: ";
            // 
            // toDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderTherapy);
            this.Controls.Add(this.lastNameSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.inputId);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputPhoneNumber);
            this.Controls.Add(this.inputDateBirth);
            this.Controls.Add(this.inputDateDeath);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.dateOfDeath);
            this.Controls.Add(this.maleOrFemale);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.id);
            this.Name = "toDelete";
            this.Size = new System.Drawing.Size(1521, 940);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button orderTherapy;
        private System.Windows.Forms.TextBox lastNameSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.TextBox inputPhoneNumber;
        private System.Windows.Forms.DateTimePicker inputDateBirth;
        private System.Windows.Forms.DateTimePicker inputDateDeath;
        private System.Windows.Forms.ComboBox inputGender;
        private System.Windows.Forms.Label dateOfDeath;
        private System.Windows.Forms.Label maleOrFemale;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label id;
    }
}
