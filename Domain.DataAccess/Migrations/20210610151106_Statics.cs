using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.DataAccess.Migrations
{
    public partial class Statics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalStatics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameofTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeOfWorkToday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfWorkAllTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusOfTask = table.Column<bool>(type: "bit", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalStatics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalStatics_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalStatics_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalStatics_ProjectId",
                table: "PersonalStatics",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalStatics_UsersId",
                table: "PersonalStatics",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalStatics");
        }
    }
}
