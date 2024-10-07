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
Summary = "Create Aguest",
Description = "Register a Guest in the database."
)]
    [SwaggerResponse(200, "Return the Guest that has been created.")]
    [SwaggerResponse(500, "An Internal server error occurred.")]
    [HttpPost]

    public async Task<ActionResult<Booking>> Create(BookingDTO inputGuest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        // var passwordh = _Booking.HashPassword(inputUser.Password);

        var Booking21 = new Booking
        {
            Start_date = inputGuest.Start_date,

            End_date = inputGuest.End_date,

            Total_cost = inputGuest.Total_cost,

            Room_id = inputGuest.Room_id,

            Guest_id = inputGuest.Guest_id,

            Employee_id = inputGuest.Employee_id

        };

        await _Booking.Add(Booking21);

        return Ok(Booking21);
    }

}
