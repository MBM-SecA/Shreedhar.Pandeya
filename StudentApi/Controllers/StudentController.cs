
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;


[Route("api/students")]
[ApiController]


public class StudentController : ControllerBase
{
    [HttpGet]
    [Route("{name}")]

    public ActionResult GetAllStudentsbyName(string name)
    {
        var students = new string[] {"Ram", " Shyam", "Hari "};
        var student = students.Where( x => x == name).FirstOrDefault();

        //students = null;

        if(student == null)
            return NotFound("STUDENST NOT FOUND");
            //return BadRequest();
        return Ok(student);
    }

    [HttpPost]
    [Route("all")]

    public ActionResult CreateStudent(Student student)
    {
        if(student == null)
            return BadRequest();
        
        //Add student to db
        return Created("", student);
    }

    


   



}