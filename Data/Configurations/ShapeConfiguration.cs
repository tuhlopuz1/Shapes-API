using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shapes.Models;

namespace shapes.Data.Configurations;

public class ShapeConfiguration : IEntityTypeConfiguration<Shape>
{
    public void Configure(EntityTypeBuilder<Shape> builder)
    {
        builder.ToTable("Shapes");
        builder.UseTptMappingStrategy();

        builder.HasKey(shape => shape.Id);
        builder.Property(shape => shape.Area).IsRequired();
    }
}
