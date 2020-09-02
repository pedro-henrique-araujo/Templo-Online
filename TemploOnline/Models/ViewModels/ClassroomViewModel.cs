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

    public IEnumerable<Person> People { get; set; }
    public IEnumerable<AttendanceList> AttendancesLists { get; set; }

    public ClassroomViewModel()
    {
        
    }
    public ClassroomViewModel(Classroom classroom)
      :base(classroom)
    {

    }
  }
}