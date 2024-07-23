using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ajith.Migrations
{
    /// <inheritdoc />
    public partial class ty : Migration
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

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentStuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubId);
                    table.ForeignKey(
                        name: "FK_Subjects_Students_StudentStuId",
                        column: x => x.StudentStuId,
                        principalTable: "Students",
                        principalColumn: "StuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudentStuId",
                table: "Subjects",
                column: "StudentStuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
