using System;

namespace AllAboutClasses
{
    public class Country
    {

        public string Name{get; set;}

        public int Population{get; set;}

        public readonly double AREA = 12312.45;
        public static readonly bool IsOnEarth;

        //Default Constructor
        public Country()
        {

        }

        //Paramaterized Constructor
        public Country(string name)
        {
            Name = name;
        }
        public Country(string name, int population, double area)

        {
            Name = name;
            Population = population;
            AREA = area;


        }

        //static Constructor
        static Country()
        {
            IsOnEarth = true;
        }

        //Destructor, Finalizer
        ~Country()
        {
           Console.WriteLine("I am dying..."); 
        }




    }

    public class Demo{

        void DoSomething()
        {
            Country country = new Country();
            Country country1 = new Country("Nepal");

        }
    }



}