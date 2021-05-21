
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
            this.SuspendLayout();
            // 
            // QuestionTB
            // 
            this.QuestionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionTB.Location = new System.Drawing.Point(12, 12);
            this.QuestionTB.Multiline = true;
            this.QuestionTB.Name = "QuestionTB";
            this.QuestionTB.ReadOnly = true;
            this.QuestionTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QuestionTB.Size = new System.Drawing.Size(776, 367);
            this.QuestionTB.TabIndex = 0;
            this.QuestionTB.TabStop = false;
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(159, 381);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(629, 23);
            this.AnswerTB.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBtn.Location = new System.Drawing.Point(0, 408);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(800, 42);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Проверить";
            this.checkBtn.UseVisualStyleBackColor = true;
            // 
            // AnswerLbl
            // 
            this.AnswerLbl.AutoSize = true;
            this.AnswerLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AnswerLbl.Location = new System.Drawing.Point(53, 379);
            this.AnswerLbl.Name = "AnswerLbl";
            this.AnswerLbl.Size = new System.Drawing.Size(100, 25);
            this.AnswerLbl.TabIndex = 4;
            this.AnswerLbl.Text = "Ваш ответ";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnswerLbl);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.QuestionTB);
            this.Name = "Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionTB;
        private System.Windows.Forms.TextBox AnswerTB;
        public System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label AnswerLbl;
    }
}