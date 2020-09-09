namespace HW1_GUI
{
    partial class virtualPlanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assignmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.assignmentType = new System.Windows.Forms.GroupBox();
            this.homeworkButton = new System.Windows.Forms.RadioButton();
            this.quizButton = new System.Windows.Forms.RadioButton();
            this.examButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleOfApplication = new System.Windows.Forms.Label();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.assignmentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignmentName
            // 
            this.assignmentName.Location = new System.Drawing.Point(183, 83);
            this.assignmentName.Name = "assignmentName";
            this.assignmentName.Size = new System.Drawing.Size(224, 26);
            this.assignmentName.TabIndex = 0;
            this.assignmentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assignment Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(444, 83);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.Tag = "?";
            // 
            // assignmentType
            // 
            this.assignmentType.Controls.Add(this.examButton);
            this.assignmentType.Controls.Add(this.quizButton);
            this.assignmentType.Controls.Add(this.homeworkButton);
            this.assignmentType.Location = new System.Drawing.Point(38, 136);
            this.assignmentType.Name = "assignmentType";
            this.assignmentType.Size = new System.Drawing.Size(369, 100);
            this.assignmentType.TabIndex = 3;
            this.assignmentType.TabStop = false;
            this.assignmentType.Text = "Assignment Type";
            this.assignmentType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // homeworkButton
            // 
            this.homeworkButton.AutoSize = true;
            this.homeworkButton.Location = new System.Drawing.Point(29, 44);
            this.homeworkButton.Name = "homeworkButton";
            this.homeworkButton.Size = new System.Drawing.Size(110, 24);
            this.homeworkButton.TabIndex = 0;
            this.homeworkButton.TabStop = true;
            this.homeworkButton.Text = "Homework";
            this.homeworkButton.UseVisualStyleBackColor = true;
            this.homeworkButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // quizButton
            // 
            this.quizButton.AutoSize = true;
            this.quizButton.Location = new System.Drawing.Point(165, 44);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(83, 24);
            this.quizButton.TabIndex = 1;
            this.quizButton.TabStop = true;
            this.quizButton.Text = "Project";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // examButton
            // 
            this.examButton.AutoSize = true;
            this.examButton.Location = new System.Drawing.Point(268, 44);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(74, 24);
            this.examButton.TabIndex = 2;
            this.examButton.TabStop = true;
            this.examButton.Text = "Exam";
            this.examButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(34, 268);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(82, 20);
            this.dueDateLabel.TabIndex = 5;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(580, 388);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(77, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(684, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 33);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // titleOfApplication
            // 
            this.titleOfApplication.AutoSize = true;
            this.titleOfApplication.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOfApplication.Location = new System.Drawing.Point(279, 21);
            this.titleOfApplication.Name = "titleOfApplication";
            this.titleOfApplication.Size = new System.Drawing.Size(230, 36);
            this.titleOfApplication.TabIndex = 8;
            this.titleOfApplication.Text = "Virtual Planner";
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.AutoSize = true;
            this.completedCheckBox.Location = new System.Drawing.Point(302, 312);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(112, 24);
            this.completedCheckBox.TabIndex = 9;
            this.completedCheckBox.Text = "Completed";
            this.completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // virtualPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.completedCheckBox);
            this.Controls.Add(this.titleOfApplication);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.assignmentType);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignmentName);
            this.Name = "virtualPlanner";
            this.Text = "Virtual Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.assignmentType.ResumeLayout(false);
            this.assignmentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assignmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox assignmentType;
        private System.Windows.Forms.RadioButton examButton;
        private System.Windows.Forms.RadioButton quizButton;
        private System.Windows.Forms.RadioButton homeworkButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleOfApplication;
        private System.Windows.Forms.CheckBox completedCheckBox;
    }
}

