using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class EditStudentForm : Form
    {
        private int _studentId;

        public EditStudentForm()
        {
            InitializeComponent();
            this.Load += EditStudentForm_Load;
        }

        public EditStudentForm(int studentId)
            : this()
        {
            _studentId = studentId;
            this.CenterToScreen();
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void LoadStudent()
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(
                @"SELECT s.Name, s.NationalID, s.FamilySerialNumber, 
                         s.EmergencyContactName, s.EmergencyContactPhone, s.StudentPhoneNumber, 
                         s.Gender, u.Username, u.PasswordHash
                  FROM Students s
                  INNER JOIN Users u ON s.UserID = u.UserID
                  WHERE s.StudentID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", _studentId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read())
                    {
                        string[] names = reader.GetString(0).Split(' ');
                        txtFirstName.Text = names.Length > 0 ? names[0] : "";
                        txtLastName.Text = names.Length > 1 ? names[1] : "";
                        txtNationalID.Text = reader.GetString(1);
                        txtFamilySerialNumber.Text = reader.GetString(2);
                        txtEmergencyContactName.Text = reader.GetString(3);
                        txtEmergencyContactPhone.Text = reader.GetString(4);
                        txtStudentPhoneNumber.Text = reader.GetString(5);
                        string gender = reader.GetString(6);
                        rdbMale.Checked = gender == "Male";
                        rdbFemale.Checked = gender == "Female";
                        txtUsername.Text = reader.GetString(7);
                        txtPassword.Text = reader.GetString(8);
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtNationalID.Text) ||
                string.IsNullOrWhiteSpace(txtFamilySerialNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmergencyContactName.Text) ||
                string.IsNullOrWhiteSpace(txtEmergencyContactPhone.Text) ||
                string.IsNullOrWhiteSpace(txtStudentPhoneNumber.Text) ||
                !(rdbMale.Checked || rdbFemale.Checked))
            {
                MessageBox.Show("Please fill in all fields and select a gender.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Update Users table
                        using (var cmdUser = new SqlCommand(
                            @"UPDATE Users SET Username = @usr, PasswordHash = @pwd
                              WHERE UserID = (SELECT UserID FROM Students WHERE StudentID = @sid)", conn, tran))
                        {
                            cmdUser.Parameters.AddWithValue("@usr", txtUsername.Text.Trim());
                            cmdUser.Parameters.AddWithValue("@pwd", txtPassword.Text); // Consider hashing
                            cmdUser.Parameters.AddWithValue("@sid", _studentId);
                            cmdUser.ExecuteNonQuery();
                        }

                        // Update Students table
                        using (var cmdStud = new SqlCommand(
                            @"UPDATE Students SET
                                  Name                   = @name,
                                  NationalID             = @nid,
                                  FamilySerialNumber     = @fsn,
                                  EmergencyContactName   = @ecn,
                                  EmergencyContactPhone  = @ecp,
                                  StudentPhoneNumber     = @spn,
                                  Gender                 = @g
                              WHERE StudentID = @id", conn, tran))
                        {
                            cmdStud.Parameters.AddWithValue("@name", txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@nid", txtNationalID.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@fsn", txtFamilySerialNumber.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@ecn", txtEmergencyContactName.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@ecp", txtEmergencyContactPhone.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@spn", txtStudentPhoneNumber.Text.Trim());
                            cmdStud.Parameters.AddWithValue("@g", rdbMale.Checked ? "Male" : "Female");
                            cmdStud.Parameters.AddWithValue("@id", _studentId);
                            cmdStud.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Student updated successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error updating student: " + ex.Message,
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