using System.Collections.Generic;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class ClassroomListingViewModel
  {
    public List<Classroom> Classrooms { get; set; }
  }

  public class ClassroomViewModel : NomeableEntityViewModel
  {
    public ClassroomViewModel()
    {
        
    }
    public ClassroomViewModel(Classroom classroom)
      :base(classroom)
    {
    }
  }
}