using Application.Entities;

namespace Application;

public interface IAllRepository
{
  public UserQuiz Create(User user, Quiz quiz);
  public IList<UserQuiz> FindUserQuiz(int userId, int quizId);

  public void CreateOrUpsertUserQuiz(UserQuiz userQuiz);

  public User CreateUser();
  public User GetUser(int userId);
  public Quiz CreateQuiz();
  public Quiz GetQuiz(int quizId);

  public UserAnswer TriggerUserAnswer(User user, Question question, Answer answers);

}
