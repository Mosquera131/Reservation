using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Reserva.Models.DTOS;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Bookings;

public partial class BookingController
{
    [HttpPost]
    [SwaggerOperation(
Summary = "Create Booking",
Description = "Register a Booking in the database."
)]
    [SwaggerResponse(200, "Return the Bookin that has been created.")]
    [SwaggerResponse(500, "An Internal server error occurred.")]
    [HttpPost]

    public async Task<ActionResult<Booking>> Create(BookingDTO inputBooking)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        // deberian haber verificaciones de que si ya exite un cuarto, un empleado y huespeded.. Verificar si la sala (Room) existe

        // var passwordh = _Booking.HashPassword(inputUser.Password);

        var Booking21 = new Booking
        {
            Start_date = inputBooking.Start_date,

            End_date = inputBooking.End_date,

            Total_cost = inputBooking.Total_cost,

            Room_id = inputBooking.Room_id,

            Guest_id = inputBooking.Guest_id,

            Employee_id = inputBooking.Employee_id

        };

        await _Booking.Add(Booking21);


        return Ok(Booking21);
    }

}
