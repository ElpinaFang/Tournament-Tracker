namespace TrackerUI
{
    partial class CreateTeamForm
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
            label1 = new Label();
            TeamOneScoreValue = new TextBox();
            TeamOneScoreLabel = new Label();
            roundDropDown = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            teamMembersListBox = new ListBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(223, 50);
            label1.TabIndex = 2;
            label1.Text = "Create Team";
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(45, 164);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(516, 27);
            TeamOneScoreValue.TabIndex = 12;
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = Color.SteelBlue;
            TeamOneScoreLabel.Location = new Point(45, 123);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(164, 38);
            TeamOneScoreLabel.TabIndex = 11;
            TeamOneScoreLabel.Text = "Team Name";
            // 
            // roundDropDown
            // 
            roundDropDown.DropDownHeight = 200;
            roundDropDown.DropDownWidth = 600;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.IntegralHeight = false;
            roundDropDown.ItemHeight = 20;
            roundDropDown.Location = new Point(45, 275);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(528, 28);
            roundDropDown.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(40, 234);
            label3.Name = "label3";
            label3.Size = new Size(277, 38);
            label3.TabIndex = 15;
            label3.Text = "Select Team Member";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(204, 332);
            button1.Name = "button1";
            button1.Size = new Size(205, 67);
            button1.TabIndex = 18;
            button1.Text = "Add Member";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(40, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 450);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(187, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 34);
            textBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(151, 38);
            label2.TabIndex = 20;
            label2.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(187, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 34);
            textBox2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(17, 127);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 22;
            label4.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(187, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 34);
            textBox3.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(17, 192);
            label5.Name = "label5";
            label5.Size = new Size(83, 38);
            label5.TabIndex = 24;
            label5.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(187, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 34);
            textBox4.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(17, 260);
            label6.Name = "label6";
            label6.Size = new Size(142, 38);
            label6.TabIndex = 26;
            label6.Text = "Cellphone";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(109, 343);
            button2.Name = "button2";
            button2.Size = new Size(260, 67);
            button2.TabIndex = 20;
            button2.Text = "Create Member";
            button2.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.Location = new Point(635, 164);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(417, 744);
            teamMembersListBox.TabIndex = 20;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(1081, 493);
            button3.Name = "button3";
            button3.Size = new Size(205, 98);
            button3.TabIndex = 28;
            button3.Text = "Delete Selected";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(451, 944);
            button4.Name = "button4";
            button4.Size = new Size(338, 98);
            button4.TabIndex = 29;
            button4.Text = "Create Team";
            button4.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 1071);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(roundDropDown);
            Controls.Add(label3);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(label1);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TeamOneScoreValue;
        private Label TeamOneScoreLabel;
        private ComboBox roundDropDown;
        private Label label3;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
        private ListBox teamMembersListBox;
        private Button button3;
        private Button button4;
    }
}