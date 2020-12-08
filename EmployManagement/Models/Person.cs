using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int ID {get; set;}


    [Required]
    [Display(Name= "First Name")]
    public string FirstName {get; set;}
    
    [Required]
    [Display(Name= "Last Name")]

    public string Surname {get; set;}
     public string Address{get; set;}
     public char Gender{get; set;} = 'M';
     public double Salary {get; set;}


     public static List<Person> GetPerson()
     {
         Person emp1 = new Person()
         {
            FirstName = "Shreedahr1",Surname = "Pandeya", Address= " Dang", Salary= 2000
         };
         Person emp2 = new Person()
         {
            FirstName = "Shreedahr2",Surname = "Pandeya", Address= " Dang", Salary= 2000
         };
         Person emp3 = new Person()
         {
            FirstName = "Shreedahr3",Surname = "Pandeya", Address= " Dang", Salary= 2000
         };
          List<Person> employees = new List<Person> {emp1,emp2,emp3};
        return employees;
     }
}