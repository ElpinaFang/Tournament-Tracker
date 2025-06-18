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
            roundDropDown = new ComboBox();
            linkLabel1 = new LinkLabel();
            scoreButton = new Button();
            button1 = new Button();
            tournamentPlayerListBox = new ListBox();
            label4 = new Label();
            deleteSelectedButton = new Button();
            button3 = new Button();
            label5 = new Label();
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
            // roundDropDown
            // 
            roundDropDown.DropDownHeight = 200;
            roundDropDown.DropDownWidth = 600;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.IntegralHeight = false;
            roundDropDown.ItemHeight = 20;
            roundDropDown.Location = new Point(52, 370);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(299, 28);
            roundDropDown.TabIndex = 14;
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
            // 
            // scoreButton
            // 
            scoreButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.Highlight;
            scoreButton.Location = new Point(116, 423);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(153, 67);
            scoreButton.TabIndex = 16;
            scoreButton.Text = "Add Team";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(92, 515);
            button1.Name = "button1";
            button1.Size = new Size(205, 67);
            button1.TabIndex = 17;
            button1.Text = "Create Prize";
            button1.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.Location = new Point(443, 173);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(417, 164);
            tournamentPlayerListBox.TabIndex = 18;
            tournamentPlayerListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
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
            // deleteSelectedButton
            // 
            deleteSelectedButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedButton.ForeColor = SystemColors.Highlight;
            deleteSelectedButton.Location = new Point(878, 216);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(153, 93);
            deleteSelectedButton.TabIndex = 20;
            deleteSelectedButton.Text = "Delete Selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(878, 466);
            button3.Name = "button3";
            button3.Size = new Size(153, 85);
            button3.TabIndex = 23;
            button3.Text = "Delete Selected";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(443, 372);
            label5.Name = "label5";
            label5.Size = new Size(197, 38);
            label5.TabIndex = 22;
            label5.Text = "Team / Players";
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
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedButton);
            Controls.Add(label4);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(button1);
            Controls.Add(scoreButton);
            Controls.Add(linkLabel1);
            Controls.Add(roundDropDown);
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
        private ComboBox roundDropDown;
        private LinkLabel linkLabel1;
        private Button scoreButton;
        private Button button1;
        private ListBox tournamentPlayerListBox;
        private Label label4;
        private Button deleteSelectedButton;
        private Button button3;
        private Label label5;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}