using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace abpapi.Migrations
{
    public partial class v52 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logintable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login_userid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login_account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login_pwd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login_avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login_state = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logintable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logintable");
        }
    }
}
