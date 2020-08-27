namespace TemploOnline.Models.EntityModels
{
  public class Attendance : Entity
  {
    public int AttendanceListId { get; set; }

    public AttendanceList AttendanceList { get; set; }

    public int PersonId { get; set; }

    public Person Person { get; set; }

    public bool Attended { get; set; }

    public bool AsTeacher { get; set; }
  }
}