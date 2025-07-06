using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Collections.Generic;

namespace LGSApp
{
    public partial class ExportPdfControl : UserControl
    {
        private readonly bool _isAdmin;
        private readonly int _studentId;
        private readonly string _studentName;
        private readonly string _gender;
        private Color _mainColor;
        private Color _lightColor;
        private Color _darkColor;
        private Color _darkerColor;

        public ExportPdfControl(bool isAdmin, int studentId = 0, string studentName = null, string gender = null)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
            _studentId = studentId;
            _studentName = studentName;
            _gender = gender;

            this.Load += ExportPdfControl_Load;
            btnBrowse.Click += BtnBrowse_Click;
            btnSavePdf.Click += BtnSavePdf_Click;

            // Apply styles after initialization
            SetStyle();
        }

        private void SetStyle()
        {
            // Default colors (used for AdminDashboard or when gender is not specified)
            _mainColor = Color.FromArgb(255, 128, 0); // Orange
            _lightColor = Color.FromArgb(245, 247, 250); // Light background
            _darkColor = Color.FromArgb(255, 128, 0); // Orange for labels and btnBrowse
            _darkerColor = Color.FromArgb(230, 100, 0); // Darker orange for mouse-over

            // Apply gender-based colors if called by StudentForm
            if (!_isAdmin && _gender != null)
            {
                if (_gender == "Female")
                {
                    _mainColor = Color.FromArgb(255, 192, 203); // Pink
                    _darkColor = Color.FromArgb(230, 170, 180); // Pink dark
                    _darkerColor = Color.FromArgb(200, 140, 150); // Pink darker
                }
                else
                {
                    _mainColor = Color.FromArgb(135, 206, 250); // Blue
                    _darkColor = Color.FromArgb(100, 180, 220); // Blue dark
                    _darkerColor = Color.FromArgb(70, 150, 190); // Blue darker
                }
            }

            this.BackColor = Color.White; // Permanent white background
            panelCard.BackColor = Color.White; // Permanent white background

            lblTitle.ForeColor = _darkColor;
            lblSelectStudent.ForeColor = _darkColor;
            lblDirectory.ForeColor = _darkColor;

            btnBrowse.BackColor = _darkColor;
            btnBrowse.FlatAppearance.MouseOverBackColor = _darkerColor;
            btnBrowse.ForeColor = Color.White;

            btnSavePdf.BackColor = Color.Black; // Permanent black
            btnSavePdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50); // Permanent mouse-over
            btnSavePdf.ForeColor = Color.White;
        }

        private void ExportPdfControl_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            if (!_isAdmin && _studentId != 0 && !string.IsNullOrEmpty(_studentName))
            {
                // Student mode: Match student by name or ID, disable ComboBox
                int studentId = _studentId;
                string studentFullName = _studentName;

                try
                {
                    using (var conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(
                            "SELECT StudentID, Name FROM Students WHERE LOWER(SUBSTRING(Name, 1, CHARINDEX(' ', Name + ' ') - 1)) = LOWER(@firstName)", conn))
                        {
                            cmd.Parameters.AddWithValue("@firstName", _studentName);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    studentId = reader.GetInt32(0);
                                    studentFullName = reader.GetString(1);
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
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Invalid Student ID: {_studentId} or Name: {_studentName}. Please select a valid student.",
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading student: {ex.Message}",
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    this.Enabled = false;
                }
            }
            else
            {
                // Admin mode: Load all students, keep ComboBox enabled
                try
                {
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading students: {ex.Message}",
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDirectory.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnSavePdf_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDirectory.Text) || !Directory.Exists(txtDirectory.Text))
            {
                MessageBox.Show("Please select a valid directory.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)cmbStudents.SelectedValue;
            string studentName = cmbStudents.Text.Trim();

            DataTable dt = GetStudentExamResults(studentId);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No exam results found for this student.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string filePath = Path.Combine(txtDirectory.Text, $"{studentName}_ExamResults.pdf");
            try
            {
                GeneratePdf(dt, studentName, filePath);
                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetStudentExamResults(int studentId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            var dt = new DataTable();
            using (var conn = new SqlConnection(connStr))
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
                WHERE r.StudentID = @sid
                GROUP BY e.Title, r.Score, e.Date
                ORDER BY e.Date DESC", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@sid", studentId);
                da.Fill(dt);
            }
            return dt;
        }

        private void GeneratePdf(DataTable dt, string studentName, string filePath)
        {
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "Exam Results for " + studentName;
            doc.Info.Author = "LGS Tracking Application";
            doc.Info.CreationDate = DateTime.Now;

            // Define fonts and colors
            XFont titleFont = new XFont("Arial", 14, XFontStyle.Bold);
            XFont headerFont = new XFont("Arial", 10, XFontStyle.Bold);
            XFont cellFont = new XFont("Arial", 9, XFontStyle.Regular);
            XFont summaryFont = new XFont("Arial", 10, XFontStyle.Bold);
            XFont footerFont = new XFont("Arial", 8, XFontStyle.Regular);
            XBrush headerBrush = new XSolidBrush(XColor.FromArgb(100, 180, 220)); // Blue from _darkColor
            XBrush altRowBrush = new XSolidBrush(XColor.FromArgb(240, 240, 240)); // Light gray
            XPen borderPen = new XPen(XColors.Black, 0.5);

            // Define margins and layout
            double margin = 40;
            double headerHeight = 40;
            double footerHeight = 20;
            double rowHeight = 20;
            double[] colWidths = { 120, 60, 60, 60, 60, 60, 60, 60, 70 }; // Adjusted for Exam Name, scores, Date

            // Calculate total table width and ensure it fits within page
            double tableWidth = 0;
            foreach (double w in colWidths) tableWidth += w;
            double pageWidth = 595; // A4 width in points
            if (tableWidth > pageWidth - 2 * margin)
            {
                // Scale column widths proportionally
                double scale = (pageWidth - 2 * margin) / tableWidth;
                for (int i = 0; i < colWidths.Length; i++) colWidths[i] *= scale;
                tableWidth = pageWidth - 2 * margin;
            }

            // Header mapping dictionary without "Net"
            Dictionary<string, string> headerMap = new Dictionary<string, string>
            {
                { "Exam", "Exam Name" },
                { "MathNet", "Math" },
                { "ScienceNet", "Science" },
                { "TurkishNet", "Turkish" },
                { "HistoryNet", "History" },
                { "ReligionNet", "Religion" },
                { "EnglishNet", "English" },
                { "TotalNet", "Total" },
                { "ExamDate", "Exam Date" }
            };

            int pageCount = 0;

            // Process data for summary
            int totalExams = dt.Rows.Count;
            double totalNetSum = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["TotalNet"] != DBNull.Value && double.TryParse(row["TotalNet"].ToString(), out double totalNet))
                {
                    totalNetSum += totalNet;
                }
            }
            double avgTotalNet = totalExams > 0 ? totalNetSum / totalExams : 0;

            // Add pages and draw content
            PdfPage page = null;
            XGraphics gfx = null;
            int y = 0;
            int rowIndex = 0;
            int rowsPerPage = (int)((595 - 2 * margin - headerHeight - footerHeight - 60) / rowHeight); // Estimate rows per page

            while (rowIndex <= dt.Rows.Count) // Include summary after data
            {
                // Check if new page is needed
                if (page == null || y + rowHeight > page.Height - margin - footerHeight - 60)
                {
                    // Start a new page
                    page = doc.AddPage();
                    pageCount++;
                    gfx = XGraphics.FromPdfPage(page);
                    y = (int)margin;

                    // Draw header
                    gfx.DrawRectangle(XPens.Black, margin, margin - 10, page.Width - 2 * margin, headerHeight);
                    gfx.DrawString("LGS Tracking Application", headerFont, XBrushes.Black, new XRect(margin + 10, y, 200, headerHeight), XStringFormats.CenterLeft);
                    gfx.DrawString("Exam Results for " + studentName, titleFont, XBrushes.Black, new XRect(margin, y, page.Width - 2 * margin, headerHeight), XStringFormats.Center);
                    gfx.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), headerFont, XBrushes.Black, new XRect(page.Width - margin - 150, y, 140, headerHeight), XStringFormats.CenterRight);
                    y += (int)headerHeight + 20;

                    // Draw table headers
                    double x = margin;
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string columnName = dt.Columns[i].ColumnName;
                        string headerText = headerMap.ContainsKey(columnName) ? headerMap[columnName] : columnName;
                        gfx.DrawRectangle(headerBrush, x, y, colWidths[i], rowHeight);
                        gfx.DrawRectangle(borderPen, x, y, colWidths[i], rowHeight);
                        gfx.DrawString(headerText, headerFont, XBrushes.White, new XRect(x + 5, y + 2, colWidths[i] - 10, rowHeight - 4), XStringFormats.Center);
                        x += colWidths[i];
                    }
                    y += (int)rowHeight;
                }

                // Draw table rows
                if (rowIndex < dt.Rows.Count)
                {
                    DataRow row = dt.Rows[rowIndex];
                    double x = margin;
                    XBrush rowBrush = (rowIndex % 2 == 0) ? XBrushes.White : altRowBrush;

                    // Ensure enough space for the row
                    if (y + rowHeight <= page.Height - margin - footerHeight)
                    {
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            string value = row[i] != DBNull.Value ? row[i].ToString() : "";
                            if (dt.Columns[i].ColumnName.EndsWith("Net") && double.TryParse(value, out double num))
                            {
                                value = num.ToString("F2");
                            }
                            else if (dt.Columns[i].ColumnName == "ExamDate" && DateTime.TryParse(value, out DateTime date))
                            {
                                value = date.ToString("MM/dd/yyyy");
                            }

                            // Draw cell: background, border, text
                            gfx.DrawRectangle(rowBrush, x, y, colWidths[i], rowHeight);
                            gfx.DrawRectangle(borderPen, x, y, colWidths[i], rowHeight);
                            XStringFormat format = dt.Columns[i].ColumnName.EndsWith("Net") ? XStringFormats.CenterRight : XStringFormats.CenterLeft;
                            gfx.DrawString(value, cellFont, XBrushes.Black, new XRect(x + 5, y + 2, colWidths[i] - 10, rowHeight - 4), format);
                            x += colWidths[i];
                        }
                        y += (int)rowHeight;
                        rowIndex++;
                    }
                    else
                    {
                        // Not enough space for row; force new page
                        continue;
                    }
                }
                else
                {
                    // Draw summary
                    if (y + 3 * rowHeight <= page.Height - margin - footerHeight)
                    {
                        y += 10;
                        gfx.DrawString("Summary", summaryFont, XBrushes.Black, new XRect(margin, y, tableWidth, rowHeight), XStringFormats.TopLeft);
                        y += (int)rowHeight;
                        gfx.DrawString("Total Exams: " + totalExams.ToString(), cellFont, XBrushes.Black, new XRect(margin, y, tableWidth, rowHeight), XStringFormats.TopLeft);
                        y += (int)rowHeight;
                        gfx.DrawString("Average Total: " + avgTotalNet.ToString("F2"), cellFont, XBrushes.Black, new XRect(margin, y, tableWidth, rowHeight), XStringFormats.TopLeft);
                        y += (int)rowHeight;
                        rowIndex++;
                    }
                    else
                    {
                        // Not enough space for summary; force new page
                        continue;
                    }
                }

                // Draw footer
                string footerText = "Page " + pageCount.ToString() + " | Generated by LGSApp";
                gfx.DrawString(footerText, footerFont, XBrushes.Black, new XRect(margin, page.Height - margin - footerHeight, page.Width - 2 * margin, footerHeight), XStringFormats.Center);
            }

            doc.Save(filePath);
        }

        private void ExportPdfControl_Load_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}