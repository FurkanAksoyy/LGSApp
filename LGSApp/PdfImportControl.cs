using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace LGSApp
{
    public partial class PdfImportControl : UserControl
    {
        private string _selectedPdfPath = "";
        private List<ExamResult> _extractedResults = new List<ExamResult>();

        public PdfImportControl()
        {
            InitializeComponent();
            this.Load += PdfImportControl_Load;
            btnSelectPdf.Click += BtnSelectPdf_Click;
            btnProcessPdf.Click += BtnProcessPdf_Click;
            btnSaveResults.Click += BtnSaveResults_Click;
            btnClearResults.Click += BtnClearResults_Click;
        }

        private void PdfImportControl_Load(object sender, EventArgs e)
        {
            btnProcessPdf.Enabled = false;
            btnSaveResults.Enabled = false;
            btnClearResults.Enabled = false;

            SetupDataGridView();

            txtExtractedText.Text = "AUTOMATIC PDF IMPORT SYSTEM\r\n\r\n1. Click 'Browse' to select PDF file\r\n2. Click 'Process PDF' - system will automatically extract all data\r\n3. Review results and click 'Save Results'\r\n\r\nNo manual work required!";

            lblStatus.Text = "Ready - Select PDF file to begin";
            lblStatus.ForeColor = Color.Green;
        }

        private void SetupDataGridView()
        {
            dgvResults.AutoGenerateColumns = false;
            dgvResults.Columns.Clear();

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentName", HeaderText = "Student Name", DataPropertyName = "StudentName", Width = 140 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExamTitle", HeaderText = "Exam Title", DataPropertyName = "ExamTitle", Width = 160 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExamDate", HeaderText = "Date", DataPropertyName = "ExamDate", Width = 80 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "TurkishNet", HeaderText = "Turkish", DataPropertyName = "TurkishNet", Width = 60 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "MathNet", HeaderText = "Math", DataPropertyName = "MathNet", Width = 60 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "ScienceNet", HeaderText = "Science", DataPropertyName = "ScienceNet", Width = 60 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "HistoryNet", HeaderText = "History", DataPropertyName = "HistoryNet", Width = 60 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReligionNet", HeaderText = "Religion", DataPropertyName = "ReligionNet", Width = 60 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "EnglishNet", HeaderText = "English", DataPropertyName = "EnglishNet", Width = 60 });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalNet", HeaderText = "TOTAL NET", DataPropertyName = "TotalNet", Width = 80, DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9, FontStyle.Bold) } });
        }

        private void BtnSelectPdf_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                openFileDialog.Title = "Select PDF File with Exam Results";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedPdfPath = openFileDialog.FileName;
                    txtPdfPath.Text = _selectedPdfPath;
                    btnProcessPdf.Enabled = true;
                    lblStatus.Text = "PDF selected - Click 'Process PDF' to extract data automatically";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
        }

        private void BtnProcessPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedPdfPath))
            {
                MessageBox.Show("Please select a PDF file first.", "No PDF Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnProcessPdf.Enabled = false;
                lblStatus.Text = "Extracting text from PDF...";
                lblStatus.ForeColor = Color.Blue;
                Application.DoEvents();

                string extractedText = ExtractTextFromPdf(_selectedPdfPath);

                if (string.IsNullOrWhiteSpace(extractedText))
                {
                    lblStatus.Text = "Failed to extract text from PDF";
                    lblStatus.ForeColor = Color.Red;
                    MessageBox.Show("Could not extract text from PDF. The PDF might be image-based or corrupted.",
                        "PDF Extraction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtExtractedText.Text = extractedText;

                lblStatus.Text = "Parsing exam results...";
                Application.DoEvents();

                var result = ParseExamResult(extractedText);
                if (result != null)
                {
                    _extractedResults.Clear();
                    _extractedResults.Add(result);

                    dgvResults.DataSource = null;
                    dgvResults.DataSource = _extractedResults;

                    btnSaveResults.Enabled = true;
                    btnClearResults.Enabled = true;

                    lblStatus.Text = $"SUCCESS: Found {result.StudentName} - {result.ExamTitle} - Total NET: {result.TotalNet}";
                    lblStatus.ForeColor = Color.Green;

                    MessageBox.Show($"Successfully extracted exam result!\n\nStudent: {result.StudentName}\nExam: {result.ExamTitle}\nTotal NET: {result.TotalNet}\n\nClick 'Save Results' to add to database.",
                        "Extraction Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblStatus.Text = "Could not parse exam result from PDF";
                    lblStatus.ForeColor = Color.Orange;
                    MessageBox.Show("PDF text was extracted but could not find valid exam result data.\n\nPlease check if this is a valid LGS exam result PDF.",
                        "Parsing Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "PDF processing failed";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show($"Error processing PDF: {ex.Message}", "PDF Processing Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnProcessPdf.Enabled = true;
            }
        }

        private string ExtractTextFromPdf(string pdfPath)
        {
            try
            {
                using (PdfReader reader = new PdfReader(pdfPath))
                {
                    string fullText = "";

                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        string pageText = PdfTextExtractor.GetTextFromPage(reader, page);
                        fullText += pageText + "\n\n";
                    }

                    return fullText;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to extract text from PDF: {ex.Message}");
            }
        }

        private ExamResult ParseExamResult(string text)
        {
            try
            {
                var result = new ExamResult();

                var namePatterns = new string[]
                {
                    @"Ad\s+Soyad\s+([A-ZÇĞIİÖŞÜ][A-ZÇĞIİÖŞÜa-zçğıiöşü\s]+?)\s+Numara",
                    @"^([A-ZÇĞIİÖŞÜ]+\s+[A-ZÇĞIİÖŞÜ]+)\s+\d+\s*$",
                    @"Öğrenci\s+([A-ZÇĞIİÖŞÜ][A-ZÇĞIİÖŞÜa-zçğıiöşü\s]+?)\s+Numara"
                };

                string[] lines = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var pattern in namePatterns)
                {
                    var match = Regex.Match(text, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                    if (match.Success)
                    {
                        result.StudentName = match.Groups[1].Value.Trim();
                        break;
                    }
                }

                if (string.IsNullOrEmpty(result.StudentName))
                {
                    foreach (string line in lines)
                    {
                        var nameMatch = Regex.Match(line.Trim(), @"^([A-ZÇĞIİÖŞÜ]+\s+[A-ZÇĞIİÖŞÜ]+)\s+\d*\s*$");
                        if (nameMatch.Success && nameMatch.Groups[1].Value.Length > 3)
                        {
                            result.StudentName = nameMatch.Groups[1].Value.Trim();
                            break;
                        }
                    }
                }

                var examPatterns = new string[]
                {
                    @"Sınav\s+Adı\s+(.*?)(?:\s+Kitapçık|\s+Kit|\s+Sınav)",
                    @"(KD\s+STARTER\s+LGS-.*?)(?:\s+Kit|\s+Sınav|\s+Kitapçık)",
                    @"(\d+\.\s*SINIF\s+LGS\s+\d+\.DENEME)",
                    @"(LGS.*DENEME|LGS.*STARTER|STARTER.*LGS)"
                };

                foreach (var pattern in examPatterns)
                {
                    var match = Regex.Match(text, pattern, RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        result.ExamTitle = match.Groups[1].Value.Trim();
                        break;
                    }
                }

                var datePatterns = new string[]
                {
                    @"(\d{2}\.\d{2}\.\d{4})",
                    @"Sınav\s+Tarihi\s+(\d{2}\.\d{2}\.\d{4})",
                    @"Tarih\s+(\d{2}\.\d{2}\.\d{4})"
                };

                foreach (var pattern in datePatterns)
                {
                    var match = Regex.Match(text, pattern);
                    if (match.Success)
                    {
                        if (DateTime.TryParseExact(match.Groups[1].Value, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime examDate))
                        {
                            result.ExamDate = examDate.ToString("yyyy-MM-dd");
                            break;
                        }
                    }
                }

                foreach (string line in lines)
                {
                    string cleanLine = line.Trim();

                    if (Regex.IsMatch(cleanLine, @"LGS-TÜRKÇE|TÜRKÇE.*\d", RegexOptions.IgnoreCase))
                    {
                        result.TurkishNet = ExtractNetFromLine(cleanLine, "TÜRKÇE");
                    }
                    else if (Regex.IsMatch(cleanLine, @"LGS-MATEMATİK|MATEMATİK.*\d", RegexOptions.IgnoreCase))
                    {
                        result.MathNet = ExtractNetFromLine(cleanLine, "MATEMATİK");
                    }
                    else if (Regex.IsMatch(cleanLine, @"LGS-FEN\s+BİLİMLERİ|FEN.*BİLİMLERİ.*\d", RegexOptions.IgnoreCase))
                    {
                        result.ScienceNet = ExtractNetFromLine(cleanLine, "FEN");
                    }
                    else if (Regex.IsMatch(cleanLine, @"LGS-İNKILAP\s+TARİHİ|İNKILAP.*TARİHİ.*\d|TARİHİ.*\d", RegexOptions.IgnoreCase))
                    {
                        result.HistoryNet = ExtractNetFromLine(cleanLine, "TARİHİ");
                    }
                    else if (Regex.IsMatch(cleanLine, @"LGS-DİN\s+KÜLTÜRÜ|DİN.*KÜLTÜRÜ.*\d", RegexOptions.IgnoreCase))
                    {
                        result.ReligionNet = ExtractNetFromLine(cleanLine, "DİN");
                    }
                    else if (Regex.IsMatch(cleanLine, @"LGS-İNGİLİZCE|İNGİLİZCE.*\d", RegexOptions.IgnoreCase))
                    {
                        result.EnglishNet = ExtractNetFromLine(cleanLine, "İNGİLİZCE");
                    }
                    else if (Regex.IsMatch(cleanLine, @"TOPLAM.*\d", RegexOptions.IgnoreCase) && !cleanLine.Contains("LGS-"))
                    {
                        result.TotalNet = ExtractNetFromLine(cleanLine, "TOPLAM", isTotal: true);
                    }
                }

                decimal calculatedTotal = result.TurkishNet + result.MathNet + result.ScienceNet +
                                         result.HistoryNet + result.ReligionNet + result.EnglishNet;

                if (result.TotalNet == 0 && calculatedTotal > 0)
                {
                    result.TotalNet = calculatedTotal;
                }

                if (string.IsNullOrEmpty(result.StudentName))
                    result.StudentName = "Unknown Student";
                if (string.IsNullOrEmpty(result.ExamTitle))
                    result.ExamTitle = "LGS Practice Exam";
                if (string.IsNullOrEmpty(result.ExamDate))
                    result.ExamDate = DateTime.Now.ToString("yyyy-MM-dd");

                txtExtractedText.Text += $"\n\n=== FINAL EXTRACTION RESULTS ===\n";
                txtExtractedText.Text += $"Student: {result.StudentName}\n";
                txtExtractedText.Text += $"Exam: {result.ExamTitle}\n";
                txtExtractedText.Text += $"Date: {result.ExamDate}\n";
                txtExtractedText.Text += $"Turkish: {result.TurkishNet}\n";
                txtExtractedText.Text += $"Math: {result.MathNet}\n";
                txtExtractedText.Text += $"Science: {result.ScienceNet}\n";
                txtExtractedText.Text += $"History: {result.HistoryNet}\n";
                txtExtractedText.Text += $"Religion: {result.ReligionNet}\n";
                txtExtractedText.Text += $"English: {result.EnglishNet}\n";
                txtExtractedText.Text += $"Total: {result.TotalNet}\n";

                return (result.TotalNet > 0 || calculatedTotal > 0) ? result : null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error parsing exam result: {ex.Message}");
            }
        }

        private decimal ExtractNetFromLine(string line, string subject, bool isTotal = false)
        {
            try
            {
                if (line.Contains("SORU") && line.Contains("DOĞRU") && line.Contains("NET"))
                {
                    return 0;
                }

                string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string part in parts)
                {
                    if (part.Contains(","))
                    {
                        if (decimal.TryParse(part.Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal score))
                        {
                            if (isTotal)
                            {
                                if (score >= 50 && score <= 120) return score;
                            }
                            else
                            {
                                if (score >= 0 && score <= 25) return score;
                            }
                        }
                    }
                    else if (part.Contains(".") && !part.EndsWith("."))
                    {
                        if (decimal.TryParse(part, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal score))
                        {
                            if (isTotal)
                            {
                                if (score >= 50 && score <= 120) return score;
                            }
                            else
                            {
                                if (score >= 0 && score <= 25) return score;
                            }
                        }
                    }
                }

                var decimalMatches = Regex.Matches(line, @"(\d{1,3})[,.](\d{2})");
                foreach (Match match in decimalMatches)
                {
                    if (decimal.TryParse($"{match.Groups[1].Value}.{match.Groups[2].Value}",
                        NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal score))
                    {
                        if (isTotal)
                        {
                            if (score >= 50 && score <= 120) return score;
                        }
                        else
                        {
                            if (score >= 0 && score <= 25) return score;
                        }
                    }
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }

        private void BtnSaveResults_Click(object sender, EventArgs e)
        {
            if (_extractedResults.Count == 0)
            {
                MessageBox.Show("No results to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnSaveResults.Enabled = false;
                lblStatus.Text = "Saving to database...";
                lblStatus.ForeColor = Color.Blue;
                Application.DoEvents();

                int savedCount = SaveResultsToDatabase(_extractedResults);

                lblStatus.Text = $"Successfully saved {savedCount} result(s) to database";
                lblStatus.ForeColor = Color.Green;

                MessageBox.Show($"Successfully saved {savedCount} exam result(s) to database!\n\nThe results are now available in the View Results section.",
                    "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnClearResults_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to database: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Failed to save to database";
                lblStatus.ForeColor = Color.Red;
            }
            finally
            {
                btnSaveResults.Enabled = true;
            }
        }

        private int SaveResultsToDatabase(List<ExamResult> results)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LGSConnection"].ConnectionString;
            int savedCount = 0;

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var result in results)
                        {
                            int userId = CreateUser(conn, transaction, result.StudentName);
                            int studentId = CreateStudent(conn, transaction, result.StudentName, userId);
                            int examId = GetOrCreateExam(conn, transaction, result.ExamTitle, result.ExamDate);

                            SaveExamResult(conn, transaction, studentId, examId, result);
                            SaveSubjectResults(conn, transaction, studentId, examId, result);

                            savedCount++;
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            return savedCount;
        }

        private int CreateUser(SqlConnection conn, SqlTransaction transaction, string studentName)
        {
            string firstName = studentName.Split(' ')[0].Trim();
            string username = firstName;
            string password = GenerateRandomPassword(5);

            int suffix = 1;
            string baseUsername = username;
            while (true)
            {
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                        break;
                    username = $"{baseUsername}{suffix++}";
                }
            }

            try
            {
                using (var cmd = new SqlCommand("INSERT INTO Users (Username, PasswordHash, Role) VALUES (@username, @password, 'Student'); SELECT SCOPE_IDENTITY();", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // In a real application, hash the password
                    cmd.Parameters.AddWithValue("@role", "Student");
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Failed to create user: {ex.Message}");
            }
        }

        private string GenerateRandomPassword(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }

        private int CreateStudent(SqlConnection conn, SqlTransaction transaction, string studentName, int userId)
        {
            string guid = Guid.NewGuid().ToString("N");
            string nationalId = $"PDF{guid.Substring(0, 15)}";
            string familySerial = $"PDF{guid.Substring(16, 10)}";

            try
            {
                using (var cmd = new SqlCommand(@"
                    INSERT INTO Students (Name, NationalID, Gender, UserID, FamilySerialNumber, EmergencyContactName, EmergencyContactPhone, StudentPhoneNumber) 
                    VALUES (@name, @nationalID, @gender, @userId, @familySerial, @emergencyName, @emergencyPhone, @studentPhone); 
                    SELECT SCOPE_IDENTITY();", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@name", studentName.Trim());
                    cmd.Parameters.AddWithValue("@nationalID", nationalId);
                    cmd.Parameters.AddWithValue("@gender", "Unknown");
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@familySerial", familySerial);
                    cmd.Parameters.AddWithValue("@emergencyName", "PDF Import");
                    cmd.Parameters.AddWithValue("@emergencyPhone", "Not Specified");
                    cmd.Parameters.AddWithValue("@studentPhone", "Not Specified");
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // UNIQUE constraint violation
                {
                    string timestampedName = $"{studentName.Trim()} (Import {DateTime.Now:HHmmss})";
                    string newGuid = Guid.NewGuid().ToString("N");

                    using (var cmd = new SqlCommand(@"
                        INSERT INTO Students (Name, NationalID, Gender, UserID, FamilySerialNumber, EmergencyContactName, EmergencyContactPhone, StudentPhoneNumber) 
                        VALUES (@name, @nationalID, @gender, @userId, @familySerial, @emergencyName, @emergencyPhone, @studentPhone); 
                        SELECT SCOPE_IDENTITY();", conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@name", timestampedName);
                        cmd.Parameters.AddWithValue("@nationalID", $"PDF{newGuid.Substring(0, 15)}");
                        cmd.Parameters.AddWithValue("@gender", "Unknown");
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@familySerial", $"PDF{newGuid.Substring(16, 10)}");
                        cmd.Parameters.AddWithValue("@emergencyName", "PDF Import");
                        cmd.Parameters.AddWithValue("@emergencyPhone", "Not Specified");
                        cmd.Parameters.AddWithValue("@studentPhone", "Not Specified");
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                throw;
            }
        }

        private int GetOrCreateExam(SqlConnection conn, SqlTransaction transaction, string examTitle, string examDate)
        {
            using (var cmd = new SqlCommand("SELECT ExamID FROM Exams WHERE Title = @title AND Date = @date", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@title", examTitle);
                cmd.Parameters.AddWithValue("@date", examDate);
                var result = cmd.ExecuteScalar();
                if (result != null) return (int)result;
            }

            try
            {
                using (var cmd = new SqlCommand("INSERT INTO Exams (Title, Date) VALUES (@title, @date); SELECT SCOPE_IDENTITY();", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@title", examTitle);
                    cmd.Parameters.AddWithValue("@date", examDate);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // UNIQUE constraint violation
                {
                    string uniqueTitle = $"{examTitle} ({DateTime.Now:HHmmss})";
                    using (var cmd = new SqlCommand("INSERT INTO Exams (Title, Date) VALUES (@title, @date); SELECT SCOPE_IDENTITY();", conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@title", uniqueTitle);
                        cmd.Parameters.AddWithValue("@date", examDate);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                throw;
            }
        }

        private void SaveExamResult(SqlConnection conn, SqlTransaction transaction, int studentId, int examId, ExamResult result)
        {
            using (var checkCmd = new SqlCommand("SELECT COUNT(*) FROM ExamResults WHERE StudentID = @studentId AND ExamID = @examId", conn, transaction))
            {
                checkCmd.Parameters.AddWithValue("@studentId", studentId);
                checkCmd.Parameters.AddWithValue("@examId", examId);
                int existingCount = (int)checkCmd.ExecuteScalar();

                string sql = existingCount > 0
                    ? "UPDATE ExamResults SET Score = @score, DateTaken = @dateTaken WHERE StudentID = @studentId AND ExamID = @examId"
                    : "INSERT INTO ExamResults (StudentID, ExamID, Score, DateTaken) VALUES (@studentId, @examId, @score, @dateTaken)";

                using (var cmd = new SqlCommand(sql, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@examId", examId);
                    cmd.Parameters.AddWithValue("@score", result.TotalNet);
                    cmd.Parameters.AddWithValue("@dateTaken", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SaveSubjectResults(SqlConnection conn, SqlTransaction transaction, int studentId, int examId, ExamResult result)
        {
            var subjects = new Dictionary<string, decimal>
            {
                { "Turkish", result.TurkishNet },
                { "Math", result.MathNet },
                { "Science", result.ScienceNet },
                { "History", result.HistoryNet },
                { "Religion", result.ReligionNet },
                { "English", result.EnglishNet }
            };

            foreach (var subject in subjects.Where(s => s.Value > 0))
            {
                using (var checkCmd = new SqlCommand("SELECT COUNT(*) FROM ExamSubjects WHERE StudentID = @studentId AND ExamID = @examId AND SubjectName = @subjectName", conn, transaction))
                {
                    checkCmd.Parameters.AddWithValue("@studentId", studentId);
                    checkCmd.Parameters.AddWithValue("@examId", examId);
                    checkCmd.Parameters.AddWithValue("@subjectName", subject.Key);
                    int existingCount = (int)checkCmd.ExecuteScalar();

                    string sql = existingCount > 0
                        ? "UPDATE ExamSubjects SET Net = @net, Correct = @correct WHERE StudentID = @studentId AND ExamID = @examId AND SubjectName = @subjectName"
                        : "INSERT INTO ExamSubjects (StudentID, ExamID, SubjectName, Net, Correct, Wrong, Blank) VALUES (@studentId, @examId, @subjectName, @net, @correct, 0, 0)";

                    using (var cmd = new SqlCommand(sql, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@examId", examId);
                        cmd.Parameters.AddWithValue("@subjectName", subject.Key);
                        cmd.Parameters.AddWithValue("@net", subject.Value);
                        cmd.Parameters.AddWithValue("@correct", (int)Math.Round(subject.Value));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void BtnClearResults_Click(object sender, EventArgs e)
        {
            _extractedResults.Clear();
            dgvResults.DataSource = null;
            txtPdfPath.Clear();
            txtExtractedText.Text = "AUTOMATIC PDF IMPORT SYSTEM\r\n\r\n1. Click 'Browse' to select PDF file\r\n2. Click 'Process PDF' - system will automatically extract all data\r\n3. Review results and click 'Save Results'\r\n\r\nNo manual work required!";
            _selectedPdfPath = "";

            btnProcessPdf.Enabled = false;
            btnSaveResults.Enabled = false;
            btnClearResults.Enabled = false;

            lblStatus.Text = "Ready - Select PDF file to begin";
            lblStatus.ForeColor = Color.Green;
        }
    }
}