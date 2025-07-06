namespace LGSApp
{
    partial class ChartsGraphsControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.ComboBox cmbExams;
        private System.Windows.Forms.ComboBox cmbDisplayType;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Label lblDisplayType;
        private System.Windows.Forms.Button btnShow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.lblChartType = new System.Windows.Forms.Label();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.lblExam = new System.Windows.Forms.Label();
            this.cmbExams = new System.Windows.Forms.ComboBox();
            this.lblDisplayType = new System.Windows.Forms.Label();
            this.cmbDisplayType = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(23, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Performance Charts && Graphs";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStudent.Location = new System.Drawing.Point(25, 88);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(132, 23);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Select Student:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStudents.Location = new System.Drawing.Point(214, 85);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(220, 31);
            this.cmbStudents.TabIndex = 2;
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChartType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblChartType.Location = new System.Drawing.Point(25, 128);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(159, 23);
            this.lblChartType.TabIndex = 3;
            this.lblChartType.Text = "Chart/Graph Type:";
            // 
            // cmbChartType
            // 
            this.cmbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChartType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbChartType.Location = new System.Drawing.Point(214, 125);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(220, 31);
            this.cmbChartType.TabIndex = 4;
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblExam.Location = new System.Drawing.Point(25, 168);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(111, 23);
            this.lblExam.TabIndex = 5;
            this.lblExam.Text = "Select Exam:";
            // 
            // cmbExams
            // 
            this.cmbExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbExams.Location = new System.Drawing.Point(214, 165);
            this.cmbExams.Name = "cmbExams";
            this.cmbExams.Size = new System.Drawing.Size(220, 31);
            this.cmbExams.TabIndex = 6;
            // 
            // lblDisplayType
            // 
            this.lblDisplayType.AutoSize = true;
            this.lblDisplayType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDisplayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDisplayType.Location = new System.Drawing.Point(25, 208);
            this.lblDisplayType.Name = "lblDisplayType";
            this.lblDisplayType.Size = new System.Drawing.Size(117, 23);
            this.lblDisplayType.TabIndex = 7;
            this.lblDisplayType.Text = "Display Type:";
            // 
            // cmbDisplayType
            // 
            this.cmbDisplayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDisplayType.Location = new System.Drawing.Point(214, 205);
            this.cmbDisplayType.Name = "cmbDisplayType";
            this.cmbDisplayType.Size = new System.Drawing.Size(220, 31);
            this.cmbDisplayType.TabIndex = 8;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Black;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(472, 201);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 43);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Controls.Add(this.btnShow);
            this.panelCard.Controls.Add(this.lblStudent);
            this.panelCard.Controls.Add(this.cmbDisplayType);
            this.panelCard.Controls.Add(this.cmbStudents);
            this.panelCard.Controls.Add(this.lblDisplayType);
            this.panelCard.Controls.Add(this.lblChartType);
            this.panelCard.Controls.Add(this.cmbExams);
            this.panelCard.Controls.Add(this.cmbChartType);
            this.panelCard.Controls.Add(this.lblExam);
            this.panelCard.Location = new System.Drawing.Point(16, 14);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(20);
            this.panelCard.Size = new System.Drawing.Size(667, 251);
            this.panelCard.TabIndex = 10;
            // 
            // ChartsGraphsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCard);
            this.Name = "ChartsGraphsControl";
            this.Size = new System.Drawing.Size(700, 281);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelCard;
    }
}
