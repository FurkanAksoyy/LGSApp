using System;
using System.Drawing;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class ManualEntryForm : Form
    {
        public ExamResult Result { get; private set; }

        public ManualEntryForm()
        {
            InitializeComponent();
            this.Load += ManualEntryForm_Load;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void ManualEntryForm_Load(object sender, EventArgs e)
        {
            // Set default date to today
            dtpExamDate.Value = DateTime.Now;

            // Focus on student name field
            txtStudentName.Focus();

            // NO PRE-FILLED VALUES - USER MUST ENTER MANUALLY
            txtStudentName.Text = "";
            txtExamTitle.Text = "";

            // Reset all numeric values to 0
            numMathNet.Value = 0;
            numScienceNet.Value = 0;
            numTurkishNet.Value = 0;
            numHistoryNet.Value = 0;
            numReligionNet.Value = 0;
            numEnglishNet.Value = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Result = new ExamResult
                {
                    StudentName = txtStudentName.Text.Trim(),
                    ExamTitle = txtExamTitle.Text.Trim(),
                    ExamDate = dtpExamDate.Value.ToString("yyyy-MM-dd"),
                    MathNet = numMathNet.Value,
                    ScienceNet = numScienceNet.Value,
                    TurkishNet = numTurkishNet.Value,
                    HistoryNet = numHistoryNet.Value,
                    ReligionNet = numReligionNet.Value,
                    EnglishNet = numEnglishNet.Value
                };

                // Calculate total
                Result.TotalNet = Result.MathNet + Result.ScienceNet + Result.TurkishNet +
                                 Result.HistoryNet + Result.ReligionNet + Result.EnglishNet;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter student name.\n\nExample: ECE OLCA", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExamTitle.Text))
            {
                MessageBox.Show("Please enter exam title.\n\nExample: KD STARTER LGS-1", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamTitle.Focus();
                return false;
            }

            // Check if at least one subject has a score
            if (numMathNet.Value == 0 && numScienceNet.Value == 0 && numTurkishNet.Value == 0 &&
                numHistoryNet.Value == 0 && numReligionNet.Value == 0 && numEnglishNet.Value == 0)
            {
                MessageBox.Show("Please enter at least one subject score.\n\nAll scores cannot be zero.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numMathNet.Focus();
                return false;
            }

            return true;


        }
    }
}
