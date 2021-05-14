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
            nextButton.Click += delegate { QuestionAnswered?.Invoke(this, EventArgs.Empty); };
            StartButton.Click += StartBut_Click;
            Load += delegate { TestOpen?.Invoke(this, EventArgs.Empty); };
        }
     
        public void ShowQuestions()
        {
            var possibleAns = shuffleTest[currentQuestionID];
            (testgroupBox.Text, FirstQuestionRB.Text, SecondQuestionRB.Text, ThirdQuestionRB.Text) =
                (possibleAns.Text, possibleAns.FirstAnswer, possibleAns.SecondAnswer, possibleAns.ThirdAnswer);
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

        public void CheckAnswer()=>
            Array.ForEach(radioButtons.Where((x) => x.Checked && 
            x.Text == shuffleTest[currentQuestionID].GetRightAnswer()).ToArray(),
                (x) => countOfRightAnswers++);
        
    }
}
