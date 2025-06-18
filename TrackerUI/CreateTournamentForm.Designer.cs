namespace TrackerUI
{
    partial class CreateTournamentForm
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
            tournamentNameValue = new TextBox();
            TeamOneScoreLabel = new Label();
            entryfeeValue = new TextBox();
            label2 = new Label();
            label3 = new Label();
            selectTeamDropDown = new ComboBox();
            linkLabel1 = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamListBox = new ListBox();
            label4 = new Label();
            removeSelectedPlayerButton = new Button();
            removeSelectedPrizesButton = new Button();
            Prizes = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(52, 27);
            label1.Name = "label1";
            label1.Size = new Size(334, 50);
            label1.TabIndex = 1;
            label1.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(52, 173);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(299, 27);
            tournamentNameValue.TabIndex = 10;
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = Color.SteelBlue;
            TeamOneScoreLabel.Location = new Point(52, 122);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(247, 38);
            TeamOneScoreLabel.TabIndex = 9;
            TeamOneScoreLabel.Text = "Tournament Name";
            TeamOneScoreLabel.Click += TeamOneScoreLabel_Click;
            // 
            // entryfeeValue
            // 
            entryfeeValue.Location = new Point(190, 242);
            entryfeeValue.Name = "entryfeeValue";
            entryfeeValue.Size = new Size(131, 27);
            entryfeeValue.TabIndex = 12;
            entryfeeValue.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(52, 231);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 11;
            label2.Text = "Entry Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(52, 329);
            label3.Name = "label3";
            label3.Size = new Size(164, 38);
            label3.TabIndex = 13;
            label3.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.DropDownHeight = 200;
            selectTeamDropDown.DropDownWidth = 600;
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.IntegralHeight = false;
            selectTeamDropDown.ItemHeight = 20;
            selectTeamDropDown.Location = new Point(52, 370);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(299, 28);
            selectTeamDropDown.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(265, 343);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 20);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create New";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = SystemColors.Highlight;
            addTeamButton.Location = new Point(116, 423);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(153, 67);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.Highlight;
            createPrizeButton.Location = new Point(92, 515);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(205, 67);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamListBox
            // 
            tournamentTeamListBox.FormattingEnabled = true;
            tournamentTeamListBox.Location = new Point(443, 173);
            tournamentTeamListBox.Name = "tournamentTeamListBox";
            tournamentTeamListBox.Size = new Size(417, 164);
            tournamentTeamListBox.TabIndex = 18;
            tournamentTeamListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(443, 122);
            label4.Name = "label4";
            label4.Size = new Size(197, 38);
            label4.TabIndex = 19;
            label4.Text = "Team / Players";
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedPlayerButton.ForeColor = SystemColors.Highlight;
            removeSelectedPlayerButton.Location = new Point(878, 216);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new Size(153, 93);
            removeSelectedPlayerButton.TabIndex = 20;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += removeSelectedPlayerButton_Click;
            // 
            // removeSelectedPrizesButton
            // 
            removeSelectedPrizesButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedPrizesButton.ForeColor = SystemColors.Highlight;
            removeSelectedPrizesButton.Location = new Point(878, 454);
            removeSelectedPrizesButton.Name = "removeSelectedPrizesButton";
            removeSelectedPrizesButton.Size = new Size(167, 105);
            removeSelectedPrizesButton.TabIndex = 23;
            removeSelectedPrizesButton.Text = "Remove Selected";
            removeSelectedPrizesButton.UseVisualStyleBackColor = true;
            removeSelectedPrizesButton.Click += removeSelectedPrizesButton_Click;
            // 
            // Prizes
            // 
            Prizes.AutoSize = true;
            Prizes.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prizes.ForeColor = Color.SteelBlue;
            Prizes.Location = new Point(443, 372);
            Prizes.Name = "Prizes";
            Prizes.Size = new Size(90, 38);
            Prizes.TabIndex = 22;
            Prizes.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.Location = new Point(443, 423);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(417, 164);
            prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = SystemColors.Highlight;
            createTournamentButton.Location = new Point(318, 645);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(426, 85);
            createTournamentButton.TabIndex = 24;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 803);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizesButton);
            Controls.Add(Prizes);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(label4);
            Controls.Add(tournamentTeamListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(linkLabel1);
            Controls.Add(selectTeamDropDown);
            Controls.Add(label3);
            Controls.Add(entryfeeValue);
            Controls.Add(label2);
            Controls.Add(tournamentNameValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(label1);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tournamentNameValue;
        private Label TeamOneScoreLabel;
        private TextBox entryfeeValue;
        private Label label2;
        private Label label3;
        private ComboBox selectTeamDropDown;
        private LinkLabel linkLabel1;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamListBox;
        private Label label4;
        private Button removeSelectedPlayerButton;
        private Button removeSelectedPrizesButton;
        private Label Prizes;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}