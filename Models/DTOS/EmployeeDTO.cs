using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models.DTOS;

public class EmployeeDTO
{
    [Required(ErrorMessage = "The Name is required")]
    public string Firt_name { get; set; }

    [Required(ErrorMessage = "The Last Name is required")]
    public string Last_name { get; set; }

    [Required(ErrorMessage = "The Email is required")]
    public string Email { get; set; }

    [Required(ErrorMessage = "The Identiification is required")]
    public string Identification_number { get; set; }

    [Required(ErrorMessage = "The Passwrod is required")]
    public string Password { get; set; }

}
