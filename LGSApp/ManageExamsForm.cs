using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class ManageExamsForm : Form
    {
        private readonly string connStr;

        public ManageExamsForm()
        {
            InitializeComponent();
            connStr = ConfigurationManager
                .ConnectionStrings["LGSConnection"]
                .ConnectionString;

            this.Load += ManageExamsForm_Load;
            btnAddExam.Click += BtnAddExam_Click;
            btnDeleteExam.Click += BtnDeleteExam_Click;
            dgvExams.SelectionChanged += DgvExams_SelectionChanged;

            this.CenterToScreen();
        }

        private void ManageExamsForm_Load(object sender, EventArgs e)
        {
            LoadExams();
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