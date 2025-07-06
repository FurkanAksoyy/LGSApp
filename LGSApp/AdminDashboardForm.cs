using System;
using System.Drawing;
using System.Windows.Forms;

namespace LGSApp
{
    public partial class AdminDashboardForm : Form
    {
        private Button _currentActiveButton;

        public AdminDashboardForm()
        {
            InitializeComponent();
            // Form load event
            this.Load += AdminDashboardForm_Load;

            // Menu button click events
            btnManageStudents.Click += btnManageStudents_Click;
            btnAddExams.Click += btnAddExams_Click;
            btnAddExamNew.Click += btnAddExamNew_Click;
            btnViewResultsList.Click += btnViewResultsList_Click;
            btnChartsReports.Click += btnChartsReports_Click;
            btnOCR.Click += btnOCR_Click;
            btnPdfImport.Click += btnPdfImport_Click; // New PDF Import button
            btnExportPdf.Click += btnExportPdf_Click;
            btnLogout.Click += btnLogout_Click;

            this.CenterToScreen();

            // Make form responsive
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1200, 700);
        }

        // Load UserControl into content panel
        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        // Set active button styling
        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons to default style
            ResetButtonStyles();

            // Set active button style
            activeButton.BackColor = Color.FromArgb(230, 100, 0); // Darker orange
            activeButton.ForeColor = Color.White;
            activeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            _currentActiveButton = activeButton;
        }

        private void ResetButtonStyles()
        {
            var buttons = new[] { btnManageStudents, btnAddExams, btnAddExamNew,
                                 btnViewResultsList, btnChartsReports, btnOCR, btnPdfImport, btnExportPdf };

            foreach (var btn in buttons)
            {
                btn.BackColor = Color.FromArgb(255, 128, 0); // Orange
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }
        }

        // Form load - show manage students by default
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            btnManageStudents_Click(null, null);
        }

        // Event handlers for menu buttons
        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnManageStudents);
            LoadControl(new ManageStudentsControl());
        }

        // Manage Exams - opens separate form
        private void btnAddExams_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAddExams);
            using (var frm = new ManageExamsForm())
                frm.ShowDialog();
        }

        // Add Exam - opens in separate window
        private void btnAddExamNew_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAddExamNew);
            using (var form = new Form())
            {
                form.Text = "Add Exam Results";
                form.Size = new Size(1200, 800);
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.StartPosition = FormStartPosition.CenterScreen;

                var addExamsControl = new AddExamsControl();
                addExamsControl.Dock = DockStyle.Fill;
                form.Controls.Add(addExamsControl);
                form.ShowDialog();
            }
        }

        private void btnViewResultsList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnViewResultsList);
            LoadControl(new ViewResultsControl());
        }

        private void btnChartsReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnChartsReports);
            var chartControl = new ChartsGraphsControl();
            chartControl.SetAdminContext();
            LoadControl(chartControl);
        }

        // OCR functionality
        private void btnOCR_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnOCR);
            LoadControl(new OCRControl());
        }

        // New PDF Import functionality
        private void btnPdfImport_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPdfImport);
            LoadControl(new PdfImportControl());
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnExportPdf);
            LoadControl(new ExportPdfControl(true));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) =>
                {
                    Application.Exit();
                };
                loginForm.Show();
                this.Hide();
            }
        }

        // Handle form resize for responsiveness
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
                return;

            // Adjust panel sizes based on form size
            AdjustLayout();
        }

        private void AdjustLayout()
        {
            if (panelCard != null && this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                // Calculate responsive sizes
                int cardWidth = this.ClientSize.Width - panelMenu.Width - 40; // 20px margin on each side
                int cardHeight = this.ClientSize.Height - 100; // 50px margin top and bottom

                // Minimum sizes
                cardWidth = Math.Max(cardWidth, 600);
                cardHeight = Math.Max(cardHeight, 400);

                // Update card panel size and position
                panelCard.Size = new Size(cardWidth, cardHeight);
                panelCard.Location = new Point(panelMenu.Width + 20, 50);

                // Update vertical line height
                if (lineVertical != null)
                {
                    lineVertical.Height = this.ClientSize.Height;
                }
            }
        }

        private void AdminDashboardForm_Load_1(object sender, EventArgs e)
        {
            // Additional load logic if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Panel paint logic if needed
        }
    }
}