using Application.Entities;

namespace Application;

public interface IUserQuizService
{
    public UserQuiz JoinQuiz(int userId, int quizId);

    public UserQuiz JoinQuiz(User user, Quiz quiz); 
    public bool SubmitAnswer(UserQuiz userQuiz, Question question, Answer answers);
    p