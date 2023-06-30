using First_Dotnet.Data;
using First_Dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_Dotnet.Controllers;

public class StudentController : Controller
{
  private readonly ApplicationDBContext _db;

  public StudentController(ApplicationDBContext db)
  {
    _db = db;
  }
  public IActionResult Index()
  {
    // Student s1 = new Student();  // new
    // s1.Id = 1;
    // s1.Name = "Jame";
    // s1.Score = 100;

    // var s2 = new Student();      // Type Interence  **
    // s2.Id = 2;
    // s2.Name = "Jane";
    // s2.Score = 80;

    // Student s3 = new();          // function new()
    // s3.Id = 3;
    // s3.Name = "Joe";
    // s3.Score = 40;

    // List<Student> allStudent = new List<Student>();
    // allStudent.Add(s1);
    // allStudent.Add(s2);
    // allStudent.Add(s3);

    // return View(s1);

    IEnumerable <Student> allStudent = _db.Students;
    return View(allStudent);
  }

  // GET METHOD
  public IActionResult Create()
  {
    return View();
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult Create(Student obj)
  {

    if (ModelState.IsValid)
    {
        _db.Students.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(obj);   
  }

  public IActionResult Edit(int? id)
  {
    if (id == null || id == 0)
    {
        return NotFound();
    }
    var obj = _db.Students.Find(id);
    if (obj == null)
    {
        return NotFound();
    }
    return View(obj);
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult Edit(Student obj)
  {

    if (ModelState.IsValid)
    {
        _db.Students.Update(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(obj);   
  }

  public IActionResult Delete(int? id)
  {
    if (id == null || id == 0)
    {
        return NotFound();
    }
    var obj = _db.Students.Find(id);
    if (obj == null)
    {
        return NotFound();
    }
    _db.Students.Remove(obj);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }
  // public IActionResult ShowScore(int id)
  // {
  //   return Content($"คะแนนสอบของนักเรียน เลขที่ {id} score");
  // }
  
}
