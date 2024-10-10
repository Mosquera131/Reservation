using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reserva.Data;
using Reserva.Models;
using Reserva.Repositories;

namespace Reserva.Services;

public class EmployeeService : IEmployeeRepository
{

    private readonly ApplicationDbContext _context;
    public EmployeeService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Add(Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        await _context.SaveChangesAsync();
    }

}
