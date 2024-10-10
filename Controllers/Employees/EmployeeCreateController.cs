using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Reserva.Models;
using Reserva.Models.DTOS;
using Swashbuckle.AspNetCore.Annotations;

namespace Reserva.Controllers.Employees;

public partial class EmployeeController
{

    [HttpPost]
    [SwaggerOperation(
    Summary = "Create Employee",
    Description = "Register an Employee in the database."
    )]
    [SwaggerResponse(200, "Return the Bookin that has been created.")]
    [SwaggerResponse(500, "An Internal server error occurred.")]

    public async Task<ActionResult<Employee>> Create(EmployeeDTO InputEmployee)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


        var employeR= new Employee
        {
            Firt_name= InputEmployee.Firt_name,
            Last_name=InputEmployee.Last_name,
            Email=InputEmployee.Email,
            Identification_number=InputEmployee.Identification_number,
            Password=InputEmployee.Password


        };

        await _Booking.Add(employeR);

        return Ok(employeR);

    }


}
