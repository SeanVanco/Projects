namespace StudentManagement
{
    partial class ExcelGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.exitB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.passingRateInstructionLabel = new System.Windows.Forms.Label();
            this.failingRateInstructionLabel = new System.Windows.Forms.Label();
            this.passingRate = new System.Windows.Forms.Label();
            this.failingRate = new System.Windows.Forms.Label();
            this.allStudentsinClass = new System.Windows.Forms.Label();
            this.allStudents = new System.Windows.Forms.Label();
            this.feedbackBox = new System.Windows.Forms.RichTextBox();
            this.feedbackQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Goldenrod;
            this.exitB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.Location = new System.Drawing.Point(356, 389);
            this.exitB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(90, 45);
            this.exitB.TabIndex = 0;
            this.exitB.Text = "No";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "If You Would Like to Save the Graph, Please Use a Screen Capturing Software";
            // 
            // displayGraph
            // 
            this.displayGraph.BackColor = System.Drawing.SystemColors.HotTrack;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Gold;
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.Gold;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.Gold;
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.Gold;
            chartArea3.Name = "ChartArea1";
            this.displayGraph.ChartAreas.Add(chartArea3);
            this.displayGraph.Location = new System.Drawing.Point(9, 60);
            this.displayGraph.Name = "displayGraph";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.Gold;
            series3.LabelForeColor = System.Drawing.Color.Gold;
            series3.Name = "StudentGrades";
            this.displayGraph.Series.Add(series3);
            this.displayGraph.Size = new System.Drawing.Size(485, 140);
            this.displayGraph.TabIndex = 3;
            title3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Gold;
            title3.Name = "Title1";
            title3.Text = "Student and Grade Breakdown";
            this.displayGraph.Titles.Add(title3);
            this.displayGraph.Click += new System.EventHandler(this.displayGraph_Click);
            // 
            // passingRateInstructionLabel
            // 
            this.passingRateInstructionLabel.AutoSize = true;
            this.passingRateInstructionLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passingRateInstructionLabel.ForeColor = System.Drawing.Color.Gold;
            this.passingRateInstructionLabel.Location = new System.Drawing.Point(18, 216);
            this.passingRateInstructionLabel.Name = "passingRateInstructionLabel";
            this.passingRateInstructionLabel.Size = new System.Drawing.Size(243, 17);
            this.passingRateInstructionLabel.TabIndex = 4;
            this.passingRateInstructionLabel.Text = "Passing Rate of Current Selected Class:";
            this.passingRateInstructionLabel.Click += new System.EventHandler(this.amountofNames_Click);
            // 
            // failingRateInstructionLabel
            // 
            this.failingRateInstructionLabel.AutoSize = true;
            this.failingRateInstructionLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failingRateInstructionLabel.ForeColor = System.Drawing.Color.Gold;
            this.failingRateInstructionLabel.Location = new System.Drawing.Point(18, 244);
            this.failingRateInstructionLabel.Name = "failingRateInstructionLabel";
            this.failingRateInstructionLabel.Size = new System.Drawing.Size(236, 17);
            this.failingRateInstructionLabel.TabIndex = 5;
            this.failingRateInstructionLabel.Text = "Failing Rate of Current Selected Class:";
            // 
            // passingRate
            // 
            this.passingRate.AutoSize = true;
            this.passingRate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.passingRate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passingRate.ForeColor = System.Drawing.Color.Gold;
            this.passingRate.Location = new System.Drawing.Point(303, 216);
            this.passingRate.Name = "passingRate";
            this.passingRate.Size = new System.Drawing.Size(12, 17);
            this.passingRate.TabIndex = 6;
            this.passingRate.Text = " ";
            // 
            // failingRate
            // 
            this.failingRate.AutoSize = true;
            this.failingRate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.failingRate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failingRate.ForeColor = System.Drawing.Color.Gold;
            this.failingRate.Location = new System.Drawing.Point(303, 244);
            this.failingRate.Name = "failingRate";
            this.failingRate.Size = new System.Drawing.Size(12, 17);
            this.failingRate.TabIndex = 7;
            this.failingRate.Text = " ";
            // 
            // allStudentsinClass
            // 
            this.allStudentsinClass.AutoSize = true;
            this.allStudentsinClass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.allStudentsinClass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStudentsinClass.ForeColor = System.Drawing.Color.Gold;
            this.allStudentsinClass.Location = new System.Drawing.Point(303, 32);
            this.allStudentsinClass.Name = "allStudentsinClass";
            this.allStudentsinClass.Size = new System.Drawing.Size(12, 17);
            this.allStudentsinClass.TabIndex = 8;
            this.allStudentsinClass.Text = " ";
            // 
            // allStudents
            // 
            this.allStudents.AutoSize = true;
            this.allStudents.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStudents.ForeColor = System.Drawing.Color.Gold;
            this.allStudents.Location = new System.Drawing.Point(144, 33);
            this.allStudents.Name = "allStudents";
            this.allStudents.Size = new System.Drawing.Size(144, 17);
            this.allStudents.TabIndex = 9;
            this.allStudents.Text = "Total Students in Class:";
            // 
            // feedbackBox
            // 
            this.feedbackBox.Location = new System.Drawing.Point(8, 289);
            this.feedbackBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.Size = new System.Drawing.Size(487, 57);
            this.feedbackBox.TabIndex = 10;
            this.feedbackBox.Text = "";
            this.feedbackBox.TextChanged += new System.EventHandler(this.feedbackBox_TextChanged);
            // 
            // feedbackQuestion
            // 
            this.feedbackQuestion.AutoSize = true;
            this.feedbackQuestion.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackQuestion.ForeColor = System.Drawing.Color.Gold;
            this.feedbackQuestion.Location = new System.Drawing.Point(18, 269);
            this.feedbackQuestion.Name = "feedbackQuestion";
            this.feedbackQuestion.Size = new System.Drawing.Size(320, 17);
            this.feedbackQuestion.TabIndex = 11;
            this.feedbackQuestion.Text = "Provide Feedback to Increase Student Preformance?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(124, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Do You Want To Evaluate Another Class?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExcelGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(508, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feedbackQuestion);
            this.Controls.Add(this.feedbackBox);
            this.Controls.Add(this.allStudents);
            this.Controls.Add(this.allStudentsinClass);
            this.Controls.Add(this.failingRate);
            this.Controls.Add(this.passingRate);
            this.Controls.Add(this.failingRateInstructionLabel);
            this.Controls.Add(this.passingRateInstructionLabel);
            this.Controls.Add(this.displayGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitB);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ExcelGraph";
            this.Text = "ExcelGraph";
            ((System.ComponentModel.ISupportInitialize)(this.displayGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart displayGraph;
        private System.Windows.Forms.Label passingRateInstructionLabel;
        private System.Windows.Forms.Label failingRateInstructionLabel;
        private System.Windows.Forms.Label passingRate;
        private System.Windows.Forms.Label failingRate;
        private System.Windows.Forms.Label allStudentsinClass;
        private System.Windows.Forms.Label allStudents;
        private System.Windows.Forms.RichTextBox feedbackBox;
        private System.Windows.Forms.Label feedbackQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}