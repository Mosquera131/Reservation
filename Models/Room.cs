using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models;
[Table("Rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("Room Number")]
    public int Room_number { get; set; }

    [Column("Price Per Night")]
    public double Price_per_night { get; set; }

    [Column("Availability")]
    public bool Availability { get; set; }


    [Column("Max Ocupancy")]

    public byte Max_ocuppancy_persons { get; set; }

    //foreign key 

    public required int Room_type_id { get; set; }

    //navigation properties

    [ForeignKey("Room_type_id")]

    public Room_type? Room_Type {get;set;}

}
