using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
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

        return _context.Bookings.ToListAsync();


    }


    public async Task<Booking> GetBooking(int Id)
    {
        var BookingToFind = await _context.Bookings.FindAsync(Id);
        return (BookingToFind);

    }
    public async Task<bool> Delete(int Id)
    {
        var BookingFound = await GetBooking(Id);
        if (BookingFound != null)
        {
            _context.Bookings.Remove(BookingFound);
            await _context.SaveChangesAsync();

            return true;
        }
        return false;

    }
}