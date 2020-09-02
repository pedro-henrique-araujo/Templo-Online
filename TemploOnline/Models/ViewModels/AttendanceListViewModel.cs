using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class AttendanceListListingViewModel
  {
    public List<AttendanceList> AttendancesLists { get; set; }

    public List<SelectListItem> Classrooms { get; set; }
  }

  public class AttendanceListViewModel
  {
    public int Id { get; set; }
    public int ClassroomId { get; set; }

    [Display(Name = "Sala de aula")]
    public Classroom Classroom { get; set; }     

    public List<SelectListItem> Classrooms { get; set; }

    [Display(Name = "Lição")]
    public int LessonId { get; set; }

    [Display(Name = "Lição")]
    public Lesson Lesson { get; set; }

    public List<SelectListItem> Lessons { get; set; }

    public List<Attendance> TeachersAttendances { get; set; }

    public List<Attendance> StudentsAttendances { get; set; }

    [Display(Name = "Criado")]
    public DateTime Created { get; set; }

    public AttendanceListViewModel()
    {      
    }

    public AttendanceListViewModel(AttendanceList attendanceList)
    {
      Id = attendanceList.Id;
      LessonId = attendanceList.LessonId;
      Lesson = attendanceList.Lesson;
      ClassroomId = attendanceList.LessonId;
      Classroom = attendanceList.Classroom;
      Created = attendanceList.Created;
    }
  }
}