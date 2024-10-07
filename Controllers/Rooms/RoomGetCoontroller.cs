using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;

namespace Reserva.Controllers.Rooms;

public partial class RoomController
{

    [HttpGet("available")]
    public async Task<IActionResult> GetAvailableRooms()
    {
        var availableRooms = await _IRoom.GetAvailableRoomsAsync();
        return Ok(availableRooms);
    }

}
