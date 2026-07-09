using System.Text.Json.Serialization;

namespace shapes.DTOs;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(CircleResponse), "circle")]
[JsonDerivedType(typeof(RectangleResponse), "rectangle")]
[JsonDerivedType(typeof(TriangleResponse), "triangle")]
public abstract record ShapeResponse(int Id, double Area);
