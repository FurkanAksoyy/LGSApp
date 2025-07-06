using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class ViewResultsControl : UserControl
    {
        public ViewResultsControl()
        {
            InitializeComponent();
            this.Load += ViewResultsControl_Load;
            btnFilter.Click += btnFilter_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnClearFilters.Click += btnClearFilters_Click;

            // Make responsive
            this.Resize += ViewResultsControl_Resize;
        }

        private void ViewResultsControl_Load(object sender, EventArgs e)
        {
            LoadFilterData();
            LoadResults(null, null);
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Configure DataGridView appearance
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Auto-resize columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 40;
        }

        private void LoadFilterData()
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Load students for filter
                    using (var da = new SqlDataAdapter(
                        "SELECT DISTINCT Name FROM Students ORDER BY Name", conn))
                    {
                        var dtStudents = new DataTable();
                        da.Fill(dtStudents);
                        DataRow emptyRow = dtStudents.NewRow();
                        emptyRow["Name"] = "-- All Students --";
                        dtStudents.Rows.InsertAt(emptyRow, 0);
                        cmbFilterStudent.DisplayMember = "Name";
                        cmbFilterStudent.ValueMember = "Name";
                        cmbFilterStudent.DataSource = dtStudents;
                    }

                    // Load exams for filter
                    using (var da = new SqlDataAdapter(
                        "SELECT DISTINCT Title FROM Exams ORDER BY Title", conn))
                    {
                        var dtExams = new DataTable();
                        da.Fill(dtExams);
                        DataRow emptyRow = dtExams.NewRow();
                        emptyRow["Title"] = "-- All Exams --";
                        dtExams.Rows.InsertAt(emptyRow, 0);
                        cmbFilterExam.DisplayMember = "Title";
                        cmbFilterExam.ValueMember = "Title";
                        cmbFilterExam.DataSource = dtExams;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading filter data: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string studentName = cmbFilterStudent.SelectedValue?.ToString();
            string examTitle = cmbFilterExam.SelectedValue?.ToString();

            // Handle "All" selections
            if (studentName == "-- All Students --") studentName = null;
            if (examTitle == "-- All Exams --") examTitle = null;

            LoadResults(studentName, examTitle);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFilterData();
            LoadResults(null, null);
            lblStatus.Text = "Data refreshed successfully";
            lblStatus.ForeColor = Color.Green;
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbFilterStudent.SelectedIndex = 0;
            cmbFilterExam.SelectedIndex = 0;
            LoadResults(null, null);
            lblStatus.Text = "Filters cleared";
            lblStatus.ForeColor = Color.Blue;
        }

        private void LoadResults(string studentName, string examTitle)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                try
                {
                    lblStatus.Text = "Loading results...";
                    lblStatus.ForeColor = Color.Blue;
                    Application.DoEvents();

                    // Updated SQL to include subject scores from OCR
                    string sql = @"
                        SELECT 
                            s.Name AS StudentName,
                            e.Title AS ExamTitle,
                            ISNULL(MAX(CASE WHEN es.SubjectName = 'Math' THEN es.Net END), 0) AS Math,
                            ISNULL(MAX(CASE WHEN es.SubjectName = 'Science' THEN es.Net END), 0) AS Science,
                            ISNULL(MAX(CASE WHEN es.SubjectName = 'Turkish' THEN es.Net END), 0) AS Turkish,
                            ISNULL(MAX(CASE WHEN es.SubjectName = 'History' THEN es.Net END), 0) AS History,
                            ISNULL(MAX(CASE WHEN es.SubjectName = 'Religion' THEN es.Net END), 0) AS Religion,
                            ISNULL(MAX(CASE WHEN es.SubjectName = 'English' THEN es.Net END), 0) AS English,
                            ISNULL(r.Score, 0) AS Total,
                            FORMAT(e.Date, 'dd.MM.yyyy') AS [Exam Date]
                        FROM Students s
                        JOIN ExamResults r ON s.StudentID = r.StudentID
                        JOIN Exams e ON r.ExamID = e.ExamID
                        LEFT JOIN ExamSubjects es ON r.ExamID = es.ExamID AND r.StudentID = es.StudentID
                        WHERE 1=1";

                    var parameters = new List<SqlParameter>();
                    if (!string.IsNullOrEmpty(studentName))
                    {
                        sql += " AND s.Name LIKE @studentName + '%'";
                        parameters.Add(new SqlParameter("@studentName", studentName));
                    }
                    if (!string.IsNullOrEmpty(examTitle))
                    {
                        sql += " AND e.Title LIKE '%' + @examTitle + '%'";
                        parameters.Add(new SqlParameter("@examTitle", examTitle));
                    }

                    sql += " GROUP BY s.Name, e.Title, r.Score, e.Date ORDER BY e.Date DESC, r.Score DESC";

                    using (var da = new SqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddRange(parameters.ToArray());
                        var dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;

                        // Configure column headers and formatting
                        ConfigureColumns();

                        // Update status
                        if (dt.Rows.Count == 0)
                        {
                            lblStatus.Text = "No results found for the selected filters";
                            lblStatus.ForeColor = Color.Orange;
                        }
                        else
                        {
                            lblStatus.Text = $"Displaying {dt.Rows.Count} exam result(s)";
                            lblStatus.ForeColor = Color.Green;
                        }

                        // Update statistics
                        UpdateStatistics(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading results: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Error loading results";
                    lblStatus.ForeColor = Color.Red;
                }
            }
        }

        private void ConfigureColumns()
        {
            if (dataGridView1.DataSource == null) return;

            var columnConfig = new Dictionary<string, (string Header, string Format, int Width)>
            {
                { "StudentName", ("Student Name", "", 150) },
                { "ExamTitle", ("Exam Title", "", 200) },
                { "Math", ("Math", "F1", 70) },
                { "Science", ("Science", "F1", 70) },
                { "Turkish", ("Turkish", "F1", 70) },
                { "History", ("History", "F1", 70) },
                { "Religion", ("Religion", "F1", 70) },
                { "English", ("English", "F1", 70) },
                { "Total", ("Total", "F1", 80) },
                { "Exam Date", ("Exam Date", "", 100) }
            };

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (columnConfig.ContainsKey(column.Name))
                {
                    var config = columnConfig[column.Name];
                    column.HeaderText = config.Header;
                    column.MinimumWidth = config.Width;

                    if (!string.IsNullOrEmpty(config.Format))
                    {
                        column.DefaultCellStyle.Format = config.Format;

                        // Right-align numeric columns
                        if (config.Format.StartsWith("F"))
                        {
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                    }

                    // Color coding for scores
                    if (column.Name != "StudentName" && column.Name != "ExamTitle" && column.Name != "Exam Date")
                    {
                        column.DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                    }
                }
            }
        }

        private void UpdateStatistics(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                lblStatistics.Text = "No data available";
                return;
            }

            try
            {
                var totalScores = new List<decimal>();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Total"] != DBNull.Value &&
                        decimal.TryParse(row["Total"].ToString(), out decimal total))
                    {
                        totalScores.Add(total);
                    }
                }

                if (totalScores.Count > 0)
                {
                    var avgTotal = totalScores.Average();
                    var maxTotal = totalScores.Max();
                    var minTotal = totalScores.Min();

                    lblStatistics.Text = $"Results: {dt.Rows.Count} | " +
                                        $"Avg: {avgTotal:F1} | " +
                                        $"Max: {maxTotal:F1} | " +
                                        $"Min: {minTotal:F1}";
                }
                else
                {
                    lblStatistics.Text = $"Results: {dt.Rows.Count} | No score data";
                }
            }
            catch (Exception)
            {
                lblStatistics.Text = $"Results: {dt.Rows.Count}";
            }
        }

        private void ViewResultsControl_Resize(object sender, EventArgs e)
        {
            // Handle responsive layout
            AdjustLayout();
        }

        private void AdjustLayout()
        {
            if (this.Width < 800)
            {
                // Compact layout for smaller screens
                panelFilters.Height = 80;
                lblFilterExam.Text = "Exam:";
                lblFilterStudent.Text = "Student:";
            }
            else
            {
                // Normal layout
                panelFilters.Height = 60;
                lblFilterExam.Text = "Filter by Exam:";
                lblFilterStudent.Text = "Filter by Student:";
            }
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic if needed
        }
    }
}