using System.Collections.Generic;
using System.Linq;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class ClassroomListingViewModel
  {
    public List<Classroom> Classrooms { get; set; }
  }

  public class ClassroomViewModel : NomeableEntityViewModel
  {

    public IEnumerable<Person> Teachers { get; set; }
    public ClassroomViewModel()
    {
        
    }
    public ClassroomViewModel(Classroom classroom)
      :base(classroom)
    {
      Teachers = classroom.PeopleClassrooms
        .Where(a => a.AsTeacher)
        .Select(a => a.Person);
    }
  }
}