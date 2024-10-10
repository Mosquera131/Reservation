using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models.DTOS;

public class BookingDTO
{

     [Required(ErrorMessage = "The start date is required")]
    public DateTime Start_date { get; set; }

    [Required(ErrorMessage = "The end date is required")]
    public DateTime? End_date { get; set; }

    [Required(ErrorMessage = "The total cost is required")]
    public double Total_cost { get; set; }

    [Required(ErrorMessage = "The room ID is required")]
    public required int Room_id { get; set; }

    [Required(ErrorMessage = "The guest ID is required")]
    public required int Guest_id { get; set; }

    [Required(ErrorMessage = "The employee ID is required")]
    public required int Employee_id { get; set; }


}
