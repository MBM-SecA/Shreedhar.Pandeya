using System;
using System.Collections.ObjectModel;
using LearnCollections;

public class Program{

    static void Main()
    {
        // Collection collection = new Collection();
        // collection.LearnDictionary();
        Square square = new Square(12.4);
        //square.Side = 12;
        square.Display();
       //var SquareArea = square.GetArea();

        Rectangle rect = new Rectangle(12.4 , 16.1);
        var AreaRect =  rect.GetArea();
        var CircRect = rect.GetCircumference();


    }
}