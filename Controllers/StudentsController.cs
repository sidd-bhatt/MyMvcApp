using MvcCrud.Models;
using StudentDAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MvcCrud.Controllers;



public class StudentsController : Controller
{
    private readonly ILogger<StudentsController> _logger;

    public StudentsController(ILogger<StudentsController> logger)
    {
        _logger = logger;
    }
    //[HttpGet]
    // public List<Students> GetAllStudents(){
    //     List<Students> list=new List<Students>();
    //     list=StudentDetailsAccess.ShowStudentsDetails();
    //     return list;
    // }
    public IActionResult Index()
    {
        List<Students> list=new List<Students>();
        list=StudentDetailsAccess.ShowStudentsDetails();
        ViewData["students"]=list;
        return View();
    }
    public Students GetStudentById(int id){
        Students student=StudentDetailsAccess.GetStudentById(id);
        return student;
    }
    public void DeleteUserById(int id){
        StudentDetailsAccess.DeleteStudent(id);
    }    
    //[HttpPost("student")]
    public void InsertStudent(Students student){
        StudentDetailsAccess.InsertStudent(student);
    }
    //[HttpPut("{id},student")]
    public void UpdateDetails(int id, Students student)
    {
        StudentDetailsAccess.UpdateDetails(id,student);
    }
}
