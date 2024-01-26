namespace StudentManagement
{
    partial class AcademicSelect
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
            this.yearFour = new System.Windows.Forms.CheckBox();
            this.yearThree = new System.Windows.Forms.CheckBox();
            this.yearTwo = new System.Windows.Forms.CheckBox();
            this.yearOne = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.schoolName = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearFour
            // 
            this.yearFour.AutoSize = true;
            this.yearFour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearFour.ForeColor = System.Drawing.Color.Gold;
            this.yearFour.Location = new System.Drawing.Point(144, 181);
            this.yearFour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearFour.Name = "yearFour";
            this.yearFour.Size = new System.Drawing.Size(132, 23);
            this.yearFour.TabIndex = 22;
            this.yearFour.Text = "Academic Year 4";
            this.yearFour.UseVisualStyleBackColor = true;
            this.yearFour.CheckedChanged += new System.EventHandler(this.yearFour_CheckedChanged);
            // 
            // yearThree
            // 
            this.yearThree.AutoSize = true;
            this.yearThree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearThree.ForeColor = System.Drawing.Color.Gold;
            this.yearThree.Location = new System.Drawing.Point(144, 157);
            this.yearThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearThree.Name = "yearThree";
            this.yearThree.Size = new System.Drawing.Size(132, 23);
            this.yearThree.TabIndex = 21;
            this.yearThree.Text = "Academic Year 3";
            this.yearThree.UseVisualStyleBackColor = true;
            this.yearThree.CheckedChanged += new System.EventHandler(this.yearThree_CheckedChanged);
            // 
            // yearTwo
            // 
            this.yearTwo.AutoSize = true;
            this.yearTwo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTwo.ForeColor = System.Drawing.Color.Gold;
            this.yearTwo.Location = new System.Drawing.Point(144, 133);
            this.yearTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearTwo.Name = "yearTwo";
            this.yearTwo.Size = new System.Drawing.Size(132, 23);
            this.yearTwo.TabIndex = 20;
            this.yearTwo.Text = "Academic Year 2";
            this.yearTwo.UseVisualStyleBackColor = true;
            this.yearTwo.CheckedChanged += new System.EventHandler(this.yearTwo_CheckedChanged);
            // 
            // yearOne
            // 
            this.yearOne.AutoSize = true;
            this.yearOne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearOne.ForeColor = System.Drawing.Color.Gold;
            this.yearOne.Location = new System.Drawing.Point(144, 109);
            this.yearOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearOne.Name = "yearOne";
            this.yearOne.Size = new System.Drawing.Size(132, 23);
            this.yearOne.TabIndex = 19;
            this.yearOne.Text = "Academic Year 1\r\n";
            this.yearOne.UseVisualStyleBackColor = true;
            this.yearOne.CheckedChanged += new System.EventHandler(this.yearOne_CheckedChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Goldenrod;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(11, 240);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 45);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // schoolName
            // 
            this.schoolName.AutoSize = true;
            this.schoolName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolName.ForeColor = System.Drawing.Color.Gold;
            this.schoolName.Location = new System.Drawing.Point(8, 9);
            this.schoolName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(174, 19);
            this.schoolName.TabIndex = 16;
            this.schoolName.Text = "SUNY Polytechnic Insituite";
            this.schoolName.Click += new System.EventHandler(this.schoolName_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Goldenrod;
            this.next.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(279, 240);
            this.next.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(90, 45);
            this.next.TabIndex = 15;
            this.next.Text = "Next ->";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(115, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Please select a year:\r\n";
            // 
            // AcademicSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(380, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearFour);
            this.Controls.Add(this.yearThree);
            this.Controls.Add(this.yearTwo);
            this.Controls.Add(this.yearOne);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.schoolName);
            this.Controls.Add(this.next);
            this.Name = "AcademicSelect";
            this.Text = "AcademicSelect";
            this.Load += new System.EventHandler(this.AcademicSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox yearFour;
        private System.Windows.Forms.CheckBox yearThree;
        private System.Windows.Forms.CheckBox yearTwo;
        private System.Windows.Forms.CheckBox yearOne;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label schoolName;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
    }
}

