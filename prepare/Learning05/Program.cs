using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        // you can put any shape object in here where the class inherits from Shape
        
        Square sq = new Square("blue", 2);
        shapes.Add(sq);

        Rectangle rect = new Rectangle("red", 3, 2);
        shapes.Add(rect);

        Circle cir = new Circle("yellow", 4);
        shapes.Add(cir);

        foreach (Shape i in shapes)
        {
            string shapeColor = i.GetColor();
            double shapeArea = i.GetArea();
            Console.WriteLine($"The area of the {shapeColor} shape is {shapeArea}.");
        }
    
        // Square sq = new Square("blue", 2);
        // string sqColor = sq.GetColor();
        // double sqArea = sq.GetArea();
        // Console.WriteLine($"The area of the {sqColor} square is {sqArea}.");

        // Rectangle rect = new Rectangle("red", 3, 2);
        // string rectColor = rect.GetColor();
        // double rectArea = rect.GetArea();
        // Console.WriteLine($"The area of the {rectColor} square is {rectArea}.");

        // Circle cir = new Circle("yellow", 4);
        // string cirColor = cir.GetColor();
        // double cirArea = cir.GetArea();
        // Console.WriteLine($"The area of the {cirColor} square is {cirArea}.");
    }
}