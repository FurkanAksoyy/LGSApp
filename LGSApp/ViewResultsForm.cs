using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class ViewResultsForm : Form
    {
        public ViewResultsForm()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            string connStr = ConfigurationManager
                .ConnectionStrings["LGSConnection"]
                .ConnectionString;

            string sql = @"
                SELECT
                    s.StudentID,
                    s.Name AS StudentName,
                    e.Title AS ExamName,
                    r.Score AS TotalNet,
                    e.Date AS ExamDate
                FROM ExamResults r
                JOIN Students s ON r.StudentID = s.StudentID
                JOIN Exams   e ON r.ExamID    = e.ExamID
                ORDER BY r.Score DESC, e.Date DESC;
            ";

            var dt = new DataTable();
            using (var conn = new SqlConnection(connStr))
            using (var da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            dgvResults.DataSource = dt;

            if (dgvResults.Columns.Contains("StudentID"))
                dgvResults.Columns["StudentID"].Visible = false;

            if (dgvResults.Columns.Contains("StudentName"))
                dgvResults.Columns["StudentName"].HeaderText = "Student";
            if (dgvResults.Columns.Contains("ExamName"))
                dgvResults.Columns["ExamName"].HeaderText = "Exam";
            if (dgvResults.Columns.Contains("TotalNet"))
            {
                dgvResults.Columns["TotalNet"].HeaderText = "Total Net";
                dgvResults.Columns["TotalNet"].DefaultCellStyle.Format = "F2";
            }
            if (dgvResults.Columns.Contains("ExamDate"))
                dgvResults.Columns["ExamDate"].HeaderText = "Exam Date";
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle cell clicks if needed
        }

        private void ViewResultsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
