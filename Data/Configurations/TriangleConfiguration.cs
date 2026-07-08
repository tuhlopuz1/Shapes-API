using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shapes.Models;

namespace shapes.Data.Configurations;

public class TriangleConfiguration : IEntityTypeConfiguration<Triangle>
{
    public void Configure(EntityTypeBuilder<Triangle> builder)
    {
        builder.ToTable("Triangles");

        builder.Property(triangle => triangle.X1).IsRequired();
        builder.Property(triangle => triangle.Y1).IsRequired();
        builder.Property(triangle => triangle.X2).IsRequired();
        builder.Property(triangle => triangle.Y2).IsRequired();
        builder.Property(triangle => triangle.X3).IsRequired();
        builder.Property(triangle => triangle.Y3).IsRequired();
    }
}
