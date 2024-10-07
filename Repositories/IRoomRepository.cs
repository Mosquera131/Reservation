using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;

namespace Reserva.Repositories;

    public interface IRoomRepository
    {
        Task<List<Room>> GetAvailableRoomsAsync();

        Task<List<Room_type>> RoomTypesAsync();

        Task<Room> GetById (int id);
    }

    


    
