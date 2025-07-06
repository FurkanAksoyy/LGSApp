using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace LGSApp
{
    public partial class StudentForm : Form
    {
        private readonly int _userId;
        private readonly string _username;
        private Color _mainColor;
        private Color _lightColor;
        private Color _darkColor;
        private Color _darkerColor;

        public StudentForm(int userId, string username)
        {
            InitializeComponent();
            _userId = userId;
            _username = username;
            this.Text = $"LGS Tracking Application - Student Dashboard";
            lblTitle.Text = $"Welcome, {_username} - Student Dashboard";
            btnViewResults.Click += BtnViewResults_Click;
            btnManageExams.Click += BtnManageExams_Click;
            btnAddExam.Click += BtnAddExam_Click;
            btnChartsReports.Click += BtnChartsReports_Click;
            btnExportPdf.Click += BtnExportPdf_Click;
            btnLogout.Click += BtnLogout_Click;
            this.Load += StudentForm_Load;
            this.CenterToScreen();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            string gender = GetStudentGender();
            string basePath = Application.StartupPath + @"\Resources\";

            if (gender == "Female")
            {
                _mainColor = Color.FromArgb(255, 192, 203);
                _lightColor = Color.FromArgb(255, 220, 225);
                _darkColor = Color.FromArgb(230, 170, 180);
                _darkerColor = Color.FromArgb(200, 140, 150);
                this.BackgroundImage = Image.FromFile(basePath + "pink.jpeg");
            }
            else
            {
                _mainColor = Color.FromArgb(135, 206, 250);
                _lightColor = Color.FromArgb(135, 206, 250);
                _darkColor = Color.FromArgb(100, 180, 220);
                _darkerColor = Color.FromArgb(70, 150, 190);
                this.BackgroundImage = Image.FromFile(basePath + "blue.jpeg");
            }

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.White;

            panelMenu.BackColor = _lightColor;
            lblTitle.ForeColor = _darkColor;

            btnViewResults.BackColor = _darkColor;
            btnViewResults.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnViewResults.Visible = true;

            btnManageExams.BackColor = _darkColor;
            btnManageExams.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnManageExams.Visible = true;

            btnAddExam.BackColor = _darkColor;
            btnAddExam.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnAddExam.Visible = true;

            btnChartsReports.BackColor = _darkColor;
            btnChartsReports.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnChartsReports.Visible = true;

            btnExportPdf.BackColor = _darkColor;
            btnExportPdf.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnExportPdf.Visible = true;

            btnLogout.BackColor = Color.Black;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);

            dgvOverallResults.Visible = false;
            dgvSubjectNets.Visible = false;

            // Ensure DataGridView is parented to panelCard
            dgvOverallResults.Parent = panelCard;
            dgvOverallResults.BringToFront();

            LoadResultsSilently();
        }

        private string GetStudentGender()
        {
            string cs = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT Gender FROM Students WHERE UserID = @uid", conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", _userId);
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

        private void BtnViewResults_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ShowResults();
        }

        private void BtnManageExams_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideContentControls();
            dgvOverallResults.Visible = false;
            dgvSubjectNets.Visible = false;

            using (var manageExamsForm = new ManageExamsStu(_userId, _username))
                manageExamsForm.ShowDialog();
        }

        private void BtnAddExam_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideContentControls();
            dgvOverallResults.Visible = false;
            dgvSubjectNets.Visible = false;

            using (var addExamForm = new Form())
            {
                addExamForm.Text = "Add Exam";
                addExamForm.Size = new Size(1200, 800);
                addExamForm.StartPosition = FormStartPosition.CenterScreen;
                addExamForm.BackColor = _lightColor;

                var addExamControl = new AddExamStu(_userId, _username)
                {
                    Dock = DockStyle.Fill
                };

                addExamForm.Controls.Add(addExamControl);
                addExamForm.ShowDialog();
            }

            LoadResultsSilently();
        }

        private void BtnChartsReports_Click(object sender, EventArgs e)
        {
            var chartControl = new ChartsGraphsControl();
            chartControl.SetStudentContext(_userId, _username, _mainColor); // _userId is UserID, _username is first name
            LoadControl(chartControl);
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideContentControls();
            LoadControl(new ExportPdfControl(false, _userId, _username, GetStudentGender()));
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            HideContentControls();
            dgvOverallResults.Visible = false;
            dgvSubjectNets.Visible = false;

            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) =>
            {
                Application.Exit();
            };
            loginForm.Show();
            this.Hide();
        }

        private void LoadControl(Control control)
        {
            ResetButtonColors();
            HideContentControls();
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void HideContentControls()
        {
            panelContent.Controls.Clear();
            dgvOverallResults.Visible = false;
            dgvSubjectNets.Visible = false;
        }

        private void ResetButtonColors()
        {
            btnViewResults.BackColor = _darkColor;
            btnManageExams.BackColor = _darkColor;
            btnAddExam.BackColor = _darkColor;
            btnChartsReports.BackColor = _darkColor;
            btnExportPdf.BackColor = _darkColor;
            btnLogout.BackColor = Color.Black;
        }

        private void LoadResultsSilently()
        {
            ResetButtonColors();
            string cs = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            try
            {
                var dtOverall = new DataTable();
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (var da = new SqlDataAdapter(@"
                        SELECT 
                            e.Title AS Exam,
                            MAX(CASE WHEN es.SubjectName = 'Math' THEN es.Net END) AS MathNet,
                            MAX(CASE WHEN es.SubjectName = 'Science' THEN es.Net END) AS ScienceNet,
                            MAX(CASE WHEN es.SubjectName = 'Turkish' THEN es.Net END) AS TurkishNet,
                            MAX(CASE WHEN es.SubjectName = 'History' THEN es.Net END) AS HistoryNet,
                            MAX(CASE WHEN es.SubjectName = 'Religion' THEN es.Net END) AS ReligionNet,
                            MAX(CASE WHEN es.SubjectName = 'English' THEN es.Net END) AS EnglishNet,
                            r.Score AS TotalNet,
                            e.Date AS ExamDate
                        FROM ExamResults r
                        JOIN Exams e ON r.ExamID = e.ExamID
                        LEFT JOIN ExamSubjects es ON r.ExamID = es.ExamID AND r.StudentID = es.StudentID
                        WHERE r.StudentID = (SELECT StudentID FROM Students WHERE UserID = @uid)
                        GROUP BY e.Title, r.Score, e.Date
                        ORDER BY e.Date DESC", conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@uid", _userId);
                        da.Fill(dtOverall);
                    }
                }
                dgvOverallResults.DataSource = dtOverall;

                var dtSubjects = new DataTable();
                dgvSubjectNets.DataSource = dtSubjects;

                dgvOverallResults.Visible = false;
                dgvSubjectNets.Visible = false;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(
                    $"Database error #{sqlEx.Number}: {sqlEx.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading results: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowResults()
        {
            // Clear other content
            HideContentControls();

            // Ensure DataGridView is parented to panelCard and positioned below lblTitle
            dgvOverallResults.Parent = panelCard;
            dgvOverallResults.Location = new Point(0, lblTitle.Height + lblTitle.Location.Y + 10); // 10px padding below lblTitle
            dgvOverallResults.Size = new Size(panelCard.Width - 20, panelCard.Height - lblTitle.Height - lblTitle.Location.Y - 20); // Adjust size to fit panelCard
            dgvOverallResults.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvOverallResults.BringToFront();
            dgvOverallResults.Visible = true;

            string cs = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            try
            {
                var dtOverall = new DataTable();
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (var da = new SqlDataAdapter(@"
                        SELECT 
                            e.Title AS Exam,
                            MAX(CASE WHEN es.SubjectName = 'Math' THEN es.Net END) AS MathNet,
                            MAX(CASE WHEN es.SubjectName = 'Science' THEN es.Net END) AS ScienceNet,
                            MAX(CASE WHEN es.SubjectName = 'Turkish' THEN es.Net END) AS TurkishNet,
                            MAX(CASE WHEN es.SubjectName = 'History' THEN es.Net END) AS HistoryNet,
                            MAX(CASE WHEN es.SubjectName = 'Religion' THEN es.Net END) AS ReligionNet,
                            MAX(CASE WHEN es.SubjectName = 'English' THEN es.Net END) AS EnglishNet,
                            r.Score AS TotalNet,
                            e.Date AS ExamDate
                        FROM ExamResults r
                        JOIN Exams e ON r.ExamID = e.ExamID
                        LEFT JOIN ExamSubjects es ON r.ExamID = es.ExamID AND r.StudentID = es.StudentID
                        WHERE r.StudentID = (SELECT StudentID FROM Students WHERE UserID = @uid)
                        GROUP BY e.Title, r.Score, e.Date
                        ORDER BY e.Date DESC", conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@uid", _userId);
                        da.Fill(dtOverall);
                    }
                }
                dgvOverallResults.DataSource = dtOverall;

                if (dtOverall.Rows.Count == 0)
                {
                    MessageBox.Show("No exam results found for this student.",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                if (dtOverall.Columns.Contains("Exam"))
                    dgvOverallResults.Columns["Exam"].HeaderText = "Exam Name";
                if (dtOverall.Columns.Contains("MathNet"))
                {
                    dgvOverallResults.Columns["MathNet"].HeaderText = "Math Net";
                    dgvOverallResults.Columns["MathNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("ScienceNet"))
                {
                    dgvOverallResults.Columns["ScienceNet"].HeaderText = "Science Net";
                    dgvOverallResults.Columns["ScienceNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("TurkishNet"))
                {
                    dgvOverallResults.Columns["TurkishNet"].HeaderText = "Turkish Net";
                    dgvOverallResults.Columns["TurkishNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("HistoryNet"))
                {
                    dgvOverallResults.Columns["HistoryNet"].HeaderText = "History Net";
                    dgvOverallResults.Columns["HistoryNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("ReligionNet"))
                {
                    dgvOverallResults.Columns["ReligionNet"].HeaderText = "Religion Net";
                    dgvOverallResults.Columns["ReligionNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("EnglishNet"))
                {
                    dgvOverallResults.Columns["EnglishNet"].HeaderText = "English Net";
                    dgvOverallResults.Columns["EnglishNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("TotalNet"))
                {
                    dgvOverallResults.Columns["TotalNet"].HeaderText = "Total Net";
                    dgvOverallResults.Columns["TotalNet"].DefaultCellStyle.Format = "F2";
                }
                if (dtOverall.Columns.Contains("ExamDate"))
                    dgvOverallResults.Columns["ExamDate"].HeaderText = "Exam Date";

                var dtSubjects = new DataTable();
                dgvSubjectNets.DataSource = dtSubjects;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(
                    $"Database error #{sqlEx.Number}: {sqlEx.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading results: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void StudentForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}