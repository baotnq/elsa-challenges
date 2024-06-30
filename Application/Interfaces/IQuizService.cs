using Application.Entities;

namespace Application;

public interface IQuizService
{
  public int MaxConcurrentUser(Quiz quiz);
  public bool AllowParticipate(Quiz quiz); 

  public bool VerifyAnswers(Question question, IList<Answer> answers);
  public IList<User> LeaderBoard(Quiz quiz); 
  public IList<User> LeaderBoard(); 
}
