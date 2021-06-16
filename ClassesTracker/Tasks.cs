using ClassesTrackerUI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerModel;
using TrackerModel.Interfaces;
using TrackerModel.TestModels;

namespace ClassesTrackerUI
{
    public partial class Tasks : Form, ITesting
    {
        public event EventHandler TestOpen;
        public event EventHandler QuestionAnswered;
        public Tasks()
        {
            InitializeComponent();
            checkBtn.Click += delegate { QuestionAnswered?.Invoke(this, EventArgs.Empty); };
            Load += delegate { TestOpen?.Invoke(this, EventArgs.Empty); };
              checkBtn.Enabled = false;

        }

        public string StudentName { get; set; } = "Doesn't matter";
        public string Group { get; set; } = "Doesn't matter";
        public ListOfTestsModel<ITestModel> ShuffleTest { get; set; } = new();
        public string TestName { get; set; } = "Задания";
        public int CurrentQuestionID { get; set; }
        public int CountOfRightAnswers { get; set; }
        
     

        public bool CheckAnswer()
        {  
            if (AnswerTB.Text!= "")
            {
                if (string.Equals(AnswerTB.Text.Replace(" ", ""), ShuffleTest[CurrentQuestionID].RightAnswer.Replace(" ", ""),
               StringComparison.CurrentCultureIgnoreCase))
                {
                    QuestionTB.BackColor = Color.Green;
                    MessageBox.Show($"Все верно! Правильный ответ: {ShuffleTest[CurrentQuestionID].RightAnswer}");
                    CountOfRightAnswers++;
                }
                else
                {
                    QuestionTB.BackColor = Color.Red;
                    MessageBox.Show($"Вы ошиблись, правильный ответ: {ShuffleTest[CurrentQuestionID].RightAnswer}");
                    
                }
            }  else
            {
                MessageBox.Show("Вы не ввели ответ!");
                return false;
            }
            
            return true;
        }

        public void ShowQuestions()
        {
            QuestionTB.BackColor = Color.White;
            AnswerTB.Text = "";
            TaskModel possibleAns = (TaskModel)ShuffleTest[CurrentQuestionID];
            (QuestionTB.Text) = (possibleAns.Text);
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            if (grouptextBox.Text == "" || nametextBox.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                (Group, StudentName) = (grouptextBox.Text, nametextBox.Text);
                infopanel.Enabled = false;
                checkBtn.Enabled = true;
            }

        }
    }
}
