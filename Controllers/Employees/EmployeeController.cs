using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reserva.Repositories;

namespace Reserva.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public partial class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _Booking;

    public EmployeeController(IEmployeeRepository IBoooking)
    {
        _Booking = IBoooking;
    }
}
