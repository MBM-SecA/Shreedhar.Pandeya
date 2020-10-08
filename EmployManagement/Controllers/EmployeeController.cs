
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller 
{
    public ActionResult Index()
    {
        
        Person empl1 = new Person()
            { FirstName = "Shreedhar",Surname = "Pandeya",Address = "Dang",Gender = 'M',Salary = 20000.0};
        Person empl2 = new Person()
            { FirstName = "Shreedhar",Surname = "Pandeya",Address = "Dang",Gender = 'M',Salary = 20000.0};
        Person empl3 = new Person()
            {FirstName = "Shreedhar",Surname = "Pandeya",Address = "Dang",Gender = 'M',Salary = 20000.0};

        
         List<Person> employees = new List<Person>() {empl1, empl2, empl3};
         return View(employees);
    }

}


