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
            teamNameValue = new TextBox();
            TeamOneScoreLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            label3 = new Label();
            addMemberButton = new Button();
            groupBox1 = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            label6 = new Label();
            emailValue = new TextBox();
            label5 = new Label();
            lastNameValue = new TextBox();
            label4 = new Label();
            firstNameValue = new TextBox();
            label2 = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedButton = new Button();
            createTeamButton = new Button();
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
            // teamNameValue
            // 
            teamNameValue.Location = new Point(45, 164);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(516, 27);
            teamNameValue.TabIndex = 12;
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
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.DropDownHeight = 200;
            selectTeamMemberDropDown.DropDownWidth = 600;
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.IntegralHeight = false;
            selectTeamMemberDropDown.ItemHeight = 20;
            selectTeamMemberDropDown.Location = new Point(45, 275);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(528, 28);
            selectTeamMemberDropDown.TabIndex = 16;
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
            // addMemberButton
            // 
            addMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = SystemColors.Highlight;
            addMemberButton.Location = new Point(204, 332);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(205, 67);
            addMemberButton.TabIndex = 18;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createMemberButton);
            groupBox1.Controls.Add(cellphoneValue);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lastNameValue);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(firstNameValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(40, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 450);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = SystemColors.Highlight;
            createMemberButton.Location = new Point(109, 343);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(260, 67);
            createMemberButton.TabIndex = 20;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneValue.Location = new Point(187, 264);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(299, 34);
            cellphoneValue.TabIndex = 27;
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
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailValue.Location = new Point(187, 196);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(299, 34);
            emailValue.TabIndex = 25;
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
            // lastNameValue
            // 
            lastNameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameValue.Location = new Point(187, 131);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(299, 34);
            lastNameValue.TabIndex = 23;
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
            // firstNameValue
            // 
            firstNameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameValue.Location = new Point(187, 64);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(299, 34);
            firstNameValue.TabIndex = 21;
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
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.Location = new Point(635, 164);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(417, 744);
            teamMembersListBox.TabIndex = 20;
            // 
            // removeSelectedButton
            // 
            removeSelectedButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedButton.ForeColor = SystemColors.Highlight;
            removeSelectedButton.Location = new Point(1081, 493);
            removeSelectedButton.Name = "removeSelectedButton";
            removeSelectedButton.Size = new Size(205, 98);
            removeSelectedButton.TabIndex = 28;
            removeSelectedButton.Text = "Remove Selected";
            removeSelectedButton.UseVisualStyleBackColor = true;
            removeSelectedButton.Click += button3_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = SystemColors.Highlight;
            createTeamButton.Location = new Point(451, 944);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(338, 98);
            createTeamButton.TabIndex = 29;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 1071);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(label3);
            Controls.Add(teamNameValue);
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
        private TextBox teamNameValue;
        private Label TeamOneScoreLabel;
        private ComboBox selectTeamMemberDropDown;
        private Label label3;
        private Button addMemberButton;
        private GroupBox groupBox1;
        private TextBox emailValue;
        private Label label5;
        private TextBox lastNameValue;
        private Label label4;
        private TextBox firstNameValue;
        private Label label2;
        private Button createMemberButton;
        private TextBox cellphoneValue;
        private Label label6;
        private ListBox teamMembersListBox;
        private Button removeSelectedButton;
        private Button createTeamButton;
    }
}