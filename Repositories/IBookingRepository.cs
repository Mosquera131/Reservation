using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Reserva.Services;

namespace Reserva.Repositories;

public interface IBookingRepository
{
    Task Add(Booking booking);
    Task <IEnumerable<Booking>> GetAllBooking();
    Task <bool> Delete(int Id);
    Task<Booking> GetBooking(int Id);
}
