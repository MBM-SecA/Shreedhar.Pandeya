
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller 

{
    private EMSContext db;
    public EmployeeController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        var employees = db.Employees.ToList();
        

        

         return View(employees);
    }

    
    public ActionResult Details([FromQuery] int id)
    {
       var employee = db.Employees.Find(id);
        return View(employee);

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


