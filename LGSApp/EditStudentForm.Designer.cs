namespace LGSApp
{
    partial class EditStudentForm
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactPhone = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactName = new System.Windows.Forms.TextBox();
            this.txtFamilySerialNumber = new System.Windows.Forms.TextBox();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblStudentPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmergencyContactPhone = new System.Windows.Forms.Label();
            this.lblEmergencyContactName = new System.Windows.Forms.Label();
            this.lblFamilySerialNumber = new System.Windows.Forms.Label();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.btnCancel);
            this.panelCard.Controls.Add(this.btnSave);
            this.panelCard.Controls.Add(this.grpGender);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.txtStudentPhoneNumber);
            this.panelCard.Controls.Add(this.txtEmergencyContactPhone);
            this.panelCard.Controls.Add(this.txtEmergencyContactName);
            this.panelCard.Controls.Add(this.txtFamilySerialNumber);
            this.panelCard.Controls.Add(this.txtNationalID);
            this.panelCard.Controls.Add(this.txtLastName);
            this.panelCard.Controls.Add(this.txtFirstName);
            this.panelCard.Controls.Add(this.lblPassword);
            this.panelCard.Controls.Add(this.lblUsername);
            this.panelCard.Controls.Add(this.lblStudentPhoneNumber);
            this.panelCard.Controls.Add(this.lblEmergencyContactPhone);
            this.panelCard.Controls.Add(this.lblEmergencyContactName);
            this.panelCard.Controls.Add(this.lblFamilySerialNumber);
            this.panelCard.Controls.Add(this.lblNationalID);
            this.panelCard.Controls.Add(this.lblLastName);
            this.panelCard.Controls.Add(this.lblFirstName);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.panelCard.Location = new System.Drawing.Point(36, 46);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(20);
            this.panelCard.Size = new System.Drawing.Size(1030, 560);
            this.panelCard.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(677, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 48);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(890, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbFemale);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpGender.ForeColor = System.Drawing.Color.Black;
            this.grpGender.Location = new System.Drawing.Point(599, 304);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(239, 113);
            this.grpGender.TabIndex = 14;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender:";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdbFemale.ForeColor = System.Drawing.Color.Black;
            this.rdbFemale.Location = new System.Drawing.Point(120, 47);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(104, 32);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rdbMale.ForeColor = System.Drawing.Color.Black;
            this.rdbMale.Location = new System.Drawing.Point(10, 47);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(84, 32);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(599, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(326, 34);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(599, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(326, 34);
            this.txtUsername.TabIndex = 12;
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtStudentPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(599, 114);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(326, 34);
            this.txtStudentPhoneNumber.TabIndex = 11;
            // 
            // txtEmergencyContactPhone
            // 
            this.txtEmergencyContactPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmergencyContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyContactPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmergencyContactPhone.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyContactPhone.Location = new System.Drawing.Point(109, 497);
            this.txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
            this.txtEmergencyContactPhone.Size = new System.Drawing.Size(326, 34);
            this.txtEmergencyContactPhone.TabIndex = 10;
            // 
            // txtEmergencyContactName
            // 
            this.txtEmergencyContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmergencyContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyContactName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmergencyContactName.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencyContactName.Location = new System.Drawing.Point(109, 417);
            this.txtEmergencyContactName.Name = "txtEmergencyContactName";
            this.txtEmergencyContactName.Size = new System.Drawing.Size(326, 34);
            this.txtEmergencyContactName.TabIndex = 9;
            // 
            // txtFamilySerialNumber
            // 
            this.txtFamilySerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFamilySerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFamilySerialNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFamilySerialNumber.ForeColor = System.Drawing.Color.Black;
            this.txtFamilySerialNumber.Location = new System.Drawing.Point(110, 342);
            this.txtFamilySerialNumber.Name = "txtFamilySerialNumber";
            this.txtFamilySerialNumber.Size = new System.Drawing.Size(326, 34);
            this.txtFamilySerialNumber.TabIndex = 8;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNationalID.ForeColor = System.Drawing.Color.Black;
            this.txtNationalID.Location = new System.Drawing.Point(110, 261);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(326, 34);
            this.txtNationalID.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(109, 180);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(326, 34);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(109, 114);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(326, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(604, 232);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 28);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(604, 152);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 28);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username:";
            // 
            // lblStudentPhoneNumber
            // 
            this.lblStudentPhoneNumber.AutoSize = true;
            this.lblStudentPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblStudentPhoneNumber.Location = new System.Drawing.Point(604, 83);
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
            this.lblEmergencyContactPhone.Location = new System.Drawing.Point(111, 469);
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
            this.lblEmergencyContactName.Location = new System.Drawing.Point(111, 389);
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
            this.lblFamilySerialNumber.Location = new System.Drawing.Point(111, 314);
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
            this.lblNationalID.Location = new System.Drawing.Point(111, 232);
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
            this.lblLastName.Location = new System.Drawing.Point(111, 152);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 28);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(111, 86);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 28);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
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
            this.lblTitle.Text = "Edit Student";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::LGSApp.Properties.Resources.orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 650);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditStudentForm";
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtFamilySerialNumber;
        private System.Windows.Forms.TextBox txtEmergencyContactName;
        private System.Windows.Forms.TextBox txtEmergencyContactPhone;
        private System.Windows.Forms.TextBox txtStudentPhoneNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}