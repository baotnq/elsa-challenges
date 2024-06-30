
using Application;
using Application.Entities;

public class UserQuizService : IUserQuizService
{
    public UserQuiz JoinQuiz(User user, Quiz quiz)
    {
      if (!quizService.AllowParticipate(quiz)) throw new Exception("Quiz not allow to enter"); 

      var history = this.allRepository.FindUserQuiz(user.Id, quiz.Id);
      if (history.Any()) {
        if (history.Last().Status != "SUBMITED") return history.Last();

        if (history.Count > quiz.MaxSubmitedCount) 
          throw new Exception("You already submited " + history.Count);
      }
      return this.allRepository.Create(user,quiz); 
    }
    public bool SubmitAnswer(UserQuiz userQuiz, Question question, IList<Answer> answers)
    {
      return userQuiz.CheckAnswer(question,answers);
//      throw new NotImplementedException();
    }

    private IQuizService quizService;
    private IAllRepository allRepository;
}