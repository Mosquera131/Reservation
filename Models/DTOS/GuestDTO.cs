using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models.DTOS;

public class GuestDTO
{

    [Required(ErrorMessage = "The Name is required")]
    public string Firts_name { get; set; }

    [Required(ErrorMessage = "The LastName is required")]
    public string Last_name { get; set; }

    [Required(ErrorMessage = "The Email is required")]
    public string Email { get; set; }

    [Required(ErrorMessage = "The DocumentNumber is required")]
    public string Identification_number { get; set; }

    [Required(ErrorMessage = "The PhoneNumber is required")]
    public string Phone_number { get; set; }


}