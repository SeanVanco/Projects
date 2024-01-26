using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentManagement
{
    public partial class ExcelGraph : Form
    {
        private int names;
        bool pointer;
        float count1, count2, count3, totalstudents, passingStudents, failingStudents;
        float passRate, failRate;
        string passing, failing;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuSelect additionForm = new MenuSelect();
            additionForm.ShowDialog();
        }

        private void feedbackBox_TextChanged(object sender, EventArgs e)
        {

        }

        string year;


        //string filepath = (@"..\..\TextFiles\OpenAccess\StudentGrades\StudentGrades.txt");

        public ExcelGraph()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Chart chart = displayGraph;

            chart.Series.Clear();

            Series series = new Series("StudentTrends");
   
            //displayGraph.Series.Add("StudentTrends");
            series.Points.AddXY("1", CountingGradesInText.CountofCharacters(Inform.filePath, '1'));
            count1 = CountingGradesInText.CountofCharacters(Inform.filePath, '1');
            series.Points.AddXY("2", CountingGradesInText.CountofCharacters(Inform.filePath, '2'));
            count2 = CountingGradesInText.CountofCharacters(Inform.filePath, '2');
            series.Points.AddXY("3", CountingGradesInText.CountofCharacters(Inform.filePath, '3'));
            count3 = CountingGradesInText.CountofCharacters(Inform.filePath, '3');

            //DataPoint ones = displayGraph.Series["StudentTrends"].Points[1];
            //double oneYs = ones.YValues[0];
            //DataPoint twos = displayGraph.Series["StudentTrends"].Points[2];
            //DataPoint threes = displayGraph.Series["StudentTrends"].Points[3];

            //troubleshoot.Text = oneYs.ToString();
            /*
            double oneYs = ones.YValues[0];
            double twosYs = twos.YValues[1];
            double threesYs = threes.YValues[2];

            float totalStudents = (float)(oneYs + twosYs + threesYs);

            count1 = (float)(oneYs);
            count2 = (float)(twosYs);
            count3 = (float)(threesYs);
            */

            chart.Series.Add(series);

            chart.ChartAreas[0].AxisX.Title = "Grade Breakdown";
            chart.ChartAreas[0].AxisY.Title = "Amount of Students";
            string[] lines = File.ReadAllLines(Inform.filePath);
            chart.ChartAreas[0].AxisY.Maximum = lines.Length;
            chart.ChartAreas[0].AxisX.Maximum = 4;

            totalstudents = count1 + count2 + count3;

            allStudentsinClass.Text = totalstudents + "Students";

            passingStudents = count2 + count3;

            failingStudents = count1;

            passRate = (passingStudents/totalstudents)*100;
            Math.Round(passRate);
            failRate = (failingStudents/totalstudents)*100;
            Math.Round(failRate);

            passing = passRate.ToString();
            failing = failRate.ToString();

            passingRate.Text = passing + "%";
            failingRate.Text = failing + "%";

            allStudentsinClass.Text = totalstudents.ToString();

            if (passRate > failRate)
            {
                feedbackBox.Visible = false;
                feedbackQuestion.Visible = false;
                pointer = true;
            }
            else
            {
                feedbackBox.Visible = true;
                feedbackQuestion.Visible = true;

                pointer = false;
                
                
                feedbackQuestion.Text = "What Feedback Would You Like To Add To Enhance Student Performance?";
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            if (pointer == true)
            {
                System.Windows.Forms.Application.Exit();
            }

            if (pointer != true)
            {
                if (feedbackBox.Text != "")
                {
                    //string snipper = @"(@""..\..\Resources\
                    string content = feedbackBox.Text;

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Inform.filePath = saveFileDialog.FileName;

                            try
                            {
                                File.WriteAllText(Inform.filePath, content);
                                MessageBox.Show("Text saved properly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error saving requested file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    System.Windows.Forms.Application.Exit();
                }

                if (feedbackBox.Text == "")
                    MessageBox.Show("Please Enter Feedback");
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void displayGraph_Click(object sender, EventArgs e)
        {
           

        }

        private void amountofNames_Click(object sender, EventArgs e)
        {

        }

        private void chartTitle_Click(object sender, EventArgs e)
        {

        }

        //https://chat.openai.com/c/55497f52-4008-4697-949e-2b2f2e5a0bee
        //https://youtu.be/ySTpfFFuYh8?si=VLLrYEED_KCszNeQ
    }
}
