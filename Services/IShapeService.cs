using shapes.Models;

namespace shapes.Services;

public interface IShapeService
{
    Task<Circle> CreateCircleAsync(double centerX, double centerY, double diameter);

    Task<Rectangle> CreateRectangleAsync(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY);

    Task<Triangle> CreateTriangleAsync(double x1, double y1, double x2, double y2, double x3, double y3);

    Task<Shape?> GetByIdAsync(int id);

    Task<double> GetTotalAreaAsync();
}
