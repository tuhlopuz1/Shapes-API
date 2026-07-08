using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shapes.Models;

namespace shapes.Data.Configurations;

public class CircleConfiguration : IEntityTypeConfiguration<Circle>
{
    public void Configure(EntityTypeBuilder<Circle> builder)
    {
        builder.ToTable("Circles");

        builder.Property(circle => circle.CenterX).IsRequired();
        builder.Property(circle => circle.CenterY).IsRequired();
        builder.Property(circle => circle.Diameter).IsRequired();
    }
}
