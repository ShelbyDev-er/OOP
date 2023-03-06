public class Circle
{
    public double? Radius { get; set; }
    public string? Color { get; set; }
    public double GetRadius()
    {
        double radius;
        Console.Write("Enter Radius of Circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
        return radius;
    }
    public string GetColor()
    {
        string color;
        Console.Write("Enter Color of Circle: ");
        color = Console.ReadLine();
        return color;
    }
    public virtual double GetArea()
    {
        const double PI = 3.14;
        double A = GetRadius() * PI;
        return A;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}