using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Reserva.Models;

namespace Reserva.Seeders;

public class RoomSeeders
{
    public static void Seeder(ModelBuilder modelBuilder)
    {
        Random random = new Random();

        var rooms = new List<Room>();
        for (int i = 1; i <= 50; i++)
        {
            // Asignar tipo de habitación de forma aleatoria
            int roomTypeId = random.Next(1, 5); // Del 1 al 4 porque tienes 4 tipos de habitaciones

            // Definir precios y capacidad según el tipo de habitación
            double price;
            byte maxOccupancy;

            switch (roomTypeId)
            {
                case 1: // Habitación Simple
                    price = 50;
                    maxOccupancy = 1;
                    break;
                case 2: // Habitación Doble
                    price = 100;
                    maxOccupancy = 2;
                    break;
                case 3: // Suite
                    price = 200;
                    maxOccupancy = 4;
                    break;
                case 4: // Habitación Familiar
                    price = 150;
                    maxOccupancy = 5;
                    break;
                default:
                    price = 0;
                    maxOccupancy = 0;
                    break;
            }

            // Crear la habitación
            rooms.Add(new Room
            {
                Id = i,
                Room_number = i,
                Price_per_night = price,
                Availability = true, // Todas las habitaciones disponibles inicialmente
                Max_ocuppancy_persons = maxOccupancy,
                Room_type_id = roomTypeId
            });
        }

        modelBuilder.Entity<Room>().HasData(rooms);
    }
}

