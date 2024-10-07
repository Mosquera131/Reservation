using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reserva.Data;
using Reserva.Models;
using Reserva.Repositories;

namespace Reserva.Services;

public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext _context;

    public RoomServices(ApplicationDbContext context)
    {
        _context = context;
    }


        public async Task<List<Room>> GetAvailableRoomsAsync()
    {
        return await _context.Rooms
                             .Where(room => room.Availability == true) // Filtrar habitaciones disponibles
                            .ToListAsync();
    }


    public async Task<List<Room_type>>RoomTypesAsync()
    {
        return await _context.Room_Types.ToListAsync();
    }

    public async Task<Room> GetById(int id)
    {
        return await _context.Rooms.FindAsync(id);
    }
}

