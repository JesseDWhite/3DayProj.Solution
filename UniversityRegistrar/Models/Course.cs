using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    [Required]
    public int CourseId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Teacher { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public int CourseNumber { get; set; }
    [Required]
    public float NumberOfCredits { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
    // - (1) -- courseId (1) -- student(1)
    // - (2) -- courseId (2) -- student(1)

  }
}