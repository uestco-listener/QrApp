using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QrApp.Migrations
{
    /// <inheritdoc />
    public partial class firstStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    stockName = table.Column<string>(type: "text", nullable: true),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true),
                    requestType = table.Column<string>(type: "text", nullable: true),
                    sourceLocation = table.Column<string>(type: "text", nullable: true),
                    destinationLocation = table.Column<string>(type: "text", nullable: true),
                    requestedBy = table.Column<string>(type: "text", nullable: true),
                    requestedFor = table.Column<string>(type: "text", nullable: true),
                    rnd = table.Column<string>(type: "text", nullable: true),
                    demandTime = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
