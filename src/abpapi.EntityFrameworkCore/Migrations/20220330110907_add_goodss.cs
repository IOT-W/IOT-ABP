using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace abpapi.Migrations
{
    public partial class add_goodss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Goods_Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_SalePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_MarketPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Shelves = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Coding = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });

    
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
