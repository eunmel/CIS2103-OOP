abstract class Shape
{
    protected string name;
    protected Shape(string name) { this.name = name; }

    public abstract double Area();
    public void Describe() => Console.WriteLine($"{Area():F2}")

}

class Circle : Shape
{
    private double r;
    publicCircle(double r) { this.r = r; } 
    public override double Area() => MathPI * r * r;

}

Class Rectangle : Shape
{
    private double w,h;
    public Rectangle(double w, double h) : base("Rectangle")
    { this.w = w; this.h = h; }
    public override double Area() => w * h;

}