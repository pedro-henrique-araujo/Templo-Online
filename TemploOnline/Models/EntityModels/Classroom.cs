using System.Collections.Generic;

namespace TemploOnline.Models.EntityModels
{
  public class Classroom : NomeableEntity
  {
    public List<PersonClassroom> PeopleClassrooms { get; set; }

    public List<AttendanceList> AttendancesLists { get; set; }

    public string CoverUrl { get; set; } = "https://cdn.pixabay.com/photo/2016/11/29/07/10/business-1868015_960_720.jpg";
  }
}