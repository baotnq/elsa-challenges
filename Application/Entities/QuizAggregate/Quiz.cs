using Application.Entities;

namespace Application;
public class Quiz : BaseEntity {
   public ICollection<Question> Questions {get;set;}

   public string Title {get;set;}
   public string Description {get;set;}

   public int QuizType {get; set;}

   public int Points {get;set;}

   public int MaxSubmitedCount {get; set;} = 5;

}