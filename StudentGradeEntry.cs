using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentManagement
{
    public partial class StudentGradeEntry : Form
    {
        public StudentGradeEntry(string One, string Two, string Three )
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            oneMore.Text = One;
            OneOneMore.Text = One;
            TwoMore.Text = Two;
            TwoTwoMore.Text = Two;
            ThreeMore.Text = Three;
        }

        private void studentNameandGradeEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void studentEnterPrompt_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            // Get the content from the RichTextBox
            string content = studentNameandGradeEntry.Text;

            // Show a SaveFileDialog to choose the file path
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = saveFileDialog.FileName;
                    Inform.filePath = filePath;
                    //string filePath = @"..\..\TextFiles\StudentGrades\StudentGrades.txt";

                    try
                    {
                        // Write the content to the selected file
                        File.WriteAllText(filePath, content);
                        MessageBox.Show("Text saved to file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
            this.Hide();
            ExcelGraph additionForm = new ExcelGraph();
            additionForm.ShowDialog();
            this.Close();
        }

        private void exampleNameandGradeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StudentGradeEntry_Load(object sender, EventArgs e)
        {

        }

        private void oneMore_Click(object sender, EventArgs e)
        {

        }
    }
}
