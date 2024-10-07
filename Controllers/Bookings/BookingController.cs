using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Repositories;
using Reserva.Services;

namespace Reserva.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
public partial class BookingController : ControllerBase
{
    private readonly IBookingRepository _Booking;

    public BookingController(IBookingRepository IBoooking)
    {
        _Booking = IBoooking;
    }

}
