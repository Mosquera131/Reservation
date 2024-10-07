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
            Summary = "Retrieve All The Room Types",
            Description = "Gets  all the Room Type that are avaliable  "
            )]
    [SwaggerResponse(200, "Return a list of all the rooms available ")]
    [SwaggerResponse(404, "Rooms not found")]
    [SwaggerResponse(500, "An Internal server error occurred.")]

    public async Task<IActionResult> RoomTypes()
    {
        var RoomTypes = await _IRoom.RoomTypesAsync();
        return Ok(RoomTypes);
    }

    [HttpGet("Romm by Id")]
    [SwaggerOperation(
            Summary = "Retrieve The room by its Id",
            Description = "Gets  the Room Information of the room that has been search by its Id  "
            )]
    [SwaggerResponse(200, "Return the room room  ")]
    [SwaggerResponse(404, "Room not found")]
    [SwaggerResponse(500, "An Internal server error occurred.")]

    public async Task<ActionResult<Room>> GetById(int id)
    {
        var Roomsearch = await _IRoom.GetById(id);
        if (Roomsearch == null)
        {
            return NotFound();
        }
        return Roomsearch;
    }



}
