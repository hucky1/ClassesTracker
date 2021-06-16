
namespace ClassesTrackerUI
{
    partial class Results
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.surNameTB = new System.Windows.Forms.TextBox();
            this.testsLB = new System.Windows.Forms.ListBox();
            this.findBut = new System.Windows.Forms.Button();
            this.surNameLbl = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(665, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // surNameTB
            // 
            this.surNameTB.Location = new System.Drawing.Point(681, 33);
            this.surNameTB.Name = "surNameTB";
            this.surNameTB.Size = new System.Drawing.Size(120, 21);
            this.surNameTB.TabIndex = 1;
            // 
            // testsLB
            // 
            this.testsLB.FormattingEnabled = true;
            this.testsLB.Items.AddRange(new object[] {
            "Все",
            "Задания",
            "Наследование",
            "Методы",
            "Классы"});
            this.testsLB.Location = new System.Drawing.Point(681, 60);
            this.testsLB.Name = "testsLB";
            this.testsLB.Size = new System.Drawing.Size(120, 95);
            this.testsLB.TabIndex = 2;
            // 
            // findBut
            // 
            this.findBut.Location = new System.Drawing.Point(701, 161);
            this.findBut.Name = "findBut";
            this.findBut.Size = new System.Drawing.Size(75, 23);
            this.findBut.TabIndex = 3;
            this.findBut.Text = "Найти";
            this.findBut.UseVisualStyleBackColor = true;
            this.findBut.Click += new System.EventHandler(this.findBut_Click);
            // 
            // surNameLbl
            // 
            this.surNameLbl.AutoSize = true;
            this.surNameLbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surNameLbl.Location = new System.Drawing.Point(681, 12);
            this.surNameLbl.Name = "surNameLbl";
            this.surNameLbl.Size = new System.Drawing.Size(78, 18);
            this.surNameLbl.TabIndex = 5;
            this.surNameLbl.Text = "Фамилия";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 387);
            this.Controls.Add(this.surNameLbl);
            this.Controls.Add(this.findBut);
            this.Controls.Add(this.testsLB);
            this.Controls.Add(this.surNameTB);

            this.Controls.Add(this.dataGridView1);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox surNameTB;
        private System.Windows.Forms.ListBox testsLB;
        private System.Windows.Forms.Button findBut;
        private System.Windows.Forms.Label surNameLbl;

    }
}