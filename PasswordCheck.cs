using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Net.Http;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace StudentManagement
{
    public partial class PasswordCheck : Form
    {
        private int attemptsRemaining = 3;
        public string instructorSelected, year;
        public PasswordCheck(string CurrentYear, string CurrentInstructor)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            instructor.Text = CurrentInstructor;
            instructorSelected = CurrentInstructor;
            year = CurrentYear;
        }

        private void nextToPIViewer_Click(object sender, EventArgs e)
        {

        }

        private void passwordInputCheck_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void numberOfAttempts_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterPrompt_Click(object sender, EventArgs e)
        {

        }

        private void nextToPIViewer_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Read the password from the text file
                string instructor1Password = @"..\..\TextFiles\Credentials\Credentials1.txt"; // Replace with the actual path to your text file
                string instructor2Password = @"..\..\TextFiles\Credentials\Credentials2.txt";
                string instructor3Password = @"..\..\TextFiles\Credentials\Credentials3.txt";
                string instructor4Password = @"..\..\TextFiles\Credentials\Credentials4.txt";

                string storedPassword = "";

                string choice = Inform.Choice;

                if (choice == "one")
                {
                   storedPassword = File.ReadAllText(instructor1Password).Trim();
                }
                if (choice == "two")
                {
                    storedPassword = File.ReadAllText(instructor2Password).Trim();
                }
                if (choice == "three")
                {
                    storedPassword = File.ReadAllText(instructor3Password).Trim();
                }
                if (choice == "four")
                {
                    storedPassword = File.ReadAllText(instructor4Password).Trim();
                }

                //string storedPassword = File.ReadAllText(filePath).Trim();

                // Get the entered password from the TextBox
                string enteredPassword = passwordInputCheck.Text.Trim();

                // Compare passwords
                if (string.Equals(storedPassword, enteredPassword))
                {
                    this.Hide();



                    PIViewer additionForm = new PIViewer(instructorSelected,year);
                    additionForm.ShowDialog();
                }
                else
                {
                    attemptsRemaining--;

                    if (attemptsRemaining > 0)
                    {
                        numberOfAttempts.Text = $"{attemptsRemaining}";
                        errorIncorrect.Text = $"Incorrect Password";
                    }
                    else
                    {
                        MessageBox.Show("You have run out of attempts. Application will close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Windows.Forms.Application.Exit();
                    }
                }

                passwordInputCheck.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error checking password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //https://chat.openai.com/c/4753c3db-8d2c-4da3-bf72-c488969075ac

        private void PasswordCheck_Load(object sender, EventArgs e)
        {

        }

    }

}