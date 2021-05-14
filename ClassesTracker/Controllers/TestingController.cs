using System;
using ClassesTrackerUI.Interfaces;
using System.Linq;
using System.Windows.Forms;
using TrackerModel;
using TrackerModel.TestModels;


namespace ClassesTrackerUI.Controllers
{
    class TestingController
    {
        private readonly Testing _testing;
        
        public TestingController(Testing testing)
        {
            _testing = testing;
            _testing.TestOpen += _testing_TestOpen;
            testing.QuestionAnswered += Testing_QuestionAnswered;
        }

        private void Testing_QuestionAnswered(object sender, EventArgs e)
        {
            _testing.CheckAnswer();
            if (_testing.currentQuestionID < 9)
            {
                _testing.currentQuestionID++;
                _testing.ShowQuestions();
            }
            else
            {
                ShowResult();
                _testing.Close();
            }
        }

        private void _testing_TestOpen(object sender, EventArgs e)
        {
            using (TestingContext db = new())
            {
                switch (_testing.testName)
                {
                    case "Классы":
                        db.ClassesTest.ToList().ConvertAll(x => (TestModel)x).ForEach(x => _testing.shuffleTest.Add(x));
                        break;
                    case "Методы":
                        db.MethodsTest.ToList().ConvertAll(x => (TestModel)x).ForEach(x => _testing.shuffleTest.Add(x));
                        break;
                    case "Наследование":
                        db.InheritanceTest.ToList().ConvertAll(x => (TestModel)x).ForEach(x => _testing.shuffleTest.Add(x));
                        break;
                }
                _testing.shuffleTest.Shuffle();
                _testing.ShowQuestions();
            }
        }
        private void ShowResult()
        {
            using (TestingContext db = new())
            {
                PassedTestsModel passedTest = new()
                {
                    Name = _testing.nametextBox.Text,
                    Group = _testing.grouptextBox.Text,
                    Mark = _testing.countOfRightAnswers,
                    Test = _testing.testName,
                    Date = DateTime.Now
                };
                db.PassedTests.Add(passedTest);
                db.SaveChanges();
            }
            MessageBox.Show($"Ваша оценка {_testing.countOfRightAnswers}");
        }
       

    }
}
