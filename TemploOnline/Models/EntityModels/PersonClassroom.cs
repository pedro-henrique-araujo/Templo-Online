namespace TemploOnline.Models.EntityModels
{
  public class PersonClassroom
  {
    public int Id { get; set; }

    public int PersonId { get; set; }

    public Person Person { get; set; }

    public int ClassroomId { get; set; }

    public Classroom Classroom { get; set; }

    public bool AsTeacher { get; set; }
  }
}