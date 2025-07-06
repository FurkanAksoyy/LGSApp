using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LGSApp
{
    public partial class ChartsGraphsControl : UserControl
    {
        private Color _adminLabelColor = Color.FromArgb(255, 128, 0); // Orange
        private Color _studentLabelColor = Color.FromArgb(135, 206, 250); // Default blue
        private bool _isStudentContext = false;
        private int _userId = -1;
        private string _studentFirstName = null;
        private Color _currentLabelColor;

        public ChartsGraphsControl()
        {
            InitializeComponent();
            this.Load += ChartsGraphsControl_Load;
            cmbChartType.SelectedIndexChanged += CmbChartType_SelectedIndexChanged;
            btnShow.Click += BtnShow_Click;
        }

        // Call this from StudentForm after construction
        public void SetStudentContext(int userId, string studentFirstName, Color labelColor)
        {
            _isStudentContext = true;
            _studentLabelColor = labelColor;
            _userId = userId;
            _studentFirstName = studentFirstName;
            _currentLabelColor = labelColor;
            SetLabelColors(labelColor);
        }

        // Call this from AdminDashboard after construction
        public void SetAdminContext()
        {
            _isStudentContext = false;
            _currentLabelColor = _adminLabelColor;
            SetLabelColors(_adminLabelColor);
            cmbStudents.Enabled = true;
        }

        private void SetLabelColors(Color color)
        {
            lblTitle.ForeColor = color;
            lblStudent.ForeColor = color;
            lblChartType.ForeColor = color;
            lblExam.ForeColor = color;
            lblDisplayType.ForeColor = color;
        }

        private void ChartsGraphsControl_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            cmbStudents.BackColor = Color.White;
            cmbChartType.BackColor = Color.White;
            cmbExams.BackColor = Color.White;
            cmbDisplayType.BackColor = Color.White;
            btnShow.BackColor = Color.Black;
            btnShow.ForeColor = Color.White;

            if (_isStudentContext && _userId > 0 && !string.IsNullOrEmpty(_studentFirstName))
            {
                string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
                int studentId = -1;
                string studentFullName = _studentFirstName;

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Try to match first name (case-insensitive)
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
                            }
                        }
                    }
                    // If not found by first name, fallback to UserID
                    if (studentId == -1)
                    {
                        using (var cmd = new SqlCommand(
                            "SELECT StudentID, Name FROM Students WHERE UserID = @userId", conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", _userId);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    studentId = reader.GetInt32(0);
                                    studentFullName = reader.GetString(1);
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid UserID: {_userId} or Name: {_studentFirstName}. Please log in with a valid student account.",
                                                    "Validation Error",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                                    this.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                }

                // Populate ComboBox with matched student's full name
                var dt = new DataTable();
                dt.Columns.Add("StudentID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Rows.Add(studentId, studentFullName);

                cmbStudents.DisplayMember = "Name";
                cmbStudents.ValueMember = "StudentID";
                cmbStudents.DataSource = dt;
                cmbStudents.Enabled = false;
            }
            else
            {
                LoadStudents();
                cmbStudents.Enabled = true;
            }

            LoadExams();

            cmbChartType.Items.Clear();
            cmbChartType.Items.Add("Graph/Chart for Exams Total Nets");
            cmbChartType.Items.Add("Graph/Chart For Subjects Nets");
            cmbChartType.SelectedIndex = 0;

            cmbDisplayType.Items.Clear();
            cmbDisplayType.Items.Add("Chart");
            cmbDisplayType.Items.Add("Graph");
            cmbDisplayType.SelectedIndex = 0;

            cmbExams.Enabled = false;
        }

        private void LoadStudents()
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter("SELECT StudentID, Name FROM Students ORDER BY Name", conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                cmbStudents.DisplayMember = "Name";
                cmbStudents.ValueMember = "StudentID";
                cmbStudents.DataSource = dt;
            }
        }

        private void LoadExams()
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter("SELECT ExamID, Title FROM Exams ORDER BY Date DESC", conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                cmbExams.DisplayMember = "Title";
                cmbExams.ValueMember = "ExamID";
                cmbExams.DataSource = dt;
            }
        }

        private void CmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbExams.Enabled = (cmbChartType.SelectedIndex == 1);
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)cmbStudents.SelectedValue;
            string studentName = cmbStudents.Text;
            string chartType = cmbChartType.SelectedItem?.ToString();
            string displayType = cmbDisplayType.SelectedItem?.ToString();

            DataTable dt = null;
            string xField = "";
            string yField = "";
            string title = "";
            string examName = "";

            if (chartType == "Graph/Chart for Exams Total Nets")
            {
                dt = GetExamsTotalNet(studentId);
                xField = "Exam Name";
                yField = "Total Net";
                title = "Exams Total Nets";
            }
            else if (chartType == "Graph/Chart For Subjects Nets" && cmbExams.SelectedValue != null)
            {
                int examId = (int)cmbExams.SelectedValue;
                examName = cmbExams.Text;
                dt = GetSubjectsNet(studentId, examId);
                xField = "Subject";
                yField = "Net";
                title = "Subjects Nets";
            }
            else
            {
                MessageBox.Show("Please select an exam.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data found for the selected options.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Use the same label color as the control
            Color labelColor = _currentLabelColor;

            // Create a new form to show the chart/graph
            var chartForm = new Form
            {
                Text = title,
                Size = new Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.White
            };

            // Set the icon using the provided method
            try
            {
                using (var stream = new MemoryStream(Properties.Resources.icon))
                {
                    chartForm.Icon = new Icon(stream);
                }
            }
            catch
            {
                chartForm.Icon = SystemIcons.Application;
            }

            // Student name label
            var lblStudent = new Label
            {
                Text = $"Student: {studentName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = labelColor,
                AutoSize = true,
                Location = new Point(20, 15)
            };
            chartForm.Controls.Add(lblStudent);

            // Exam name label (if needed)
            Label lblExam = null;
            int chartTop = 50;
            if (!string.IsNullOrEmpty(examName))
            {
                lblExam = new Label
                {
                    Text = $"Exam: {examName}",
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    ForeColor = labelColor,
                    AutoSize = true,
                    Location = new Point(20, 40)
                };
                chartForm.Controls.Add(lblExam);
                chartTop = 70;
            }

            var chart = new Chart
            {
                Dock = DockStyle.None,
                Location = new Point(20, chartTop),
                Size = new Size(740, 480),
                BackColor = Color.White
            };

            if (displayType == "Chart")
                DrawLineChart(dt, xField, yField, title, chart);
            else
                DrawPieChart(dt, xField, yField, title, chart);

            chartForm.Controls.Add(chart);
            chart.BringToFront();
            chartForm.ShowDialog();
        }

        private DataTable GetExamsTotalNet(int studentId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            var dt = new DataTable();
            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter(@"
                SELECT 
                    e.Title AS [Exam Name],
                    r.Score AS [Total Net]
                FROM ExamResults r
                JOIN Exams e ON r.ExamID = e.ExamID
                WHERE r.StudentID = @sid
                ORDER BY e.Date", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@sid", studentId);
                da.Fill(dt);
            }
            return dt;
        }

        private DataTable GetSubjectsNet(int studentId, int examId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            var dt = new DataTable();
            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter(@"
                SELECT 
                    es.SubjectName AS [Subject],
                    es.Net AS [Net]
                FROM ExamSubjects es
                WHERE es.ExamID = @eid AND es.StudentID = @sid
                ORDER BY es.SubjectName", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@eid", examId);
                da.SelectCommand.Parameters.AddWithValue("@sid", studentId);
                da.Fill(dt);
            }
            return dt;
        }

        private void DrawLineChart(DataTable dt, string xField, string yField, string title, Chart chart)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();
            chart.ChartAreas.Clear();

            // Create and style chart area
            var chartArea = new ChartArea
            {
                BackColor = Color.White,
                BackSecondaryColor = Color.FromArgb(240, 240, 240),
                BackGradientStyle = GradientStyle.TopBottom,
                BorderColor = Color.FromArgb(100, 100, 100),
                BorderWidth = 1,
                ShadowColor = Color.FromArgb(50, 0, 0, 0),
                ShadowOffset = 2
            };

            // Style axes
            chartArea.AxisX.Title = xField;
            chartArea.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(200, 200, 200);
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotate labels for better readability
            chartArea.AxisX.IsLabelAutoFit = true;

            chartArea.AxisY.Title = yField;
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(200, 200, 200);
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart.ChartAreas.Add(chartArea);

            // Create series
            var series = new Series
            {
                Name = title,
                ChartType = SeriesChartType.Spline, // Use spline for smoother lines
                BorderWidth = 4,
                Color = _currentLabelColor, // Use the current label color for consistency
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10,
                MarkerColor = _currentLabelColor,
                MarkerBorderColor = Color.Black,
                MarkerBorderWidth = 1,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Black,
                LabelBackColor = Color.FromArgb(200, 255, 255, 255),
                LabelBorderColor = Color.FromArgb(150, 150, 150),
                LabelBorderWidth = 1
            };

            // Add data points
            foreach (DataRow row in dt.Rows)
            {
                string x = row[xField].ToString();
                double y = row[yField] != DBNull.Value ? Convert.ToDouble(row[yField]) : 0;
                int pointIndex = series.Points.AddXY(x, y);
                series.Points[pointIndex].Label = y.ToString("F2");
                series.Points[pointIndex].ToolTip = $"{x}: {y:F2}"; // Add tooltip
            }

            chart.Series.Add(series);

            // Add title
            var chartTitle = new Title
            {
                Text = title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = _currentLabelColor
            };
            chart.Titles.Add(chartTitle);

            // Add legend
            var legend = new Legend
            {
                Docking = Docking.Top,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(240, 240, 240),
                BorderColor = Color.FromArgb(150, 150, 150),
                BorderWidth = 1
            };
            chart.Legends.Add(legend);
        }

        private void DrawPieChart(DataTable dt, string xField, string yField, string title, Chart chart)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();
            chart.ChartAreas.Clear();

            // Create and style chart area
            var chartArea = new ChartArea
            {
                BackColor = Color.White,
                BackSecondaryColor = Color.FromArgb(240, 240, 240),
                BackGradientStyle = GradientStyle.TopBottom,
                BorderColor = Color.FromArgb(100, 100, 100),
                BorderWidth = 1,
                ShadowColor = Color.FromArgb(50, 0, 0, 0),
                ShadowOffset = 2
            };
            chartArea.Area3DStyle.Enable3D = true; // Enable 3D effect
            chartArea.Area3DStyle.Inclination = 30;
            chartArea.Area3DStyle.Rotation = 30;

            chart.ChartAreas.Add(chartArea);

            // Create series
            var series = new Series
            {
                Name = title,
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                ["PieLabelStyle"] = "Outside", // Place labels outside the pie
                ["PieLineColor"] = "Black" // Line connecting labels to slices
            };

            // Custom color palette
            Color[] palette = new Color[]
            {
                _currentLabelColor,
                Color.FromArgb(100, 149, 237),
                Color.FromArgb(60, 179, 113),
                Color.FromArgb(255, 99, 71),
                Color.FromArgb(147, 112, 219),
                Color.FromArgb(255, 215, 0)
            };

            // Add data points
            int colorIndex = 0;
            foreach (DataRow row in dt.Rows)
            {
                string x = row[xField].ToString();
                double y = row[yField] != DBNull.Value ? Convert.ToDouble(row[yField]) : 0;
                int pointIndex = series.Points.AddXY(x, y);
                series.Points[pointIndex].LegendText = x;
                series.Points[pointIndex].Label = $"{y:F2} ({(y / dt.AsEnumerable().Sum(r => r[yField] != DBNull.Value ? Convert.ToDouble(r[yField]) : 0) * 100):F1}%)";
                series.Points[pointIndex].Color = palette[colorIndex % palette.Length];
                series.Points[pointIndex]["Exploded"] = "true"; // Slightly explode all slices
                series.Points[pointIndex].ToolTip = $"{x}: {y:F2}"; // Add tooltip
                colorIndex++;
            }

            chart.Series.Add(series);

            // Add title
            var chartTitle = new Title
            {
                Text = title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = _currentLabelColor
            };
            chart.Titles.Add(chartTitle);

            // Add legend
            var legend = new Legend
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center,
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(240, 240, 240),
                BorderColor = Color.FromArgb(150, 150, 150),
                BorderWidth = 1
            };
            chart.Legends.Add(legend);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}