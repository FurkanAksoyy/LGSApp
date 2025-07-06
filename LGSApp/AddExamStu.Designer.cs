namespace LGSApp
{
    partial class AddExamStu
    {
        /// <summary> 
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        /// içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.cmbExamStudent = new System.Windows.Forms.ComboBox();
            this.lblExamName = new System.Windows.Forms.Label();
            this.cmbExamName = new System.Windows.Forms.ComboBox();
            this.lblDateTaken = new System.Windows.Forms.Label();
            this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
            this.grpScores = new System.Windows.Forms.GroupBox();
            this.btnSaveExam = new System.Windows.Forms.Button();
            this.grpVerbal = new System.Windows.Forms.GroupBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.txtEnglishNet = new System.Windows.Forms.TextBox();
            this.txtEnglishBlank = new System.Windows.Forms.TextBox();
            this.txtEnglishWrong = new System.Windows.Forms.TextBox();
            this.txtEnglishCorrect = new System.Windows.Forms.TextBox();
            this.lblEnglishBlank = new System.Windows.Forms.Label();
            this.lblEnglishNet = new System.Windows.Forms.Label();
            this.lblEnglishCorrect = new System.Windows.Forms.Label();
            this.lblEnglishWrong = new System.Windows.Forms.Label();
            this.lblReligionEthics = new System.Windows.Forms.Label();
            this.txtReligionNet = new System.Windows.Forms.TextBox();
            this.txtReligionBlank = new System.Windows.Forms.TextBox();
            this.txtReligionWrong = new System.Windows.Forms.TextBox();
            this.txtReligionCorrect = new System.Windows.Forms.TextBox();
            this.lblReligionNet = new System.Windows.Forms.Label();
            this.lblReligionBlank = new System.Windows.Forms.Label();
            this.lblReligionWrong = new System.Windows.Forms.Label();
            this.lblReligionCorrect = new System.Windows.Forms.Label();
            this.txtHistoryNet = new System.Windows.Forms.TextBox();
            this.txtHistoryBlank = new System.Windows.Forms.TextBox();
            this.txtHistoryWrong = new System.Windows.Forms.TextBox();
            this.txtHistoryCorrect = new System.Windows.Forms.TextBox();
            this.lblHistoryNet = new System.Windows.Forms.Label();
            this.lblHistoryBlank = new System.Windows.Forms.Label();
            this.lblHistoryWrong = new System.Windows.Forms.Label();
            this.lblHistoryCorrect = new System.Windows.Forms.Label();
            this.txtTurkishNet = new System.Windows.Forms.TextBox();
            this.txtTurkishWrong = new System.Windows.Forms.TextBox();
            this.txtTurkishBlank = new System.Windows.Forms.TextBox();
            this.txtTurkishCorrect = new System.Windows.Forms.TextBox();
            this.lblTurkishNet = new System.Windows.Forms.Label();
            this.lblTurkishBlank = new System.Windows.Forms.Label();
            this.lblTurkishWrong = new System.Windows.Forms.Label();
            this.lblTurkishCorrect = new System.Windows.Forms.Label();
            this.lblRevolutionHistory = new System.Windows.Forms.Label();
            this.lblTurkish = new System.Windows.Forms.Label();
            this.grpNumerical = new System.Windows.Forms.GroupBox();
            this.txtScienceNet = new System.Windows.Forms.TextBox();
            this.txtScienceCorrect = new System.Windows.Forms.TextBox();
            this.txtScienceBlank = new System.Windows.Forms.TextBox();
            this.txtScienceWrong = new System.Windows.Forms.TextBox();
            this.lblScienceNet = new System.Windows.Forms.Label();
            this.lblScienceBlank = new System.Windows.Forms.Label();
            this.lblScienceWrong = new System.Windows.Forms.Label();
            this.lblScienceCorrect = new System.Windows.Forms.Label();
            this.txtMathNet = new System.Windows.Forms.TextBox();
            this.txtMathBlank = new System.Windows.Forms.TextBox();
            this.txtMathWrong = new System.Windows.Forms.TextBox();
            this.txtMathCorrect = new System.Windows.Forms.TextBox();
            this.lblMathNet = new System.Windows.Forms.Label();
            this.lblMathBlank = new System.Windows.Forms.Label();
            this.lblMathWrong = new System.Windows.Forms.Label();
            this.lblMathCorrect = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblMathematics = new System.Windows.Forms.Label();
            this.grpScores.SuspendLayout();
            this.grpVerbal.SuspendLayout();
            this.grpNumerical.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStudent.ForeColor = System.Drawing.Color.Black;
            this.lblSelectStudent.Location = new System.Drawing.Point(24, 12);
            this.lblSelectStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(154, 28);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select Student:";
            this.lblSelectStudent.Click += new System.EventHandler(this.lblSelectStudent_Click);
            // 
            // cmbExamStudent
            // 
            this.cmbExamStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.cmbExamStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExamStudent.FormattingEnabled = true;
            this.cmbExamStudent.Location = new System.Drawing.Point(190, 10);
            this.cmbExamStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbExamStudent.Name = "cmbExamStudent";
            this.cmbExamStudent.Size = new System.Drawing.Size(180, 36);
            this.cmbExamStudent.TabIndex = 1;
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.BackColor = System.Drawing.Color.Transparent;
            this.lblExamName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.ForeColor = System.Drawing.Color.Black;
            this.lblExamName.Location = new System.Drawing.Point(419, 12);
            this.lblExamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(130, 28);
            this.lblExamName.TabIndex = 2;
            this.lblExamName.Text = "Exam Name:";
            // 
            // cmbExamName
            // 
            this.cmbExamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.cmbExamName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExamName.Location = new System.Drawing.Point(557, 10);
            this.cmbExamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbExamName.Name = "cmbExamName";
            this.cmbExamName.Size = new System.Drawing.Size(148, 36);
            this.cmbExamName.TabIndex = 3;
            // 
            // lblDateTaken
            // 
            this.lblDateTaken.AutoSize = true;
            this.lblDateTaken.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTaken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTaken.ForeColor = System.Drawing.Color.Black;
            this.lblDateTaken.Location = new System.Drawing.Point(762, 12);
            this.lblDateTaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTaken.Name = "lblDateTaken";
            this.lblDateTaken.Size = new System.Drawing.Size(62, 28);
            this.lblDateTaken.TabIndex = 4;
            this.lblDateTaken.Text = "Date:";
            // 
            // dtpDateTaken
            // 
            this.dtpDateTaken.BackColor = System.Drawing.Color.White;
            this.dtpDateTaken.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTaken.Location = new System.Drawing.Point(845, 12);
            this.dtpDateTaken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateTaken.Name = "dtpDateTaken";
            this.dtpDateTaken.Size = new System.Drawing.Size(298, 34);
            this.dtpDateTaken.TabIndex = 5;
            // 
            // grpScores
            // 
            this.grpScores.BackColor = System.Drawing.Color.White;
            this.grpScores.Controls.Add(this.btnSaveExam);
            this.grpScores.Controls.Add(this.grpVerbal);
            this.grpScores.Controls.Add(this.grpNumerical);
            this.grpScores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScores.ForeColor = System.Drawing.Color.Black;
            this.grpScores.Location = new System.Drawing.Point(96, 66);
            this.grpScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpScores.Name = "grpScores";
            this.grpScores.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpScores.Size = new System.Drawing.Size(1047, 611);
            this.grpScores.TabIndex = 6;
            this.grpScores.TabStop = false;
            this.grpScores.Text = "Wrong Counts";
            // 
            // btnSaveExam
            // 
            this.btnSaveExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveExam.FlatAppearance.BorderSize = 0;
            this.btnSaveExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnSaveExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExam.ForeColor = System.Drawing.Color.White;
            this.btnSaveExam.Location = new System.Drawing.Point(9, 538);
            this.btnSaveExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveExam.Name = "btnSaveExam";
            this.btnSaveExam.Size = new System.Drawing.Size(225, 54);
            this.btnSaveExam.TabIndex = 47;
            this.btnSaveExam.Text = "Save Exam";
            this.btnSaveExam.UseVisualStyleBackColor = false;
            // 
            // grpVerbal
            // 
            this.grpVerbal.BackColor = System.Drawing.Color.White;
            this.grpVerbal.Controls.Add(this.lblEnglish);
            this.grpVerbal.Controls.Add(this.txtEnglishNet);
            this.grpVerbal.Controls.Add(this.txtEnglishBlank);
            this.grpVerbal.Controls.Add(this.txtEnglishWrong);
            this.grpVerbal.Controls.Add(this.txtEnglishCorrect);
            this.grpVerbal.Controls.Add(this.lblEnglishBlank);
            this.grpVerbal.Controls.Add(this.lblEnglishNet);
            this.grpVerbal.Controls.Add(this.lblEnglishCorrect);
            this.grpVerbal.Controls.Add(this.lblEnglishWrong);
            this.grpVerbal.Controls.Add(this.lblReligionEthics);
            this.grpVerbal.Controls.Add(this.txtReligionNet);
            this.grpVerbal.Controls.Add(this.txtReligionBlank);
            this.grpVerbal.Controls.Add(this.txtReligionWrong);
            this.grpVerbal.Controls.Add(this.txtReligionCorrect);
            this.grpVerbal.Controls.Add(this.lblReligionNet);
            this.grpVerbal.Controls.Add(this.lblReligionBlank);
            this.grpVerbal.Controls.Add(this.lblReligionWrong);
            this.grpVerbal.Controls.Add(this.lblReligionCorrect);
            this.grpVerbal.Controls.Add(this.txtHistoryNet);
            this.grpVerbal.Controls.Add(this.txtHistoryBlank);
            this.grpVerbal.Controls.Add(this.txtHistoryWrong);
            this.grpVerbal.Controls.Add(this.txtHistoryCorrect);
            this.grpVerbal.Controls.Add(this.lblHistoryNet);
            this.grpVerbal.Controls.Add(this.lblHistoryBlank);
            this.grpVerbal.Controls.Add(this.lblHistoryWrong);
            this.grpVerbal.Controls.Add(this.lblHistoryCorrect);
            this.grpVerbal.Controls.Add(this.txtTurkishNet);
            this.grpVerbal.Controls.Add(this.txtTurkishWrong);
            this.grpVerbal.Controls.Add(this.txtTurkishBlank);
            this.grpVerbal.Controls.Add(this.txtTurkishCorrect);
            this.grpVerbal.Controls.Add(this.lblTurkishNet);
            this.grpVerbal.Controls.Add(this.lblTurkishBlank);
            this.grpVerbal.Controls.Add(this.lblTurkishWrong);
            this.grpVerbal.Controls.Add(this.lblTurkishCorrect);
            this.grpVerbal.Controls.Add(this.lblRevolutionHistory);
            this.grpVerbal.Controls.Add(this.lblTurkish);
            this.grpVerbal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerbal.ForeColor = System.Drawing.Color.Black;
            this.grpVerbal.Location = new System.Drawing.Point(278, 29);
            this.grpVerbal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVerbal.Name = "grpVerbal";
            this.grpVerbal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVerbal.Size = new System.Drawing.Size(970, 489);
            this.grpVerbal.TabIndex = 16;
            this.grpVerbal.TabStop = false;
            this.grpVerbal.Text = "Verbal";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEnglish.Location = new System.Drawing.Point(403, 269);
            this.lblEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(96, 32);
            this.lblEnglish.TabIndex = 45;
            this.lblEnglish.Text = "English";
            // 
            // txtEnglishNet
            // 
            this.txtEnglishNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtEnglishNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishNet.Location = new System.Drawing.Point(519, 426);
            this.txtEnglishNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnglishNet.Name = "txtEnglishNet";
            this.txtEnglishNet.ReadOnly = true;
            this.txtEnglishNet.Size = new System.Drawing.Size(148, 34);
            this.txtEnglishNet.TabIndex = 40;
            // 
            // txtEnglishBlank
            // 
            this.txtEnglishBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEnglishBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishBlank.Location = new System.Drawing.Point(519, 383);
            this.txtEnglishBlank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnglishBlank.Name = "txtEnglishBlank";
            this.txtEnglishBlank.Size = new System.Drawing.Size(148, 34);
            this.txtEnglishBlank.TabIndex = 39;
            // 
            // txtEnglishWrong
            // 
            this.txtEnglishWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEnglishWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishWrong.Location = new System.Drawing.Point(519, 343);
            this.txtEnglishWrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnglishWrong.Name = "txtEnglishWrong";
            this.txtEnglishWrong.Size = new System.Drawing.Size(148, 34);
            this.txtEnglishWrong.TabIndex = 38;
            // 
            // txtEnglishCorrect
            // 
            this.txtEnglishCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtEnglishCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishCorrect.Location = new System.Drawing.Point(519, 306);
            this.txtEnglishCorrect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnglishCorrect.Name = "txtEnglishCorrect";
            this.txtEnglishCorrect.Size = new System.Drawing.Size(148, 34);
            this.txtEnglishCorrect.TabIndex = 37;
            // 
            // lblEnglishBlank
            // 
            this.lblEnglishBlank.AutoSize = true;
            this.lblEnglishBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishBlank.ForeColor = System.Drawing.Color.Black;
            this.lblEnglishBlank.Location = new System.Drawing.Point(404, 386);
            this.lblEnglishBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnglishBlank.Name = "lblEnglishBlank";
            this.lblEnglishBlank.Size = new System.Drawing.Size(71, 28);
            this.lblEnglishBlank.TabIndex = 36;
            this.lblEnglishBlank.Text = "Blank:";
            // 
            // lblEnglishNet
            // 
            this.lblEnglishNet.AutoSize = true;
            this.lblEnglishNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishNet.ForeColor = System.Drawing.Color.Black;
            this.lblEnglishNet.Location = new System.Drawing.Point(404, 422);
            this.lblEnglishNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnglishNet.Name = "lblEnglishNet";
            this.lblEnglishNet.Size = new System.Drawing.Size(52, 28);
            this.lblEnglishNet.TabIndex = 35;
            this.lblEnglishNet.Text = "Net:";
            // 
            // lblEnglishCorrect
            // 
            this.lblEnglishCorrect.AutoSize = true;
            this.lblEnglishCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblEnglishCorrect.Location = new System.Drawing.Point(404, 306);
            this.lblEnglishCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnglishCorrect.Name = "lblEnglishCorrect";
            this.lblEnglishCorrect.Size = new System.Drawing.Size(86, 28);
            this.lblEnglishCorrect.TabIndex = 34;
            this.lblEnglishCorrect.Text = "Correct:";
            // 
            // lblEnglishWrong
            // 
            this.lblEnglishWrong.AutoSize = true;
            this.lblEnglishWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishWrong.ForeColor = System.Drawing.Color.Black;
            this.lblEnglishWrong.Location = new System.Drawing.Point(404, 346);
            this.lblEnglishWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnglishWrong.Name = "lblEnglishWrong";
            this.lblEnglishWrong.Size = new System.Drawing.Size(81, 28);
            this.lblEnglishWrong.TabIndex = 33;
            this.lblEnglishWrong.Text = "Wrong:";
            this.lblEnglishWrong.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblReligionEthics
            // 
            this.lblReligionEthics.AutoSize = true;
            this.lblReligionEthics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligionEthics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblReligionEthics.Location = new System.Drawing.Point(403, 32);
            this.lblReligionEthics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReligionEthics.Name = "lblReligionEthics";
            this.lblReligionEthics.Size = new System.Drawing.Size(181, 32);
            this.lblReligionEthics.TabIndex = 44;
            this.lblReligionEthics.Text = "Religion Ethics";
            // 
            // txtReligionNet
            // 
            this.txtReligionNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtReligionNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligionNet.Location = new System.Drawing.Point(519, 199);
            this.txtReligionNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReligionNet.Name = "txtReligionNet";
            this.txtReligionNet.ReadOnly = true;
            this.txtReligionNet.Size = new System.Drawing.Size(148, 34);
            this.txtReligionNet.TabIndex = 25;
            // 
            // txtReligionBlank
            // 
            this.txtReligionBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtReligionBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligionBlank.Location = new System.Drawing.Point(519, 155);
            this.txtReligionBlank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReligionBlank.Name = "txtReligionBlank";
            this.txtReligionBlank.Size = new System.Drawing.Size(148, 34);
            this.txtReligionBlank.TabIndex = 26;
            // 
            // txtReligionWrong
            // 
            this.txtReligionWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtReligionWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligionWrong.Location = new System.Drawing.Point(519, 112);
            this.txtReligionWrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReligionWrong.Name = "txtReligionWrong";
            this.txtReligionWrong.Size = new System.Drawing.Size(148, 34);
            this.txtReligionWrong.TabIndex = 27;
            // 
            // txtReligionCorrect
            // 
            this.txtReligionCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtReligionCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligionCorrect.Location = new System.Drawing.Point(519, 75);
            this.txtReligionCorrect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReligionCorrect.Name = "txtReligionCorrect";
            this.txtReligionCorrect.Size = new System.Drawing.Size(148, 34);
            this.txtReligionCorrect.TabIndex = 28;
            // 
            // lblReligionNet
            // 
            this.lblReligionNet.AutoSize = true;
            this.lblReligionNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligionNet.ForeColor = System.Drawing.Color.Black;
            this.lblReligionNet.Location = new System.Drawing.Point(404, 200);
            this.lblReligionNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReligionNet.Name = "lblReligionNet";
            this.lblReligionNet.Size = new System.Drawing.Size(52, 28);
            this.lblReligionNet.TabIndex = 32;
            this.lblReligionNet.Text = "Net:";
            // 
            // lblReligionBlank
            // 
            this.lblReligionBlank.AutoSize = true;
            this.lblReligionBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligionBlank.ForeColor = System.Drawing.Color.Black;
            this.lblReligionBlank.Location = new System.Drawing.Point(404, 157);
            this.lblReligionBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReligionBlank.Name = "lblReligionBlank";
            this.lblReligionBlank.Size = new System.Drawing.Size(71, 28);
            this.lblReligionBlank.TabIndex = 31;
            this.lblReligionBlank.Text = "Blank:";
            // 
            // lblReligionWrong
            // 
            this.lblReligionWrong.AutoSize = true;
            this.lblReligionWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligionWrong.ForeColor = System.Drawing.Color.Black;
            this.lblReligionWrong.Location = new System.Drawing.Point(404, 115);
            this.lblReligionWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReligionWrong.Name = "lblReligionWrong";
            this.lblReligionWrong.Size = new System.Drawing.Size(81, 28);
            this.lblReligionWrong.TabIndex = 30;
            this.lblReligionWrong.Text = "Wrong:";
            // 
            // lblReligionCorrect
            // 
            this.lblReligionCorrect.AutoSize = true;
            this.lblReligionCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligionCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblReligionCorrect.Location = new System.Drawing.Point(404, 75);
            this.lblReligionCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReligionCorrect.Name = "lblReligionCorrect";
            this.lblReligionCorrect.Size = new System.Drawing.Size(86, 28);
            this.lblReligionCorrect.TabIndex = 29;
            this.lblReligionCorrect.Text = "Correct:";
            // 
            // txtHistoryNet
            // 
            this.txtHistoryNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtHistoryNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoryNet.Location = new System.Drawing.Point(117, 426);
            this.txtHistoryNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHistoryNet.Name = "txtHistoryNet";
            this.txtHistoryNet.ReadOnly = true;
            this.txtHistoryNet.Size = new System.Drawing.Size(148, 34);
            this.txtHistoryNet.TabIndex = 17;
            // 
            // txtHistoryBlank
            // 
            this.txtHistoryBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtHistoryBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoryBlank.Location = new System.Drawing.Point(117, 386);
            this.txtHistoryBlank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHistoryBlank.Name = "txtHistoryBlank";
            this.txtHistoryBlank.Size = new System.Drawing.Size(148, 34);
            this.txtHistoryBlank.TabIndex = 18;
            // 
            // txtHistoryWrong
            // 
            this.txtHistoryWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtHistoryWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoryWrong.Location = new System.Drawing.Point(117, 346);
            this.txtHistoryWrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHistoryWrong.Name = "txtHistoryWrong";
            this.txtHistoryWrong.Size = new System.Drawing.Size(148, 34);
            this.txtHistoryWrong.TabIndex = 19;
            // 
            // txtHistoryCorrect
            // 
            this.txtHistoryCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtHistoryCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoryCorrect.Location = new System.Drawing.Point(117, 306);
            this.txtHistoryCorrect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHistoryCorrect.Name = "txtHistoryCorrect";
            this.txtHistoryCorrect.Size = new System.Drawing.Size(148, 34);
            this.txtHistoryCorrect.TabIndex = 20;
            // 
            // lblHistoryNet
            // 
            this.lblHistoryNet.AutoSize = true;
            this.lblHistoryNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryNet.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryNet.Location = new System.Drawing.Point(28, 422);
            this.lblHistoryNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoryNet.Name = "lblHistoryNet";
            this.lblHistoryNet.Size = new System.Drawing.Size(52, 28);
            this.lblHistoryNet.TabIndex = 21;
            this.lblHistoryNet.Text = "Net:";
            // 
            // lblHistoryBlank
            // 
            this.lblHistoryBlank.AutoSize = true;
            this.lblHistoryBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryBlank.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryBlank.Location = new System.Drawing.Point(28, 386);
            this.lblHistoryBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoryBlank.Name = "lblHistoryBlank";
            this.lblHistoryBlank.Size = new System.Drawing.Size(71, 28);
            this.lblHistoryBlank.TabIndex = 22;
            this.lblHistoryBlank.Text = "Blank:";
            // 
            // lblHistoryWrong
            // 
            this.lblHistoryWrong.AutoSize = true;
            this.lblHistoryWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryWrong.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryWrong.Location = new System.Drawing.Point(28, 346);
            this.lblHistoryWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoryWrong.Name = "lblHistoryWrong";
            this.lblHistoryWrong.Size = new System.Drawing.Size(81, 28);
            this.lblHistoryWrong.TabIndex = 23;
            this.lblHistoryWrong.Text = "Wrong:";
            // 
            // lblHistoryCorrect
            // 
            this.lblHistoryCorrect.AutoSize = true;
            this.lblHistoryCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryCorrect.Location = new System.Drawing.Point(28, 306);
            this.lblHistoryCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoryCorrect.Name = "lblHistoryCorrect";
            this.lblHistoryCorrect.Size = new System.Drawing.Size(86, 28);
            this.lblHistoryCorrect.TabIndex = 24;
            this.lblHistoryCorrect.Text = "Correct:";
            // 
            // txtTurkishNet
            // 
            this.txtTurkishNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTurkishNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurkishNet.Location = new System.Drawing.Point(117, 203);
            this.txtTurkishNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurkishNet.Name = "txtTurkishNet";
            this.txtTurkishNet.ReadOnly = true;
            this.txtTurkishNet.Size = new System.Drawing.Size(148, 34);
            this.txtTurkishNet.TabIndex = 7;
            // 
            // txtTurkishWrong
            // 
            this.txtTurkishWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtTurkishWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurkishWrong.Location = new System.Drawing.Point(117, 115);
            this.txtTurkishWrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurkishWrong.Name = "txtTurkishWrong";
            this.txtTurkishWrong.Size = new System.Drawing.Size(148, 34);
            this.txtTurkishWrong.TabIndex = 5;
            // 
            // txtTurkishBlank
            // 
            this.txtTurkishBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtTurkishBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurkishBlank.Location = new System.Drawing.Point(117, 155);
            this.txtTurkishBlank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurkishBlank.Name = "txtTurkishBlank";
            this.txtTurkishBlank.Size = new System.Drawing.Size(148, 34);
            this.txtTurkishBlank.TabIndex = 4;
            // 
            // txtTurkishCorrect
            // 
            this.txtTurkishCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtTurkishCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurkishCorrect.Location = new System.Drawing.Point(117, 75);
            this.txtTurkishCorrect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurkishCorrect.Name = "txtTurkishCorrect";
            this.txtTurkishCorrect.Size = new System.Drawing.Size(148, 34);
            this.txtTurkishCorrect.TabIndex = 6;
            // 
            // lblTurkishNet
            // 
            this.lblTurkishNet.AutoSize = true;
            this.lblTurkishNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurkishNet.ForeColor = System.Drawing.Color.Black;
            this.lblTurkishNet.Location = new System.Drawing.Point(28, 200);
            this.lblTurkishNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurkishNet.Name = "lblTurkishNet";
            this.lblTurkishNet.Size = new System.Drawing.Size(52, 28);
            this.lblTurkishNet.TabIndex = 3;
            this.lblTurkishNet.Text = "Net:";
            // 
            // lblTurkishBlank
            // 
            this.lblTurkishBlank.AutoSize = true;
            this.lblTurkishBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurkishBlank.ForeColor = System.Drawing.Color.Black;
            this.lblTurkishBlank.Location = new System.Drawing.Point(28, 157);
            this.lblTurkishBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurkishBlank.Name = "lblTurkishBlank";
            this.lblTurkishBlank.Size = new System.Drawing.Size(71, 28);
            this.lblTurkishBlank.TabIndex = 2;
            this.lblTurkishBlank.Text = "Blank:";
            // 
            // lblTurkishWrong
            // 
            this.lblTurkishWrong.AutoSize = true;
            this.lblTurkishWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurkishWrong.ForeColor = System.Drawing.Color.Black;
            this.lblTurkishWrong.Location = new System.Drawing.Point(28, 115);
            this.lblTurkishWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurkishWrong.Name = "lblTurkishWrong";
            this.lblTurkishWrong.Size = new System.Drawing.Size(81, 28);
            this.lblTurkishWrong.TabIndex = 1;
            this.lblTurkishWrong.Text = "Wrong:";
            // 
            // lblTurkishCorrect
            // 
            this.lblTurkishCorrect.AutoSize = true;
            this.lblTurkishCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurkishCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblTurkishCorrect.Location = new System.Drawing.Point(28, 75);
            this.lblTurkishCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurkishCorrect.Name = "lblTurkishCorrect";
            this.lblTurkishCorrect.Size = new System.Drawing.Size(86, 28);
            this.lblTurkishCorrect.TabIndex = 0;
            this.lblTurkishCorrect.Text = "Correct:";
            // 
            // lblRevolutionHistory
            // 
            this.lblRevolutionHistory.AutoSize = true;
            this.lblRevolutionHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevolutionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRevolutionHistory.Location = new System.Drawing.Point(8, 269);
            this.lblRevolutionHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevolutionHistory.Name = "lblRevolutionHistory";
            this.lblRevolutionHistory.Size = new System.Drawing.Size(374, 32);
            this.lblRevolutionHistory.TabIndex = 46;
            this.lblRevolutionHistory.Text = "Revolution History && Kemalism";
            // 
            // lblTurkish
            // 
            this.lblTurkish.AutoSize = true;
            this.lblTurkish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurkish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTurkish.Location = new System.Drawing.Point(8, 32);
            this.lblTurkish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurkish.Name = "lblTurkish";
            this.lblTurkish.Size = new System.Drawing.Size(96, 32);
            this.lblTurkish.TabIndex = 43;
            this.lblTurkish.Text = "Turkish";
            // 
            // grpNumerical
            // 
            this.grpNumerical.BackColor = System.Drawing.Color.White;
            this.grpNumerical.Controls.Add(this.txtScienceNet);
            this.grpNumerical.Controls.Add(this.txtScienceCorrect);
            this.grpNumerical.Controls.Add(this.txtScienceBlank);
            this.grpNumerical.Controls.Add(this.txtScienceWrong);
            this.grpNumerical.Controls.Add(this.lblScienceNet);
            this.grpNumerical.Controls.Add(this.lblScienceBlank);
            this.grpNumerical.Controls.Add(this.lblScienceWrong);
            this.grpNumerical.Controls.Add(this.lblScienceCorrect);
            this.grpNumerical.Controls.Add(this.txtMathNet);
            this.grpNumerical.Controls.Add(this.txtMathBlank);
            this.grpNumerical.Controls.Add(this.txtMathWrong);
            this.grpNumerical.Controls.Add(this.txtMathCorrect);
            this.grpNumerical.Controls.Add(this.lblMathNet);
            this.grpNumerical.Controls.Add(this.lblMathBlank);
            this.grpNumerical.Controls.Add(this.lblMathWrong);
            this.grpNumerical.Controls.Add(this.lblMathCorrect);
            this.grpNumerical.Controls.Add(this.lblScience);
            this.grpNumerical.Controls.Add(this.lblMathematics);
            this.grpNumerical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNumerical.ForeColor = System.Drawing.Color.Black;
            this.grpNumerical.Location = new System.Drawing.Point(9, 29);
            this.grpNumerical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNumerical.Name = "grpNumerical";
            this.grpNumerical.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNumerical.Size = new System.Drawing.Size(264, 489);
            this.grpNumerical.TabIndex = 16;
            this.grpNumerical.TabStop = false;
            this.grpNumerical.Text = "Numerical";
            // 
            // txtScienceNet
            // 
            this.txtScienceNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtScienceNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScienceNet.Location = new System.Drawing.Point(100, 426);
            this.txtScienceNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScienceNet.Name = "txtScienceNet";
            this.txtScienceNet.ReadOnly = true;
            this.txtScienceNet.Size = new System.Drawing.Size(148, 34);
            this.txtScienceNet.TabIndex = 11;
            // 
            // txtScienceCorrect
            // 
            this.txtScienceCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtScienceCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScienceCorrect.Location = new System.Drawing.Point(100, 306);
            this.txtScienceCorrect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScienceCorrect.Name = "txtScienceCorrect";
            this.txtScienceCorrect.Size = new System.Drawing.Size(148, 34);
            this.txtScienceCorrect.TabIndex = 10;
            // 
            // txtScienceBlank
            // 
            this.txtScienceBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtScienceBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScienceBlank.Location = new System.Drawing.Point(100, 386);
            this.txtScienceBlank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScienceBlank.Name = "txtScienceBlank";
            this.txtScienceBlank.Size = new System.Drawing.Size(148, 34);
            this.txtScienceBlank.TabIndex = 9;
            // 
            // txtScienceWrong
            // 
            this.txtScienceWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtScienceWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScienceWrong.Location = new System.Drawing.Point(100, 346);
            this.txtScienceWrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScienceWrong.Name = "txtScienceWrong";
            this.txtScienceWrong.Size = new System.Drawing.Size(148, 34);
            this.txtScienceWrong.TabIndex = 8;
            // 
            // lblScienceNet
            // 
            this.lblScienceNet.AutoSize = true;
            this.lblScienceNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScienceNet.ForeColor = System.Drawing.Color.Black;
            this.lblScienceNet.Location = new System.Drawing.Point(9, 422);
            this.lblScienceNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScienceNet.Name = "lblScienceNet";
            this.lblScienceNet.Size = new System.Drawing.Size(52, 28);
            this.lblScienceNet.TabIndex = 15;
            this.lblScienceNet.Text = "Net:";
            // 
            // lblScienceBlank
            // 
            this.lblScienceBlank.AutoSize = true;
            this.lblScienceBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScienceBlank.ForeColor = System.Drawing.Color.Black;
            this.lblScienceBlank.Location = new System.Drawing.Point(9, 386);
            this.lblScienceBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScienceBlank.Name = "lblScienceBlank";
            this.lblScienceBlank.Size = new System.Drawing.Size(71, 28);
            this.lblScienceBlank.TabIndex = 14;
            this.lblScienceBlank.Text = "Blank:";
            // 
            // lblScienceWrong
            // 
            this.lblScienceWrong.AutoSize = true;
            this.lblScienceWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScienceWrong.ForeColor = System.Drawing.Color.Black;
            this.lblScienceWrong.Location = new System.Drawing.Point(9, 346);
            this.lblScienceWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScienceWrong.Name = "lblScienceWrong";
            this.lblScienceWrong.Size = new System.Drawing.Size(81, 28);
            this.lblScienceWrong.TabIndex = 13;
            this.lblScienceWrong.Text = "Wrong:";
            // 
            // lblScienceCorrect
            // 
            this.lblScienceCorrect.AutoSize = true;
            this.lblScienceCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScienceCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblScienceCorrect.Location = new System.Drawing.Point(9, 306);
            this.lblScienceCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScienceCorrect.Name = "lblScienceCorrect";
            this.lblScienceCorrect.Size = new System.Drawing.Size(86, 28);
            this.lblScienceCorrect.TabIndex = 12;
            this.lblScienceCorrect.Text = "Correct:";
            this.lblScienceCorrect.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMathNet
            // 
            this.txtMathNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtMathNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathNet.Location = new System.Drawing.Point(100, 199);
            this.txtMathNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMathNet.Name = "txtMathNet";
            this.txtMathNet.ReadOnly = true;
            this.txtMathNet.Size = new System.Drawing.Size(148, 34);
            this.txtMathNet.TabIndex = 6;
            // 
            // txtMathBlank
            // 
            this.txtMathBlank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtMathBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathBlank.Location = new System.Drawing.Point(100, 155);
            this.txtMathBlank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMathBlank.Name = "txtMathBlank";
            this.txtMathBlank.Size = new System.Drawing.Size(148, 34);
            this.txtMathBlank.TabIndex = 4;
            // 
            // txtMathWrong
            // 
            this.txtMathWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtMathWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathWrong.Location = new System.Drawing.Point(100, 115);
            this.txtMathWrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMathWrong.Name = "txtMathWrong";
            this.txtMathWrong.Size = new System.Drawing.Size(148, 34);
            this.txtMathWrong.TabIndex = 5;
            // 
            // txtMathCorrect
            // 
            this.txtMathCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtMathCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathCorrect.Location = new System.Drawing.Point(100, 75);
            this.txtMathCorrect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMathCorrect.Name = "txtMathCorrect";
            this.txtMathCorrect.Size = new System.Drawing.Size(148, 34);
            this.txtMathCorrect.TabIndex = 16;
            // 
            // lblMathNet
            // 
            this.lblMathNet.AutoSize = true;
            this.lblMathNet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathNet.ForeColor = System.Drawing.Color.Black;
            this.lblMathNet.Location = new System.Drawing.Point(8, 202);
            this.lblMathNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathNet.Name = "lblMathNet";
            this.lblMathNet.Size = new System.Drawing.Size(52, 28);
            this.lblMathNet.TabIndex = 3;
            this.lblMathNet.Text = "Net:";
            // 
            // lblMathBlank
            // 
            this.lblMathBlank.AutoSize = true;
            this.lblMathBlank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathBlank.ForeColor = System.Drawing.Color.Black;
            this.lblMathBlank.Location = new System.Drawing.Point(9, 157);
            this.lblMathBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathBlank.Name = "lblMathBlank";
            this.lblMathBlank.Size = new System.Drawing.Size(71, 28);
            this.lblMathBlank.TabIndex = 2;
            this.lblMathBlank.Text = "Blank:";
            // 
            // lblMathWrong
            // 
            this.lblMathWrong.AutoSize = true;
            this.lblMathWrong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathWrong.ForeColor = System.Drawing.Color.Black;
            this.lblMathWrong.Location = new System.Drawing.Point(9, 115);
            this.lblMathWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathWrong.Name = "lblMathWrong";
            this.lblMathWrong.Size = new System.Drawing.Size(81, 28);
            this.lblMathWrong.TabIndex = 1;
            this.lblMathWrong.Text = "Wrong:";
            // 
            // lblMathCorrect
            // 
            this.lblMathCorrect.AutoSize = true;
            this.lblMathCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathCorrect.ForeColor = System.Drawing.Color.Black;
            this.lblMathCorrect.Location = new System.Drawing.Point(9, 78);
            this.lblMathCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathCorrect.Name = "lblMathCorrect";
            this.lblMathCorrect.Size = new System.Drawing.Size(86, 28);
            this.lblMathCorrect.TabIndex = 0;
            this.lblMathCorrect.Text = "Correct:";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScience.Location = new System.Drawing.Point(8, 269);
            this.lblScience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(99, 32);
            this.lblScience.TabIndex = 42;
            this.lblScience.Text = "Science";
            // 
            // lblMathematics
            // 
            this.lblMathematics.AutoSize = true;
            this.lblMathematics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathematics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMathematics.Location = new System.Drawing.Point(5, 32);
            this.lblMathematics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMathematics.Name = "lblMathematics";
            this.lblMathematics.Size = new System.Drawing.Size(160, 32);
            this.lblMathematics.TabIndex = 41;
            this.lblMathematics.Text = "Mathematics";
            // 
            // AddExamStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.grpScores);
            this.Controls.Add(this.dtpDateTaken);
            this.Controls.Add(this.lblDateTaken);
            this.Controls.Add(this.cmbExamName);
            this.Controls.Add(this.lblExamName);
            this.Controls.Add(this.cmbExamStudent);
            this.Controls.Add(this.lblSelectStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddExamStu";
            this.Size = new System.Drawing.Size(1278, 809);
            this.grpScores.ResumeLayout(false);
            this.grpVerbal.ResumeLayout(false);
            this.grpVerbal.PerformLayout();
            this.grpNumerical.ResumeLayout(false);
            this.grpNumerical.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.ComboBox cmbExamStudent;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.ComboBox cmbExamName;
        private System.Windows.Forms.Label lblDateTaken;
        private System.Windows.Forms.DateTimePicker dtpDateTaken;
        private System.Windows.Forms.GroupBox grpScores;
        private System.Windows.Forms.GroupBox grpNumerical;
        private System.Windows.Forms.GroupBox grpVerbal;
        private System.Windows.Forms.Button btnSaveExam;
        private System.Windows.Forms.Label lblMathCorrect;
        private System.Windows.Forms.Label lblMathWrong;
        private System.Windows.Forms.Label lblMathBlank;
        private System.Windows.Forms.Label lblMathNet;
        private System.Windows.Forms.TextBox txtMathCorrect;
        private System.Windows.Forms.TextBox txtMathWrong;
        private System.Windows.Forms.TextBox txtMathBlank;
        private System.Windows.Forms.TextBox txtMathNet;
        private System.Windows.Forms.Label lblScienceCorrect;
        private System.Windows.Forms.Label lblScienceWrong;
        private System.Windows.Forms.Label lblScienceBlank;
        private System.Windows.Forms.Label lblScienceNet;
        private System.Windows.Forms.TextBox txtScienceCorrect;
        private System.Windows.Forms.TextBox txtScienceWrong;
        private System.Windows.Forms.TextBox txtScienceBlank;
        private System.Windows.Forms.TextBox txtScienceNet;
        private System.Windows.Forms.Label lblTurkishCorrect;
        private System.Windows.Forms.Label lblTurkishWrong;
        private System.Windows.Forms.Label lblTurkishBlank;
        private System.Windows.Forms.Label lblTurkishNet;
        private System.Windows.Forms.TextBox txtTurkishCorrect;
        private System.Windows.Forms.TextBox txtTurkishWrong;
        private System.Windows.Forms.TextBox txtTurkishBlank;
        private System.Windows.Forms.TextBox txtTurkishNet;
        private System.Windows.Forms.Label lblHistoryCorrect;
        private System.Windows.Forms.Label lblHistoryWrong;
        private System.Windows.Forms.Label lblHistoryBlank;
        private System.Windows.Forms.Label lblHistoryNet;
        private System.Windows.Forms.TextBox txtHistoryCorrect;
        private System.Windows.Forms.TextBox txtHistoryWrong;
        private System.Windows.Forms.TextBox txtHistoryBlank;
        private System.Windows.Forms.TextBox txtHistoryNet;
        private System.Windows.Forms.Label lblReligionCorrect;
        private System.Windows.Forms.Label lblReligionWrong;
        private System.Windows.Forms.Label lblReligionBlank;
        private System.Windows.Forms.Label lblReligionNet;
        private System.Windows.Forms.TextBox txtReligionCorrect;
        private System.Windows.Forms.TextBox txtReligionWrong;
        private System.Windows.Forms.TextBox txtReligionBlank;
        private System.Windows.Forms.TextBox txtReligionNet;
        private System.Windows.Forms.Label lblEnglishCorrect;
        private System.Windows.Forms.Label lblEnglishWrong;
        private System.Windows.Forms.Label lblEnglishBlank;
        private System.Windows.Forms.Label lblEnglishNet;
        private System.Windows.Forms.TextBox txtEnglishCorrect;
        private System.Windows.Forms.TextBox txtEnglishWrong;
        private System.Windows.Forms.TextBox txtEnglishBlank;
        private System.Windows.Forms.TextBox txtEnglishNet;
        private System.Windows.Forms.Label lblMathematics;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblTurkish;
        private System.Windows.Forms.Label lblRevolutionHistory;
        private System.Windows.Forms.Label lblReligionEthics;
        private System.Windows.Forms.Label lblEnglish;
    }
}