using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Bookings;

public partial class BookingController
{
    [HttpGet]
    [SwaggerOperation(
    Summary = "Retrieve all Bookings",
    Description = "Showing all the Bookings that has been Register in the database."
    )]
    [SwaggerResponse(200, "Return all the  Bookings that has been created.")]
    [SwaggerResponse(500, "An Internal server error occurred.")]


    public async Task<ActionResult<IEnumerable<Booking>>> GetAllBooking()
    {
        var AllBookings= await _Booking.GetAllBooking();
        
        return Ok(AllBookings);
    }
}
