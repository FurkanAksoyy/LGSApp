using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class ManageStudentsControl : UserControl
    {
        public ManageStudentsControl()
        {
            InitializeComponent();
            this.Load += ManageStudentsControl_Load;
        }

        private void ManageStudentsControl_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["LGSConnection"]
                .ConnectionString;

            string sql = @"
                SELECT 
                  s.StudentID,
                  u.UserID,
                  u.Username,
                  u.PasswordHash,
                  s.Name,
                  s.NationalID,
                  s.FamilySerialNumber,
                  s.EmergencyContactName,
                  s.EmergencyContactPhone,
                  s.StudentPhoneNumber,
                  s.Gender
                FROM Students s
                INNER JOIN Users u 
                    ON s.UserID = u.UserID
                ORDER BY s.Name;
            ";

            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);

                dgvManageStudents.AutoGenerateColumns = true;
                dgvManageStudents.DataSource = dt;

                if (dgvManageStudents.Columns["StudentID"] != null)
                    dgvManageStudents.Columns["StudentID"].Visible = false;
                if (dgvManageStudents.Columns["UserID"] != null)
                    dgvManageStudents.Columns["UserID"].Visible = false;

                dgvManageStudents.Columns["Username"].HeaderText = "Username";
                dgvManageStudents.Columns["PasswordHash"].HeaderText = "Password";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddStudentForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                    LoadStudents();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvManageStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student first.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = Convert.ToInt32(dgvManageStudents.CurrentRow.Cells["StudentID"].Value);
            using (var editForm = new EditStudentForm(studentId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                    LoadStudents();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvManageStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to delete.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = Convert.ToInt32(dgvManageStudents.CurrentRow.Cells["StudentID"].Value);
            int userId = Convert.ToInt32(dgvManageStudents.CurrentRow.Cells["UserID"].Value);
            var result = MessageBox.Show("Are you sure you want to delete this student?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            string connStr = ConfigurationManager
                .ConnectionStrings["LGSConnection"]
                .ConnectionString;

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Delete from ExamSubjects table
                        using (var cmdExamSubjects = new SqlCommand("DELETE FROM ExamSubjects WHERE StudentID = @id", conn, transaction))
                        {
                            cmdExamSubjects.Parameters.AddWithValue("@id", studentId);
                            cmdExamSubjects.ExecuteNonQuery();
                        }

                        // Delete from Students table
                        using (var cmdStudents = new SqlCommand("DELETE FROM Students WHERE StudentID = @id", conn, transaction))
                        {
                            cmdStudents.Parameters.AddWithValue("@id", studentId);
                            cmdStudents.ExecuteNonQuery();
                        }

                        // Delete from Users table
                        using (var cmdUsers = new SqlCommand("DELETE FROM Users WHERE UserID = @userId", conn, transaction))
                        {
                            cmdUsers.Parameters.AddWithValue("@userId", userId);
                            cmdUsers.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error deleting student: {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            LoadStudents();
        }

        private void dgvManageStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}