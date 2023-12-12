using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authen.Migrations
{
    /// <inheritdoc />
    public partial class addAgendamentoApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_AspNetUsers_ApplicationUserId1",
                table: "Agendamento");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_ApplicationUserId1",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Agendamento");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Agendamento",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ApplicationUserId",
                table: "Agendamento",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_AspNetUsers_ApplicationUserId",
                table: "Agendamento",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_AspNetUsers_ApplicationUserId",
                table: "Agendamento");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_ApplicationUserId",
                table: "Agendamento");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Agendamento",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Agendamento",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ApplicationUserId1",
                table: "Agendamento",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_AspNetUsers_ApplicationUserId1",
                table: "Agendamento",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
