using System;
using System.Drawing;
using System.Windows.Forms;

namespace LGSApp
{
    partial class PdfImportControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMain;
        private Panel panelTop;
        private Panel panelBottom;
        private Label lblTitle;
        private GroupBox groupBoxPdfSelection;
        private TextBox txtPdfPath;
        private Button btnSelectPdf;
        private Button btnProcessPdf;
        private GroupBox groupBoxExtractedText;
        private TextBox txtExtractedText;
        private GroupBox groupBoxResults;
        private DataGridView dgvResults;
        private Panel panelButtons;
        private Button btnSaveResults;
        private Button btnClearResults;
        private Label lblStatus;

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
            this.panelMain = new Panel();
            this.panelBottom = new Panel();
            this.groupBoxResults = new GroupBox();
            this.dgvResults = new DataGridView();
            this.panelButtons = new Panel();
            this.lblStatus = new Label();
            this.btnClearResults = new Button();
            this.btnSaveResults = new Button();
            this.panelTop = new Panel();
            this.groupBoxExtractedText = new GroupBox();
            this.txtExtractedText = new TextBox();
            this.groupBoxPdfSelection = new GroupBox();
            this.btnProcessPdf = new Button();
            this.btnSelectPdf = new Button();
            this.txtPdfPath = new TextBox();
            this.lblTitle = new Label();

            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBoxExtractedText.SuspendLayout();
            this.groupBoxPdfSelection.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.White;
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new Point(0, 0);
            this.panelMain.Margin = new Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new Padding(20);
            this.panelMain.Size = new Size(1200, 800);
            this.panelMain.TabIndex = 0;

            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.groupBoxResults);
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = DockStyle.Fill;
            this.panelBottom.Location = new Point(20, 320);
            this.panelBottom.Margin = new Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(1160, 460);
            this.panelBottom.TabIndex = 2;

            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dgvResults);
            this.groupBoxResults.Dock = DockStyle.Fill;
            this.groupBoxResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxResults.ForeColor = Color.FromArgb(255, 128, 0);
            this.groupBoxResults.Location = new Point(0, 0);
            this.groupBoxResults.Margin = new Padding(4);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new Padding(10);
            this.groupBoxResults.Size = new Size(1160, 410);
            this.groupBoxResults.TabIndex = 1;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Extracted Exam Results from PDF";

            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = Color.White;
            this.dgvResults.BorderStyle = BorderStyle.None;
            this.dgvResults.ColumnHeadersHeight = 40;
            this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResults.Dock = DockStyle.Fill;
            this.dgvResults.GridColor = Color.FromArgb(224, 224, 224);
            this.dgvResults.Location = new Point(10, 27);
            this.dgvResults.Margin = new Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new Size(1140, 373);
            this.dgvResults.TabIndex = 0;

            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.lblStatus);
            this.panelButtons.Controls.Add(this.btnClearResults);
            this.panelButtons.Controls.Add(this.btnSaveResults);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Location = new Point(0, 410);
            this.panelButtons.Margin = new Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(1160, 50);
            this.panelButtons.TabIndex = 0;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblStatus.Location = new Point(10, 15);
            this.lblStatus.Margin = new Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(55, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";

            // 
            // btnClearResults
            // 
            this.btnClearResults.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnClearResults.BackColor = Color.FromArgb(220, 53, 69);
            this.btnClearResults.FlatAppearance.BorderSize = 0;
            this.btnClearResults.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            this.btnClearResults.FlatStyle = FlatStyle.Flat;
            this.btnClearResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClearResults.ForeColor = Color.White;
            this.btnClearResults.Location = new Point(970, 10);
            this.btnClearResults.Margin = new Padding(4);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new Size(120, 35);
            this.btnClearResults.TabIndex = 1;
            this.btnClearResults.Text = "Clear All";
            this.btnClearResults.UseVisualStyleBackColor = false;

            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnSaveResults.BackColor = Color.FromArgb(40, 167, 69);
            this.btnSaveResults.FlatAppearance.BorderSize = 0;
            this.btnSaveResults.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 136, 56);
            this.btnSaveResults.FlatStyle = FlatStyle.Flat;
            this.btnSaveResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSaveResults.ForeColor = Color.White;
            this.btnSaveResults.Location = new Point(842, 10);
            this.btnSaveResults.Margin = new Padding(4);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new Size(120, 35);
            this.btnSaveResults.TabIndex = 0;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = false;

            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBoxExtractedText);
            this.panelTop.Controls.Add(this.groupBoxPdfSelection);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new Point(20, 60);
            this.panelTop.Margin = new Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(1160, 260);
            this.panelTop.TabIndex = 1;

            // 
            // groupBoxExtractedText
            // 
            this.groupBoxExtractedText.Controls.Add(this.txtExtractedText);
            this.groupBoxExtractedText.Dock = DockStyle.Fill;
            this.groupBoxExtractedText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxExtractedText.ForeColor = Color.FromArgb(255, 128, 0);
            this.groupBoxExtractedText.Location = new Point(450, 0);
            this.groupBoxExtractedText.Margin = new Padding(4);
            this.groupBoxExtractedText.Name = "groupBoxExtractedText";
            this.groupBoxExtractedText.Padding = new Padding(10);
            this.groupBoxExtractedText.Size = new Size(710, 260);
            this.groupBoxExtractedText.TabIndex = 1;
            this.groupBoxExtractedText.TabStop = false;
            this.groupBoxExtractedText.Text = "Extracted Text (PDF Content)";

            // 
            // txtExtractedText
            // 
            this.txtExtractedText.BackColor = Color.FromArgb(245, 247, 250);
            this.txtExtractedText.BorderStyle = BorderStyle.FixedSingle;
            this.txtExtractedText.Dock = DockStyle.Fill;
            this.txtExtractedText.Font = new Font("Consolas", 9F);
            this.txtExtractedText.Location = new Point(10, 27);
            this.txtExtractedText.Margin = new Padding(4);
            this.txtExtractedText.Multiline = true;
            this.txtExtractedText.Name = "txtExtractedText";
            this.txtExtractedText.ReadOnly = true;
            this.txtExtractedText.ScrollBars = ScrollBars.Vertical;
            this.txtExtractedText.Size = new Size(690, 223);
            this.txtExtractedText.TabIndex = 0;

            // 
            // groupBoxPdfSelection
            // 
            this.groupBoxPdfSelection.Controls.Add(this.btnProcessPdf);
            this.groupBoxPdfSelection.Controls.Add(this.btnSelectPdf);
            this.groupBoxPdfSelection.Controls.Add(this.txtPdfPath);
            this.groupBoxPdfSelection.Dock = DockStyle.Left;
            this.groupBoxPdfSelection.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.groupBoxPdfSelection.ForeColor = Color.FromArgb(255, 128, 0);
            this.groupBoxPdfSelection.Location = new Point(0, 0);
            this.groupBoxPdfSelection.Margin = new Padding(4);
            this.groupBoxPdfSelection.Name = "groupBoxPdfSelection";
            this.groupBoxPdfSelection.Padding = new Padding(10);
            this.groupBoxPdfSelection.Size = new Size(450, 260);
            this.groupBoxPdfSelection.TabIndex = 0;
            this.groupBoxPdfSelection.TabStop = false;
            this.groupBoxPdfSelection.Text = "PDF File Selection & Processing";

            // 
            // btnProcessPdf
            // 
            this.btnProcessPdf.BackColor = Color.FromArgb(13, 110, 253);
            this.btnProcessPdf.FlatAppearance.BorderSize = 0;
            this.btnProcessPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 86, 179);
            this.btnProcessPdf.FlatStyle = FlatStyle.Flat;
            this.btnProcessPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnProcessPdf.ForeColor = Color.White;
            this.btnProcessPdf.Location = new Point(14, 110);
            this.btnProcessPdf.Margin = new Padding(4);
            this.btnProcessPdf.Name = "btnProcessPdf";
            this.btnProcessPdf.Size = new Size(422, 40);
            this.btnProcessPdf.TabIndex = 3;
            this.btnProcessPdf.Text = "Process PDF (Extract Text)";
            this.btnProcessPdf.UseVisualStyleBackColor = false;

            // 
            // btnSelectPdf
            // 
            this.btnSelectPdf.BackColor = Color.FromArgb(255, 128, 0);
            this.btnSelectPdf.FlatAppearance.BorderSize = 0;
            this.btnSelectPdf.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 100, 0);
            this.btnSelectPdf.FlatStyle = FlatStyle.Flat;
            this.btnSelectPdf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSelectPdf.ForeColor = Color.White;
            this.btnSelectPdf.Location = new Point(356, 27);
            this.btnSelectPdf.Margin = new Padding(4);
            this.btnSelectPdf.Name = "btnSelectPdf";
            this.btnSelectPdf.Size = new Size(80, 30);
            this.btnSelectPdf.TabIndex = 1;
            this.btnSelectPdf.Text = "Browse";
            this.btnSelectPdf.UseVisualStyleBackColor = false;

            // 
            // txtPdfPath
            // 
            this.txtPdfPath.BackColor = Color.FromArgb(245, 247, 250);
            this.txtPdfPath.BorderStyle = BorderStyle.FixedSingle;
            this.txtPdfPath.Font = new Font("Segoe UI", 10F);
            this.txtPdfPath.Location = new Point(14, 27);
            this.txtPdfPath.Margin = new Padding(4);
            this.txtPdfPath.Name = "txtPdfPath";
            this.txtPdfPath.ReadOnly = true;
            this.txtPdfPath.Size = new Size(334, 30);
            this.txtPdfPath.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = Color.Transparent;
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(255, 128, 0);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Margin = new Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(1160, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PDF Import - Import Exam Results from PDF Files";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // PdfImportControl
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.panelMain);
            this.Margin = new Padding(4);
            this.Name = "PdfImportControl";
            this.Size = new Size(1200, 800);

            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.groupBoxExtractedText.ResumeLayout(false);
            this.groupBoxExtractedText.PerformLayout();
            this.groupBoxPdfSelection.ResumeLayout(false);
            this.groupBoxPdfSelection.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}