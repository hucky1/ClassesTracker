using System;
using TrackerModel;
using TrackerModel.Interfaces;


namespace ClassesTrackerUI.Interfaces
{
    interface ITesting
    {
        public event EventHandler TestOpen;
        public event EventHandler QuestionAnswered;

        string StudentName { get; set; } 
        string Group { get; set; }

        public ListOfTestsModel<ITestModel> ShuffleTest { get; set; }
        public string TestName { get; set; }
        public int CurrentQuestionID { get; set; }
        public int CountOfRightAnswers { get; set; }

        public void ShowQuestions();
        public bool CheckAnswer();
        public void Close();
        public void Show();
    }
}
