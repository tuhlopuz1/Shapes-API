using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace shapes.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Area = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Circles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    CenterX = table.Column<double>(type: "double precision", nullable: false),
                    CenterY = table.Column<double>(type: "double precision", nullable: false),
                    Diameter = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Circles_Shapes_Id",
                        column: x => x.Id,
                        principalTable: "Shapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rectangles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    TopLeftX = table.Column<double>(type: "double precision", nullable: false),
                    TopLeftY = table.Column<double>(type: "double precision", nullable: false),
                    BottomRightX = table.Column<double>(type: "double precision", nullable: false),
                    BottomRightY = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rectangles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rectangles_Shapes_Id",
                        column: x => x.Id,
                        principalTable: "Shapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Triangles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    X1 = table.Column<double>(type: "double precision", nullable: false),
                    Y1 = table.Column<double>(type: "double precision", nullable: false),
                    X2 = table.Column<double>(type: "double precision", nullable: false),
                    Y2 = table.Column<double>(type: "double precision", nullable: false),
                    X3 = table.Column<double>(type: "double precision", nullable: false),
                    Y3 = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triangles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Triangles_Shapes_Id",
                        column: x => x.Id,
                        principalTable: "Shapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circles");

            migrationBuilder.DropTable(
                name: "Rectangles");

            migrationBuilder.DropTable(
                name: "Triangles");

            migrationBuilder.DropTable(
                name: "Shapes");
        }
    }
}
