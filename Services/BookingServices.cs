using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reserva.Data;
using Reserva.Models;
using Reserva.Repositories;

namespace Reserva.Services;

public class BookingServices : IBookingRepository
{
    private readonly ApplicationDbContext _context;
    public BookingServices(ApplicationDbContext context)
    {
        _context = context;
    }


    public Task Add(Booking booking)
    {

        return  _context.Bookings.ToListAsync();
        

    }
}