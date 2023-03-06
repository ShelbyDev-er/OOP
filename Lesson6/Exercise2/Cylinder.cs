public class Cylinder : Circle {
    public double height { get; set; }
    public double GetHeight() {
        double height;
        Console.Write("Enter height of clinder: ");
        height = Convert.ToDouble(Console.ReadLine());
        return height;
    }
    public override double GetArea() {
        const double PI = 3.14;
        double A = 2 * PI * base.GetRadius() * GetHeight() + 2 * PI * Math.Pow(base.GetRadius(), 2);
        return A;
    }
}