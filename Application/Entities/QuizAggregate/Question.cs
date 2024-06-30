using Application.Entities;

namespace Application;
public class Question : BaseEntity {

  public int QuestionType {get;set;} //Yes/No, One, Many Answers 
  public string? Title  {get;set;}
  public string? Description {get;set;}

  public IList<Answer> CorrectAnswers {get;set;} //default answer to compare with user select, could be null if open question
  public int Points {get;set;}

  public bool CheckAnswer(IList<Answer> answers) {
    return this.CorrectAnswers == answers;
  }
}