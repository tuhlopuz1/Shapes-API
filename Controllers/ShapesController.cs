using Microsoft.AspNetCore.Mvc;
using shapes.DTOs;
using shapes.Services;

namespace shapes.Controllers;

[ApiController]
[Route("shapes")]
public class ShapesController : ControllerBase
{
    private readonly IShapeService _shapeService;

    public ShapesController(IShapeService shapeService)
    {
        _shapeService = shapeService;
    }

    [HttpPost("circles")]
    public async Task<ActionResult<ShapeResponse>> CreateCircle(CircleRequest request)
    {
        var circle = await _shapeService.CreateCircleAsync(request.CenterX, request.CenterY, request.Diameter);
        return CreatedShape(circle.Id, circle.ToResponse());
    }

    [HttpPost("rectangles")]
    public async Task<ActionResult<ShapeResponse>> CreateRectangle(RectangleRequest request)
    {
        var rectangle = await _shapeService.CreateRectangleAsync(request.TopLeftX, request.TopLeftY, request.BottomRightX, request.BottomRightY);
        return CreatedShape(rectangle.Id, rectangle.ToResponse());
    }

    [HttpPost("triangles")]
    public async Task<ActionResult<ShapeResponse>> CreateTriangle(TriangleRequest request)
    {
        var triangle = await _shapeService.CreateTriangleAsync(request.X1, request.Y1, request.X2, request.Y2, request.X3, request.Y3);
        return CreatedShape(triangle.Id, triangle.ToResponse());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ShapeResponse>> GetById(int id)
    {
        var shape = await _shapeService.GetByIdAsync(id);
        if (shape is null)
        {
            return NotFound();
        }

        return new ObjectResult(shape.ToResponse()) { DeclaredType = typeof(ShapeResponse) };
    }

    [HttpGet("area")]
    public async Task<ActionResult<double>> GetTotalArea()
    {
        var totalArea = await _shapeService.GetTotalAreaAsync();
        return Ok(totalArea);
    }

    private CreatedAtActionResult CreatedShape(int id, ShapeResponse response) =>
        new(nameof(GetById), null, new { id }, response) { DeclaredType = typeof(ShapeResponse) };
}
