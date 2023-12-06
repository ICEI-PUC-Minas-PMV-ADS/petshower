using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authen.Migrations
{
    /// <inheritdoc />
    public partial class addtosadorNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TosadorBanhista_Agenda_AgendaId",
                table: "TosadorBanhista");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "TosadorBanhista",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_TosadorBanhista_Agenda_AgendaId",
                table: "TosadorBanhista",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TosadorBanhista_Agenda_AgendaId",
                table: "TosadorBanhista");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "TosadorBanhista",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TosadorBanhista_Agenda_AgendaId",
                table: "TosadorBanhista",
                column: "AgendaId",
                principalTable: "Agenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
