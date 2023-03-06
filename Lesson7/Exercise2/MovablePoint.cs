public class MovablePoint : IMovable
{
    public int X { get; set; }
    public int Y { get; set; }
    public void MoveUp() => Y++;
    public void MoveDown() => Y--;
    public void MoveLeft() => X--;
    public void MoveRight() => X++;
} 