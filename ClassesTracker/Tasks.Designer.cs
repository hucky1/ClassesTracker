
namespace ClassesTrackerUI
{
    partial class Tasks
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
            this.QuestionTB = new System.Windows.Forms.TextBox();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.AnswerLbl = new System.Windows.Forms.Label();
            this.infopanel = new System.Windows.Forms.Panel();
            this.grouptextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionTB
            // 
            this.QuestionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionTB.Location = new System.Drawing.Point(8, 74);
            this.QuestionTB.Multiline = true;
            this.QuestionTB.Name = "QuestionTB";
            this.QuestionTB.ReadOnly = true;
            this.QuestionTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QuestionTB.Size = new System.Drawing.Size(666, 319);
            this.QuestionTB.TabIndex = 0;
            this.QuestionTB.TabStop = false;
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(134, 399);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(540, 21);
            this.AnswerTB.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBtn.Location = new System.Drawing.Point(0, 438);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(686, 36);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Проверить";
            this.checkBtn.UseVisualStyleBackColor = true;
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.AutoSize = true;
            this.AnswerLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AnswerLbl.Location = new System.Drawing.Point(12, 396);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(104, 24);
            this.AnswerLbl.TabIndex = 4;
            this.AnswerLbl.Text = "Ваш ответ";
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.grouptextBox);
            this.infopanel.Controls.Add(this.nametextBox);
            this.infopanel.Controls.Add(this.StartButton);
            this.infopanel.Controls.Add(this.groupLabel);
            this.infopanel.Controls.Add(this.NameLabel);
            this.infopanel.Location = new System.Drawing.Point(12, 12);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(662, 56);
            this.infopanel.TabIndex = 5;
            // 
            // grouptextBox
            // 
            this.grouptextBox.Location = new System.Drawing.Point(335, 17);
            this.grouptextBox.Name = "grouptextBox";
            this.grouptextBox.Size = new System.Drawing.Size(181, 21);
            this.grouptextBox.TabIndex = 11;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(64, 14);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(181, 21);
            this.nametextBox.TabIndex = 10;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartButton.Location = new System.Drawing.Point(533, 8);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 36);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Далее";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupLabel.Location = new System.Drawing.Point(261, 11);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(76, 25);
            this.groupLabel.TabIndex = 8;
            this.groupLabel.Text = "Группа";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NameLabel.Location = new System.Drawing.Point(7, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "ФИО";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 474);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.QuestionTB);
            this.Name = "Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionTB;
        private System.Windows.Forms.TextBox AnswerTB;
        public System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label AnswerLbl;
        private System.Windows.Forms.Panel infopanel;
        public System.Windows.Forms.TextBox grouptextBox;
        public System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label NameLabel;


    }
}