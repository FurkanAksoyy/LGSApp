using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace LGSApp
{
    public partial class AddExamStu : UserControl
    {
        private readonly Dictionary<string, int> subjectMaxSums = new Dictionary<string, int>
        {
            { "Turkish", 20 },
            { "Math", 20 },
            { "Science", 20 },
            { "History", 10 },
            { "Religion", 10 },
            { "English", 10 }
        };

        private int _studentId; // Made non-readonly to allow update
        private readonly string _studentFirstName;
        private Color _mainColor;
        private Color _lightColor;
        private Color _darkColor;
        private Color _darkerColor;

        public AddExamStu(int studentId, string studentFirstName)
        {
            InitializeComponent();
            _studentId = studentId;
            _studentFirstName = studentFirstName;
            this.Load += AddExamStu_Load;
            btnSaveExam.Click += btnSaveExam_Click;
            this.ParentChanged += AddExamStu_ParentChanged;

            txtMathCorrect.TextChanged += (s, e) => { CalculateNet(txtMathCorrect, txtMathWrong, txtMathNet); ValidateSubjectSum("Math", txtMathCorrect, txtMathWrong, txtMathBlank, subjectMaxSums["Math"]); };
            txtMathWrong.TextChanged += (s, e) => { CalculateNet(txtMathCorrect, txtMathWrong, txtMathNet); ValidateSubjectSum("Math", txtMathCorrect, txtMathWrong, txtMathBlank, subjectMaxSums["Math"]); };
            txtMathBlank.TextChanged += (s, e) => ValidateSubjectSum("Math", txtMathCorrect, txtMathWrong, txtMathBlank, subjectMaxSums["Math"]);

            txtScienceCorrect.TextChanged += (s, e) => { CalculateNet(txtScienceCorrect, txtScienceWrong, txtScienceNet); ValidateSubjectSum("Science", txtScienceCorrect, txtScienceWrong, txtScienceBlank, subjectMaxSums["Science"]); };
            txtScienceWrong.TextChanged += (s, e) => { CalculateNet(txtScienceCorrect, txtScienceWrong, txtScienceNet); ValidateSubjectSum("Science", txtScienceCorrect, txtScienceWrong, txtScienceBlank, subjectMaxSums["Science"]); };
            txtScienceBlank.TextChanged += (s, e) => ValidateSubjectSum("Science", txtScienceCorrect, txtScienceWrong, txtScienceBlank, subjectMaxSums["Science"]);

            txtTurkishCorrect.TextChanged += (s, e) => { CalculateNet(txtTurkishCorrect, txtTurkishWrong, txtTurkishNet); ValidateSubjectSum("Turkish", txtTurkishCorrect, txtTurkishWrong, txtTurkishBlank, subjectMaxSums["Turkish"]); };
            txtTurkishWrong.TextChanged += (s, e) => { CalculateNet(txtTurkishCorrect, txtTurkishWrong, txtTurkishNet); ValidateSubjectSum("Turkish", txtTurkishCorrect, txtTurkishWrong, txtTurkishBlank, subjectMaxSums["Turkish"]); };
            txtTurkishBlank.TextChanged += (s, e) => ValidateSubjectSum("Turkish", txtTurkishCorrect, txtTurkishWrong, txtTurkishBlank, subjectMaxSums["Turkish"]);

            txtHistoryCorrect.TextChanged += (s, e) => { CalculateNet(txtHistoryCorrect, txtHistoryWrong, txtHistoryNet); ValidateSubjectSum("History", txtHistoryCorrect, txtHistoryWrong, txtHistoryBlank, subjectMaxSums["History"]); };
            txtHistoryWrong.TextChanged += (s, e) => { CalculateNet(txtHistoryCorrect, txtHistoryWrong, txtHistoryNet); ValidateSubjectSum("History", txtHistoryCorrect, txtHistoryWrong, txtHistoryBlank, subjectMaxSums["History"]); };
            txtHistoryBlank.TextChanged += (s, e) => ValidateSubjectSum("History", txtHistoryCorrect, txtHistoryWrong, txtHistoryBlank, subjectMaxSums["History"]);

            txtReligionCorrect.TextChanged += (s, e) => { CalculateNet(txtReligionCorrect, txtReligionWrong, txtReligionNet); ValidateSubjectSum("Religion", txtReligionCorrect, txtReligionWrong, txtReligionBlank, subjectMaxSums["Religion"]); };
            txtReligionWrong.TextChanged += (s, e) => { CalculateNet(txtReligionCorrect, txtReligionWrong, txtReligionNet); ValidateSubjectSum("Religion", txtReligionCorrect, txtReligionWrong, txtReligionBlank, subjectMaxSums["Religion"]); };
            txtReligionBlank.TextChanged += (s, e) => ValidateSubjectSum("Religion", txtReligionCorrect, txtReligionWrong, txtReligionBlank, subjectMaxSums["Religion"]);

            txtEnglishCorrect.TextChanged += (s, e) => { CalculateNet(txtEnglishCorrect, txtEnglishWrong, txtEnglishNet); ValidateSubjectSum("English", txtEnglishCorrect, txtEnglishWrong, txtEnglishBlank, subjectMaxSums["English"]); };
            txtEnglishWrong.TextChanged += (s, e) => { CalculateNet(txtEnglishCorrect, txtEnglishWrong, txtEnglishNet); ValidateSubjectSum("English", txtEnglishCorrect, txtEnglishWrong, txtEnglishBlank, subjectMaxSums["English"]); };
            txtEnglishBlank.TextChanged += (s, e) => ValidateSubjectSum("English", txtEnglishCorrect, txtEnglishWrong, txtEnglishBlank, subjectMaxSums["English"]);
        }

        private void AddExamStu_ParentChanged(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                try
                {
                    using (var stream = new MemoryStream(Properties.Resources.icon))
                    {
                        this.ParentForm.Icon = new Icon(stream);
                    }
                }
                catch
                {
                    this.ParentForm.Icon = SystemIcons.Application;
                }
            }
        }

        private void AddExamStu_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            int studentId = _studentId;
            string studentFullName = _studentFirstName;

            // Debug: Log input values
            Console.WriteLine($"Login Input - StudentID: {_studentId}, FirstName: {_studentFirstName}");

            // Try to match first name (case-insensitive)
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT StudentID, Name FROM Students WHERE LOWER(SUBSTRING(Name, 1, CHARINDEX(' ', Name + ' ') - 1)) = LOWER(@firstName)", conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", _studentFirstName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentId = reader.GetInt32(0);
                            studentFullName = reader.GetString(1);
                            _studentId = studentId; // Update _studentId
                            Console.WriteLine($"Name Match - StudentID: {studentId}, FullName: {studentFullName}");
                        }
                        else
                        {
                            // Fallback to StudentID
                            reader.Close();
                            cmd.CommandText = "SELECT StudentID, Name FROM Students WHERE StudentID = @studentId";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@studentId", _studentId);
                            using (var fallbackReader = cmd.ExecuteReader())
                            {
                                if (fallbackReader.Read())
                                {
                                    studentId = fallbackReader.GetInt32(0);
                                    studentFullName = fallbackReader.GetString(1);
                                    Console.WriteLine($"ID Fallback - StudentID: {studentId}, FullName: {studentFullName}");
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid Student ID: {_studentId} or Name: {_studentFirstName}. Please log in with a valid student account.",
                                                    "Validation Error",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    Console.WriteLine("Validation Failed - No match found");
                                    this.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            // Set gender-based theming
            string gender = GetStudentGender();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = gender == "Female"
                ? Path.Combine(basePath, "Resources", "pink.jpeg")
                : Path.Combine(basePath, "Resources", "blue.jpeg");

            bool imageExists = File.Exists(imagePath);

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

            if (imageExists)
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.BackColor = _lightColor;
                MessageBox.Show($"Background image not found at: {imagePath}\nEnsure 'pink.jpeg' and 'blue.jpeg' are in the 'Resources' folder with 'Copy to Output Directory' set.",
                                "Image Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            grpScores.BackColor = Color.White;
            grpScores.BackgroundImage = null;
            grpScores.BackgroundImageLayout = ImageLayout.None;

            btnSaveExam.BackColor = _darkColor;
            btnSaveExam.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnSaveExam.ForeColor = Color.White;

            ApplyLabelColors(this.Controls);

            // Populate ComboBox with matched student's full name
            var dt = new DataTable();
            dt.Columns.Add("StudentID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(studentId, studentFullName);

            cmbExamStudent.DisplayMember = "Name";
            cmbExamStudent.ValueMember = "StudentID";
            cmbExamStudent.DataSource = dt;
            cmbExamStudent.Enabled = false;

            // Load exam titles
            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter(
                "SELECT ExamID, Title FROM Exams", conn))
            {
                var dtExams = new DataTable();
                da.Fill(dtExams);
                cmbExamName.DisplayMember = "Title";
                cmbExamName.ValueMember = "ExamID";
                cmbExamName.DataSource = dtExams;
            }
        }

        private string GetStudentGender()
        {
            string cs = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            try
            {
                using (var conn = new SqlConnection(cs))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "SELECT Gender FROM Students WHERE LOWER(SUBSTRING(Name, 1, CHARINDEX(' ', Name + ' ') - 1)) = LOWER(@firstName)", conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", _studentFirstName);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            return result.ToString();

                        // Fallback to StudentID
                        cmd.CommandText = "SELECT Gender FROM Students WHERE StudentID = @studentId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@studentId", _studentId);
                        result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "Male";
                    }
                }
            }
            catch
            {
                return "Male";
            }
        }

        private void ApplyLabelColors(Control.ControlCollection controls)
        {
            var labelsToKeepBlack = new HashSet<string>
            {
                "lblMathCorrect", "lblMathWrong", "lblMathBlank", "lblMathNet",
                "lblScienceCorrect", "lblScienceWrong", "lblScienceBlank", "lblScienceNet",
                "lblTurkishCorrect", "lblTurkishWrong", "lblTurkishBlank", "lblTurkishNet",
                "lblHistoryCorrect", "lblHistoryWrong", "lblHistoryBlank", "lblHistoryNet",
                "lblReligionCorrect", "lblReligionWrong", "lblReligionBlank", "lblReligionNet",
                "lblEnglishCorrect", "lblEnglishWrong", "lblEnglishBlank", "lblEnglishNet",
                "lblSelectStudent", "lblExamName", "lblDateTaken"
            };

            foreach (Control control in controls)
            {
                if (control is Label label)
                {
                    if (!labelsToKeepBlack.Contains(label.Name))
                    {
                        label.ForeColor = _darkColor;
                    }
                    else
                    {
                        label.ForeColor = Color.Black;
                    }
                }
                if (control.HasChildren)
                {
                    ApplyLabelColors(control.Controls);
                }
            }
        }

        private void CalculateNet(TextBox txtCorrect, TextBox txtWrong, TextBox txtNet)
        {
            bool isCorrectValid = decimal.TryParse(txtCorrect.Text, out decimal correct);
            bool isWrongValid = decimal.TryParse(txtWrong.Text, out decimal wrong);

            if (!isCorrectValid) correct = 0;
            if (!isWrongValid) wrong = 0;

            decimal net = correct - (wrong * 0.25m);
            txtNet.Text = Math.Max(0, net).ToString("F2");
        }

        private void ValidateSubjectSum(string subject, TextBox txtCorrect, TextBox txtWrong, TextBox txtBlank, int maxSum)
        {
            bool isCorrectValid = decimal.TryParse(txtCorrect.Text, out decimal correct);
            bool isWrongValid = decimal.TryParse(txtWrong.Text, out decimal wrong);
            bool isBlankValid = decimal.TryParse(txtBlank.Text, out decimal blank);

            if (!isCorrectValid) correct = 0;
            if (!isWrongValid) wrong = 0;
            if (!isBlankValid) blank = 0;

            decimal sum = correct + wrong + blank;

            if (sum > maxSum)
            {
                MessageBox.Show($"For {subject}, the sum of Correct + Wrong + Blank must not exceed {maxSum}. Current sum: {sum}.",
                                "Validation Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool AreSubjectSumsValid()
        {
            var subjects = new[]
            {
                new { Name = "Math", Correct = txtMathCorrect, Wrong = txtMathWrong, Blank = txtMathBlank, Max = subjectMaxSums["Math"] },
                new { Name = "Science", Correct = txtScienceCorrect, Wrong = txtScienceWrong, Blank = txtScienceBlank, Max = subjectMaxSums["Science"] },
                new { Name = "Turkish", Correct = txtTurkishCorrect, Wrong = txtTurkishWrong, Blank = txtTurkishBlank, Max = subjectMaxSums["Turkish"] },
                new { Name = "History", Correct = txtHistoryCorrect, Wrong = txtHistoryWrong, Blank = txtHistoryBlank, Max = subjectMaxSums["History"] },
                new { Name = "Religion", Correct = txtReligionCorrect, Wrong = txtReligionWrong, Blank = txtReligionBlank, Max = subjectMaxSums["Religion"] },
                new { Name = "English", Correct = txtEnglishCorrect, Wrong = txtEnglishWrong, Blank = txtEnglishBlank, Max = subjectMaxSums["English"] }
            };

            foreach (var subject in subjects)
            {
                bool isCorrectValid = decimal.TryParse(subject.Correct.Text, out decimal correct);
                bool isWrongValid = decimal.TryParse(subject.Wrong.Text, out decimal wrong);
                bool isBlankValid = decimal.TryParse(subject.Blank.Text, out decimal blank);

                if (!isCorrectValid) correct = 0;
                if (!isWrongValid) wrong = 0;
                if (!isBlankValid) blank = 0;

                decimal sum = correct + wrong + blank;
                if (sum > subject.Max)
                {
                    MessageBox.Show($"For {subject.Name}, the sum of Correct + Wrong + Blank must not exceed {subject.Max}. Current sum: {sum}.",
                                    "Validation Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            if (cmbExamName.SelectedValue == null)
            {
                MessageBox.Show("Please select an exam title.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMathNet.Text, out decimal mathNet) ||
                !decimal.TryParse(txtScienceNet.Text, out decimal scienceNet) ||
                !decimal.TryParse(txtTurkishNet.Text, out decimal turkishNet) ||
                !decimal.TryParse(txtHistoryNet.Text, out decimal historyNet) ||
                !decimal.TryParse(txtReligionNet.Text, out decimal religionNet) ||
                !decimal.TryParse(txtEnglishNet.Text, out decimal englishNet))
            {
                MessageBox.Show("Please ensure all net scores are valid numbers.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!AreSubjectSumsValid())
            {
                return;
            }

            int examId = (int)cmbExamName.SelectedValue;
            DateTime date = dtpDateTaken.Value.Date;
            decimal totalNet = mathNet + scienceNet + turkishNet + historyNet + religionNet + englishNet;

            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        int resultId;
                        string sqlResult = @"
                            INSERT INTO ExamResults (ExamID, StudentID, Score, DateTaken)
                            VALUES (@examId, @studentId, @score, @dateTaken);
                            SELECT SCOPE_IDENTITY();";
                        using (var cmdResult = new SqlCommand(sqlResult, conn, tran))
                        {
                            cmdResult.Parameters.AddWithValue("@examId", examId);
                            cmdResult.Parameters.AddWithValue("@studentId", _studentId);
                            cmdResult.Parameters.AddWithValue("@score", totalNet);
                            cmdResult.Parameters.AddWithValue("@dateTaken", date);
                            resultId = Convert.ToInt32(cmdResult.ExecuteScalar());
                        }

                        string sqlSubject = @"
                            INSERT INTO ExamSubjects (ExamID, StudentID, SubjectName, Correct, Wrong, Blank, Net)
                            VALUES (@examId, @studentId, @subject, @correct, @wrong, @blank, @net);";

                        var subjects = new[]
                        {
                            new { Name = "Math", Correct = txtMathCorrect, Wrong = txtMathWrong, Blank = txtMathBlank, Net = txtMathNet },
                            new { Name = "Science", Correct = txtScienceCorrect, Wrong = txtScienceWrong, Blank = txtScienceBlank, Net = txtScienceNet },
                            new { Name = "Turkish", Correct = txtTurkishCorrect, Wrong = txtTurkishWrong, Blank = txtTurkishBlank, Net = txtTurkishNet },
                            new { Name = "History", Correct = txtHistoryCorrect, Wrong = txtHistoryWrong, Blank = txtHistoryBlank, Net = txtHistoryNet },
                            new { Name = "Religion", Correct = txtReligionCorrect, Wrong = txtReligionWrong, Blank = txtReligionBlank, Net = txtReligionNet },
                            new { Name = "English", Correct = txtEnglishCorrect, Wrong = txtEnglishWrong, Blank = txtEnglishBlank, Net = txtEnglishNet }
                        };

                        foreach (var subject in subjects)
                        {
                            using (var cmdSubject = new SqlCommand(sqlSubject, conn, tran))
                            {
                                cmdSubject.Parameters.AddWithValue("@examId", examId);
                                cmdSubject.Parameters.AddWithValue("@studentId", _studentId);
                                cmdSubject.Parameters.AddWithValue("@subject", subject.Name);
                                cmdSubject.Parameters.AddWithValue("@correct", string.IsNullOrWhiteSpace(subject.Correct.Text) ? 0 : int.Parse(subject.Correct.Text));
                                cmdSubject.Parameters.AddWithValue("@wrong", string.IsNullOrWhiteSpace(subject.Wrong.Text) ? 0 : int.Parse(subject.Wrong.Text));
                                cmdSubject.Parameters.AddWithValue("@blank", string.IsNullOrWhiteSpace(subject.Blank.Text) ? 0 : int.Parse(subject.Blank.Text));
                                cmdSubject.Parameters.AddWithValue("@net", string.IsNullOrWhiteSpace(subject.Net.Text) ? 0 : decimal.Parse(subject.Net.Text));
                                cmdSubject.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                        MessageBox.Show("Exam saved successfully!",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error saving exam: " + ex.Message,
                                        "Database Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearForm()
        {
            if (cmbExamName.Items.Count > 0)
                cmbExamName.SelectedIndex = 0;

            dtpDateTaken.Value = DateTime.Today;

            txtMathCorrect.Clear();
            txtMathWrong.Clear();
            txtMathBlank.Clear();
            txtMathNet.Clear();

            txtScienceCorrect.Clear();
            txtScienceWrong.Clear();
            txtScienceBlank.Clear();
            txtScienceNet.Clear();

            txtTurkishCorrect.Clear();
            txtTurkishWrong.Clear();
            txtTurkishBlank.Clear();
            txtTurkishNet.Clear();

            txtHistoryCorrect.Clear();
            txtHistoryWrong.Clear();
            txtHistoryBlank.Clear();
            txtHistoryNet.Clear();

            txtReligionCorrect.Clear();
            txtReligionWrong.Clear();
            txtReligionBlank.Clear();
            txtReligionNet.Clear();

            txtEnglishCorrect.Clear();
            txtEnglishWrong.Clear();
            txtEnglishBlank.Clear();
            txtEnglishNet.Clear();
        }

        private void lblSelectStudent_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
    }
}