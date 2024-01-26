namespace StudentManagement
{
    partial class AdminAccess
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
            this.findFile = new System.Windows.Forms.Button();
            this.changePIorCred = new System.Windows.Forms.Label();
            this.textFileDisplay = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.saveTextFileandLaunchAcaSelect = new System.Windows.Forms.Button();
            this.saveTextFileLogic = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findFile
            // 
            this.findFile.BackColor = System.Drawing.Color.Goldenrod;
            this.findFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFile.Location = new System.Drawing.Point(170, 66);
            this.findFile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.findFile.Name = "findFile";
            this.findFile.Size = new System.Drawing.Size(92, 37);
            this.findFile.TabIndex = 20;
            this.findFile.Text = "Browse";
            this.findFile.UseVisualStyleBackColor = false;
            this.findFile.Click += new System.EventHandler(this.findFile_Click);
            // 
            // changePIorCred
            // 
            this.changePIorCred.AutoSize = true;
            this.changePIorCred.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePIorCred.ForeColor = System.Drawing.Color.White;
            this.changePIorCred.Location = new System.Drawing.Point(142, 27);
            this.changePIorCred.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changePIorCred.Name = "changePIorCred";
            this.changePIorCred.Size = new System.Drawing.Size(331, 17);
            this.changePIorCred.TabIndex = 19;
            this.changePIorCred.Text = "Change Instructor Credentials, Name, Year, and/or PIs:\r\n";
            this.changePIorCred.Click += new System.EventHandler(this.changePIorCred_Click);
            // 
            // textFileDisplay
            // 
            this.textFileDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textFileDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileDisplay.ForeColor = System.Drawing.Color.White;
            this.textFileDisplay.Location = new System.Drawing.Point(33, 129);
            this.textFileDisplay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textFileDisplay.Name = "textFileDisplay";
            this.textFileDisplay.Size = new System.Drawing.Size(553, 250);
            this.textFileDisplay.TabIndex = 18;
            this.textFileDisplay.Text = "";
            this.textFileDisplay.TextChanged += new System.EventHandler(this.textFileDisplay_TextChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Goldenrod;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(11, 420);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 45);
            this.Exit.TabIndex = 22;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // saveTextFileandLaunchAcaSelect
            // 
            this.saveTextFileandLaunchAcaSelect.BackColor = System.Drawing.Color.Goldenrod;
            this.saveTextFileandLaunchAcaSelect.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTextFileandLaunchAcaSelect.Location = new System.Drawing.Point(459, 420);
            this.saveTextFileandLaunchAcaSelect.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.saveTextFileandLaunchAcaSelect.Name = "saveTextFileandLaunchAcaSelect";
            this.saveTextFileandLaunchAcaSelect.Size = new System.Drawing.Size(157, 45);
            this.saveTextFileandLaunchAcaSelect.TabIndex = 21;
            this.saveTextFileandLaunchAcaSelect.Text = "Back to Main Menu ";
            this.saveTextFileandLaunchAcaSelect.UseVisualStyleBackColor = false;
            this.saveTextFileandLaunchAcaSelect.Click += new System.EventHandler(this.saveTextFileandLaunchAcaSelect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(627, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.saveTextFileandLaunchAcaSelect);
            this.Controls.Add(this.findFile);
            this.Controls.Add(this.changePIorCred);
            this.Controls.Add(this.textFileDisplay);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminAccess";
            this.Text = "AdminAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findFile;
        private System.Windows.Forms.Label changePIorCred;
        private System.Windows.Forms.RichTextBox textFileDisplay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button saveTextFileandLaunchAcaSelect;
        private System.Windows.Forms.SaveFileDialog saveTextFileLogic;
        private System.Windows.Forms.Button button1;
    }
}