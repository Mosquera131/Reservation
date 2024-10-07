using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Reserva.Models.DTOS;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Guests;

public partial class GuestController

{
    [HttpPost]
    [SwaggerOperation(
    Summary = "Create Aguest",
    Description = "Register a Guest in the database."
)]
    [SwaggerResponse(200, "Return the Guest that has been created.")]
    [SwaggerResponse(500, "An Internal server error occurred.")]

    public async Task<ActionResult<Guest>> Create(GuestDTO inputGuest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        // var passwordh = _IGuest.HashPassword(inputUser.Password);

        var Guest1 = new Guest
        {
            Firts_name = inputGuest.Firts_name,
            Last_name = inputGuest.Last_name,

            Email = inputGuest.Email,
            Identification_number = inputGuest.Identification_number,

            Phone_number = inputGuest.Phone_number

        };

        await _IGuest.Add(Guest1);
        return Ok(Guest1);
    }
}