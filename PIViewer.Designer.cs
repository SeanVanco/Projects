namespace StudentManagement
{
    partial class PIViewer
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
            this.selectorOfPI = new System.Windows.Forms.RichTextBox();
            this.PIIntroductoryText = new System.Windows.Forms.Label();
            this.browsePIButton = new System.Windows.Forms.Button();
            this.nextToStudentSelection = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.Label();
            this.instructor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.three = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectorOfPI
            // 
            this.selectorOfPI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectorOfPI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectorOfPI.ForeColor = System.Drawing.Color.White;
            this.selectorOfPI.Location = new System.Drawing.Point(12, 145);
            this.selectorOfPI.Name = "selectorOfPI";
            this.selectorOfPI.Size = new System.Drawing.Size(664, 207);
            this.selectorOfPI.TabIndex = 0;
            this.selectorOfPI.Text = "";
            this.selectorOfPI.TextChanged += new System.EventHandler(this.selectorOfPI_TextChanged);
            // 
            // PIIntroductoryText
            // 
            this.PIIntroductoryText.AutoSize = true;
            this.PIIntroductoryText.BackColor = System.Drawing.Color.Goldenrod;
            this.PIIntroductoryText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIIntroductoryText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PIIntroductoryText.Location = new System.Drawing.Point(152, 77);
            this.PIIntroductoryText.Name = "PIIntroductoryText";
            this.PIIntroductoryText.Size = new System.Drawing.Size(379, 17);
            this.PIIntroductoryText.TabIndex = 1;
            this.PIIntroductoryText.Text = "Please Select the Course You Would Like to Enter Students To:";
            this.PIIntroductoryText.Click += new System.EventHandler(this.PIIntroductoryText_Click);
            // 
            // browsePIButton
            // 
            this.browsePIButton.BackColor = System.Drawing.Color.Goldenrod;
            this.browsePIButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsePIButton.Location = new System.Drawing.Point(303, 101);
            this.browsePIButton.Name = "browsePIButton";
            this.browsePIButton.Size = new System.Drawing.Size(79, 38);
            this.browsePIButton.TabIndex = 2;
            this.browsePIButton.Text = "Browse";
            this.browsePIButton.UseVisualStyleBackColor = false;
            this.browsePIButton.Click += new System.EventHandler(this.browsePIButton_Click);
            // 
            // nextToStudentSelection
            // 
            this.nextToStudentSelection.BackColor = System.Drawing.Color.Goldenrod;
            this.nextToStudentSelection.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextToStudentSelection.Location = new System.Drawing.Point(567, 366);
            this.nextToStudentSelection.Name = "nextToStudentSelection";
            this.nextToStudentSelection.Size = new System.Drawing.Size(115, 63);
            this.nextToStudentSelection.TabIndex = 3;
            this.nextToStudentSelection.Text = "Submit Selection and Begin Selecting Students?";
            this.nextToStudentSelection.UseVisualStyleBackColor = false;
            this.nextToStudentSelection.Click += new System.EventHandler(this.nextToStudentSelection_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Goldenrod;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(12, 364);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 65);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.White;
            this.year.Location = new System.Drawing.Point(406, 46);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(36, 17);
            this.year.TabIndex = 5;
            this.year.Text = "Year";
            this.year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructor
            // 
            this.instructor.AutoSize = true;
            this.instructor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructor.ForeColor = System.Drawing.Color.White;
            this.instructor.Location = new System.Drawing.Point(234, 46);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(65, 17);
            this.instructor.TabIndex = 6;
            this.instructor.Text = "Instructor";
            this.instructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Selection:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.one.Location = new System.Drawing.Point(122, 426);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(64, 20);
            this.one.TabIndex = 10;
            this.one.TextChanged += new System.EventHandler(this.one_TextChanged);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.two.Location = new System.Drawing.Point(300, 426);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(64, 20);
            this.two.TabIndex = 11;
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.three.Location = new System.Drawing.Point(484, 426);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(64, 20);
            this.three.TabIndex = 12;
            this.three.TextChanged += new System.EventHandler(this.three_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(125, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter the Thresholds You Would Like 1, 2 and 3 to be Represented By:\r\nExample:\r\n6" +
    "0, 80, 90";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(143, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "1\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(325, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(509, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(694, 493);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.year);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.nextToStudentSelection);
            this.Controls.Add(this.browsePIButton);
            this.Controls.Add(this.PIIntroductoryText);
            this.Controls.Add(this.selectorOfPI);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PIViewer";
            this.Text = "PIViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox selectorOfPI;
        private System.Windows.Forms.Label PIIntroductoryText;
        private System.Windows.Forms.Button browsePIButton;
        private System.Windows.Forms.Button nextToStudentSelection;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label instructor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}