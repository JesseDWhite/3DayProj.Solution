using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniversityRegistrar.Controllers
{
  public class StudentsController : Controller
  {
    public ActionResult Index()
    {
      return View(_db.Students.ToList());
    }

    public ActionResult Details(int id)
    {
      var thisStudent = _db.Students
        .Includes(student => student.JoinEntities)
        .ThenInclude(join => join.Course)
        .FirstOrDefault(student => student.StudentId == id);
        return View(thisStudent);
    }

    private readonly UniversityRegistrarContext _db;

    public StudentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Create()
    {
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student, int CourseId)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      if (CourseId != 0)
      {
        _db.CourseStudent.Add(new )
      }
    }
  }
}