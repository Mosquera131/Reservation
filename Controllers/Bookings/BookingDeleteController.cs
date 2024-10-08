using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Bookings;

public partial class BookingController
{
    [HttpDelete]
    [SwaggerOperation(
Summary = "Deleting a Booking",
Description = "Delete a Booking in the database."
)]
    [SwaggerResponse(200, "Booking has been deleted")]
    [SwaggerResponse(500, "An Internal server error occurred.")]

    public async Task<IActionResult> Delete([FromRoute] int Id)
    {
        var BookingDelete= await _Booking.Delete(Id);
        if (BookingDelete)
        {
            return Ok("The Booking has been deleted");
        }

        return StatusCode(500, "the Booking was not found");
    }


}
