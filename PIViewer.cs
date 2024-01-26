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
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.CompilerServices;

namespace StudentManagement
{
    public partial class PIViewer : Form
    {
        string yearSet;
        string filePath = @"\TextFiles\OpenAccess\2020\PIs";
        string One, Two, Three;
        public PIViewer(string CurrentYear, string CurrentInstructor)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            year.Text = CurrentYear;
            yearSet = CurrentYear;
            instructor.Text = CurrentInstructor;
        }

        private void selectorOfPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextToStudentSelection_Click(object sender, EventArgs e)
        {

        if (one.Text == "" || two.Text == "" ||three.Text == "")
            {
                MessageBox.Show("You Did Not Fill In The Thresholds, Please Fill In Numbers That Are Representative For 1, 2, and 3.");
            }
        else
            {
                this.Hide();
                One = one.Text;
                Two = two.Text;
                Three = three.Text;
                StudentGradeEntry additionForm = new StudentGradeEntry(One, Two, Three);
                additionForm.ShowDialog();
            }
        }

        private void browsePIButton_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = filePath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string text = File.ReadAllText(openFileDialog.FileName);
                    selectorOfPI.Text = text;
                }

            }
            //https://www.youtube.com/watch?v=w_TAzZg7Q0k

            /*
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    string selectedDirectory = folderBrowser.SelectedPath;
                    instructor.Text = selectedDirectory;

                }
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void three_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_TextChanged(object sender, EventArgs e)
        {

        }

        private void PIIntroductoryText_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
