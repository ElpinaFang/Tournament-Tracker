namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            label2 = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(188, 42);
            label1.Name = "label1";
            label1.Size = new Size(408, 50);
            label1.TabIndex = 4;
            label1.Text = "Tournament Dashboard";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(220, 150);
            label2.Name = "label2";
            label2.Size = new Size(359, 41);
            label2.TabIndex = 5;
            label2.Text = "Load Existing Tournament";
            label2.Click += label2_Click;
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.DropDownHeight = 200;
            loadExistingTournamentDropDown.DropDownWidth = 600;
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.IntegralHeight = false;
            loadExistingTournamentDropDown.ItemHeight = 20;
            loadExistingTournamentDropDown.Location = new Point(150, 203);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(528, 28);
            loadExistingTournamentDropDown.TabIndex = 17;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadTournamentButton.ForeColor = SystemColors.Highlight;
            loadTournamentButton.Location = new Point(288, 277);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(260, 53);
            loadTournamentButton.TabIndex = 32;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            loadTournamentButton.Click += loadTournamentButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = SystemColors.Highlight;
            createTournamentButton.Location = new Point(247, 361);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(338, 98);
            createTournamentButton.TabIndex = 33;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += button1_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 505);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox loadExistingTournamentDropDown;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}