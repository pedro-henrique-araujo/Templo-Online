using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TemploOnline.Models.EntityModels;

namespace TemploOnline.Models.ViewModels
{
  public class LessonViewModel : NomeableEntityViewModel
  {
    [Required]
    public int TextbookId { get; set; }

    [Required]
    [Display(Name = "Número da Lição")]
    public int LessonNumber { get; set; }

    public Textbook Textbook { get; set; }

    public List<SelectListItem> LessonNumbers { get; set; }

    public LessonViewModel()
      :base()
    {
        
    }

    public LessonViewModel(Lesson lesson)
      :base(lesson)
    {
        Textbook = lesson.Textbook;
        TextbookId = lesson.TextbookId;
        LessonNumber = lesson.LessonNumber;
    }

  }
}