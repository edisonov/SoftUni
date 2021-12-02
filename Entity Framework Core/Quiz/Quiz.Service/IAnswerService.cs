namespace Quiz.Service
{
    public interface IAnswerService
    {
        int Add(string title, int points, bool isCorrect, int questionId);
    }
}