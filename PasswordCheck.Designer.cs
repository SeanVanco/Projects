namespace StudentManagement
{
    partial class PasswordCheck
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
            this.passwordInputCheck = new System.Windows.Forms.RichTextBox();
            this.enterPrompt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfAttempts = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.nextToPIViewer = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.instructor = new System.Windows.Forms.Label();
            this.errorIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordInputCheck
            // 
            this.passwordInputCheck.BackColor = System.Drawing.Color.White;
            this.passwordInputCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInputCheck.Location = new System.Drawing.Point(166, 140);
            this.passwordInputCheck.Name = "passwordInputCheck";
            this.passwordInputCheck.Size = new System.Drawing.Size(125, 28);
            this.passwordInputCheck.TabIndex = 0;
            this.passwordInputCheck.Text = "";
            this.passwordInputCheck.TextChanged += new System.EventHandler(this.passwordInputCheck_TextChanged);
            // 
            // enterPrompt
            // 
            this.enterPrompt.AutoSize = true;
            this.enterPrompt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPrompt.ForeColor = System.Drawing.Color.Gold;
            this.enterPrompt.Location = new System.Drawing.Point(84, 9);
            this.enterPrompt.Name = "enterPrompt";
            this.enterPrompt.Size = new System.Drawing.Size(292, 19);
            this.enterPrompt.TabIndex = 2;
            this.enterPrompt.Text = "Please Enter the Password for the User Below:";
            this.enterPrompt.Click += new System.EventHandler(this.enterPrompt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(132, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attempts Remaining:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfAttempts
            // 
            this.numberOfAttempts.AutoSize = true;
            this.numberOfAttempts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAttempts.ForeColor = System.Drawing.Color.Gold;
            this.numberOfAttempts.Location = new System.Drawing.Point(287, 93);
            this.numberOfAttempts.Name = "numberOfAttempts";
            this.numberOfAttempts.Size = new System.Drawing.Size(17, 19);
            this.numberOfAttempts.TabIndex = 4;
            this.numberOfAttempts.Text = "3";
            this.numberOfAttempts.Click += new System.EventHandler(this.numberOfAttempts_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Goldenrod;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(11, 176);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 45);
            this.exit.TabIndex = 23;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // nextToPIViewer
            // 
            this.nextToPIViewer.BackColor = System.Drawing.Color.Goldenrod;
            this.nextToPIViewer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextToPIViewer.Location = new System.Drawing.Point(366, 173);
            this.nextToPIViewer.Margin = new System.Windows.Forms.Padding(2);
            this.nextToPIViewer.Name = "nextToPIViewer";
            this.nextToPIViewer.Size = new System.Drawing.Size(90, 45);
            this.nextToPIViewer.TabIndex = 24;
            this.nextToPIViewer.Text = "Next";
            this.nextToPIViewer.UseVisualStyleBackColor = false;
            this.nextToPIViewer.Click += new System.EventHandler(this.nextToPIViewer_Click_1);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(188, 97);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 15);
            this.errorMessage.TabIndex = 25;
            // 
            // instructor
            // 
            this.instructor.AutoSize = true;
            this.instructor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructor.ForeColor = System.Drawing.Color.Gold;
            this.instructor.Location = new System.Drawing.Point(198, 43);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(67, 19);
            this.instructor.TabIndex = 26;
            this.instructor.Text = "Instructor";
            // 
            // errorIncorrect
            // 
            this.errorIncorrect.AutoSize = true;
            this.errorIncorrect.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorIncorrect.ForeColor = System.Drawing.Color.Gold;
            this.errorIncorrect.Location = new System.Drawing.Point(163, 116);
            this.errorIncorrect.Name = "errorIncorrect";
            this.errorIncorrect.Size = new System.Drawing.Size(12, 17);
            this.errorIncorrect.TabIndex = 27;
            this.errorIncorrect.Text = " ";
            this.errorIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordCheck
            // 
            this.AcceptButton = this.nextToPIViewer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(467, 229);
            this.Controls.Add(this.errorIncorrect);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.nextToPIViewer);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.numberOfAttempts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterPrompt);
            this.Controls.Add(this.passwordInputCheck);
            this.Name = "PasswordCheck";
            this.Text = "PasswordCheck";
            this.Load += new System.EventHandler(this.PasswordCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox passwordInputCheck;
        private System.Windows.Forms.Label enterPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfAttempts;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button nextToPIViewer;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label instructor;
        private System.Windows.Forms.Label errorIncorrect;
    }
}