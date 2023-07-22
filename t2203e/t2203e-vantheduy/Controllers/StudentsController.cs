// StudentsController.cs
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using t2203e_vantheduy.Data;
using t2203e_vantheduy.Models;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Student>> GetStudents()
    {
        return _context.Students.ToList();
    }

    [HttpPost]
    public ActionResult<Student> AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
    }
}
