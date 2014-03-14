namespace Weighted_Grade_Calculator
{
    partial class WeightedGradeForm
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
            this.ptsEarnedLbl = new System.Windows.Forms.Label();
            this.ptsPossibleLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.percentEarnedBox = new System.Windows.Forms.TextBox();
            this.finalGradeBox = new System.Windows.Forms.TextBox();
            this.pctEarnedLbl = new System.Windows.Forms.Label();
            this.finalGradeLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptsEarnedLbl
            // 
            this.ptsEarnedLbl.AutoSize = true;
            this.ptsEarnedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsEarnedLbl.Location = new System.Drawing.Point(31, 50);
            this.ptsEarnedLbl.Name = "ptsEarnedLbl";
            this.ptsEarnedLbl.Size = new System.Drawing.Size(76, 13);
            this.ptsEarnedLbl.TabIndex = 1;
            this.ptsEarnedLbl.Text = "Points Earned:";
            // 
            // ptsPossibleLbl
            // 
            this.ptsPossibleLbl.AutoSize = true;
            this.ptsPossibleLbl.Location = new System.Drawing.Point(247, 50);
            this.ptsPossibleLbl.Name = "ptsPossibleLbl";
            this.ptsPossibleLbl.Size = new System.Drawing.Size(81, 13);
            this.ptsPossibleLbl.TabIndex = 2;
            this.ptsPossibleLbl.Text = "Points Possible:";
            this.ptsPossibleLbl.UseMnemonic = false;
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(465, 50);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(61, 13);
            this.weightLbl.TabIndex = 3;
            this.weightLbl.Text = "Weight (%):";
            this.weightLbl.UseMnemonic = false;
            // 
            // percentEarnedBox
            // 
            this.percentEarnedBox.BackColor = System.Drawing.Color.Khaki;
            this.percentEarnedBox.Enabled = false;
            this.percentEarnedBox.Location = new System.Drawing.Point(34, 121);
            this.percentEarnedBox.Multiline = true;
            this.percentEarnedBox.Name = "percentEarnedBox";
            this.percentEarnedBox.Size = new System.Drawing.Size(294, 354);
            this.percentEarnedBox.TabIndex = 6;
            // 
            // finalGradeBox
            // 
            this.finalGradeBox.BackColor = System.Drawing.Color.Khaki;
            this.finalGradeBox.Enabled = false;
            this.finalGradeBox.Location = new System.Drawing.Point(338, 121);
            this.finalGradeBox.Multiline = true;
            this.finalGradeBox.Name = "finalGradeBox";
            this.finalGradeBox.Size = new System.Drawing.Size(294, 171);
            this.finalGradeBox.TabIndex = 7;
            // 
            // pctEarnedLbl
            // 
            this.pctEarnedLbl.AutoSize = true;
            this.pctEarnedLbl.Location = new System.Drawing.Point(31, 105);
            this.pctEarnedLbl.Name = "pctEarnedLbl";
            this.pctEarnedLbl.Size = new System.Drawing.Size(81, 13);
            this.pctEarnedLbl.TabIndex = 8;
            this.pctEarnedLbl.Text = "Percent Earned";
            // 
            // finalGradeLbl
            // 
            this.finalGradeLbl.AutoSize = true;
            this.finalGradeLbl.Location = new System.Drawing.Point(335, 105);
            this.finalGradeLbl.Name = "finalGradeLbl";
            this.finalGradeLbl.Size = new System.Drawing.Size(61, 13);
            this.finalGradeLbl.TabIndex = 9;
            this.finalGradeLbl.Text = "Final Grade";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(113, 74);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add to List";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(253, 74);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "Calculate Grade";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(399, 74);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 12;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Khaki;
            this.numericUpDown1.Location = new System.Drawing.Point(104, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Khaki;
            this.numericUpDown2.Location = new System.Drawing.Point(325, 48);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 14;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.Khaki;
            this.numericUpDown3.Location = new System.Drawing.Point(523, 48);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.helloToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // WeightedGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(815, 509);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.finalGradeLbl);
            this.Controls.Add(this.pctEarnedLbl);
            this.Controls.Add(this.finalGradeBox);
            this.Controls.Add(this.percentEarnedBox);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.ptsPossibleLbl);
            this.Controls.Add(this.ptsEarnedLbl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WeightedGradeForm";
            this.Text = "Weighted Grade Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ptsEarnedLbl;
        private System.Windows.Forms.Label ptsPossibleLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.TextBox percentEarnedBox;
        private System.Windows.Forms.TextBox finalGradeBox;
        private System.Windows.Forms.Label pctEarnedLbl;
        private System.Windows.Forms.Label finalGradeLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

