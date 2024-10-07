using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
