using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Migrations
{
    /// <inheritdoc />
    public partial class Bookingtableactual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Employees_Employeed_id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Employeed_id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Employeed_id",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Employee_id",
                table: "Bookings",
                column: "Employee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Employees_Employee_id",
                table: "Bookings",
                column: "Employee_id",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Employees_Employee_id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Employee_id",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "Employeed_id",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)4, 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)2, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Max Ocupancy", "Price Per Night", "Room_type_id" },
                values: new object[] { (byte)1, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Price Per Night", "Room_type_id" },
                values: new object[] { 150.0, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Employeed_id",
                table: "Bookings",
                column: "Employeed_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Employees_Employeed_id",
                table: "Bookings",
                column: "Employeed_id",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
