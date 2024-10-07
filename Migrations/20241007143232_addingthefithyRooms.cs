using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reserva.Migrations
{
    /// <inheritdoc />
    public partial class addingthefithyRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Room Types",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, " Una acogedora habitación básica con una cama individual, ideal para viajeros solos. ", "Habitación Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos. ", "Habitacion Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar eparada, ideal para quienes buscan confort y exclusividad.", "Suite" },
                    { 4, " Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitacion Familiar" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Availability", "Max Ocupancy", "Price Per Night", "Room Number", "Room_type_id" },
                values: new object[,]
                {
                    { 1, true, (byte)1, 50.0, 1, 1 },
                    { 2, true, (byte)1, 50.0, 2, 1 },
                    { 3, true, (byte)2, 150.0, 3, 3 },
                    { 4, true, (byte)2, 150.0, 4, 3 },
                    { 5, true, (byte)4, 200.0, 5, 4 },
                    { 6, true, (byte)4, 200.0, 6, 4 },
                    { 7, true, (byte)2, 150.0, 7, 3 },
                    { 8, true, (byte)4, 200.0, 8, 4 },
                    { 9, true, (byte)1, 50.0, 9, 1 },
                    { 10, true, (byte)1, 50.0, 10, 1 },
                    { 11, true, (byte)2, 80.0, 11, 2 },
                    { 12, true, (byte)2, 80.0, 12, 2 },
                    { 13, true, (byte)2, 150.0, 13, 3 },
                    { 14, true, (byte)1, 50.0, 14, 1 },
                    { 15, true, (byte)2, 80.0, 15, 2 },
                    { 16, true, (byte)4, 200.0, 16, 4 },
                    { 17, true, (byte)4, 200.0, 17, 4 },
                    { 18, true, (byte)2, 80.0, 18, 2 },
                    { 19, true, (byte)4, 200.0, 19, 4 },
                    { 20, true, (byte)2, 80.0, 20, 2 },
                    { 21, true, (byte)1, 50.0, 21, 1 },
                    { 22, true, (byte)4, 200.0, 22, 4 },
                    { 23, true, (byte)2, 80.0, 23, 2 },
                    { 24, true, (byte)1, 50.0, 24, 1 },
                    { 25, true, (byte)2, 150.0, 25, 3 },
                    { 26, true, (byte)2, 150.0, 26, 3 },
                    { 27, true, (byte)4, 200.0, 27, 4 },
                    { 28, true, (byte)2, 150.0, 28, 3 },
                    { 29, true, (byte)2, 80.0, 29, 2 },
                    { 30, true, (byte)1, 50.0, 30, 1 },
                    { 31, true, (byte)2, 80.0, 31, 2 },
                    { 32, true, (byte)1, 50.0, 32, 1 },
                    { 33, true, (byte)2, 150.0, 33, 3 },
                    { 34, true, (byte)1, 50.0, 34, 1 },
                    { 35, true, (byte)1, 50.0, 35, 1 },
                    { 36, true, (byte)1, 50.0, 36, 1 },
                    { 37, true, (byte)2, 80.0, 37, 2 },
                    { 38, true, (byte)2, 80.0, 38, 2 },
                    { 39, true, (byte)4, 200.0, 39, 4 },
                    { 40, true, (byte)2, 80.0, 40, 2 },
                    { 41, true, (byte)1, 50.0, 41, 1 },
                    { 42, true, (byte)1, 50.0, 42, 1 },
                    { 43, true, (byte)2, 80.0, 43, 2 },
                    { 44, true, (byte)2, 150.0, 44, 3 },
                    { 45, true, (byte)2, 150.0, 45, 3 },
                    { 46, true, (byte)2, 150.0, 46, 3 },
                    { 47, true, (byte)1, 50.0, 47, 1 },
                    { 48, true, (byte)2, 80.0, 48, 2 },
                    { 49, true, (byte)2, 150.0, 49, 3 },
                    { 50, true, (byte)2, 80.0, 50, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Room Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room Types",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
