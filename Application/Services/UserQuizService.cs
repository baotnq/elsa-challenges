
using Application;
using Application.Entities;

public class UserQuizService : IUserQuizService
{
    public UserQuiz JoinQuiz(int userId, int quizId)
    {
      var user = this.allRepository.GetUser(userId) ?? throw new Exception("Invalid User" + userId);
      var quiz = this.allRepository.GetQuiz(quizId) ?? throw new Exception("Invalid Quiz " + quizId);
      return this.JoinQuiz(user, quiz);
    }

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
    public bool SubmitAnswer(UserQuiz userQuiz, Question question, Answer answers)
    {
      return userQuiz.CheckAnswer(question,answers);
    }

    public int ScoreUpdate(int userQuizId)
    {
        throw new NotImplementedException();
    }

    private IQuizService quizService;
    private IAllRepository allRepository;

    publ