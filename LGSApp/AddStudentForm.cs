using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // Optional: initialize form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtUsernameAdd.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordAdd.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtNationalID.Text) ||
                string.IsNullOrWhiteSpace(txtFamilySerialNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmergencyContactName.Text) ||
                string.IsNullOrWhiteSpace(txtEmergencyContactPhone.Text) ||
                string.IsNullOrWhiteSpace(txtStudentPhoneNumber.Text) ||
                !(rdbMale.Checked || rdbFemale.Checked))
            {
                MessageBox.Show("Please fill in all fields and select a gender, username, and password.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsernameAdd.Text.Trim();
            string password = txtPasswordAdd.Text; // Consider hashing in production
            const string role = "Student";

            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert into Users table
                        int newUserId;
                        string sqlUser = @"
                            INSERT INTO Users (Username, PasswordHash, Role)
                            VALUES (@usr, @pwd, @role);
                            SELECT SCOPE_IDENTITY();";
                        using (var cmdUser = new SqlCommand(sqlUser, conn, tran))
                        {
                            cmdUser.Parameters.AddWithValue("@usr", username);
                            cmdUser.Parameters.AddWithValue("@pwd", password);
                            cmdUser.Parameters.AddWithValue("@role", role);
                            newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());
                        }

                        // Insert into Students table
                        string sqlStud = @"
                            INSERT INTO Students
                              (Name, NationalID, FamilySerialNumber,
                               EmergencyContactName, EmergencyContactPhone,
                               StudentPhoneNumber, Gender, UserID)
                            VALUES
                              (@name, @nid, @fsn,
                               @ecn, @ecp, @spn, @gdr, @uid);";
                        using (var cmdStud = new SqlCommand(sqlStud, conn, tran))
                        {
                            cmdStud.Parameters.AddWithValue("@name", txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@nid", txtNationalID.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@fsn", txtFamilySerialNumber.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@ecn", txtEmergencyContactName.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@ecp", txtEmergencyContactPhone.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@spn", txtStudentPhoneNumber.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@gdr", rdbMale.Checked ? "Male" : "Female");
                            cmdStud.Parameters.AddWithValue("@uid", newUserId);
                            cmdStud.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Student added successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error saving student: " + ex.Message,
                                        "Database Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}