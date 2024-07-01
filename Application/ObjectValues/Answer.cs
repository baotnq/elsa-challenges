namespace Application;

public class Answer(IList<string> value)
{
    //Answer could be Boolean, text , url, .... which convert to string 
    public IList<string> Value { get; set; } = value;

    public bool Compare(Answer answer) {
    //change the compare rules later
    return this.Value == answer.Value; 
  }
}
