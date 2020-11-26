
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller 
{
    public ActionResult Index()
    {
        List<Person> employees = Person.GetPerson();
         return View(employees);
    }

    
    public ActionResult Details([FromQuery] int id)
    {
        var employe = Person.GetPerson();
        var reqEmployee = employe.FirstOrDefault(x=>x.ID==id);
        return View(reqEmployee);

    }

    public ActionResult Add()
    {
        return View();

    }

    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
        return "Records Saved"; 

    }



}


