using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace entitytesting.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacterID = table.Column<int>(nullable: true),
                    Charisma = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Wisdom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSheets", x => x.CharacterSheetID);
                    table.ForeignKey(
                        name: "FK_CharacterSheets_Characters_CharacterID",
                        column: x => x.CharacterID,
                        principalTable: "Characters",
                        principalColumn: "CharacterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_CharacterID",
                table: "CharacterSheets",
                column: "CharacterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
