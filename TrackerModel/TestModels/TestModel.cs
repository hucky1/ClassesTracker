namespace TrackerModel.TestModels
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public int RightAnswer { get; set; }
        public string GetRightAnswer()
        {
            if (RightAnswer == 1)
                return FirstAnswer;
            else if (RightAnswer == 2)
                return SecondAnswer;
            return ThirdAnswer;
        }
    }
}
