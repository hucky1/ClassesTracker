using System;
using System.Linq;
using System.Windows.Forms;
using TrackerModel;
using TrackerModel.TestModels;

namespace ClassesTrackerUI
{
    public partial class Testing : Form
    {
        public event EventHandler TestOpen;
        public event EventHandler QuestionAnswered;

        public readonly string testName;
        public ListOfTestsModel<TestModel> shuffleTest = new();

        RadioButton[] radioButtons;
        public int currentQuestionID { get; set; }
        public int countOfRightAnswers;
        public Testing(string test)
        {
            InitializeComponent();
            testName = test;
            radioButtons = new RadioButton[] { FirstQuestionRB, SecondQuestionRB, ThirdQuestionRB };
            nextButton.Click += NextButton_Click;
            StartButton.Click += StartBut_Click;
            Load += Testing_Load;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            QuestionAnswered?.Invoke(this, EventArgs.Empty);
        }

        public void ShowQuestions()
        {
            testgroupBox.Text = shuffleTest[currentQuestionID].Text;
            FirstQuestionRB.Text = shuffleTest[currentQuestionID].FirstAnswer;
            SecondQuestionRB.Text = shuffleTest[currentQuestionID].SecondAnswer;
            ThirdQuestionRB.Text = shuffleTest[currentQuestionID].ThirdAnswer;
        }
        private void Testing_Load(object sender, EventArgs e)
        {
            TestOpen?.Invoke(this, EventArgs.Empty);
        }

        private void StartBut_Click(object sender, EventArgs e)
        {
            if (grouptextBox.Text== "" || nametextBox.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                infopanel.Enabled = false;
                testgroupBox.Enabled = true;
            }  
        }
      
        public void CheckAnswer()
        {
            foreach (var but in radioButtons)
            {
                if (but.Checked && but.Text == shuffleTest[currentQuestionID].GetRightAnswer())
                    countOfRightAnswers++;
            }
        } 
    }
}
