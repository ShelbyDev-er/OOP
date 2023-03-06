public abstract class Triangle : Shape {
    public double Base { get; set; }
    public double Height { get; set; }
    public override double GetArea()
    {
        double A = 1/2 * Base * Height;
        return A;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}