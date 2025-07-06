namespace LGSApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panelCard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.grpGenderReg = new System.Windows.Forms.GroupBox();
            this.rdbFemaleReg = new System.Windows.Forms.RadioButton();
            this.rdbMaleReg = new System.Windows.Forms.RadioButton();
            this.txtStudentPhoneReg = new System.Windows.Forms.TextBox();
            this.lblStudentPhoneReg = new System.Windows.Forms.Label();
            this.txtEmergencyPhoneReg = new System.Windows.Forms.TextBox();
            this.lblEmergencyPhoneReg = new System.Windows.Forms.Label();
            this.txtEmergencyNameReg = new System.Windows.Forms.TextBox();
            this.lblEmergencyNameReg = new System.Windows.Forms.Label();
            this.txtFamilySNReg = new System.Windows.Forms.TextBox();
            this.lblFamilySNReg = new System.Windows.Forms.Label();
            this.txtNationalIDReg = new System.Windows.Forms.TextBox();
            this.lblNationalIDReg = new System.Windows.Forms.Label();
            this.txtLastNameReg = new System.Windows.Forms.TextBox();
            this.lblLastNameReg = new System.Windows.Forms.Label();
            this.txtFirstNameReg = new System.Windows.Forms.TextBox();
            this.lblFirstNameReg = new System.Windows.Forms.Label();
            this.grpRoleReg = new System.Windows.Forms.GroupBox();
            this.rdbStudentReg = new System.Windows.Forms.RadioButton();
            this.rdbAdminReg = new System.Windows.Forms.RadioButton();
            this.txtConfirmPasswordReg = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordReg = new System.Windows.Forms.Label();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.lblPasswordReg = new System.Windows.Forms.Label();
            this.txtUsernameReg = new System.Windows.Forms.TextBox();
            this.lblUsernameReg = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            this.grpGenderReg.SuspendLayout();
            this.grpRoleReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.button1);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Controls.Add(this.btnRegister);
            this.panelCard.Controls.Add(this.grpStudentDetails);
            this.panelCard.Controls.Add(this.grpRoleReg);
            this.panelCard.Controls.Add(this.txtConfirmPasswordReg);
            this.panelCard.Controls.Add(this.lblConfirmPasswordReg);
            this.panelCard.Controls.Add(this.txtPasswordReg);
            this.panelCard.Controls.Add(this.lblPasswordReg);
            this.panelCard.Controls.Add(this.txtUsernameReg);
            this.panelCard.Controls.Add(this.lblUsernameReg);
            this.panelCard.Location = new System.Drawing.Point(71, 51);
            this.panelCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.panelCard.Size = new System.Drawing.Size(920, 456);
            this.panelCard.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Already have an account? Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(73, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(756, 34);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "LGS Tracking Application - Register";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(33, 328);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(258, 43);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.grpGenderReg);
            this.grpStudentDetails.Controls.Add(this.txtStudentPhoneReg);
            this.grpStudentDetails.Controls.Add(this.lblStudentPhoneReg);
            this.grpStudentDetails.Controls.Add(this.txtEmergencyPhoneReg);
            this.grpStudentDetails.Controls.Add(this.lblEmergencyPhoneReg);
            this.grpStudentDetails.Controls.Add(this.txtEmergencyNameReg);
            this.grpStudentDetails.Controls.Add(this.lblEmergencyNameReg);
            this.grpStudentDetails.Controls.Add(this.txtFamilySNReg);
            this.grpStudentDetails.Controls.Add(this.lblFamilySNReg);
            this.grpStudentDetails.Controls.Add(this.txtNationalIDReg);
            this.grpStudentDetails.Controls.Add(this.lblNationalIDReg);
            this.grpStudentDetails.Controls.Add(this.txtLastNameReg);
            this.grpStudentDetails.Controls.Add(this.lblLastNameReg);
            this.grpStudentDetails.Controls.Add(this.txtFirstNameReg);
            this.grpStudentDetails.Controls.Add(this.lblFirstNameReg);
            this.grpStudentDetails.Enabled = false;
            this.grpStudentDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentDetails.Location = new System.Drawing.Point(318, 61);
            this.grpStudentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudentDetails.Size = new System.Drawing.Size(582, 383);
            this.grpStudentDetails.TabIndex = 7;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            this.grpStudentDetails.Enter += new System.EventHandler(this.grpStudentDetails_Enter);
            // 
            // grpGenderReg
            // 
            this.grpGenderReg.Controls.Add(this.rdbFemaleReg);
            this.grpGenderReg.Controls.Add(this.rdbMaleReg);
            this.grpGenderReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenderReg.Location = new System.Drawing.Point(18, 282);
            this.grpGenderReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGenderReg.Name = "grpGenderReg";
            this.grpGenderReg.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGenderReg.Size = new System.Drawing.Size(320, 66);
            this.grpGenderReg.TabIndex = 14;
            this.grpGenderReg.TabStop = false;
            this.grpGenderReg.Text = "Gender";
            // 
            // rdbFemaleReg
            // 
            this.rdbFemaleReg.AutoSize = true;
            this.rdbFemaleReg.Checked = true;
            this.rdbFemaleReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemaleReg.Location = new System.Drawing.Point(180, 26);
            this.rdbFemaleReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemaleReg.Name = "rdbFemaleReg";
            this.rdbFemaleReg.Size = new System.Drawing.Size(85, 27);
            this.rdbFemaleReg.TabIndex = 1;
            this.rdbFemaleReg.TabStop = true;
            this.rdbFemaleReg.Text = "Female";
            this.rdbFemaleReg.UseVisualStyleBackColor = true;
            // 
            // rdbMaleReg
            // 
            this.rdbMaleReg.AutoSize = true;
            this.rdbMaleReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaleReg.Location = new System.Drawing.Point(41, 26);
            this.rdbMaleReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMaleReg.Name = "rdbMaleReg";
            this.rdbMaleReg.Size = new System.Drawing.Size(68, 27);
            this.rdbMaleReg.TabIndex = 0;
            this.rdbMaleReg.Text = "Male";
            this.rdbMaleReg.UseVisualStyleBackColor = true;
            // 
            // txtStudentPhoneReg
            // 
            this.txtStudentPhoneReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtStudentPhoneReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentPhoneReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPhoneReg.Location = new System.Drawing.Point(18, 250);
            this.txtStudentPhoneReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentPhoneReg.Name = "txtStudentPhoneReg";
            this.txtStudentPhoneReg.Size = new System.Drawing.Size(233, 30);
            this.txtStudentPhoneReg.TabIndex = 13;
            // 
            // lblStudentPhoneReg
            // 
            this.lblStudentPhoneReg.AutoSize = true;
            this.lblStudentPhoneReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentPhoneReg.ForeColor = System.Drawing.Color.Black;
            this.lblStudentPhoneReg.Location = new System.Drawing.Point(18, 226);
            this.lblStudentPhoneReg.Name = "lblStudentPhoneReg";
            this.lblStudentPhoneReg.Size = new System.Drawing.Size(205, 23);
            this.lblStudentPhoneReg.TabIndex = 12;
            this.lblStudentPhoneReg.Text = "Student Phone Number:";
            // 
            // txtEmergencyPhoneReg
            // 
            this.txtEmergencyPhoneReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmergencyPhoneReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyPhoneReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyPhoneReg.Location = new System.Drawing.Point(293, 186);
            this.txtEmergencyPhoneReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmergencyPhoneReg.Name = "txtEmergencyPhoneReg";
            this.txtEmergencyPhoneReg.Size = new System.Drawing.Size(233, 30);
            this.txtEmergencyPhoneReg.TabIndex = 11;
            // 
            // lblEmergencyPhoneReg
            // 
            this.lblEmergencyPhoneReg.AutoSize = true;
            this.lblEmergencyPhoneReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyPhoneReg.ForeColor = System.Drawing.Color.Black;
            this.lblEmergencyPhoneReg.Location = new System.Drawing.Point(293, 162);
            this.lblEmergencyPhoneReg.Name = "lblEmergencyPhoneReg";
            this.lblEmergencyPhoneReg.Size = new System.Drawing.Size(224, 23);
            this.lblEmergencyPhoneReg.TabIndex = 10;
            this.lblEmergencyPhoneReg.Text = "Emergency Contact Phone:";
            // 
            // txtEmergencyNameReg
            // 
            this.txtEmergencyNameReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEmergencyNameReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmergencyNameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyNameReg.Location = new System.Drawing.Point(18, 186);
            this.txtEmergencyNameReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmergencyNameReg.Name = "txtEmergencyNameReg";
            this.txtEmergencyNameReg.Size = new System.Drawing.Size(233, 30);
            this.txtEmergencyNameReg.TabIndex = 9;
            // 
            // lblEmergencyNameReg
            // 
            this.lblEmergencyNameReg.AutoSize = true;
            this.lblEmergencyNameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyNameReg.ForeColor = System.Drawing.Color.Black;
            this.lblEmergencyNameReg.Location = new System.Drawing.Point(18, 162);
            this.lblEmergencyNameReg.Name = "lblEmergencyNameReg";
            this.lblEmergencyNameReg.Size = new System.Drawing.Size(222, 23);
            this.lblEmergencyNameReg.TabIndex = 8;
            this.lblEmergencyNameReg.Text = "Emergency Contact Name:";
            // 
            // txtFamilySNReg
            // 
            this.txtFamilySNReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFamilySNReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFamilySNReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilySNReg.Location = new System.Drawing.Point(298, 116);
            this.txtFamilySNReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFamilySNReg.Name = "txtFamilySNReg";
            this.txtFamilySNReg.Size = new System.Drawing.Size(233, 30);
            this.txtFamilySNReg.TabIndex = 7;
            // 
            // lblFamilySNReg
            // 
            this.lblFamilySNReg.AutoSize = true;
            this.lblFamilySNReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilySNReg.ForeColor = System.Drawing.Color.Black;
            this.lblFamilySNReg.Location = new System.Drawing.Point(298, 92);
            this.lblFamilySNReg.Name = "lblFamilySNReg";
            this.lblFamilySNReg.Size = new System.Drawing.Size(150, 23);
            this.lblFamilySNReg.TabIndex = 6;
            this.lblFamilySNReg.Text = "Family Serial No.:";
            // 
            // txtNationalIDReg
            // 
            this.txtNationalIDReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNationalIDReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalIDReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalIDReg.Location = new System.Drawing.Point(18, 116);
            this.txtNationalIDReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationalIDReg.Name = "txtNationalIDReg";
            this.txtNationalIDReg.Size = new System.Drawing.Size(233, 30);
            this.txtNationalIDReg.TabIndex = 5;
            // 
            // lblNationalIDReg
            // 
            this.lblNationalIDReg.AutoSize = true;
            this.lblNationalIDReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalIDReg.ForeColor = System.Drawing.Color.Black;
            this.lblNationalIDReg.Location = new System.Drawing.Point(18, 92);
            this.lblNationalIDReg.Name = "lblNationalIDReg";
            this.lblNationalIDReg.Size = new System.Drawing.Size(106, 23);
            this.lblNationalIDReg.TabIndex = 4;
            this.lblNationalIDReg.Text = "National ID:";
            // 
            // txtLastNameReg
            // 
            this.txtLastNameReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtLastNameReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastNameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameReg.Location = new System.Drawing.Point(302, 48);
            this.txtLastNameReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastNameReg.Name = "txtLastNameReg";
            this.txtLastNameReg.Size = new System.Drawing.Size(233, 30);
            this.txtLastNameReg.TabIndex = 3;
            // 
            // lblLastNameReg
            // 
            this.lblLastNameReg.AutoSize = true;
            this.lblLastNameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameReg.ForeColor = System.Drawing.Color.Black;
            this.lblLastNameReg.Location = new System.Drawing.Point(302, 24);
            this.lblLastNameReg.Name = "lblLastNameReg";
            this.lblLastNameReg.Size = new System.Drawing.Size(99, 23);
            this.lblLastNameReg.TabIndex = 2;
            this.lblLastNameReg.Text = "Last Name:";
            // 
            // txtFirstNameReg
            // 
            this.txtFirstNameReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFirstNameReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstNameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameReg.Location = new System.Drawing.Point(18, 48);
            this.txtFirstNameReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstNameReg.Name = "txtFirstNameReg";
            this.txtFirstNameReg.Size = new System.Drawing.Size(233, 30);
            this.txtFirstNameReg.TabIndex = 1;
            // 
            // lblFirstNameReg
            // 
            this.lblFirstNameReg.AutoSize = true;
            this.lblFirstNameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameReg.ForeColor = System.Drawing.Color.Black;
            this.lblFirstNameReg.Location = new System.Drawing.Point(18, 24);
            this.lblFirstNameReg.Name = "lblFirstNameReg";
            this.lblFirstNameReg.Size = new System.Drawing.Size(102, 23);
            this.lblFirstNameReg.TabIndex = 0;
            this.lblFirstNameReg.Text = "First Name:";
            // 
            // grpRoleReg
            // 
            this.grpRoleReg.Controls.Add(this.rdbStudentReg);
            this.grpRoleReg.Controls.Add(this.rdbAdminReg);
            this.grpRoleReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoleReg.Location = new System.Drawing.Point(33, 258);
            this.grpRoleReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRoleReg.Name = "grpRoleReg";
            this.grpRoleReg.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRoleReg.Size = new System.Drawing.Size(258, 64);
            this.grpRoleReg.TabIndex = 6;
            this.grpRoleReg.TabStop = false;
            this.grpRoleReg.Text = "Register As:";
            // 
            // rdbStudentReg
            // 
            this.rdbStudentReg.AutoSize = true;
            this.rdbStudentReg.Checked = true;
            this.rdbStudentReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStudentReg.Location = new System.Drawing.Point(148, 26);
            this.rdbStudentReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbStudentReg.Name = "rdbStudentReg";
            this.rdbStudentReg.Size = new System.Drawing.Size(90, 27);
            this.rdbStudentReg.TabIndex = 1;
            this.rdbStudentReg.TabStop = true;
            this.rdbStudentReg.Text = "Student";
            this.rdbStudentReg.UseVisualStyleBackColor = true;
            // 
            // rdbAdminReg
            // 
            this.rdbAdminReg.AutoSize = true;
            this.rdbAdminReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdminReg.Location = new System.Drawing.Point(15, 26);
            this.rdbAdminReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAdminReg.Name = "rdbAdminReg";
            this.rdbAdminReg.Size = new System.Drawing.Size(81, 27);
            this.rdbAdminReg.TabIndex = 0;
            this.rdbAdminReg.Text = "Admin";
            this.rdbAdminReg.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPasswordReg
            // 
            this.txtConfirmPasswordReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtConfirmPasswordReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPasswordReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordReg.Location = new System.Drawing.Point(33, 224);
            this.txtConfirmPasswordReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPasswordReg.Name = "txtConfirmPasswordReg";
            this.txtConfirmPasswordReg.PasswordChar = '*';
            this.txtConfirmPasswordReg.Size = new System.Drawing.Size(258, 30);
            this.txtConfirmPasswordReg.TabIndex = 5;
            // 
            // lblConfirmPasswordReg
            // 
            this.lblConfirmPasswordReg.AutoSize = true;
            this.lblConfirmPasswordReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordReg.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmPasswordReg.Location = new System.Drawing.Point(34, 198);
            this.lblConfirmPasswordReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPasswordReg.Name = "lblConfirmPasswordReg";
            this.lblConfirmPasswordReg.Size = new System.Drawing.Size(161, 23);
            this.lblConfirmPasswordReg.TabIndex = 4;
            this.lblConfirmPasswordReg.Text = "Confirm Password:";
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtPasswordReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordReg.Location = new System.Drawing.Point(33, 166);
            this.txtPasswordReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.PasswordChar = '*';
            this.txtPasswordReg.Size = new System.Drawing.Size(258, 30);
            this.txtPasswordReg.TabIndex = 3;
            // 
            // lblPasswordReg
            // 
            this.lblPasswordReg.AutoSize = true;
            this.lblPasswordReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordReg.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordReg.Location = new System.Drawing.Point(34, 139);
            this.lblPasswordReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordReg.Name = "lblPasswordReg";
            this.lblPasswordReg.Size = new System.Drawing.Size(90, 23);
            this.lblPasswordReg.TabIndex = 2;
            this.lblPasswordReg.Text = "Password:";
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtUsernameReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameReg.Location = new System.Drawing.Point(33, 103);
            this.txtUsernameReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(258, 30);
            this.txtUsernameReg.TabIndex = 1;
            // 
            // lblUsernameReg
            // 
            this.lblUsernameReg.AutoSize = true;
            this.lblUsernameReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameReg.ForeColor = System.Drawing.Color.Black;
            this.lblUsernameReg.Location = new System.Drawing.Point(34, 77);
            this.lblUsernameReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameReg.Name = "lblUsernameReg";
            this.lblUsernameReg.Size = new System.Drawing.Size(94, 23);
            this.lblUsernameReg.TabIndex = 0;
            this.lblUsernameReg.Text = "Username:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::LGSApp.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpGenderReg.ResumeLayout(false);
            this.grpGenderReg.PerformLayout();
            this.grpRoleReg.ResumeLayout(false);
            this.grpRoleReg.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.GroupBox grpGenderReg;
        private System.Windows.Forms.RadioButton rdbFemaleReg;
        private System.Windows.Forms.RadioButton rdbMaleReg;
        private System.Windows.Forms.TextBox txtStudentPhoneReg;
        private System.Windows.Forms.Label lblStudentPhoneReg;
        private System.Windows.Forms.TextBox txtEmergencyPhoneReg;
        private System.Windows.Forms.Label lblEmergencyPhoneReg;
        private System.Windows.Forms.TextBox txtEmergencyNameReg;
        private System.Windows.Forms.Label lblEmergencyNameReg;
        private System.Windows.Forms.TextBox txtFamilySNReg;
        private System.Windows.Forms.Label lblFamilySNReg;
        private System.Windows.Forms.TextBox txtNationalIDReg;
        private System.Windows.Forms.Label lblNationalIDReg;
        private System.Windows.Forms.TextBox txtLastNameReg;
        private System.Windows.Forms.Label lblLastNameReg;
        private System.Windows.Forms.TextBox txtFirstNameReg;
        private System.Windows.Forms.Label lblFirstNameReg;
        private System.Windows.Forms.GroupBox grpRoleReg;
        private System.Windows.Forms.RadioButton rdbStudentReg;
        private System.Windows.Forms.RadioButton rdbAdminReg;
        private System.Windows.Forms.TextBox txtConfirmPasswordReg;
        private System.Windows.Forms.Label lblConfirmPasswordReg;
        private System.Windows.Forms.TextBox txtPasswordReg;
        private System.Windows.Forms.Label lblPasswordReg;
        private System.Windows.Forms.TextBox txtUsernameReg;
        private System.Windows.Forms.Label lblUsernameReg;
    }
}