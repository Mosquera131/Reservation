using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models;
[Table("Room Types")]
public class Room_type
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("Name")]
    public string Name { get; set; }

    [Column("Description")]
    public string? Description {get;set;}


}
