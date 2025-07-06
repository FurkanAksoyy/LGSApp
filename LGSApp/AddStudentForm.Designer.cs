namespace LGSApp
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.panelCard = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.txtUsernameAdd = new System.Windows.Forms.TextBox();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactPhone = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactName = new System.Windows.Forms.TextBox();
            this.txtFamilySerialNumber = new System.Windows.Forms.TextBox();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPasswordAdd = new System.Windows.Forms.Label();
            this.lblUsernameAdd = new System.Windows.Forms.Label();
            this.lblStudentPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmergencyContactPhone = new System.Windows.Forms.Label();
            this.lblEmergencyContactName = new System.Windows.Forms.Label();
            this.lblFamilySerialNumber = new System.Windows.Forms.Label();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.groupBox1);
            this.panelCard.Controls.Add(this.btnCancel);
            this.panelCard.Controls.Add(this.lblFirstName);
            this.panelCard.Controls.Add(this.txtFirstName);
            this.panelCard.Controls.Add(this.btnSave);
            this.panelCard.Controls.Add(this.txtPasswordAdd);
            this.panelCard.Controls.Add(this.txtUsernameAdd);
            this.panelCard.Controls.Add(this.txtStudentPhoneNumber);
            this.panelCard.Controls.Add(this.txtEmergencyContactPhone);
            this.panelCard.Controls.Add(this.txtEmergencyContactName);
            this.panelCard.Controls.Add(this.txtFamilySerialNumber);
            this.panelCard.Controls.Add(this.txtNationalID);
            this.panelCard.Controls.Add(this.txtLastName);
            this.panelCard.Controls.Add(this.lblPasswordAdd);
            this.panelCard.Controls.Add(this.lblUsernameAdd);
            this.panelCard.Controls.Add(this.lblStudentPhoneNumber);
            this.panelCard.Controls.Add(this.lblEmergencyContactPhone);
            this.panelCard.Controls.Add(this.lblEmergencyContactName);
            this.panelCard.Controls.Add(this.lblFamilySerialNumber);
            this.panelCard.Controls.Add(this.lblNationalID);
            this.panelCard.Controls.Add(this.lblLastName);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Location = new System.Drawing.Point(36, 49);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(20);
            this.panelCard.Size = new System.Drawing.Size(1030, 560);
            this.panelCard.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(547, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender:";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdbMale.ForeColor = System.Drawing.Color.Black;
            this.rdbMale.Location = new System.Drawing.Point(19, 47);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(84, 32);
            this.rdbMale.TabIndex = 7;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdbFemale.ForeColor = System.Drawing.Color.Black;
            this.rdbFemale.Location = new System.Drawing.Point(119, 47);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(104, 32);
            this.rdbFemale.TabIndex = 8;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(672, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 48);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(96, 86);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 28);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(97, 114);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(310, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(890, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtPasswordAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPasswordAdd.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAdd.Location = new System.Drawing.Point(547, 275);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.PasswordChar = '*';
            this.txtPasswordAdd.Size = new System.Drawing.Size(310, 34);
            this.txtPasswordAdd.TabIndex = 19;
            // 
            // txtUsernameAdd
            // 
            this.txtUsernameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtUsernameAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsernameAdd.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameAdd.Location = new System.Drawing.Point(547, 195);
            this.txtUsernameAdd.Name = "txtUsernameAdd";
            this.txtUsernameAdd.Size = new System.Drawing.Size(310, 34);
            this.txtUsernameAdd.TabIndex = 21;
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtStudentPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(547, 114);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(310, 34);
            this.txtStudentPhoneNumber.TabIndex = 0;
            // 
            // txtEmergencyContactPhone
            // 
            this.txtEmergencyContactPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmergencyContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyContactPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmergencyContactPhone.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyContactPhone.Location = new System.Drawing.Point(91, 497);
            this.txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
            this.txtEmergencyContactPhone.Size = new System.Drawing.Size(310, 34);
            this.txtEmergencyContactPhone.TabIndex = 2;
            // 
            // txtEmergencyContactName
            // 
            this.txtEmergencyContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmergencyContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyContactName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmergencyContactName.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyContactName.Location = new System.Drawing.Point(91, 425);
            this.txtEmergencyContactName.Name = "txtEmergencyContactName";
            this.txtEmergencyContactName.Size = new System.Drawing.Size(310, 34);
            this.txtEmergencyContactName.TabIndex = 3;
            // 
            // txtFamilySerialNumber
            // 
            this.txtFamilySerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFamilySerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFamilySerialNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFamilySerialNumber.ForeColor = System.Drawing.Color.Black;
            this.txtFamilySerialNumber.Location = new System.Drawing.Point(91, 353);
            this.txtFamilySerialNumber.Name = "txtFamilySerialNumber";
            this.txtFamilySerialNumber.Size = new System.Drawing.Size(310, 34);
            this.txtFamilySerialNumber.TabIndex = 4;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNationalID.ForeColor = System.Drawing.Color.Black;
            this.txtNationalID.Location = new System.Drawing.Point(91, 275);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(310, 34);
            this.txtNationalID.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(97, 195);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(310, 34);
            this.txtLastName.TabIndex = 6;
            // 
            // lblPasswordAdd
            // 
            this.lblPasswordAdd.AutoSize = true;
            this.lblPasswordAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPasswordAdd.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordAdd.Location = new System.Drawing.Point(552, 247);
            this.lblPasswordAdd.Name = "lblPasswordAdd";
            this.lblPasswordAdd.Size = new System.Drawing.Size(106, 28);
            this.lblPasswordAdd.TabIndex = 20;
            this.lblPasswordAdd.Text = "Password:";
            // 
            // lblUsernameAdd
            // 
            this.lblUsernameAdd.AutoSize = true;
            this.lblUsernameAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsernameAdd.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameAdd.Location = new System.Drawing.Point(552, 167);
            this.lblUsernameAdd.Name = "lblUsernameAdd";
            this.lblUsernameAdd.Size = new System.Drawing.Size(111, 28);
            this.lblUsernameAdd.TabIndex = 18;
            this.lblUsernameAdd.Text = "Username:";
            // 
            // lblStudentPhoneNumber
            // 
            this.lblStudentPhoneNumber.AutoSize = true;
            this.lblStudentPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblStudentPhoneNumber.Location = new System.Drawing.Point(552, 86);
            this.lblStudentPhoneNumber.Name = "lblStudentPhoneNumber";
            this.lblStudentPhoneNumber.Size = new System.Drawing.Size(240, 28);
            this.lblStudentPhoneNumber.TabIndex = 17;
            this.lblStudentPhoneNumber.Text = "Student Phone Number:";
            // 
            // lblEmergencyContactPhone
            // 
            this.lblEmergencyContactPhone.AutoSize = true;
            this.lblEmergencyContactPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyContactPhone.ForeColor = System.Drawing.Color.Black;
            this.lblEmergencyContactPhone.Location = new System.Drawing.Point(96, 469);
            this.lblEmergencyContactPhone.Name = "lblEmergencyContactPhone";
            this.lblEmergencyContactPhone.Size = new System.Drawing.Size(265, 28);
            this.lblEmergencyContactPhone.TabIndex = 16;
            this.lblEmergencyContactPhone.Text = "Emergency Contact Phone:";
            // 
            // lblEmergencyContactName
            // 
            this.lblEmergencyContactName.AutoSize = true;
            this.lblEmergencyContactName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyContactName.ForeColor = System.Drawing.Color.Black;
            this.lblEmergencyContactName.Location = new System.Drawing.Point(96, 397);
            this.lblEmergencyContactName.Name = "lblEmergencyContactName";
            this.lblEmergencyContactName.Size = new System.Drawing.Size(262, 28);
            this.lblEmergencyContactName.TabIndex = 15;
            this.lblEmergencyContactName.Text = "Emergency Contact Name:";
            // 
            // lblFamilySerialNumber
            // 
            this.lblFamilySerialNumber.AutoSize = true;
            this.lblFamilySerialNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFamilySerialNumber.ForeColor = System.Drawing.Color.Black;
            this.lblFamilySerialNumber.Location = new System.Drawing.Point(96, 325);
            this.lblFamilySerialNumber.Name = "lblFamilySerialNumber";
            this.lblFamilySerialNumber.Size = new System.Drawing.Size(221, 28);
            this.lblFamilySerialNumber.TabIndex = 14;
            this.lblFamilySerialNumber.Text = "Family Serial Number:";
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNationalID.ForeColor = System.Drawing.Color.Black;
            this.lblNationalID.Location = new System.Drawing.Point(96, 247);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(126, 28);
            this.lblNationalID.TabIndex = 13;
            this.lblNationalID.Text = "National ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(96, 167);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 28);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(170, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 43);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Add Student";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::LGSApp.Properties.Resources.orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 650);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.Label lblFamilySerialNumber;
        private System.Windows.Forms.Label lblEmergencyContactName;
        private System.Windows.Forms.Label lblEmergencyContactPhone;
        private System.Windows.Forms.Label lblStudentPhoneNumber;
        private System.Windows.Forms.Label lblUsernameAdd;
        private System.Windows.Forms.Label lblPasswordAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtFamilySerialNumber;
        private System.Windows.Forms.TextBox txtEmergencyContactName;
        private System.Windows.Forms.TextBox txtEmergencyContactPhone;
        private System.Windows.Forms.TextBox txtStudentPhoneNumber;
        private System.Windows.Forms.TextBox txtUsernameAdd;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}