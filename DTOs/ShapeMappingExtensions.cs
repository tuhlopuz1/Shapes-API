using shapes.Models;

namespace shapes.DTOs;

public static class ShapeMappingExtensions
{
    public static ShapeResponse ToResponse(this Shape shape) => shape switch
    {
        Circle circle => new CircleResponse(circle.Id, circle.Area, circle.CenterX, circle.CenterY, circle.Diameter),
        Rectangle rectangle => new RectangleResponse(rectangle.Id, rectangle.Area, rectangle.TopLeftX, rectangle.TopLeftY, rectangle.BottomRightX, rectangle.BottomRightY),
        Triangle triangle => new TriangleResponse(triangle.Id, triangle.Area, triangle.X1, triangle.Y1, triangle.X2, triangle.Y2, triangle.X3, triangle.Y3),
        _ => throw new InvalidOperationException($"Unknown shape type: {shape.GetType().Name}")
    };
}
