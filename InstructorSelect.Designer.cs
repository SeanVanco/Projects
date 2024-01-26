namespace StudentManagement
{
    partial class InstructorSelect
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
            this.instructorFour = new System.Windows.Forms.CheckBox();
            this.instructorThree = new System.Windows.Forms.CheckBox();
            this.instructorTwo = new System.Windows.Forms.CheckBox();
            this.instructorOne = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.schoolName = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructorFour
            // 
            this.instructorFour.AutoSize = true;
            this.instructorFour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorFour.ForeColor = System.Drawing.Color.Gold;
            this.instructorFour.Location = new System.Drawing.Point(212, 163);
            this.instructorFour.Margin = new System.Windows.Forms.Padding(2);
            this.instructorFour.Name = "instructorFour";
            this.instructorFour.Size = new System.Drawing.Size(98, 23);
            this.instructorFour.TabIndex = 30;
            this.instructorFour.Text = "Instructor 4";
            this.instructorFour.UseVisualStyleBackColor = true;
            this.instructorFour.CheckedChanged += new System.EventHandler(this.instructorFour_CheckedChanged);
            // 
            // instructorThree
            // 
            this.instructorThree.AutoSize = true;
            this.instructorThree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorThree.ForeColor = System.Drawing.Color.Gold;
            this.instructorThree.Location = new System.Drawing.Point(212, 140);
            this.instructorThree.Margin = new System.Windows.Forms.Padding(2);
            this.instructorThree.Name = "instructorThree";
            this.instructorThree.Size = new System.Drawing.Size(98, 23);
            this.instructorThree.TabIndex = 29;
            this.instructorThree.Text = "Instructor 3";
            this.instructorThree.UseVisualStyleBackColor = true;
            this.instructorThree.CheckedChanged += new System.EventHandler(this.instructorThree_CheckedChanged);
            // 
            // instructorTwo
            // 
            this.instructorTwo.AutoSize = true;
            this.instructorTwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorTwo.ForeColor = System.Drawing.Color.Gold;
            this.instructorTwo.Location = new System.Drawing.Point(212, 117);
            this.instructorTwo.Margin = new System.Windows.Forms.Padding(2);
            this.instructorTwo.Name = "instructorTwo";
            this.instructorTwo.Size = new System.Drawing.Size(98, 23);
            this.instructorTwo.TabIndex = 28;
            this.instructorTwo.Text = "Instructor 2";
            this.instructorTwo.UseVisualStyleBackColor = true;
            this.instructorTwo.CheckedChanged += new System.EventHandler(this.instructorTwo_CheckedChanged);
            // 
            // instructorOne
            // 
            this.instructorOne.AutoSize = true;
            this.instructorOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorOne.ForeColor = System.Drawing.Color.Gold;
            this.instructorOne.Location = new System.Drawing.Point(212, 94);
            this.instructorOne.Margin = new System.Windows.Forms.Padding(2);
            this.instructorOne.Name = "instructorOne";
            this.instructorOne.Size = new System.Drawing.Size(98, 23);
            this.instructorOne.TabIndex = 27;
            this.instructorOne.Text = "Instructor 1";
            this.instructorOne.UseVisualStyleBackColor = true;
            this.instructorOne.CheckedChanged += new System.EventHandler(this.instructorOne_CheckedChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Goldenrod;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(11, 203);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 45);
            this.exit.TabIndex = 26;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // schoolName
            // 
            this.schoolName.AutoSize = true;
            this.schoolName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.ForeColor = System.Drawing.Color.Gold;
            this.schoolName.Location = new System.Drawing.Point(108, 21);
            this.schoolName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(174, 19);
            this.schoolName.TabIndex = 24;
            this.schoolName.Text = "SUNY Polytechnic Insituite";
            this.schoolName.Click += new System.EventHandler(this.schoolName_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Goldenrod;
            this.next.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(279, 203);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(90, 45);
            this.next.TabIndex = 23;
            this.next.Text = "Next ->";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(182, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Please select an instructor:";
            // 
            // selectedYear
            // 
            this.selectedYear.AutoSize = true;
            this.selectedYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedYear.ForeColor = System.Drawing.Color.Gold;
            this.selectedYear.Location = new System.Drawing.Point(59, 129);
            this.selectedYear.Name = "selectedYear";
            this.selectedYear.Size = new System.Drawing.Size(42, 17);
            this.selectedYear.TabIndex = 32;
            this.selectedYear.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Selected Year:";
            // 
            // InstructorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(380, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructorFour);
            this.Controls.Add(this.instructorThree);
            this.Controls.Add(this.instructorTwo);
            this.Controls.Add(this.instructorOne);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.next);
            this.Name = "InstructorSelect";
            this.Text = "InstructorSelect";
            this.Load += new System.EventHandler(this.InstructorSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox instructorFour;
        private System.Windows.Forms.CheckBox instructorThree;
        private System.Windows.Forms.CheckBox instructorTwo;
        private System.Windows.Forms.CheckBox instructorOne;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label schoolName;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedYear;
        private System.Windows.Forms.Label label2;
    }
}