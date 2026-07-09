namespace shapes.DTOs;

public record CircleResponse(int Id, double Area, double CenterX, double CenterY, double Diameter)
    : ShapeResponse(Id, Area);
