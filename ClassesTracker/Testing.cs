using ClassesTrackerUI.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;
using TrackerModel;
using TrackerModel.Interfaces;
using TrackerModel.TestModels;

namespace ClassesTrackerUI
{
    public partial class Testing : Form, ITesting
    {
        public event EventHandler TestOpen;
        public event EventHandler QuestionAnswered;

        public string TestName { get; set; }
        public ListOfTestsModel<ITestModel> ShuffleTest { get; set; } = new();
        RadioButton[] radioButtons;
        public int CurrentQuestionID { get; set; }
        public int CountOfRightAnswers { get; set; }
        public string Group { get; set; }
        public string StudentName { get; set; }
       
        public Testing(string test)
        {
            InitializeComponent();
            TestName = test;
            radioButtons = new RadioButton[] { FirstQuestionRB, SecondQuestionRB, ThirdQuestionRB };
            nextButton.Click += delegate { QuestionAnswered?.Invoke(this, EventArgs.Empty); };
            StartButton.Click += StartBut_Click;
            Load += delegate { TestOpen?.Invoke(this, EventArgs.Empty); };
        }
     
        public void ShowQuestions()
        {
                TestModel possibleAns = (TestModel)ShuffleTest[CurrentQuestionID];
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
                (Group, StudentName) = (grouptextBox.Text, nametextBox.Text);
                infopanel.Enabled = false;
                testgroupBox.Enabled = true;
            }  
        }

        public bool CheckAnswer()
        {
            Array.ForEach(radioButtons.Where((x) => x.Checked &&
            x.Text == ShuffleTest[CurrentQuestionID].RightAnswer).ToArray(),
                (x) => CountOfRightAnswers++);
            return true;
        }
            

    }
}
