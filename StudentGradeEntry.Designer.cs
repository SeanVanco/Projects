namespace StudentManagement
{
    partial class StudentGradeEntry
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
            this.studentNameandGradeEntry = new System.Windows.Forms.RichTextBox();
            this.excelButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.studentEnterPrompt = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.exampleNameandGradeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oneMore = new System.Windows.Forms.Label();
            this.OneOneMore = new System.Windows.Forms.Label();
            this.TwoMore = new System.Windows.Forms.Label();
            this.TwoTwoMore = new System.Windows.Forms.Label();
            this.ThreeMore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentNameandGradeEntry
            // 
            this.studentNameandGradeEntry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.studentNameandGradeEntry.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameandGradeEntry.ForeColor = System.Drawing.Color.White;
            this.studentNameandGradeEntry.Location = new System.Drawing.Point(26, 123);
            this.studentNameandGradeEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentNameandGradeEntry.Name = "studentNameandGradeEntry";
            this.studentNameandGradeEntry.Size = new System.Drawing.Size(561, 250);
            this.studentNameandGradeEntry.TabIndex = 0;
            this.studentNameandGradeEntry.Text = "";
            this.studentNameandGradeEntry.TextChanged += new System.EventHandler(this.studentNameandGradeEntry_TextChanged);
            // 
            // excelButton
            // 
            this.excelButton.BackColor = System.Drawing.Color.Goldenrod;
            this.excelButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelButton.Location = new System.Drawing.Point(486, 419);
            this.excelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(120, 45);
            this.excelButton.TabIndex = 1;
            this.excelButton.Text = "Generate Graph";
            this.excelButton.UseVisualStyleBackColor = false;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Goldenrod;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(11, 420);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 45);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // studentEnterPrompt
            // 
            this.studentEnterPrompt.AutoSize = true;
            this.studentEnterPrompt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEnterPrompt.ForeColor = System.Drawing.Color.Gold;
            this.studentEnterPrompt.Location = new System.Drawing.Point(113, 11);
            this.studentEnterPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentEnterPrompt.Name = "studentEnterPrompt";
            this.studentEnterPrompt.Size = new System.Drawing.Size(412, 17);
            this.studentEnterPrompt.TabIndex = 3;
            this.studentEnterPrompt.Text = "Please Enter the Students and Grades from the Corresponding Class:";
            this.studentEnterPrompt.Click += new System.EventHandler(this.studentEnterPrompt_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.instructionLabel.Location = new System.Drawing.Point(190, 37);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(256, 17);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Please Enter in the Following Format:";
            this.instructionLabel.Click += new System.EventHandler(this.instructionLabel_Click);
            // 
            // exampleNameandGradeLabel
            // 
            this.exampleNameandGradeLabel.AutoSize = true;
            this.exampleNameandGradeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleNameandGradeLabel.ForeColor = System.Drawing.Color.Gold;
            this.exampleNameandGradeLabel.Location = new System.Drawing.Point(272, 67);
            this.exampleNameandGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exampleNameandGradeLabel.Name = "exampleNameandGradeLabel";
            this.exampleNameandGradeLabel.Size = new System.Drawing.Size(83, 34);
            this.exampleNameandGradeLabel.TabIndex = 5;
            this.exampleNameandGradeLabel.Text = "Name,Grade\r\nName,Grade\r\n";
            this.exampleNameandGradeLabel.Click += new System.EventHandler(this.exampleNameandGradeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(145, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Grades Based On the Following Format:\r\n1 = Grades < \r\n2 = Grades <=      <=" +
    " \r\n3 = Grades <       -     ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneMore
            // 
            this.oneMore.AutoSize = true;
            this.oneMore.BackColor = System.Drawing.Color.CadetBlue;
            this.oneMore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneMore.ForeColor = System.Drawing.Color.Purple;
            this.oneMore.Location = new System.Drawing.Point(343, 415);
            this.oneMore.Name = "oneMore";
            this.oneMore.Size = new System.Drawing.Size(21, 15);
            this.oneMore.TabIndex = 7;
            this.oneMore.Text = "60";
            this.oneMore.Click += new System.EventHandler(this.oneMore_Click);
            // 
            // OneOneMore
            // 
            this.OneOneMore.AutoSize = true;
            this.OneOneMore.BackColor = System.Drawing.Color.CadetBlue;
            this.OneOneMore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneOneMore.ForeColor = System.Drawing.Color.Purple;
            this.OneOneMore.Location = new System.Drawing.Point(327, 432);
            this.OneOneMore.Name = "OneOneMore";
            this.OneOneMore.Size = new System.Drawing.Size(21, 15);
            this.OneOneMore.TabIndex = 8;
            this.OneOneMore.Text = "60";
            // 
            // TwoMore
            // 
            this.TwoMore.AutoSize = true;
            this.TwoMore.BackColor = System.Drawing.Color.CadetBlue;
            this.TwoMore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoMore.ForeColor = System.Drawing.Color.Purple;
            this.TwoMore.Location = new System.Drawing.Point(371, 432);
            this.TwoMore.Name = "TwoMore";
            this.TwoMore.Size = new System.Drawing.Size(21, 15);
            this.TwoMore.TabIndex = 9;
            this.TwoMore.Text = "90";
            // 
            // TwoTwoMore
            // 
            this.TwoTwoMore.AutoSize = true;
            this.TwoTwoMore.BackColor = System.Drawing.Color.CadetBlue;
            this.TwoTwoMore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoTwoMore.ForeColor = System.Drawing.Color.Purple;
            this.TwoTwoMore.Location = new System.Drawing.Point(320, 448);
            this.TwoTwoMore.Name = "TwoTwoMore";
            this.TwoTwoMore.Size = new System.Drawing.Size(21, 15);
            this.TwoTwoMore.TabIndex = 10;
            this.TwoTwoMore.Text = "90";
            // 
            // ThreeMore
            // 
            this.ThreeMore.AutoSize = true;
            this.ThreeMore.BackColor = System.Drawing.Color.CadetBlue;
            this.ThreeMore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeMore.ForeColor = System.Drawing.Color.Purple;
            this.ThreeMore.Location = new System.Drawing.Point(354, 448);
            this.ThreeMore.Name = "ThreeMore";
            this.ThreeMore.Size = new System.Drawing.Size(28, 15);
            this.ThreeMore.TabIndex = 11;
            this.ThreeMore.Text = "100";
            // 
            // StudentGradeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(617, 475);
            this.Controls.Add(this.ThreeMore);
            this.Controls.Add(this.TwoTwoMore);
            this.Controls.Add(this.TwoMore);
            this.Controls.Add(this.OneOneMore);
            this.Controls.Add(this.oneMore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exampleNameandGradeLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.studentEnterPrompt);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.studentNameandGradeEntry);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentGradeEntry";
            this.Text = "StudentGradeEntry";
            this.Load += new System.EventHandler(this.StudentGradeEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox studentNameandGradeEntry;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label studentEnterPrompt;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label exampleNameandGradeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oneMore;
        private System.Windows.Forms.Label OneOneMore;
        private System.Windows.Forms.Label TwoMore;
        private System.Windows.Forms.Label TwoTwoMore;
        private System.Windows.Forms.Label ThreeMore;
    }
}