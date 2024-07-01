
using Application;
using Application.Entities;

public class QuizService : IQuizService
{
    public bool AllowParticipate(Quiz quiz)
    {
        throw new NotImplementedException();
    }

    public IList<User> CurrentUser(Quiz quiz)
    {
        throw new NotImplementedException();
    }

    public IList<User> LeaderBoard(Quiz quiz)
    {
        throw new NotImplementedException();
    }

    public IList<User> LeaderBoard()
    {
        throw new NotImplementedException();
    }

    public int MaxConcurrentUser(Quiz quiz)
    {
        throw new NotImplementedException();
    }

    public bool VerifyAnswers(Question question, IList<Answer> answers)
    {
        throw new NotImplementedException();
    }
}