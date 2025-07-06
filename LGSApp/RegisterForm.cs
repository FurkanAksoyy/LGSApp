using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace LGSApp
{
    public partial class RegisterForm : Form
    {
        private Point originalLblUsernameRegLocation;
        private Point originalTxtUsernameRegLocation;
        private Point originalLblPasswordRegLocation;
        private Point originalTxtPasswordRegLocation;
        private Point originalLblConfirmPasswordRegLocation;
        private Point originalTxtConfirmPasswordRegLocation;
        private Point originalGrpRoleRegLocation;
        private Point originalBtnRegisterLocation;
        private Point originalButton1Location;

        public RegisterForm()
        {
            InitializeComponent();
            HideAllDetailControls();
            rdbAdminReg.CheckedChanged += Role_CheckedChanged;
            rdbStudentReg.CheckedChanged += Role_CheckedChanged;

            originalLblUsernameRegLocation = lblUsernameReg.Location;
            originalTxtUsernameRegLocation = txtUsernameReg.Location;
            originalLblPasswordRegLocation = lblPasswordReg.Location;
            originalTxtPasswordRegLocation = txtPasswordReg.Location;
            originalLblConfirmPasswordRegLocation = lblConfirmPasswordReg.Location;
            originalTxtConfirmPasswordRegLocation = txtConfirmPasswordReg.Location;
            originalGrpRoleRegLocation = grpRoleReg.Location;
            originalBtnRegisterLocation = btnRegister.Location;
            originalButton1Location = button1.Location;

            Role_CheckedChanged(null, null);
            this.CenterToScreen();
        }

        private void HideAllDetailControls()
        {
            lblUsernameReg.Visible = false;
            txtUsernameReg.Visible = false;
            lblPasswordReg.Visible = false;
            txtPasswordReg.Visible = false;
            lblConfirmPasswordReg.Visible = false;
            txtConfirmPasswordReg.Visible = false;
            grpStudentDetails.Visible = false;
            grpStudentDetails.Enabled = false;
            btnRegister.Visible = false;
            button1.Visible = false;
        }

        private void ShowCredentials()
        {
            lblUsernameReg.Visible = true;
            txtUsernameReg.Visible = true;
            lblPasswordReg.Visible = true;
            txtPasswordReg.Visible = true;
            lblConfirmPasswordReg.Visible = true;
            txtConfirmPasswordReg.Visible = true;
        }

        private void Role_CheckedChanged(object sender, EventArgs e)
        {
            HideAllDetailControls();
            ShowCredentials();
            btnRegister.Visible = true;
            button1.Visible = true;

            int panelCenterX = panelCard.Width / 2;
            int controlWidth = txtUsernameReg.Width;
            int startX = panelCenterX - (controlWidth / 2);

            if (rdbAdminReg.Checked)
            {
                lblUsernameReg.Location = new Point(startX, originalLblUsernameRegLocation.Y);
                txtUsernameReg.Location = new Point(startX, originalTxtUsernameRegLocation.Y);
                lblPasswordReg.Location = new Point(startX, originalLblPasswordRegLocation.Y);
                txtPasswordReg.Location = new Point(startX, originalTxtPasswordRegLocation.Y);
                lblConfirmPasswordReg.Location = new Point(startX, originalLblConfirmPasswordRegLocation.Y);
                txtConfirmPasswordReg.Location = new Point(startX, originalTxtConfirmPasswordRegLocation.Y);
                grpRoleReg.Location = new Point(startX, originalGrpRoleRegLocation.Y);
                btnRegister.Location = new Point(startX, originalBtnRegisterLocation.Y);
                button1.Location = new Point(startX, originalButton1Location.Y);

                grpStudentDetails.Visible = false;
                grpStudentDetails.Enabled = false;
            }
            else
            {
                lblUsernameReg.Location = originalLblUsernameRegLocation;
                txtUsernameReg.Location = originalTxtUsernameRegLocation;
                lblPasswordReg.Location = originalLblPasswordRegLocation;
                txtPasswordReg.Location = originalTxtPasswordRegLocation;
                lblConfirmPasswordReg.Location = originalLblConfirmPasswordRegLocation;
                txtConfirmPasswordReg.Location = originalTxtConfirmPasswordRegLocation;
                grpRoleReg.Location = originalGrpRoleRegLocation;
                btnRegister.Location = originalBtnRegisterLocation;
                button1.Location = originalButton1Location;

                grpStudentDetails.Visible = true;
                grpStudentDetails.Enabled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string role = rdbAdminReg.Checked ? "Admin" : "Student";
            string username = txtUsernameReg.Text.Trim();
            string password = txtPasswordReg.Text.Trim();
            string confirm = txtConfirmPasswordReg.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please fill in Username and Password fields.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (role == "Student")
            {
                bool genderSelected = rdbMaleReg.Checked || rdbFemaleReg.Checked;
                if (string.IsNullOrEmpty(txtFirstNameReg.Text.Trim()) ||
                    string.IsNullOrEmpty(txtLastNameReg.Text.Trim()) ||
                    string.IsNullOrEmpty(txtNationalIDReg.Text.Trim()) ||
                    string.IsNullOrEmpty(txtFamilySNReg.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmergencyNameReg.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmergencyPhoneReg.Text.Trim()) ||
                    string.IsNullOrEmpty(txtStudentPhoneReg.Text.Trim()) ||
                    !genderSelected)
                {
                    MessageBox.Show("Please fill all student detail fields.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sqlUser = @"
                                INSERT INTO Users (Username, PasswordHash, Role)
                                VALUES (@usr, @pwd, @role);
                                SELECT SCOPE_IDENTITY();";
                            int newUserId;
                            using (var cmd = new SqlCommand(sqlUser, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@usr", username);
                                cmd.Parameters.AddWithValue("@pwd", password);
                                cmd.Parameters.AddWithValue("@role", role);
                                newUserId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            if (role == "Student")
                            {
                                string gender = rdbMaleReg.Checked ? "Male" : "Female";
                                string sqlStud = @"
                                    INSERT INTO Students 
                                      (Name, UserID, NationalID, FamilySerialNumber,
                                       EmergencyContactName, EmergencyContactPhone,
                                       StudentPhoneNumber, Gender)
                                    VALUES
                                      (@name, @uid, @nid, @fsn,
                                       @ecn, @ecp, @spn, @gdr);";
                                using (var cmd2 = new SqlCommand(sqlStud, conn, tran))
                                {
                                    cmd2.Parameters.AddWithValue("@name", txtFirstNameReg.Text.Trim() + " " + txtLastNameReg.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@uid", newUserId);
                                    cmd2.Parameters.AddWithValue("@nid", txtNationalIDReg.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@fsn", txtFamilySNReg.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@ecn", txtEmergencyNameReg.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@ecp", txtEmergencyPhoneReg.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@spn", txtStudentPhoneReg.Text.Trim());
                                    cmd2.Parameters.AddWithValue("@gdr", gender);
                                    cmd2.ExecuteNonQuery();
                                }
                            }

                            tran.Commit();
                            MessageBox.Show("Registration successful!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (SqlException sqlEx)
                        {
                            tran.Rollback();
                            MessageBox.Show(
                                $"SQL Error #{sqlEx.Number}: {sqlEx.Message}",
                                "Registration Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        catch (Exception exTrans)
                        {
                            tran.Rollback();
                            MessageBox.Show(
                                "Registration failed:\n" + exTrans.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exConn)
            {
                MessageBox.Show(
                    "Connection error:\n" + exConn.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();

            loginForm.FormClosed += (s, args) =>
            {
                Application.Exit();
            };

            loginForm.Show();
            this.Hide();
        }

        private void grpStudentDetails_Enter(object sender, EventArgs e)
        {
            // Optional: group box content handling
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}