using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace StudentManagement
{
    public partial class AcademicSelect : Form
    {
        int yearPointer;
        string year;
        string filePath = @"..\..\TextFiles\ProfNameYear\Year.txt";
        public AcademicSelect()
        {
            InitializeComponent();



            StartPosition = FormStartPosition.CenterScreen;

            int currentLine = 0;

            using (StreamReader sr = new StreamReader(@"..\..\TextFiles\ProfNameYear\Year.txt"))
            {
                string line;


                while ((line = sr.ReadLine()) != null)
                {
                    currentLine++;

                    switch (currentLine)
                    {
                        case 1: yearOne.Text = line; break;
                        case 2: yearTwo.Text = line; break;
                        case 3: yearThree.Text = line; break;
                        case 4: yearFour.Text = line; break;
                    }


                }
            }
        }

        private void AcademicSelect_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (yearOne.Checked && yearTwo.Checked)
                System.Windows.Forms.Application.Exit();
            if (yearOne.Checked && yearThree.Checked)
                System.Windows.Forms.Application.Exit();
            if (yearOne.Checked && yearFour.Checked)
                System.Windows.Forms.Application.Exit();
            if (yearTwo.Checked && yearThree.Checked)
                System.Windows.Forms.Application.Exit();
            if (yearTwo.Checked && yearFour.Checked)
                System.Windows.Forms.Application.Exit();
            if (yearThree.Checked && yearFour.Checked)
                System.Windows.Forms.Application.Exit();

            if (yearOne.Checked)
            {
                yearPointer = 1;
                year = yearOne.Text;
            }
            if (yearTwo.Checked)
            {
                yearPointer = 2;
                year = yearTwo.Text;
            }
            if (yearThree.Checked)
            {
                yearPointer = 3;
                year = yearThree.Text;
            }
            if (yearFour.Checked)
            {
                yearPointer = 4;
                year = yearFour.Text;
            }


            this.Hide();

            
            InstructorSelect additionForm = new InstructorSelect(year);
            additionForm.ShowDialog();
        }

        private void yearThree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yearTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yearOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void adminAccess_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin additionForm = new AdminLogin();
            additionForm.ShowDialog();
        }

        private void schoolName_Click(object sender, EventArgs e)
        {

        }

        private void yearFour_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}

