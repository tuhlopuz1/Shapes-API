namespace shapes.DTOs;

public record RectangleResponse(int Id, double Area, double TopLeftX, double TopLeftY, double BottomRightX, double BottomRightY)
    : ShapeResponse(Id, Area);
