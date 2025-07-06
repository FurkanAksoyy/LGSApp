namespace LGSApp
{
    partial class OCRControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxImageSelection;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnProcessOCR;
        private System.Windows.Forms.Button btnManualEntry;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.GroupBox groupBoxExtractedText;
        private System.Windows.Forms.TextBox txtExtractedText;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Label lblStatus;

       

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBoxExtractedText = new System.Windows.Forms.GroupBox();
            this.txtExtractedText = new System.Windows.Forms.TextBox();
            this.groupBoxImageSelection = new System.Windows.Forms.GroupBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnProcessOCR = new System.Windows.Forms.Button();
            this.btnManualEntry = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBoxExtractedText.SuspendLayout();
            this.groupBoxImageSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1200, 800);
            this.panelMain.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.groupBoxResults);
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(20, 320);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1160, 460);
            this.panelBottom.TabIndex = 2;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dgvResults);
            this.groupBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxResults.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResults.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxResults.Size = new System.Drawing.Size(1160, 410);
            this.groupBoxResults.TabIndex = 1;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Extracted Exam Results";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.ColumnHeadersHeight = 40;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvResults.Location = new System.Drawing.Point(10, 27);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1140, 373);
            this.dgvResults.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.lblStatus);
            this.panelButtons.Controls.Add(this.btnClearResults);
            this.panelButtons.Controls.Add(this.btnSaveResults);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 410);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1160, 50);
            this.panelButtons.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblStatus.Location = new System.Drawing.Point(10, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";
            // 
            // btnClearResults
            // 
            this.btnClearResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClearResults.FlatAppearance.BorderSize = 0;
            this.btnClearResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnClearResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearResults.ForeColor = System.Drawing.Color.White;
            this.btnClearResults.Location = new System.Drawing.Point(970, 10);
            this.btnClearResults.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(120, 35);
            this.btnClearResults.TabIndex = 1;
            this.btnClearResults.Text = "Clear All";
            this.btnClearResults.UseVisualStyleBackColor = false;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSaveResults.FlatAppearance.BorderSize = 0;
            this.btnSaveResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSaveResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveResults.ForeColor = System.Drawing.Color.White;
            this.btnSaveResults.Location = new System.Drawing.Point(842, 10);
            this.btnSaveResults.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(120, 35);
            this.btnSaveResults.TabIndex = 0;
            this.btnSaveResults.Text = "Save Results";
            this.btnSaveResults.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBoxExtractedText);
            this.panelTop.Controls.Add(this.groupBoxImageSelection);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(20, 60);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1160, 260);
            this.panelTop.TabIndex = 1;
            // 
            // groupBoxExtractedText
            // 
            this.groupBoxExtractedText.Controls.Add(this.txtExtractedText);
            this.groupBoxExtractedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExtractedText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxExtractedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxExtractedText.Location = new System.Drawing.Point(450, 0);
            this.groupBoxExtractedText.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExtractedText.Name = "groupBoxExtractedText";
            this.groupBoxExtractedText.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxExtractedText.Size = new System.Drawing.Size(710, 260);
            this.groupBoxExtractedText.TabIndex = 1;
            this.groupBoxExtractedText.TabStop = false;
            this.groupBoxExtractedText.Text = "Extracted Text (OCR Output)";
            // 
            // txtExtractedText
            // 
            this.txtExtractedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtExtractedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtractedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExtractedText.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtExtractedText.Location = new System.Drawing.Point(10, 27);
            this.txtExtractedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtractedText.Multiline = true;
            this.txtExtractedText.Name = "txtExtractedText";
            this.txtExtractedText.ReadOnly = true;
            this.txtExtractedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExtractedText.Size = new System.Drawing.Size(690, 223);
            this.txtExtractedText.TabIndex = 0;
            // 
            // groupBoxImageSelection
            // 
            this.groupBoxImageSelection.Controls.Add(this.pictureBoxPreview);
            this.groupBoxImageSelection.Controls.Add(this.btnManualEntry);
            this.groupBoxImageSelection.Controls.Add(this.btnProcessOCR);
            this.groupBoxImageSelection.Controls.Add(this.btnSelectImage);
            this.groupBoxImageSelection.Controls.Add(this.txtImagePath);
            this.groupBoxImageSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxImageSelection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxImageSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxImageSelection.Location = new System.Drawing.Point(0, 0);
            this.groupBoxImageSelection.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxImageSelection.Name = "groupBoxImageSelection";
            this.groupBoxImageSelection.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxImageSelection.Size = new System.Drawing.Size(450, 260);
            this.groupBoxImageSelection.TabIndex = 0;
            this.groupBoxImageSelection.TabStop = false;
            this.groupBoxImageSelection.Text = "Image Selection & Data Entry";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(14, 110);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(422, 140);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 5;
            this.pictureBoxPreview.TabStop = false;
            // 
            // btnManualEntry
            // 
            this.btnManualEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnManualEntry.FlatAppearance.BorderSize = 0;
            this.btnManualEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnManualEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManualEntry.ForeColor = System.Drawing.Color.White;
            this.btnManualEntry.Location = new System.Drawing.Point(220, 68);
            this.btnManualEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnManualEntry.Name = "btnManualEntry";
            this.btnManualEntry.Size = new System.Drawing.Size(100, 32);
            this.btnManualEntry.TabIndex = 4;
            this.btnManualEntry.Text = "Manual Entry";
            this.btnManualEntry.UseVisualStyleBackColor = false;
            // 
            // btnProcessOCR
            // 
            this.btnProcessOCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnProcessOCR.FlatAppearance.BorderSize = 0;
            this.btnProcessOCR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.btnProcessOCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessOCR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProcessOCR.ForeColor = System.Drawing.Color.White;
            this.btnProcessOCR.Location = new System.Drawing.Point(326, 68);
            this.btnProcessOCR.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessOCR.Name = "btnProcessOCR";
            this.btnProcessOCR.Size = new System.Drawing.Size(110, 32);
            this.btnProcessOCR.TabIndex = 3;
            this.btnProcessOCR.Text = "Process OCR";
            this.btnProcessOCR.UseVisualStyleBackColor = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(356, 27);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(80, 30);
            this.btnSelectImage.TabIndex = 1;
            this.btnSelectImage.Text = "Browse";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagePath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImagePath.Location = new System.Drawing.Point(14, 27);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtImagePath.Name = "txtImagePath";
            // this.txtImagePath.PlaceholderText = "Select an exam result image...";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(334, 30);
            this.txtImagePath.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "OCR - Optical Character Recognition";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OCRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OCRControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.groupBoxExtractedText.ResumeLayout(false);
            this.groupBoxExtractedText.PerformLayout();
            this.groupBoxImageSelection.ResumeLayout(false);
            this.groupBoxImageSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
        }
    }
}