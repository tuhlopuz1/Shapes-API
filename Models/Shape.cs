namespace shapes.Models;

public abstract class Shape
{
    public int Id { get; set; }

    public double Area { get; protected set; }
}
