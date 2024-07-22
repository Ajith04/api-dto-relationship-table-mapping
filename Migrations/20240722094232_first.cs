using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ajith.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StuAge = table.Column<int>(type: "int", nullable: false),
                    StuEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StuId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
