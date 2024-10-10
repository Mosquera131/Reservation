using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reserva.Models;
using Reserva.Models.DTOS;

namespace Reserva.Repositories;

    public interface IGuestRepository
    {
        Task Add(Guest Guest);

        Task<IEnumerable <Guest>> GetAllGuest();
    }
