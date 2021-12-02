using Quiz.Service.Models;

namespace Quiz.Service
{
    public interface IQuizService
    {
        void Add(string title);

        QuizViewModel GetQuizById(int quizId);
    }
}