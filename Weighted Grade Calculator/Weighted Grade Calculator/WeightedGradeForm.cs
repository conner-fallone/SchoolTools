using System;
using System.Collections;
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
    public partial class WeightedGradeForm : Form
    {
        ArrayList values = new ArrayList();
        decimal totalWeight;
        decimal finalGrade;

        public WeightedGradeForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (pointsPossibleNumeric.Value == 0 || weightNumeric.Value == 0){
                MessageBox.Show("Can't have 0 points possible or weight.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (pointsEarnedNumeric.Value > pointsPossibleNumeric.Value){
                MessageBox.Show("Can't have higher earned points than possible points.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal percentage = pointsEarnedNumeric.Value / pointsPossibleNumeric.Value;
            percentage = percentage * (weightNumeric.Value * (decimal).01) * 100;
            percentEarnedBox.AppendText("This accounted for " + percentage.ToString("#.##") + "% of your grade.\n");

            values.Add(percentage);
            totalWeight += weightNumeric.Value;

            pointsEarnedNumeric.Value = 0;
            pointsPossibleNumeric.Value = 0;
            weightNumeric.Value = 0;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (values.Count == 0){
                MessageBox.Show("You haven't added any scores yet!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            calculateBtn.Enabled = false;
            addBtn.Enabled = false;
            pointsEarnedNumeric.Enabled = false;
            pointsPossibleNumeric.Enabled = false;
            weightNumeric.Enabled = false;

            for (int i = 0; i < values.Count; i++)
            {
                finalGrade += (decimal)values[i];
            }

            finalGrade = (finalGrade / totalWeight) * 100;
            finalGradeBox.AppendText("Your final grade is: " + finalGrade.ToString("#.##") + "%.\n");
            finalProgress.Value = (int)finalGrade;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            values.Clear();
            finalGradeBox.Clear();
            percentEarnedBox.Clear();
            totalWeight = 0;
            finalGrade = 0;

            pointsEarnedNumeric.Value = 0;
            pointsPossibleNumeric.Value = 0;
            weightNumeric.Value = 0;

            calculateBtn.Enabled = true;
            addBtn.Enabled = true;
            pointsEarnedNumeric.Enabled = true;
            pointsPossibleNumeric.Enabled = true;
            weightNumeric.Enabled = true;

            finalProgress.Value = 0;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartBtn_Click(sender, e);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void pointsEarnedNumeric_Enter(object sender, EventArgs e)
        {
            pointsEarnedNumeric.Select(0, pointsEarnedNumeric.Value.ToString().Length);
        }

        private void pointsPossibleNumeric_Enter(object sender, EventArgs e)
        {
            pointsPossibleNumeric.Select(0, pointsPossibleNumeric.Value.ToString().Length);
        }

        private void weightNumeric_Enter(object sender, EventArgs e)
        {
            weightNumeric.Select(0, weightNumeric.Value.ToString().Length);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Conner Fallone" + Environment.NewLine + "Version: 1", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Add your scores." + Environment.NewLine
                + "For each weighted category in your class, " + 
                "compute your points earned, points possible, and that categories weight. " + 
                "When you have entered all values for this category, click add." + Environment.NewLine + Environment.NewLine +
                " 2. Continue to add scores until you have added them all." + Environment.NewLine +
                " 3. Press calculate. This will show your final grade.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void gpaButton_Click(object sender, EventArgs e)
        {
            GPACalculatorForm gpaForm = new GPACalculatorForm();
            this.Hide();
            gpaForm.ShowDialog();
            this.Close();
        }

    }
}
