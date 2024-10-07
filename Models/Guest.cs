using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models;
[Table("Guests")]
public class Guest
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("First Name")]
    public string Firts_name { get; set; }

    [Column("Last Name")]
    public string Last_name { get; set; }

    [Column("Email")]
    public string Email { get; set; }

    [Column("Identification Number")]
    public string Identification_number { get; set; }

    [Column("Phone Number")]
    public string Phone_number { get; set; }

    [Column("Birthdate")]

    public DateTime? Birthdate { get; set; }

}
