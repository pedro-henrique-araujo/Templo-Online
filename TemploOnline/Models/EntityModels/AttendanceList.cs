using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TemploOnline.Models.EntityModels
{
  public class AttendanceList : Entity
  {
    public int ClassroomId { get; set; }

    public Classroom Classroom { get; set; }

    [Display(Name = "Lição")]
    public int LessonId { get; set; }

    public Lesson Lesson { get; set; }

    public List<Attendance> Attendances { get; set; }

    public DateTime Created { get; set; }
  }
}