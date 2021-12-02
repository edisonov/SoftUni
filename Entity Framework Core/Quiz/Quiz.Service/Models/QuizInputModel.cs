using System.Collections.Generic;

namespace Quiz.Service.Models
{
    public class QuizInputModel
    {
        public string UserId { get; set; }

        public int QuizId { get; set; }

        public List<QuestionInputModel> Questions { get; set; }
    }
}