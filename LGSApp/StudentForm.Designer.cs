namespace LGSApp
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnManageExams;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnChartsReports;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Panel line4;
        private System.Windows.Forms.Panel line5;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvOverallResults;
        private System.Windows.Forms.DataGridView dgvSubjectNets;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel lineVertical;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.line5 = new System.Windows.Forms.Panel();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.line4 = new System.Windows.Forms.Panel();
            this.btnChartsReports = new System.Windows.Forms.Button();
            this.line3 = new System.Windows.Forms.Panel();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.line2 = new System.Windows.Forms.Panel();
            this.btnManageExams = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvSubjectNets = new System.Windows.Forms.DataGridView();
            this.dgvOverallResults = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lineVertical = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectNets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverallResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.line5);
            this.panelMenu.Controls.Add(this.btnExportPdf);
            this.panelMenu.Controls.Add(this.line4);
            this.panelMenu.Controls.Add(this.btnChartsReports);
            this.panelMenu.Controls.Add(this.line3);
            this.panelMenu.Controls.Add(this.btnAddExam);
            this.panelMenu.Controls.Add(this.line2);
            this.panelMenu.Controls.Add(this.btnManageExams);
            this.panelMenu.Controls.Add(this.line1);
            this.panelMenu.Controls.Add(this.btnViewResults);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 480);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 443);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 37);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.Black;
            this.line5.Dock = System.Windows.Forms.DockStyle.Top;
            this.line5.Location = new System.Drawing.Point(0, 204);
            this.line5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(178, 1);
            this.line5.TabIndex = 6;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportPdf.FlatAppearance.BorderSize = 0;
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(0, 164);
            this.btnExportPdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(178, 40);
            this.btnExportPdf.TabIndex = 7;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.Black;
            this.line4.Dock = System.Windows.Forms.DockStyle.Top;
            this.line4.Location = new System.Drawing.Point(0, 163);
            this.line4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(178, 1);
            this.line4.TabIndex = 6;
            // 
            // btnChartsReports
            // 
            this.btnChartsReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChartsReports.FlatAppearance.BorderSize = 0;
            this.btnChartsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChartsReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChartsReports.ForeColor = System.Drawing.Color.White;
            this.btnChartsReports.Location = new System.Drawing.Point(0, 123);
            this.btnChartsReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChartsReports.Name = "btnChartsReports";
            this.btnChartsReports.Size = new System.Drawing.Size(178, 40);
            this.btnChartsReports.TabIndex = 5;
            this.btnChartsReports.Text = "Charts && Graphs";
            this.btnChartsReports.UseVisualStyleBackColor = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Black;
            this.line3.Dock = System.Windows.Forms.DockStyle.Top;
            this.line3.Location = new System.Drawing.Point(0, 122);
            this.line3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(178, 1);
            this.line3.TabIndex = 4;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddExam.FlatAppearance.BorderSize = 0;
            this.btnAddExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExam.ForeColor = System.Drawing.Color.White;
            this.btnAddExam.Location = new System.Drawing.Point(0, 82);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(178, 40);
            this.btnAddExam.TabIndex = 5;
            this.btnAddExam.Text = "Add Exam";
            this.btnAddExam.UseVisualStyleBackColor = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Black;
            this.line2.Dock = System.Windows.Forms.DockStyle.Top;
            this.line2.Location = new System.Drawing.Point(0, 81);
            this.line2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(178, 1);
            this.line2.TabIndex = 3;
            // 
            // btnManageExams
            // 
            this.btnManageExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageExams.FlatAppearance.BorderSize = 0;
            this.btnManageExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageExams.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageExams.ForeColor = System.Drawing.Color.White;
            this.btnManageExams.Location = new System.Drawing.Point(0, 41);
            this.btnManageExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageExams.Name = "btnManageExams";
            this.btnManageExams.Size = new System.Drawing.Size(178, 40);
            this.btnManageExams.TabIndex = 3;
            this.btnManageExams.Text = "Manage Exams";
            this.btnManageExams.UseVisualStyleBackColor = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Black;
            this.line1.Dock = System.Windows.Forms.DockStyle.Top;
            this.line1.Location = new System.Drawing.Point(0, 40);
            this.line1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(178, 1);
            this.line1.TabIndex = 2;
            // 
            // btnViewResults
            // 
            this.btnViewResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewResults.FlatAppearance.BorderSize = 0;
            this.btnViewResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResults.ForeColor = System.Drawing.Color.White;
            this.btnViewResults.Location = new System.Drawing.Point(0, 0);
            this.btnViewResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(178, 40);
            this.btnViewResults.TabIndex = 1;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = false;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.panelContent);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Location = new System.Drawing.Point(204, 51);
            this.panelCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.panelCard.Size = new System.Drawing.Size(667, 376);
            this.panelCard.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.dgvSubjectNets);
            this.panelContent.Controls.Add(this.dgvOverallResults);
            this.panelContent.Location = new System.Drawing.Point(18, 56);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(631, 304);
            this.panelContent.TabIndex = 1;
            // 
            // dgvSubjectNets
            // 
            this.dgvSubjectNets.AllowUserToAddRows = false;
            this.dgvSubjectNets.AllowUserToDeleteRows = false;
            this.dgvSubjectNets.AllowUserToResizeRows = false;
            this.dgvSubjectNets.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjectNets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjectNets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjectNets.ColumnHeadersHeight = 40;
            this.dgvSubjectNets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjectNets.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubjectNets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjectNets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSubjectNets.Location = new System.Drawing.Point(0, 152);
            this.dgvSubjectNets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSubjectNets.Name = "dgvSubjectNets";
            this.dgvSubjectNets.ReadOnly = true;
            this.dgvSubjectNets.RowHeadersVisible = false;
            this.dgvSubjectNets.RowHeadersWidth = 62;
            this.dgvSubjectNets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjectNets.Size = new System.Drawing.Size(631, 152);
            this.dgvSubjectNets.TabIndex = 1;
            // 
            // dgvOverallResults
            // 
            this.dgvOverallResults.AllowUserToAddRows = false;
            this.dgvOverallResults.AllowUserToDeleteRows = false;
            this.dgvOverallResults.AllowUserToResizeRows = false;
            this.dgvOverallResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvOverallResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverallResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOverallResults.ColumnHeadersHeight = 40;
            this.dgvOverallResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverallResults.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOverallResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOverallResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOverallResults.Location = new System.Drawing.Point(0, 0);
            this.dgvOverallResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOverallResults.Name = "dgvOverallResults";
            this.dgvOverallResults.ReadOnly = true;
            this.dgvOverallResults.RowHeadersVisible = false;
            this.dgvOverallResults.RowHeadersWidth = 62;
            this.dgvOverallResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverallResults.Size = new System.Drawing.Size(631, 152);
            this.dgvOverallResults.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(73, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LGS Tracking Application - Student Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineVertical
            // 
            this.lineVertical.BackColor = System.Drawing.Color.Black;
            this.lineVertical.Location = new System.Drawing.Point(178, 0);
            this.lineVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineVertical.Name = "lineVertical";
            this.lineVertical.Size = new System.Drawing.Size(1, 480);
            this.lineVertical.TabIndex = 2;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 480);
            this.Controls.Add(this.lineVertical);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.StudentForm_Load_1);
            this.panelMenu.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectNets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverallResults)).EndInit();
            this.ResumeLayout(false);

        }
    }
}