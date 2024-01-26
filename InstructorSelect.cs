using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentManagement
{
    public partial class InstructorSelect: Form
    {

        string filePath = (@"..\..\TextFiles\ProfNameYear\ProfName.txt");
        int instructorPointer;
        string instructor;
        public string CurrentYear;
        public InstructorSelect(string currentYear)
        {
            InitializeComponent();
            selectedYear.Text = currentYear;
            CurrentYear = currentYear;

            StartPosition = FormStartPosition.CenterScreen;

            int currentLine = 0;

            using (StreamReader sr = new StreamReader(@"..\..\TextFiles\ProfNameYear\ProfName.txt"))
            {
                string line;


                while ((line = sr.ReadLine()) != null)
                {
                    currentLine++;

                    switch (currentLine)
                    {
                        case 1: instructorOne.Text = line; break;
                        case 2: instructorTwo.Text = line; break;
                        case 3: instructorThree.Text = line;break;
                        case 4: instructorFour.Text = line; break;
                    }


                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (instructorOne.Checked && instructorTwo.Checked)
                System.Windows.Forms.Application.Exit();

            if (instructorOne.Checked && instructorThree.Checked)
                System.Windows.Forms.Application.Exit();

            if (instructorOne.Checked && instructorFour.Checked)
                System.Windows.Forms.Application.Exit();

            if (instructorTwo.Checked && instructorThree.Checked)
                System.Windows.Forms.Application.Exit();

            if (instructorTwo.Checked && instructorFour.Checked)
                System.Windows.Forms.Application.Exit();

            if (instructorThree.Checked && instructorFour.Checked)
                System.Windows.Forms.Application.Exit();
            
           if(!instructorTwo.Checked && !instructorOne.Checked && !instructorThree.Checked && !instructorFour.Checked)
                System.Windows.Forms.Application.Exit();

            if (instructorOne.Checked)
            {
                instructorPointer = 1;
                instructor = instructorOne.Text;
            }
            if (instructorTwo.Checked)
            {
                instructorPointer = 2;
                instructor = instructorTwo.Text;
            }
            if (instructorThree.Checked)
            {
                instructorPointer = 3;
                instructor = instructorThree.Text;
            }
            if (instructorFour.Checked)
            {
                instructorPointer = 4;
                instructor = instructorFour.Text;
            }




            this.Hide();

            PasswordCheck additionForm = new PasswordCheck(CurrentYear,instructor);
            additionForm.ShowDialog();
        }

        private void instructorThree_CheckedChanged(object sender, EventArgs e)
        {
            Inform.Choice = "three";
        }

        private void instructorTwo_CheckedChanged(object sender, EventArgs e)
        {
            Inform.Choice = "two";
        }

        private void instructorOne_CheckedChanged(object sender, EventArgs e)
        {
            Inform.Choice = "one";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void schoolName_Click(object sender, EventArgs e)
        {

        }

        private void instructorFour_CheckedChanged(object sender, EventArgs e)
        {
            Inform.Choice = "four";
        }
        private string ReadSpecificLine(string filePath, int lineNumber)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found.", filePath);
            }

            // Read the specified line of the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                for (int i = 1; i < lineNumber; i++)
                {
                    // Read and discard lines until the desired line is reached
                    if (reader.ReadLine() == null)
                    {
                        return null; // File does not have the specified line
                    }
                }

                // Read and return the specified line
                return reader.ReadLine();
            }
        }

        private void InstructorSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
