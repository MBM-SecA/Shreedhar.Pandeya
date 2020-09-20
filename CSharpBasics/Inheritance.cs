using System;

public abstract class Shape
{

    public abstract double GetArea();
    

    public abstract double GetCircumference();
    
    public void Display(Shape shape)
    {
        Console.WriteLine($"Displaying result for : {shape}");

    }



}
public class Square : Shape
{

    public Square(double side)
    {
        Side = side;
    }
    public double Side {get; set;}
    public double breadth {get; set;}
    public override double GetArea() => Side * Side;
    public override double GetCircumference() => Side + breadth ;

    

}
public class Rectangle : Shape
{

    public double length {get; set;}
    public double breadth {get; set;}

    public Rectangle(double Length, double Breadth)
    {
        Length = length;
        Breadth = breadth;

    }
    public override double GetArea() => length * breadth;
    public override double GetCircumference() => 2*(length + breadth );

    

}
public class Circle : Shape
{
    public double Radius {get; set;}
    //public double breadth {get; set;}
    public override double GetArea() => Math.PI *Radius * Radius;
    public override double GetCircumference() => 2* Math.PI * Radius;

    

}
