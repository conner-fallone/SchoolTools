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
            if (numericUpDown2.Value == 0 || numericUpDown3.Value == 0){
                MessageBox.Show("Can't have 0 points possible or weight.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (numericUpDown1.Value > numericUpDown2.Value){
                MessageBox.Show("Can't have higher earned points than possible points.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal percentage = numericUpDown1.Value / numericUpDown2.Value;
            percentage = percentage * (numericUpDown3.Value * (decimal).01) * 100;
            percentEarnedBox.AppendText("This accounted for " + percentage + "% of your grade.\n");

            values.Add(percentage);
            totalWeight += numericUpDown3.Value;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (values.Count == 0){
                MessageBox.Show("You haven't added any scores yet!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            calculateBtn.Enabled = false;
            addBtn.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;

            for (int i = 0; i < values.Count; i++)
            {
                finalGrade += (decimal)values[i];
            }

            finalGrade = (finalGrade / totalWeight) * 100;
            finalGradeBox.AppendText("Your final grade is: " + finalGrade + "%.\n");
            finalProgress.Value = (int)finalGrade;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            values.Clear();
            finalGradeBox.Clear();
            percentEarnedBox.Clear();
            totalWeight = 0;
            finalGrade = 0;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;

            calculateBtn.Enabled = true;
            addBtn.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;

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

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            numericUpDown2.Select(0, numericUpDown2.Value.ToString().Length);
        }

        private void numericUpDown3_Enter(object sender, EventArgs e)
        {
            numericUpDown3.Select(0, numericUpDown3.Value.ToString().Length);
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

        private void button2_Click(object sender, EventArgs e)
        {
            GPACalculatorForm gpaForm = new GPACalculatorForm();
            this.Hide();
            gpaForm.ShowDialog();
            this.Close();
        }

        private void WeightedGradeForm_Load(object sender, EventArgs e)
        {

        }

    }
}
