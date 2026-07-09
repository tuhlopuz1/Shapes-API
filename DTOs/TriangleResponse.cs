namespace shapes.DTOs;

public record TriangleResponse(int Id, double Area, double X1, double Y1, double X2, double Y2, double X3, double Y3)
    : ShapeResponse(Id, Area);
