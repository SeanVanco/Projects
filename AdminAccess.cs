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
using System.Diagnostics;
namespace StudentManagement
{
    public partial class AdminAccess : Form
    {
        public AdminAccess()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textFileDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveTextFileandLaunchAcaSelect_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            MenuSelect additionForm = new MenuSelect();
            additionForm.ShowDialog();

        }

        private void findFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                textFileDisplay.Text = text;
            }
        }
        //https://www.youtube.com/watch?v=w_TAzZg7Q0k

        private void changePIorCred_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void instructorThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructorThreeLabel_Click(object sender, EventArgs e)
        {

        }

        private void instructorTwoLabel_Click(object sender, EventArgs e)
        {

        }

        private void instructorOneLabel_Click(object sender, EventArgs e)
        {

        }

        private void instructorFour_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructorFourLabel_Click(object sender, EventArgs e)
        {

        }

        private void instructorTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructorOne_TextChanged(object sender, EventArgs e)
        {
            /*
            if (Convert.ToBoolean(instructorOne.Text)) {
                Inform.ProfName1 = instructorOne.Text;
            }
            else
            {
                Inform.ProfName1 = "Instructor 1";
            }
            */
        }

        private void saveInstruct_Click(object sender, EventArgs e)
        {
            //Inform.ProfName1 = instructorOne.Text;
            //Inform.ProfName2 = instructorTwo.Text;
            //Inform.ProfName3 = instructorThree.Text;
            //Inform.ProfName4 = instructorFour.Text;
        }

        private void saveYear_Click(object sender, EventArgs e)
        {
            //Inform.AccYear1 = accYearOne.Text;
            //Inform.AccYear2 = accYearTwo.Text;
           //Inform.AccYear3 = accYearThree.Text;
            //Inform.AccYear4 = accYearFour.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to get the file path
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set the default file extension and filter
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                // Show the SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Save the contents of the RichTextBox to the selected file
                        textFileDisplay.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // https://chat.openai.com/c/4753c3db-8d2c-4da3-bf72-c488969075ac
        }
    }
}
