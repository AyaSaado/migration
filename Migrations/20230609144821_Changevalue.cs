using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace migration.Migrations
{
    /// <inheritdoc />
    public partial class Changevalue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeSlot_StartTime",
                table: "Sections",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "TimeSlot_EndTime",
                table: "Sections",
                newName: "EndTime");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Sections",
                newName: "TimeSlot_StartTime");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Sections",
                newName: "TimeSlot_EndTime");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Schedules",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
