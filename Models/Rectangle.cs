namespace shapes.Models;

public class Rectangle : Shape
{
    public double TopLeftX { get; private set; }
    public double TopLeftY { get; private set; }
    public double BottomRightX { get; private set; }
    public double BottomRightY { get; private set; }

    public Rectangle(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
    {
        TopLeftX = topLeftX;
        TopLeftY = topLeftY;
        BottomRightX = bottomRightX;
        BottomRightY = bottomRightY;
        Area = Math.Abs(bottomRightX - topLeftX) * Math.Abs(topLeftY - bottomRightY);
    }
}
