namespace Weighted_Grade_Calculator
{
    partial class GPACalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crdHoursLbl = new System.Windows.Forms.Label();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.gradeCombo = new System.Windows.Forms.ComboBox();
            this.creditCombo = new System.Windows.Forms.ComboBox();
            this.addCreditBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpaCalculatorBtn = new System.Windows.Forms.Button();
            this.weightedGradeCalculatorBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.todoButton = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.qualityPointsEarnedBox = new System.Windows.Forms.TextBox();
            this.finalGPABox = new System.Windows.Forms.TextBox();
            this.pointsEarnedLbl = new System.Windows.Forms.Label();
            this.finalGpaLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helloToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.usageToolStripMenuItem.Text = "Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // crdHoursLbl
            // 
            this.crdHoursLbl.AutoSize = true;
            this.crdHoursLbl.Location = new System.Drawing.Point(31, 50);
            this.crdHoursLbl.Name = "crdHoursLbl";
            this.crdHoursLbl.Size = new System.Drawing.Size(68, 13);
            this.crdHoursLbl.TabIndex = 19;
            this.crdHoursLbl.Text = "Credit Hours:";
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Location = new System.Drawing.Point(247, 50);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(39, 13);
            this.gradeLbl.TabIndex = 20;
            this.gradeLbl.Text = "Grade:";
            // 
            // gradeCombo
            // 
            this.gradeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeCombo.FormattingEnabled = true;
            this.gradeCombo.Location = new System.Drawing.Point(292, 47);
            this.gradeCombo.Name = "gradeCombo";
            this.gradeCombo.Size = new System.Drawing.Size(121, 21);
            this.gradeCombo.TabIndex = 21;
            // 
            // creditCombo
            // 
            this.creditCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditCombo.FormattingEnabled = true;
            this.creditCombo.Location = new System.Drawing.Point(104, 48);
            this.creditCombo.Name = "creditCombo";
            this.creditCombo.Size = new System.Drawing.Size(121, 21);
            this.creditCombo.TabIndex = 22;
            // 
            // addCreditBtn
            // 
            this.addCreditBtn.Location = new System.Drawing.Point(113, 74);
            this.addCreditBtn.Name = "addCreditBtn";
            this.addCreditBtn.Size = new System.Drawing.Size(75, 23);
            this.addCreditBtn.TabIndex = 23;
            this.addCreditBtn.Text = "Add to List";
            this.addCreditBtn.UseVisualStyleBackColor = true;
            this.addCreditBtn.Click += new System.EventHandler(this.addCreditBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(253, 74);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 24;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gpaCalculatorBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.weightedGradeCalculatorBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scheduleBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.todoButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 327);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 142);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // gpaCalculatorBtn
            // 
            this.gpaCalculatorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpaCalculatorBtn.Location = new System.Drawing.Point(101, 3);
            this.gpaCalculatorBtn.Name = "gpaCalculatorBtn";
            this.gpaCalculatorBtn.Size = new System.Drawing.Size(91, 65);
            this.gpaCalculatorBtn.TabIndex = 1;
            this.gpaCalculatorBtn.Text = "GPA Calculator";
            this.gpaCalculatorBtn.UseVisualStyleBackColor = true;
            // 
            // weightedGradeCalculatorBtn
            // 
            this.weightedGradeCalculatorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weightedGradeCalculatorBtn.Location = new System.Drawing.Point(3, 3);
            this.weightedGradeCalculatorBtn.Name = "weightedGradeCalculatorBtn";
            this.weightedGradeCalculatorBtn.Size = new System.Drawing.Size(91, 65);
            this.weightedGradeCalculatorBtn.TabIndex = 0;
            this.weightedGradeCalculatorBtn.Text = "Weighted Grade Calculator";
            this.weightedGradeCalculatorBtn.UseVisualStyleBackColor = true;
            this.weightedGradeCalculatorBtn.Click += new System.EventHandler(this.weightedGradeCalculatorBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleBtn.Location = new System.Drawing.Point(199, 3);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(92, 65);
            this.scheduleBtn.TabIndex = 2;
            this.scheduleBtn.Text = "My Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            // 
            // todoButton
            // 
            this.todoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoButton.Location = new System.Drawing.Point(3, 74);
            this.todoButton.Name = "todoButton";
            this.todoButton.Size = new System.Drawing.Size(91, 65);
            this.todoButton.TabIndex = 3;
            this.todoButton.Text = "Todo";
            this.todoButton.UseVisualStyleBackColor = true;
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(399, 74);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 26;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // qualityPointsEarnedBox
            // 
            this.qualityPointsEarnedBox.BackColor = System.Drawing.Color.Khaki;
            this.qualityPointsEarnedBox.Enabled = false;
            this.qualityPointsEarnedBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityPointsEarnedBox.Location = new System.Drawing.Point(34, 121);
            this.qualityPointsEarnedBox.Multiline = true;
            this.qualityPointsEarnedBox.Name = "qualityPointsEarnedBox";
            this.qualityPointsEarnedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.qualityPointsEarnedBox.Size = new System.Drawing.Size(294, 319);
            this.qualityPointsEarnedBox.TabIndex = 27;
            // 
            // finalGPABox
            // 
            this.finalGPABox.BackColor = System.Drawing.Color.Khaki;
            this.finalGPABox.Enabled = false;
            this.finalGPABox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalGPABox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.finalGPABox.Location = new System.Drawing.Point(338, 121);
            this.finalGPABox.Multiline = true;
            this.finalGPABox.Name = "finalGPABox";
            this.finalGPABox.Size = new System.Drawing.Size(294, 171);
            this.finalGPABox.TabIndex = 28;
            // 
            // pointsEarnedLbl
            // 
            this.pointsEarnedLbl.AutoSize = true;
            this.pointsEarnedLbl.Location = new System.Drawing.Point(31, 105);
            this.pointsEarnedLbl.Name = "pointsEarnedLbl";
            this.pointsEarnedLbl.Size = new System.Drawing.Size(108, 13);
            this.pointsEarnedLbl.TabIndex = 29;
            this.pointsEarnedLbl.Text = "Quality Points Earned";
            // 
            // finalGpaLbl
            // 
            this.finalGpaLbl.AutoSize = true;
            this.finalGpaLbl.Location = new System.Drawing.Point(335, 105);
            this.finalGpaLbl.Name = "finalGpaLbl";
            this.finalGpaLbl.Size = new System.Drawing.Size(54, 13);
            this.finalGpaLbl.TabIndex = 30;
            this.finalGpaLbl.Text = "Final GPA";
            // 
            // GPACalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(815, 509);
            this.Controls.Add(this.finalGpaLbl);
            this.Controls.Add(this.pointsEarnedLbl);
            this.Controls.Add(this.finalGPABox);
            this.Controls.Add(this.qualityPointsEarnedBox);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addCreditBtn);
            this.Controls.Add(this.creditCombo);
            this.Controls.Add(this.gradeCombo);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.crdHoursLbl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GPACalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPACalculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label crdHoursLbl;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.ComboBox gradeCombo;
        private System.Windows.Forms.ComboBox creditCombo;
        private System.Windows.Forms.Button addCreditBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button gpaCalculatorBtn;
        private System.Windows.Forms.Button weightedGradeCalculatorBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button todoButton;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.TextBox qualityPointsEarnedBox;
        private System.Windows.Forms.TextBox finalGPABox;
        private System.Windows.Forms.Label pointsEarnedLbl;
        private System.Windows.Forms.Label finalGpaLbl;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
    }
}