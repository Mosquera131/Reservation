using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reserva.Data;
using Reserva.Models;
using Reserva.Repositories;

namespace Reserva.Services;

    public class GuestService:IGuestRepository
    {
        private readonly ApplicationDbContext _context;
        public GuestService(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task Add(Guest Guest)

        {
            await _context.Guests.AddAsync(Guest);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Guest>> GetAllGuest()
        {
            var AllGuests= await _context.Guests.ToListAsync();
            return AllGuests;
        }
    }
