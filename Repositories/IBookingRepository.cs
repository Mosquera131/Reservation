using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reserva.Models;
using Reserva.Services;

namespace Reserva.Repositories;

public interface IBookingRepository
{
    Task Add(Booking booking);

}
