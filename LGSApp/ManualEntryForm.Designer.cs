namespace LGSApp
{
    partial class ManualEntryForm
    {
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.txtExamTitle = new System.Windows.Forms.TextBox();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxScores = new System.Windows.Forms.GroupBox();
            this.lblMath = new System.Windows.Forms.Label();
            this.numMathNet = new System.Windows.Forms.NumericUpDown();
            this.lblScience = new System.Windows.Forms.Label();
            this.numScienceNet = new System.Windows.Forms.NumericUpDown();
            this.lblTurkish = new System.Windows.Forms.Label();
            this.numTurkishNet = new System.Windows.Forms.NumericUpDown();
            this.lblHistory = new System.Windows.Forms.Label();
            this.numHistoryNet = new System.Windows.Forms.NumericUpDown();
            this.lblReligion = new System.Windows.Forms.Label();
            this.numReligionNet = new System.Windows.Forms.NumericUpDown();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.numEnglishNet = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotalInfo = new System.Windows.Forms.Label();
            this.groupBoxScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMathNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScienceNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurkishNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReligionNet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnglishNet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manual Exam Result Entry";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.Location = new System.Drawing.Point(30, 70);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(123, 23);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentName.Location = new System.Drawing.Point(160, 67);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(300, 30);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.Text = "ECE OLCA";
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExamTitle.Location = new System.Drawing.Point(30, 110);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(96, 23);
            this.lblExamTitle.TabIndex = 3;
            this.lblExamTitle.Text = "Exam Title:";
            // 
            // txtExamTitle
            // 
            this.txtExamTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExamTitle.Location = new System.Drawing.Point(160, 107);
            this.txtExamTitle.Name = "txtExamTitle";
            this.txtExamTitle.Size = new System.Drawing.Size(300, 30);
            this.txtExamTitle.TabIndex = 2;
            this.txtExamTitle.Text = "KD STARTER LGS-1";
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExamDate.Location = new System.Drawing.Point(30, 150);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(98, 23);
            this.lblExamDate.TabIndex = 5;
            this.lblExamDate.Text = "Exam Date:";
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExamDate.Location = new System.Drawing.Point(160, 147);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(200, 30);
            this.dtpExamDate.TabIndex = 3;
            // 
            // groupBoxScores
            // 
            this.groupBoxScores.Controls.Add(this.lblEnglish);
            this.groupBoxScores.Controls.Add(this.numEnglishNet);
            this.groupBoxScores.Controls.Add(this.lblReligion);
            this.groupBoxScores.Controls.Add(this.numReligionNet);
            this.groupBoxScores.Controls.Add(this.lblHistory);
            this.groupBoxScores.Controls.Add(this.numHistoryNet);
            this.groupBoxScores.Controls.Add(this.lblTurkish);
            this.groupBoxScores.Controls.Add(this.numTurkishNet);
            this.groupBoxScores.Controls.Add(this.lblScience);
            this.groupBoxScores.Controls.Add(this.numScienceNet);
            this.groupBoxScores.Controls.Add(this.lblMath);
            this.groupBoxScores.Controls.Add(this.numMathNet);
            this.groupBoxScores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxScores.Location = new System.Drawing.Point(30, 190);
            this.groupBoxScores.Name = "groupBoxScores";
            this.groupBoxScores.Size = new System.Drawing.Size(430, 200);
            this.groupBoxScores.TabIndex = 4;
            this.groupBoxScores.TabStop = false;
            this.groupBoxScores.Text = "Subject Net Scores (Enter the NET values from the exam result)";
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMath.ForeColor = System.Drawing.Color.Black;
            this.lblMath.Location = new System.Drawing.Point(20, 40);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(98, 23);
            this.lblMath.TabIndex = 0;
            this.lblMath.Text = "Math (0-20):";
            // 
            // numMathNet
            // 
            this.numMathNet.DecimalPlaces = 2;
            this.numMathNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMathNet.Location = new System.Drawing.Point(130, 38);
            this.numMathNet.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numMathNet.Name = "numMathNet";
            this.numMathNet.Size = new System.Drawing.Size(80, 30);
            this.numMathNet.TabIndex = 1;
            this.numMathNet.Value = new decimal(new int[] { 17, 0, 0, 0 });
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblScience.ForeColor = System.Drawing.Color.Black;
            this.lblScience.Location = new System.Drawing.Point(230, 40);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(115, 23);
            this.lblScience.TabIndex = 2;
            this.lblScience.Text = "Science (0-20):";
            // 
            // numScienceNet
            // 
            this.numScienceNet.DecimalPlaces = 2;
            this.numScienceNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numScienceNet.Location = new System.Drawing.Point(350, 38);
            this.numScienceNet.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numScienceNet.Name = "numScienceNet";
            this.numScienceNet.Size = new System.Drawing.Size(70, 30);
            this.numScienceNet.TabIndex = 2;
            this.numScienceNet.Value = new decimal(new int[] { 1467, 0, 0, 131072 });
            // 
            // lblTurkish
            // 
            this.lblTurkish.AutoSize = true;
            this.lblTurkish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTurkish.ForeColor = System.Drawing.Color.Black;
            this.lblTurkish.Location = new System.Drawing.Point(20, 85);
            this.lblTurkish.Name = "lblTurkish";
            this.lblTurkish.Size = new System.Drawing.Size(113, 23);
            this.lblTurkish.TabIndex = 4;
            this.lblTurkish.Text = "Turkish (0-20):";
            // 
            // numTurkishNet
            // 
            this.numTurkishNet.DecimalPlaces = 2;
            this.numTurkishNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numTurkishNet.Location = new System.Drawing.Point(130, 83);
            this.numTurkishNet.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numTurkishNet.Name = "numTurkishNet";
            this.numTurkishNet.Size = new System.Drawing.Size(80, 30);
            this.numTurkishNet.TabIndex = 3;
            this.numTurkishNet.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHistory.ForeColor = System.Drawing.Color.Black;
            this.lblHistory.Location = new System.Drawing.Point(230, 85);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(113, 23);
            this.lblHistory.TabIndex = 6;
            this.lblHistory.Text = "History (0-10):";
            // 
            // numHistoryNet
            // 
            this.numHistoryNet.DecimalPlaces = 2;
            this.numHistoryNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numHistoryNet.Location = new System.Drawing.Point(350, 83);
            this.numHistoryNet.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numHistoryNet.Name = "numHistoryNet";
            this.numHistoryNet.Size = new System.Drawing.Size(70, 30);
            this.numHistoryNet.TabIndex = 4;
            this.numHistoryNet.Value = new decimal(new int[] { 867, 0, 0, 131072 });
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReligion.ForeColor = System.Drawing.Color.Black;
            this.lblReligion.Location = new System.Drawing.Point(20, 130);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(119, 23);
            this.lblReligion.TabIndex = 8;
            this.lblReligion.Text = "Religion (0-10):";
            // 
            // numReligionNet
            // 
            this.numReligionNet.DecimalPlaces = 2;
            this.numReligionNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numReligionNet.Location = new System.Drawing.Point(130, 128);
            this.numReligionNet.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numReligionNet.Name = "numReligionNet";
            this.numReligionNet.Size = new System.Drawing.Size(80, 30);
            this.numReligionNet.TabIndex = 5;
            this.numReligionNet.Value = new decimal(new int[] { 733, 0, 0, 131072 });
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEnglish.ForeColor = System.Drawing.Color.Black;
            this.lblEnglish.Location = new System.Drawing.Point(230, 130);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(115, 23);
            this.lblEnglish.TabIndex = 10;
            this.lblEnglish.Text = "English (0-10):";
            // 
            // numEnglishNet
            // 
            this.numEnglishNet.DecimalPlaces = 2;
            this.numEnglishNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEnglishNet.Location = new System.Drawing.Point(350, 128);
            this.numEnglishNet.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numEnglishNet.Name = "numEnglishNet";
            this.numEnglishNet.Size = new System.Drawing.Size(70, 30);
            this.numEnglishNet.TabIndex = 6;
            this.numEnglishNet.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblTotalInfo
            // 
            this.lblTotalInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTotalInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalInfo.Location = new System.Drawing.Point(30, 400);
            this.lblTotalInfo.Name = "lblTotalInfo";
            this.lblTotalInfo.Size = new System.Drawing.Size(430, 20);
            this.lblTotalInfo.TabIndex = 12;
            this.lblTotalInfo.Text = "Total NET score will be calculated automatically";
            this.lblTotalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(280, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(390, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ManualEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 480);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalInfo);
            this.Controls.Add(this.groupBoxScores);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.lblExamDate);
            this.Controls.Add(this.txtExamTitle);
            this.Controls.Add(this.lblExamTitle);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manual Entry - Exam Results";
            this.groupBoxScores.ResumeLayout(false);
            this.groupBoxScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMathNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScienceNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurkishNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReligionNet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnglishNet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.TextBox txtExamTitle;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.GroupBox groupBoxScores;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.NumericUpDown numMathNet;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.NumericUpDown numScienceNet;
        private System.Windows.Forms.Label lblTurkish;
        private System.Windows.Forms.NumericUpDown numTurkishNet;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.NumericUpDown numHistoryNet;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.NumericUpDown numReligionNet;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.NumericUpDown numEnglishNet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotalInfo;
    }

    // ExamResult class should be defined here or in a separate file
    public class ExamResult
    {
        public string StudentName { get; set; } = "";
        public string ExamTitle { get; set; } = "";
        public string ExamDate { get; set; } = "";
        public decimal MathNet { get; set; } = 0;
        public decimal ScienceNet { get; set; } = 0;
        public decimal TurkishNet { get; set; } = 0;
        public decimal HistoryNet { get; set; } = 0;
        public decimal ReligionNet { get; set; } = 0;
        public decimal EnglishNet { get; set; } = 0;
        public decimal TotalNet { get; set; } = 0;
    }
}
