using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerModel;
using TrackerModel.TestModels;

namespace ClassesTrackerUI.Interfaces
{
    interface ITesting
    {
        public event EventHandler TestOpen;
        public event EventHandler QuestionAnswered;

        string StudentName { get; set; }
        string Group { get; set; }

        public ListOfTestsModel<TestModel> shuffleTest { get; set; }
        public string testName { get; set; }
        public int currentQuestionID { get; set; }
        public int countOfRightAnswers { get; set; }

        public void ShowQuestions();
        public void CheckAnswer();
        public void Close();
    }
}
