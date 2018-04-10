using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace entitytesting.Migrations
{
    public partial class AddAgeToCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(name: "Age", table: "Characters", nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Age", table: "Characters");
        }
    }
}
