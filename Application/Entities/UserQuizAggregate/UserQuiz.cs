
using Application;
using Application.Entities;

public class UserQuiz : BaseEntity {

  private IAllRepository allRepository; 
  public User User {get;set;}

  public Quiz Quiz {get;set; }

  public IList<UserAnswer> UserAnswers {get;set;} //list of answers, 

  public int Points() {
    if (this.UserAnswers.Any()) {
      return this.UserAnswers.Sum(item => item.Points);
    }
    return 0;
  }

  public bool CheckAnswer(Question question, Answer answers) {
    if (Quiz.Questions.Any(q => q.Id == question.Id)) {
     // var userAnswer = this.allRepositor
      var answer = this.allRepository.TriggerUserAnswer(this.User, question, answers); 
      var existingAnswer = this.UserAnswers.First(i => i.Question.Id == question.Id);
      if (existingAnswer != null) {
        existingAnswer = answer;
      }else {
        UserAnswers.Add(answer); 
      }
      return answer.isCorrect;
    }else {
      throw new Exception("No question in this Quiz"); 
    }
  }

  public void CompleteQuiz() {
    this.Status = "SUBMITED";
  }
}