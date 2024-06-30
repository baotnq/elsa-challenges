
using System.Reflection.Metadata.Ecma335;
using Application;
using Application.Entities;

public class UserAnswer : BaseEntity {
  public Question Question {get;set; }
  public IList<Answer> SelectedAnswers {get; private set;} //

  public bool isSubmited {get; private set;}

  public bool isCorrect {get; private set;}

  public UserAnswer() {
    isSubmited = false; 
    isCorrect = false;
  }
  public int Points {get;set;}

  public bool SubmitAnswer(IList<Answer> answers) {
    isSubmited = true;
    if (Question.CheckAnswer(answers)) {
      isCorrect = true; 
      SelectedAnswers = answers;
      Points = this.Question.Points;
      return true; 
    } else {
      isCorrect = false;
      Points = 0;
      return false;
    }
  }

}