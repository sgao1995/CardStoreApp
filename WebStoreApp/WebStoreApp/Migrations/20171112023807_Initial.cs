using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebStoreApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    ReviewerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: false),
                    Attribute = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EffectText = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false),
                    IsInStock = table.Column<bool>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ThumbnailUrl = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CategoryId",
                table: "Cards",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
