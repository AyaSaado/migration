﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace migration.Migrations
{
    /// <inheritdoc />
    public partial class OwnInSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Sections",
                newName: "TimeSlot_StartTime");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Sections",
                newName: "TimeSlot_EndTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeSlot_StartTime",
                table: "Sections",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "TimeSlot_EndTime",
                table: "Sections",
                newName: "EndTime");
        }
    }
}
