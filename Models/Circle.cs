namespace shapes.Models;

public class Circle : Shape
{
    public double CenterX { get; private set; }
    public double CenterY { get; private set; }
    public double Diameter { get; private set; }

    public Circle(double centerX, double centerY, double diameter)
    {
        CenterX = centerX;
        CenterY = centerY;
        Diameter = diameter;
        Area = Math.PI * Math.Pow(diameter / 2, 2);
    }
}
