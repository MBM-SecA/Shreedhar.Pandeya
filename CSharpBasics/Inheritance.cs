using System;

public interface IShapeWithSides
{
    public double GetDiagonal();
    

}

public abstract class Shape
{

    public abstract double GetArea();
    

    public abstract double GetCircumference();
    
    public virtual void Display()
    {
        Console.WriteLine("Displaying result");

    }



}

public class Rectangle : Shape , IShapeWithSides
{

    public double Length {get; set;}
    public double Breadth {get; set;}

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;

    }
    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2*(Length + Breadth );

    public double GetDiagonal() =>Math.Sqrt(Length*Length + Breadth*Breadth);
     public override void Display()
    {
        Console.WriteLine($"displaying results for rectangle with length [{Length}X{Breadth}]:");
        Console.WriteLine($"Area: {this.GetArea()}");
        Console.WriteLine($"Diagonal : {this.GetDiagonal()}");
    }

    

}
public class Square : Rectangle
{
    public Square(double side) : base (side, side)
    {

    }

    

}
public class Circle : Shape
{
    public double Radius {get; set;}
    //public double breadth {get; set;}
    public override double GetArea() => Math.PI *Radius * Radius;
    public override double GetCircumference() => 2* Math.PI * Radius;

    

}
 class a {}
  class b : a {}

  class c : b , IA, IB {}


  interface IA {}
   interface IB {}
