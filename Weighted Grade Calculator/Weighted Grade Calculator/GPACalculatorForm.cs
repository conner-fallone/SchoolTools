using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weighted_Grade_Calculator
{
    public partial class GPACalculatorForm : Form
    {
        string[] grades = { "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };
        double[] gradePoints = { 4.00, 3.67, 3.33, 3.00, 2.67, 2.33, 2.00, 1.67, 1.33, 1.00, .67, 0.00 };
        int[] creditHours = { 1, 2, 3, 4};
        double qualityPoints;
        double totalCreditHours;
        double totalQualityPoints;
        double finalGPA;

        public GPACalculatorForm()
        {
            InitializeComponent();
            gradeCombo.DataSource = grades;
            creditCombo.DataSource = creditHours;
        }

        private void addCreditBtn_Click(object sender, EventArgs e)
        {
            qualityPoints = gradePoints[gradeCombo.SelectedIndex] * creditHours[creditCombo.SelectedIndex];
            totalCreditHours += creditHours[creditCombo.SelectedIndex];
            totalQualityPoints += qualityPoints;
            qualityPointsEarnedBox.AppendText("Added grade " + grades[gradeCombo.SelectedIndex] + " for " + qualityPoints.ToString("#.##") + " quality points.\n");
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            finalGPA = totalQualityPoints / totalCreditHours;
            finalGPABox.AppendText("Your GPA is: " + finalGPA.ToString("#.###") + "\n");
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            qualityPoints = 0;
            totalCreditHours = 0;
            totalQualityPoints = 0;
            finalGPA = 0;
            qualityPointsEarnedBox.Clear();
            finalGPABox.Clear();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartBtn_Click(sender, e);
        }

        private void weightedGradeCalculatorBtn_Click(object sender, EventArgs e)
        {
            WeightedGradeForm weightedGradeForm = new WeightedGradeForm();
            this.Hide();
            weightedGradeForm.ShowDialog();
            this.Close();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Add each individual class and the grade received." + Environment.NewLine + 
                " 2. Continue to add classes until you have added them all." + Environment.NewLine +
                " 3. Press calculate. This will show your final GPA for the term.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }
    }
}
