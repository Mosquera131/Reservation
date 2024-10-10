using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Guests;

public partial class GuestController
{
    [HttpGet]
    [SwaggerOperation(
        Summary = "Retrieve all the  Aguest",
        Description = "Show all the  Guest in the database."
        )]
    [SwaggerResponse(200, "Return the Guest that has been created.")]
    [SwaggerResponse(500, "An Internal server error occurred.")]

    public async Task<ActionResult<IEnumerable<Guest>>> GetAllGuest()
    {
        var AllGuest = await _IGuest.GetAllGuest();
        return Ok(AllGuest);
    }

}
