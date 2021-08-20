using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 1, "Female", "Fifi", "Holland Lop" },
                    { 18, 1, "Male", "Kevin", "Bunny" },
                    { 17, 1, "Unknown", "Herb", "Holland Lop" },
                    { 16, 3, "Female", "Peggy", "Holland Lop" },
                    { 15, 1, "Male", "Orion", "Bunny" },
                    { 14, 1, "Unknown", "Matchstick", "Bunny" },
                    { 13, 1, "Female", "Potato", "Bunny" },
                    { 12, 1, "Unknown", "Dumbo", "Holland Lop" },
                    { 11, 3, "Female", "Muffin", "Holland Lop" },
                    { 10, 2, "Male", "Hungry", "Bunny" },
                    { 9, 1, "Male", "Big Nose", "Bunny" },
                    { 8, 1, "Female", "The Onion", "Bunny" },
                    { 7, 1, "Unknown", "Bubba", "Lizard" },
                    { 6, 3, "Female", "Commando", "Holland Lop" },
                    { 5, 2, "Male", "Gus", "Holland Lop" },
                    { 4, 1, "Male", "vSmol", "Holland Lop" },
                    { 3, 1, "Female", "Smol", "Holland Lop" },
                    { 2, 1, "Unknown", "Bobo", "Lizard" },
                    { 19, 1, "Male", "Daniel", "Bunny" },
                    { 20, 2, "Male", "Steve", "Bunny" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
