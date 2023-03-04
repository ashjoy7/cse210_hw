using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("red", 5);
        shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("green", 3, 4);
        shapes.Add(rectangle);
        
        Circle circle = new Circle("blue", 2);
        shapes.Add(circle);
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine();
        }
    }
}
