using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    [Display(Name = "Imagem de capa")]
    public string CoverUrl { get; set; }

    public ClassroomViewModel()
    {
        
    }
    public ClassroomViewModel(Classroom classroom)
      :base(classroom)
    {
      CoverUrl = classroom.CoverUrl;
    }
  }
}