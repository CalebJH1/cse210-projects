using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 8);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green", 3, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Red", 7);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}