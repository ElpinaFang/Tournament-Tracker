namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tournamentName = new Label();
            Round = new Label();
            roundDropDown = new ComboBox();
            checkBox1 = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            TeamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            TeamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            label2 = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 0;
            label1.Text = "Tournament: ";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = Color.SteelBlue;
            tournamentName.Location = new Point(246, 45);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(118, 38);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // Round
            // 
            Round.AutoSize = true;
            Round.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Round.ForeColor = Color.SteelBlue;
            Round.Location = new Point(50, 129);
            Round.Name = "Round";
            Round.Size = new Size(97, 38);
            Round.TabIndex = 2;
            Round.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(169, 122);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(300, 45);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.Highlight;
            checkBox1.Location = new Point(167, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(257, 50);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Unplayed Only";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(50, 275);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(417, 337);
            matchupListBox.TabIndex = 5;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneName.ForeColor = Color.SteelBlue;
            teamOneName.Location = new Point(555, 275);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(172, 38);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = Color.SteelBlue;
            TeamOneScoreLabel.Location = new Point(563, 337);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(86, 38);
            TeamOneScoreLabel.TabIndex = 7;
            TeamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(655, 334);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(134, 43);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(667, 569);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(134, 43);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = Color.SteelBlue;
            TeamTwoScoreLabel.Location = new Point(575, 572);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(86, 38);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = Color.SteelBlue;
            teamTwoName.Location = new Point(567, 510);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(172, 38);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team one>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(627, 427);
            label2.Name = "label2";
            label2.Size = new Size(71, 38);
            label2.TabIndex = 12;
            label2.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.Highlight;
            scoreButton.Location = new Point(838, 427);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(157, 80);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1030, 713);
            Controls.Add(scoreButton);
            Controls.Add(label2);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(checkBox1);
            Controls.Add(roundDropDown);
            Controls.Add(Round);
            Controls.Add(tournamentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tournamentName;
        private Label Round;
        private ComboBox roundDropDown;
        private CheckBox checkBox1;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label TeamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label teamTwoName;
        private Label label2;
        private Button scoreButton;
    }
}
