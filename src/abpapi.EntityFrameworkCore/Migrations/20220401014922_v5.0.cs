using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace abpapi.Migrations
{
    public partial class v50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_TheMember = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Consignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_MethodPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_AfterState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_TotalAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Amountpayable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
