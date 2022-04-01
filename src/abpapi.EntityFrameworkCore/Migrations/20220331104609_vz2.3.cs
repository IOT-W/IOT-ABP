using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace abpapi.Migrations
{
    public partial class vz23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BDescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BSort = table.Column<int>(type: "int", nullable: false),
                    BType = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrandType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandType", x => x.Id);
                });

          
            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.Id);
                });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
