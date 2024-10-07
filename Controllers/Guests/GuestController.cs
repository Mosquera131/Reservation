using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Repositories;

namespace Reserva.Controllers.Guests;

    [ApiController]
    [Route("api/[controller]")]
    public partial class GuestController : ControllerBase
    {
        private  readonly IGuestRepository  _IGuest;

        public GuestController (IGuestRepository IGuest)
        {
            _IGuest= IGuest;
        }
    }
