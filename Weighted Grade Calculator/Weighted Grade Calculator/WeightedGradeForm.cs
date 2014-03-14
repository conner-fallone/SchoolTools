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
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            values.Clear();
            finalGradeBox.Clear();
            percentEarnedBox.Clear();
            totalWeight = 0;
            finalGrade = 0;

            calculateBtn.Enabled = true;
            addBtn.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
        }
    }
}
