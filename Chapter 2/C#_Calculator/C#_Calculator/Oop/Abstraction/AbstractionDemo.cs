
abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double Area()
    {
        return length * width;
    }

    public override double Perimeter()
    {
        return 2 * (length + width);
    }
}

class TestAbstraction
{
    
    public static void RunShapesExample()
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + circle.Area()); // Output: Circle Area: 78.53981633974483
        Console.WriteLine("Circle Perimeter: " + circle.Perimeter()); // Output: Circle Perimeter: 31.41592653589793

        Console.WriteLine("Rectangle Area: " + rectangle.Area()); // Output: Rectangle Area: 24
        Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter()); // Output: Rectangle Perimeter: 20
    }
}
