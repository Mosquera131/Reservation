using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models;
[Table("Bookings")]
public class Booking
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("Start Date")]
    public DateTime Start_date { get; set; }

    [Column("End Date")]
    public DateTime? End_date { get; set; }

    [Column("Total Cost")]
    public double Total_cost { get; set; }


    // foreign keys
    public required int Room_id { get; set; }

    public required int Guest_id { get; set; }

    public required int Employee_id {get;set;}



    //navigations properties

    [ForeignKey("Room_id")]
    public Room Room { get; set; }

    [ForeignKey("Guest_id")]
    public Guest Guest { get; set; }

    [ForeignKey("Employeed_id")]
    public Employee Employee { get; set; }

}
