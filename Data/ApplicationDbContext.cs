using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reserva.Models;
using Reserva.Seeders;

namespace Reserva.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Room_type> Room_Types { get; set; }
    public DbSet<Room> Rooms { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        RoomSeeders.Seeder(modelBuilder);
        RoomTypeSeeder.Seeder(modelBuilder);


    }

}
