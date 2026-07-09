using Microsoft.EntityFrameworkCore;
using shapes.Data;
using shapes.Models;

namespace shapes.Services;

public class ShapeService : IShapeService
{
    private readonly AppDbContext _dbContext;

    public ShapeService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Circle> CreateCircleAsync(double centerX, double centerY, double diameter)
    {
        var circle = new Circle(centerX, centerY, diameter);
        _dbContext.Shapes.Add(circle);
        await _dbContext.SaveChangesAsync();
        return circle;
    }

    public async Task<Rectangle> CreateRectangleAsync(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
    {
        var rectangle = new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY);
        _dbContext.Shapes.Add(rectangle);
        await _dbContext.SaveChangesAsync();
        return rectangle;
    }

    public async Task<Triangle> CreateTriangleAsync(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        var triangle = new Triangle(x1, y1, x2, y2, x3, y3);
        _dbContext.Shapes.Add(triangle);
        await _dbContext.SaveChangesAsync();
        return triangle;
    }

    public async Task<Shape?> GetByIdAsync(int id)
    {
        return await _dbContext.Shapes.FirstOrDefaultAsync(shape => shape.Id == id);
    }

    public async Task<double> GetTotalAreaAsync()
    {
        return await _dbContext.Shapes.SumAsync(shape => shape.Area);
    }
}
