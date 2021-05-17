using TrackerModel.Interfaces;

namespace TrackerModel.TestModels
{
    public class TestModel: ITestModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public string RightAnswer { get; set; }
     
    }
}
