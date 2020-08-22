using System.Collections.Generic;

namespace TemploOnline.Models.EntityModels
{
  public class Classroom : NomeableEntity
  {
    public List<PersonClassroom> PeopleClassrooms { get; set; }
  }
}