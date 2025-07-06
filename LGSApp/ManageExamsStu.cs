using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace LGSApp
{
    public partial class ManageExamsStu : Form
    {
        private readonly string connStr;
        private readonly int _studentId;
        private readonly string _studentFirstName; // Changed to clarify this is the first name
        private Color _mainColor;
        private Color _lightColor;
        private Color _darkColor;
        private Color _darkerColor;

        public ManageExamsStu(int studentId, string studentFirstName)
        {
            InitializeComponent();
            connStr = ConfigurationManager
                .ConnectionStrings["LGSConnection"]
                .ConnectionString;
            _studentId = studentId;
            _studentFirstName = studentFirstName;

            this.Load += ManageExamsStu_Load;
            btnAddExam.Click += BtnAddExam_Click;
            btnDeleteExam.Click += BtnDeleteExam_Click;
            dgvExams.SelectionChanged += DgvExams_SelectionChanged;

            this.CenterToScreen();
        }

        private void ManageExamsStu_Load(object sender, EventArgs e)
        {
            string gender = GetStudentGender();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = gender == "Female"
                ? System.IO.Path.Combine(basePath, "Resources", "pink.jpeg")
                : System.IO.Path.Combine(basePath, "Resources", "blue.jpeg");

            bool imageExists = System.IO.File.Exists(imagePath);

            if (gender == "Female")
            {
                _mainColor = Color.FromArgb(255, 192, 203);
                _lightColor = Color.FromArgb(255, 220, 225);
                _darkColor = Color.FromArgb(230, 170, 180);
                _darkerColor = Color.FromArgb(200, 140, 150);
            }
            else
            {
                _mainColor = Color.FromArgb(135, 206, 250);
                _lightColor = Color.FromArgb(173, 216, 230);
                _darkColor = Color.FromArgb(100, 180, 220);
                _darkerColor = Color.FromArgb(70, 150, 190);
            }

            // Set background: image if exists, else fallback to light color
            if (imageExists)
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.BackColor = _lightColor;
            }

            // Style controls
            panelCard.BackColor = Color.White;
            panelCard.BackgroundImage = null; // Avoid transparency issues
            panelCard.BackgroundImageLayout = ImageLayout.None;

            btnAddExam.BackColor = _darkColor;
            btnAddExam.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnAddExam.ForeColor = Color.White;

            lblTitle.ForeColor = _darkColor;

            LoadExams();
        }

        private string GetStudentGender()
        {
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "SELECT Gender FROM Students WHERE SUBSTRING(Name, 1, CHARINDEX(' ', Name + ' ') - 1) = @firstName", conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", _studentFirstName);
                        var result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "Male";
                    }
                }
            }
            catch
            {
                return "Male";
            }
        }

        private void LoadExams()
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter(
                "SELECT ExamID, Date, Title FROM Exams ORDER BY Date DESC",
                new SqlConnection(connStr)))
            {
                da.Fill(dt);
            }
            dgvExams.DataSource = dt;
        }

        private void BtnAddExam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamTitle.Text))
            {
                MessageBox.Show("Please enter a title.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand(
                "INSERT INTO Exams (Date, Title, CreatedBy) VALUES (@dt, @title, NULL)",
                conn))
            {
                cmd.Parameters.AddWithValue("@dt", dtpExamDate.Value.Date);
                cmd.Parameters.AddWithValue("@title", txtExamTitle.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadExams();
            txtExamTitle.Clear();
        }

        private void BtnDeleteExam_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvExams.CurrentRow.Cells["ExamID"].Value);
            var res = MessageBox.Show("Are you sure you want to delete this exam?",
                                      "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            using (var conn = new SqlConnection(connStr))
            using (var cmd = new SqlCommand("DELETE FROM Exams WHERE ExamID = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadExams();
        }

        private void DgvExams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null) return;

            dtpExamDate.Value = Convert.ToDateTime(dgvExams.CurrentRow.Cells["Date"].Value);
            txtExamTitle.Text = dgvExams.CurrentRow.Cells["Title"].Value.ToString();
        }
    }
}