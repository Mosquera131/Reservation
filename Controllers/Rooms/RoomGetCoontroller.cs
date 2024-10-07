using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Rooms;

public partial class RoomController
{

    [HttpGet("available")]
    [SwaggerOperation(
        Summary = "Retrieve the Rooms that are avalible",
        Description = "Gets  the Book  that has been search for its availability "
        )]
        [SwaggerResponse(200, "Return a list of all the rooms available ")]
        [SwaggerResponse(404, "Rooms not found")]
        [SwaggerResponse(500, "An Internal server error occurred.")]
    public async Task<IActionResult> GetAvailableRooms()
    {
        var availableRooms = await _IRoom.GetAvailableRoomsAsync();
        return Ok(availableRooms);
    }

[HttpGet("Room Type")]
    [SwaggerOperation(
        Summary = "Retrieve the Rooms that are avalible",
        Description = "Gets  the Book  that has been search for its availability "
        )]
        [SwaggerResponse(200, "Return a list of all the rooms available ")]
        [SwaggerResponse(404, "Rooms not found")]
        [SwaggerResponse(500, "An Internal server error occurred.")]

        public async Task <IActionResult> RoomTypes()
        {
            var RoomTypes= await _IRoom.RoomTypesAsync();
            return Ok(RoomTypes);
        }


}
