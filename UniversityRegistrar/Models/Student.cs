using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
    [Required]
    public int StudentId { get; set; }
    [Required]
    public string Name { get; set; }
    public float GPA {get; set;}
    [Required]
    public DateTime EnrollmentDate {get; set;}
    

    public virtual ICollection<CourseStudent> JoinEntities { get;}
  }
}