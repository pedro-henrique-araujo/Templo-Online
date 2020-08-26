using System;
using System.Collections.Generic;
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
    
    public int ClassroomId { get; set; }

    public List<SelectListItem> Classrooms { get; set; }

    public int LessonId { get; set; }

    public List<SelectListItem> Lessons { get; set; }

    public List<Attendance> TeachersAttendances { get; set; }

    public List<Attendance> StudentsAttendances { get; set; }

    public DateTime Created { get; set; }

    public AttendanceListViewModel()
    {      
    }

    public AttendanceListViewModel(AttendanceList attendanceList)
    {
      LessonId = attendanceList.LessonId;
      ClassroomId = attendanceList.LessonId;
      Created = attendanceList.Created;
    }
  }
}