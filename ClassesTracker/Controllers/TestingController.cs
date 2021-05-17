using System;
using System.Linq;
using ClassesTrackerUI.Interfaces;
using System.Windows.Forms;
using TrackerModel.TestModels;
using TrackerModel.Interfaces;
using ClassesTrackerUI;

namespace TrackerModel.Controllers
{
    class TestingController
    {
        private readonly ITesting _testing;
        
        public TestingController(ITesting testing)
        {
            _testing = testing;
            _testing.TestOpen += _testing_TestOpen;
            testing.QuestionAnswered += Testing_QuestionAnswered;
        }

        private void Testing_QuestionAnswered(object sender, EventArgs e)
        {
            if (_testing.CheckAnswer())
            {
                if (_testing.CurrentQuestionID < 9)
                {
                    _testing.CurrentQuestionID++;
                    _testing.ShowQuestions();
                }
                else
                {
                    ShowResult();
                    _testing.Close();
                }
            }
            
        }

        private void _testing_TestOpen(object sender, EventArgs e)
        {
            using (TestingContext db = new())
            {
                switch (_testing.TestName)
                {
                    case "Классы":
                        db.ClassesTest.ToList().ConvertAll(x => (ITestModel)x).ForEach(x => _testing.ShuffleTest.Add(x));
                        break;
                    case "Методы":
                        db.MethodsTest.ToList().ConvertAll(x => (ITestModel)x).ForEach(x => _testing.ShuffleTest.Add(x));
                        break;
                    case "Наследование":
                        db.InheritanceTest.ToList().ConvertAll(x => (ITestModel)x).ForEach(x => _testing.ShuffleTest.Add(x));
                        break;
                    case "Задания":
                        db.Tasks.ToList().ConvertAll(x => (ITestModel)x).ForEach(x => _testing.ShuffleTest.Add(x));
                        break;
                }
                _testing.ShuffleTest.Shuffle();
                _testing.ShowQuestions();
            }
        }
        private void ShowResult()
        {
            if (_testing is Testing)
            {
                using (TestingContext db = new())
                {
                    PassedTestsModel passedTest = new()
                    {
                        Name = _testing.StudentName,
                        Group = _testing.Group,
                        Mark = _testing.CountOfRightAnswers,
                        Test = _testing.TestName,
                        Date = DateTime.Now
                    };
                    db.PassedTests.Add(passedTest);
                    db.SaveChanges();
                }
            }
            
            MessageBox.Show($"Ваша оценка {_testing.CountOfRightAnswers}");
        }
       

    }
}
