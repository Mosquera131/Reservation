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

    public async Task Add(Booking booking)
    {
        _context.Bookings.Add(booking);
        await _context.SaveChangesAsync();

    }

    public async Task<IEnumerable<Booking>> GetAllBooking()
    {
        var AllBookings = await _context.Bookings.ToListAsync();
        return AllBookings;
    }

    public async Task<Booking> GetBooking(int id)
    {
        var BookingToFind = await _context.Bookings.FindAsync();
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