using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva.Models;

[Table("Employees")]
public class Employee
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("Firt Name")]
    public string Firt_name { get; set; }

    [Column("Last Name")]
    public string Last_name { get; set; }

    [Column("Email")]
    public string Email { get; set; }

    [Column("Identification Number")]
    public string Identification_number { get; set; }

    [Column("Password")]

    public string Password {get;set;}



}

