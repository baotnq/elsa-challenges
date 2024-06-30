namespace Application.Entities;

public class BaseEntity {
  public virtual int Id {get; protected set;}

  public virtual string Status {get; protected set;}

  public BaseEntity() {
    Status = "CREATED"; 
  }

  public virtual bool Compare(BaseEntity entity) {
    if (entity.Id > 0 && Id == entity.Id) {
      return true;
    }else {
      return false; 
    }
    
  }
}