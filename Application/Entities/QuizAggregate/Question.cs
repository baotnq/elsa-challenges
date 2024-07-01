using Application.Entities;

namespace Application;
public class Question : BaseEntity {

  public int QuestionType {get;set;} //Yes/No, One, Many Answers 
  public string? Title  {get;set;}
  public string? Description {get;set;}

  public Answer CorrectAnswer {get;set;} //default answer to compare with user select, could be null if open question
  public int Points {get;set;}

  public bool CheckAnswer(Answer answer) {
    return CorrectAnswer.Compare(answer);
  }
}