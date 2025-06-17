namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberValue = new TextBox();
            TeamOneScoreLabel = new Label();
            placeNameValue = new TextBox();
            label2 = new Label();
            prizeAmountValue = new TextBox();
            label3 = new Label();
            prizePercentageValue = new TextBox();
            label4 = new Label();
            label5 = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(39, 32);
            label1.Name = "label1";
            label1.Size = new Size(217, 50);
            label1.TabIndex = 3;
            label1.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(269, 123);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(366, 27);
            placeNumberValue.TabIndex = 14;
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = Color.SteelBlue;
            TeamOneScoreLabel.Location = new Point(39, 112);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(192, 38);
            TeamOneScoreLabel.TabIndex = 13;
            TeamOneScoreLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(269, 179);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(366, 27);
            placeNameValue.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(39, 168);
            label2.Name = "label2";
            label2.Size = new Size(164, 38);
            label2.TabIndex = 15;
            label2.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(269, 242);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(366, 27);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(39, 231);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 17;
            label3.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(269, 357);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(366, 27);
            prizePercentageValue.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(39, 346);
            label4.Name = "label4";
            label4.Size = new Size(224, 38);
            label4.TabIndex = 19;
            label4.Text = "Prize Percentage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(187, 296);
            label5.Name = "label5";
            label5.Size = new Size(70, 38);
            label5.TabIndex = 21;
            label5.Text = "-Or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.Highlight;
            createPrizeButton.Location = new Point(171, 430);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(260, 67);
            createPrizeButton.TabIndex = 22;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 554);
            Controls.Add(createPrizeButton);
            Controls.Add(label5);
            Controls.Add(prizePercentageValue);
            Controls.Add(label4);
            Controls.Add(prizeAmountValue);
            Controls.Add(label3);
            Controls.Add(placeNameValue);
            Controls.Add(label2);
            Controls.Add(placeNumberValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(label1);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox placeNumberValue;
        private Label TeamOneScoreLabel;
        private TextBox placeNameValue;
        private Label label2;
        private TextBox prizeAmountValue;
        private Label label3;
        private TextBox prizePercentageValue;
        private Label label4;
        private Label label5;
        private Button createPrizeButton;
    }
}