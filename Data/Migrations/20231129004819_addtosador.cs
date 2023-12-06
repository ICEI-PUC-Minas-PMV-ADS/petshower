using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authen.Migrations
{
    /// <inheritdoc />
    public partial class addtosador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Agenda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Agenda",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
