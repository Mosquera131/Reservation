using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Repositories;

namespace Reserva.Controllers.Rooms;

    [ApiController]
    [Route("api/[controller]")]
    public partial class RoomController : ControllerBase
    {
        private  readonly IRoomRepository  _IRoom;

        public RoomController (IRoomRepository IRoom)
        {
            _IRoom= IRoom;
        }

        
    }
