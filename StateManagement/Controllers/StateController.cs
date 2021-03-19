using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
public class StateController: Controller
{
    public ViewResult First()
    {
        // StateManagement
        //1. Client Side
        //1.1 Cookies
        var name ="Shreedhar Pandeya";
        //CookieOptions
        Response.Cookies.Append("user",name);

        //1.2 Query String (Query Parameters)
        HttpContext.Session.SetString("Hello", "World");
        


        return View();
    }

    [HttpGet]
    public ViewResult Second(string name, int age)
    {
        var userAddress = HttpContext.Session.GetString("World");


        // ///2.2 Temp Data

        TempData["CollegeName"] = "MadanBhandari College";

        return View();
    }

    [HttpGet]
    public ViewResult Third()
    {
        


        ///2.2 Temp Data

       var cName = TempData["CollegeName"] = "MadanBhandari College";
        byte value = 76;

        ViewData["Name1"] = "DUDUDADA";
        ViewBag.Name = "he welcome";


        return View(value);
    }


    [HttpPost]
    public bool Second(string collegeName)
    {
        return true;
    }
}