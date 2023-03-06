public abstract class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public override double GetArea()
    {
        double A = Length * Width;
        return A;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}