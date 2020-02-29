using Microsoft.EntityFrameworkCore.Migrations;

namespace VNext.BienEtreAuTravail.DAL.Migrations
{
    public partial class BienEtre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HumeurEmp_Humeur_HumeurEmpMoodId",
                table: "HumeurEmp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Humeur",
                table: "Humeur");

            migrationBuilder.RenameTable(
                name: "Humeur",
                newName: "Moods");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moods",
                table: "Moods",
                column: "MoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_HumeurEmp_Moods_HumeurEmpMoodId",
                table: "HumeurEmp",
                column: "HumeurEmpMoodId",
                principalTable: "Moods",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HumeurEmp_Moods_HumeurEmpMoodId",
                table: "HumeurEmp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moods",
                table: "Moods");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Moods",
                newName: "Humeur");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Humeur",
                table: "Humeur",
                column: "MoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_HumeurEmp_Humeur_HumeurEmpMoodId",
                table: "HumeurEmp",
                column: "HumeurEmpMoodId",
                principalTable: "Humeur",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
