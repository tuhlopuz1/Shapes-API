using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shapes.Models;

namespace shapes.Data.Configurations;

public class RectangleConfiguration : IEntityTypeConfiguration<Rectangle>
{
    public void Configure(EntityTypeBuilder<Rectangle> builder)
    {
        builder.ToTable("Rectangles");

        builder.Property(rectangle => rectangle.TopLeftX).IsRequired();
        builder.Property(rectangle => rectangle.TopLeftY).IsRequired();
        builder.Property(rectangle => rectangle.BottomRightX).IsRequired();
        builder.Property(rectangle => rectangle.BottomRightY).IsRequired();
    }
}
